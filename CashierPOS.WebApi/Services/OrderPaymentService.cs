using Microsoft.EntityFrameworkCore;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using Microsoft.IdentityModel.Tokens;

namespace CashierPOS.WebApi.Services;

public class OrderPaymentService : IOrderPaymentService
{
    private readonly IRepository<OrderPayment> _repo;
    private readonly IRepository<Order> _repoOrder;
    private readonly IRepository<PaymentType> _repoPaymentType;
    private readonly IRepository<Source> _repoSource;
    private readonly IRepository<CustomerType> _repoCusType;
    private readonly IRepository<SellInvoice> _repoInvoice;
    private readonly IRepository<ReturnOrder> _repoReturnOrder;
    private readonly ISellInvoiceService _invoice;

    public OrderPaymentService(IRepository<OrderPayment> repo, IRepository<Order> repoOrder, IRepository<PaymentType> payment, IRepository<Source> source,
        IRepository<CustomerType> CusType, IRepository<SellInvoice> repoInvoice, ISellInvoiceService invoice,IRepository<ReturnOrder> returnOrder)
    {
        _repo = repo;
        _repoOrder = repoOrder;
        _repoPaymentType = payment;
        _repoSource = source;
        _repoCusType = CusType;
        _repoInvoice = repoInvoice;
        _invoice = invoice;
        _repoReturnOrder = returnOrder;
    }

    public Response<string> Create(OrderPaymentCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<OrderPaymentCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }
            var orderData = _repoOrder.GetQueryable().Where(e=>e.Id==request.Order_Id);
            var order = orderData.Include(e=>e.User.Company).FirstOrDefault(e => e.Id == request.Order_Id);
            if (order == null)
            {
                return Response<string>.Fail();
            }
            // Error 
            var payment = _repoPaymentType.GetAll().FirstOrDefault(e=>e.PaymentCode == request.PaymentTypeCode);
            if(payment == null)
            {
                return Response<string>.Fail("Payment Id not found.");
            }
            var source = _repoSource.GetById(request.SourceId);
            if (source == null)
            {
                return Response<string>.Fail("Source Id not found.");
            }
            var customerType = _repoCusType.GetAll().First(e => e.Code == request.CustomerTypeCode && !e.IsDeleted && e.Status == Status.Enable);
            var exchageRate = order.User.Company.Exchange_Rate;

            
            var receipt = new OrderPayment()
            {
                Id = Guid.NewGuid().ToString(),
                //Status = OrderStatus.Close,
                Order_Id = request.Order_Id,
                Received = request.Received,
                SourceId = request.SourceId,
                ChangeKh = request.ChangeKh,
                //PaymentId = payment.Id,
                PaymentCode = payment.PaymentCode,
                Remaining = request.Remaining,  
                Change = request.Change,
                Exchange_Rate = exchageRate,
                Discount = order.Total_Discount,
                Reference = order.Reference_Id,
                Total = order.Grand_Total,
                Total_Kh = order.Grand_Total * exchageRate,
                Transaction_Date = DateTime.Now,
                CustomerTypeId = customerType.Id,
                PaymentTypeId = payment.Id,
                PaymentTypeName = payment.Name,
                //IsPaid = true,
                Status = PaymentStatus.Paid,
               // DiscountName = order.Total_Discount,
            };
            order.Order_Status = OrderStatus.Close;
            var result = 0;
            try
            {
                _repo.Add(receipt);
                _repoOrder.Update(order);
                result = _repo.SaveChanges();
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                _repoOrder.Rollback();
            }

            return result > 0 ? Response<string>.Success() : Response<string>.Fail();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<SellInvoiceResponse> CreatePaymentWithInvoice(OrderPaymentCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<OrderPaymentCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<SellInvoiceResponse>.Fail(dataErrors.First().ToString());
            }
            var orderData = _repoOrder.GetQueryable().Where(e => e.Id == request.Order_Id);
            var order = orderData.Include(e => e.User.Company).FirstOrDefault(e => e.Id == request.Order_Id);
            if (order == null)
            {
                return Response<SellInvoiceResponse>.Fail();
            }
            // Error 
            var payment = _repoPaymentType.GetAll().FirstOrDefault(e => e.PaymentCode == request.PaymentTypeCode);
            if (payment == null)
            {
                return Response<SellInvoiceResponse>.Fail("Payment Id not found.");
            }
            var source = _repoSource.GetById(request.SourceId);
            if (source == null)
            {
                return Response<SellInvoiceResponse>.Fail("Source Id not found.");
            }
            var customerType = _repoCusType.GetAll().First(e => e.Code == request.CustomerTypeCode && !e.IsDeleted && e.Status == Status.Enable);
            var exchageRate = order.User.Company.Exchange_Rate;
            var totalKh = (order.Grand_Total * exchageRate);

            var orderPayment = new OrderPayment()
            {
                Id = Guid.NewGuid().ToString(),
                Order_Id = request.Order_Id,
                /*Received = totalReceived == 0 ? request.Received : totalReceived,
                ReceivedKh = totalReceived == 0 ? request.ReceivedKh : 0,*/
                Received = request.Received,    
                ReceivedKh = request.ReceivedKh,
                //PaymentMethod_Code = request.PaymentMethodCode,
                PaymentMethodId = request.PaymentMethodId,
                RemainingKh = request.RemainingKh,
                Remaining = request.Remaining,
                SourceId = request.SourceId,
                Change = request.Change,
                ChangeKh = request.ChangeKh,
                PaymentCode = payment.PaymentCode,
                Exchange_Rate = exchageRate,
                Discount = order.Total_Discount,
                Reference = order.Reference_Id,
                Total = order.Grand_Total,
                Total_Kh = (int)totalKh,
                Transaction_Date = DateTime.Now,
                CustomerTypeId = customerType.Id,
                PaymentTypeId = payment.Id,
                PaymentTypeName = payment.Name,
                Status = PaymentStatus.Paid,
                CustomerCode = request.CustomerCode
            };
            order.Order_Status = OrderStatus.Close;
            
            var result = 0;
            var invoiceReponse = new SellInvoiceResponse();
            try
            {
                _repo.Add(orderPayment);
                _repoOrder.Update(order);
                result = _repo.SaveChanges();

                var temp = CreateSellInvoice(orderPayment.Code.ToString());
                temp.OrderTransaction = temp.OrderTransaction.Where(e => e.Status == OrderItemStatus.Close).ToList();
                invoiceReponse = temp;
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                _repoOrder.Rollback();
            }

            return result > 0 ? Response<SellInvoiceResponse>.Success(invoiceReponse, 1,"Successfully") 
                              : Response<SellInvoiceResponse>.Fail();

        }catch(Exception ex)
        {
            _repo.Rollback();
            return Response<SellInvoiceResponse>.Fail(ex.InnerException!.Message);
        }
    }

    private SellInvoiceResponse CreateSellInvoice(string orderPaymentCode)
    {
        var invoiceReq = new SellInvoiceCreateReq()
        {
            OrderId = orderPaymentCode,
        };
        
        var data = _invoice.CreateAndPrint(invoiceReq);
         
        return data.Status==(int)ResponseStatus.Success ? data.Result! : null!;
    }

    public Response<SellInvoiceResponse> CreatePaymentForReturn(OrderPaymentReturnReq request)
    {
        try
        {
            var invoice = _repoInvoice.GetQueryable() 
                .Include(e => e.Order.OrderPayments)  
                .FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);

            var order = invoice?.Order;

            if (order == null)
            {
                return Response<SellInvoiceResponse>.Fail("Invoice or order not found");
            }
            var orderPayment = _repo.GetAll().FirstOrDefault(e => e.Order_Id == request.OrderId && e.Status == PaymentStatus.Return);
            var orderReturn = _repoReturnOrder.GetAll().FirstOrDefault(e => e.OrderId == invoice.OrderId);

            decimal exchangeRate = invoice.Order.ExchangeRate;
            if (orderPayment!=null)
            {
                orderPayment.Total = orderReturn!.Grand_Total;
                orderPayment.Total_Kh = orderReturn.Grand_Total * exchangeRate;
                orderPayment.Discount = orderReturn.Total_Discount;
                //orderPayment.DiscountName = invoice.d;
                _repo.Update(orderPayment);
            }
            else
            {
                orderPayment = new OrderPayment
                {
                    Id = Guid.NewGuid().ToString(),
                    Order_Id = request.OrderId,
                    Exchange_Rate = exchangeRate,
                    Discount = orderReturn!.Total_Discount,
                    Reference = invoice.Order.Reference_Id,
                    Total = orderReturn.Grand_Total,
                    Total_Kh = orderReturn.Grand_Total * exchangeRate,
                    Transaction_Date = DateTime.Now,
                    CustomerTypeId = invoice.Order.CustomerId,
                    PaymentTypeId = invoice.Order.PaymentTypeCode,
                    /*PaymentTypeName = invoice.Order.PaymentTypeName,
                    DiscountName = invoice.OrderPayment.DiscountName,
                    PaymentCode = invoice.OrderPayment.PaymentCode,
                    Status = PaymentStatus.Return,
                    SourceId = invoice.OrderPayment.SourceId,*/
                };

                _repo.Add(orderPayment);
            }

            if (_repo.SaveChanges() <= 0)
            {
                return Response<SellInvoiceResponse>.Fail("Failed to save order payment");
            }

            var invoiceReq = new SellInvoiceCreateReq
            {
                OrderId = orderPayment.Order_Id,
                InvoiceNo = request.InvoiceNo,
            };

            var data = _invoice.CreateAndPrint(invoiceReq);
            
            return Response<SellInvoiceResponse>.Success(data.Result, 1, "Successfully");
        }
        catch (Exception ex)
        {
            _repo.Rollback();
            return Response<SellInvoiceResponse>.Fail(ex.Message!);
        }
    }

    public Response<OrderPaymentResponse?> Read(Key key)
    {
        try
        {
            var data = _repo.GetQueryable().Include(e => e.Order)
                .Include(e => e.User)
                .Where(e => e.Id == key.Id || e.Code.ToString() == key.Code)
                .Select(e => new OrderPaymentResponse()
                {
                    Code = e.Code,
                    ExchangeRate = e.Exchange_Rate,
                    OrderId = e.Order_Id,
                    OrderPaymentId = e.Id,
                    PosId = e.Order.ShiftId,
                    Total = e.Total,
                    TotalKh = e.Total_Kh,
                    Tax = e.Order.Tax,
                    Tax_Kh = e.Total_Kh
                });
            return Response<OrderPaymentResponse?>.Success(data.First(),data.Count());
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<List<OrderPaymentResponse>>? ReadAll()
    {
        try
        {
            var data = _repo.GetQueryable().Include(e => e.Order).Include(e=>e.CustomerType).Include(e => e.User.Company)
                .Select(e => new OrderPaymentResponse()
                {
                    Code = e.Code,
                    ExchangeRate = e.Exchange_Rate,
                    OrderId = e.Order_Id,
                    OrderPaymentId = e.Id,
                    PosId = e.Order.ShiftId,
                    Total = e.Total,
                    TotalKh = e.Total_Kh,
                    Tax = e.Order.Tax,
                    Tax_Kh = e.Total_Kh,
                    Transaction_Date = e.Transaction_Date
                }).OrderBy(e => e.Transaction_Date).ToList();
            return Response<List<OrderPaymentResponse>>.Success(data,data.Count());
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<string> Update(OrderPaymentUpdateReq request)
    {
        try
        {
            var receipt = _repo.GetQueryable().Where(e => e.Code == request.Code /*|| e.Code.ToString()==request.Key*/).FirstOrDefault();
            if (receipt == null)
            {
                return Response<string>.NotFound();
            }
            if(!request.SourceId.IsNullOrEmpty())
            {
                var source = _repoSource.GetById(request.SourceId!);
                if(source == null)
                {
                    return Response<string>.NotFound("Source Id not found.");
                }
            }
            if (!request.PaymentTypeCode.IsNullOrEmpty())
            {
                var payment = _repoPaymentType.GetAll().FirstOrDefault(e=>e.PaymentCode==request.PaymentTypeCode);
                if (payment == null)
                {
                    return Response<string>.NotFound("Payment Id not found.");
                }
            }
            // Update other properties
            receipt.Remaining = request.Remaining ?? receipt.Remaining;
            receipt.Received = request.Received ?? receipt.Received;
            receipt.Change = request.Change ?? receipt.Change;
            receipt.SourceId = request.SourceId ?? receipt.SourceId;
            request.PaymentTypeCode = request.PaymentTypeCode ?? request.PaymentTypeCode;

            _repo.Update(receipt);

            var result = _repo.SaveChanges();

            return result > 0 ? Response<string>.Success() : Response<string>.Fail();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }


    public Response<string> Delete(Key key)
    {
        try
        {
            var receipt = _repo.GetQueryable().Where(e => e.Id == key.Id || e.Code.ToString()==key.Code).FirstOrDefault();
            if (receipt == null)
            {
                return Response<string>.NotFound();
            }

            _repo.Delete(receipt);
            var result = _repo.SaveChanges();

            return result > 0 ? Response<string>.Success() : Response<string>.Fail();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<OrderPaymentResponse> ReprintByLast(ReprintInvoiceByLast request)
    {
        try
        {
            var data = _repo.GetQueryable().Include(e => e.Order).Include(e => e.User.Company)
            /*.Select(e => new OrderPaymentResponse()
            {
                Id = e.Id.ToString(),
                Code = e.Code.ToString("D9"),
                Company_Id = e.User.Company_Id,
                Discount = e.Order.Total_Discount,
                Order_Id = e.Order_Id,
                Reference_Id = e.User.Id,
                Reference_Name = e.User.Name,
                Total = e.Order.Grand_Total,
                Total_Kh = e.Order.Grand_Total * e.Exchange_Rate,
                Received = e.Received,
                Exchange_Rate = e.Exchange_Rate,
                Reference = e.Reference,
                Remaining = e.Remaining,
                Change = e.Change,
                Company_Address = e.User.Company.Address,
                Company_Contact = e.User.Company.Contact,
                *//*Customer_Id = e.Order,
                Customer_Name = e.User,*//*
                Tax = e.Order.Tax,
                Tax_Kh = e.Order.Tax * e.Exchange_Rate,
                Print_Date = DateTime.Now
            }).OrderByDescending(e => e.Print_Date).First();*/
                .Select(e => new OrderPaymentResponse()
                {
                    Code = e.Code,
                    ExchangeRate = e.Exchange_Rate,
                    OrderId = e.Order_Id,
                    OrderPaymentId = e.Id,
                    //PosId = e.Order.Pos_Id,
                    Total = e.Total,
                    TotalKh = e.Total_Kh,
                    Tax = e.Order.Tax,
                    Tax_Kh = e.Total_Kh,
                    Transaction_Date = e.Transaction_Date
                }).OrderByDescending(e => e.Transaction_Date).First();
            return Response<OrderPaymentResponse>.Success(data,1,"Successfully");
        }catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<OrderPaymentResponse> ReprintByNo(ReprintInvoiceByNo request)
    {
        try
        {
            var data = _repo.GetQueryable().Include(e => e.Order).Include(e => e.User.Company)
                .Where(e=>e.Code.ToString()==request.InvoiceNo && request.ShiftId == e.Order.ShiftId)
                /*.Select(e => new OrderPaymentResponse()
                {
                    Id = e.Id.ToString(),
                    Code = e.Code.ToString("D9"),
                    Company_Id = e.User.Company_Id,
                    Discount = e.Order.Total_Discount,
                    Order_Id = e.Order_Id,
                    Reference_Id = e.User.Id,
                    Reference_Name = e.User.Name,
                    Total = e.Order.Grand_Total,
                    Total_Kh = e.Order.Grand_Total * e.Exchange_Rate,
                    Received = e.Received,
                    Exchange_Rate = e.Exchange_Rate,
                    Reference = e.Reference,
                    Remaining = e.Remaining,
                    Change = e.Change,
                    Company_Address = e.User.Company.Address,
                    Company_Contact = e.User.Company.Contact,
                    *//*Customer_Id = e.Order,
                    Customer_Name = e.User,*//*
                    Tax = e.Order.Tax,
                    Tax_Kh = e.Order.Tax * e.Exchange_Rate,
                    Print_Date = DateTime.Now
                }).OrderByDescending(e => e.Print_Date).First();*/
                .Select(e => new OrderPaymentResponse()
                {
                    Code = e.Code,
                    ExchangeRate = e.Exchange_Rate,
                    OrderId = e.Order_Id,
                    OrderPaymentId = e.Id,
                    PosId = e.Order.ShiftId,
                    Total = e.Total,
                    TotalKh = e.Total_Kh,
                    Tax = e.Order.Tax,
                    Tax_Kh = e.Total_Kh,
                    Transaction_Date = e.Transaction_Date
                }).OrderByDescending(e => e.Transaction_Date).First();

            if (data == null)
            {
                return Response<OrderPaymentResponse>.NotFound("Receipt not found.");
            }
            return Response<OrderPaymentResponse>.Success(data, 1, "Successfully");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    
}
