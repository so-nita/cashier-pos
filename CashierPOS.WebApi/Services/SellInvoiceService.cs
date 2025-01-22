using CashierPOS.Model.Models;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.Model.Models.Response;
using Microsoft.EntityFrameworkCore;
using CashierPOS.Model.Models.Constant;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.Model.Services
{
    public class SellInvoiceService : ISellInvoiceService
    {
        private readonly IRepository<SellInvoice> _repo;
        private readonly IRepository<SellInvoiceDetail> _repoInvoiceDetail;
        private readonly IRepository<OrderPayment> _repoOrderPayment;
        private readonly IRepository<CustomerType> _repoCustomerType;
        private readonly IRepository<ReturnOrder> _repoReturnOrder;
        private readonly IRepository<Product> _repoProduct;
        private readonly IRepository<Order> _repoOrder;
        //private string Prefix { get; set; } = "101";
        private string PrefixUserId { get; set; } = "RAE";

        public SellInvoiceService(IRepository<SellInvoice> repo, IRepository<OrderPayment> payment, IRepository<SellInvoiceDetail> detail, 
            IRepository<CustomerType> CustomerType, IRepository<ReturnOrder> repoReturnOrder, IRepository<Product> product, IRepository<Order> repoOrder)
        {
            _repo = repo;
            _repoOrderPayment = payment;
            _repoInvoiceDetail = detail;
            _repoCustomerType = CustomerType;
            _repoReturnOrder = repoReturnOrder;
            _repoProduct = product;
            _repoOrder = repoOrder;
        }

        private readonly string _prefixSellInvoice = "RIV";
        private readonly string _prefixReturnInvoice = "SCN";

        #region Api For Create invoice (First Version)
        public Response<string> Create(SellInvoiceCreateReq request)
        {
            try
            {
                var paymentOrder = _repoOrderPayment.GetQueryable()
                                   .Include(e=>e.Order.OrderDetails)
                                   .Include(e=>e.User.Company)
                                   .FirstOrDefault(e => e.Order_Id == request.OrderId);
                if(paymentOrder == null)
                {
                    return Response<string>.NotFound("Order payement does not existing.");
                }

                var invoice = new SellInvoice()
                {
                    Id = Guid.NewGuid().ToString(),
                    //--InvoiceNo = Prefix  + paymentOrder.Code.ToString("D9"),
                    InvoiceNo = paymentOrder.User.Company.Code  + paymentOrder.Code.ToString("D9"),
                    OrderId = paymentOrder.Order_Id,
                    PrintDate = DateTime.Now,
                };
                _repo.Add(invoice);

                var result = _repoInvoiceDetail.SaveChanges();

                return result > 0 ? Response<string>.Success(null,result,"Successfully") : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }
        #endregion

        #region Api for Create payment and print Invoice
        public Response<SellInvoiceResponse> CreateAndPrint(SellInvoiceCreateReq request)
        {
            try
            {
                var paymentOrder = _repoOrderPayment.GetQueryable()
                                    .Include(e=>e.CustomerType)
                                    .Include(e=>e.User.Company)
                                    .Include(e=>e.Order.ChangeShift)
                                    .Include(e => e.Order.OrderDetails).FirstOrDefault(e => e.Order_Id == request.OrderId);

                var returnOrder = _repoReturnOrder.GetQueryable().Include(e => e.Details).FirstOrDefault(e => e.OrderId == paymentOrder.Order_Id);
                 
                if (paymentOrder == null)
                {
                    return Response<SellInvoiceResponse>.NotFound("Order payement does not existing.");
                }

                var invoice = new SellInvoice()
                {
                    Id = Guid.NewGuid().ToString(),
                    //InvoiceNo = request.InvoiceNo ?? GenerateInvoiceNumber(), //Prefix + paymentOrder.Code.ToString("D9"),
                    InvoiceNo = request.InvoiceNo ?? GenerateInvoiceNumber(paymentOrder.Order.ChangeShift.Pos_Id, paymentOrder.Order.ChangeShift.Id, paymentOrder.User.Company.Code.ToString(), _prefixSellInvoice),
                    OrderId = paymentOrder.Order_Id,
                    PrintDate = DateTime.Now,
                };
                _repo.Add(invoice);

                var result = _repoInvoiceDetail.SaveChanges();
                var products = _repoProduct.GetAll().ToList();

                // Return Data to print
                var user = paymentOrder.User;
                var orderTransaction = new List<OrderDetailResponse>();
                if (request.InvoiceNo != null)
                {
                    orderTransaction = returnOrder!.Details!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.ProductId,
                        Discount_Percent = e.Discount_Percent,
                        Discount_Amount = e.Discount_Amount,
                        Total_Discount = e.Total_Discount,
                        Product_Code = products.FirstOrDefault(p=>p.Id == e.ProductId)!.Code,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.ProductId)!.Name,
                        Price = e.Price,
                        Grand_Amount = e.Total,
                        Qty = e.Qty,
                        Sub_Amount = e.Total,
                        Status = OrderItemStatus.Cancel,
                    }).ToList();
                }
                else
                {
                    orderTransaction = paymentOrder.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Discount_Amount = e.Discount_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Total_Discount = e.Total_Discount,  
                        Price = e.Price,
                        Grand_Amount = e.Grand_Amount,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Qty = e.Qty,
                        Sub_Amount = e.Sub_Amount,
                        Size = products.FirstOrDefault(p => p.Id == e.Product_Id)?.Size,
                        Status = e.Status,
                          
                    }).ToList();
                }
                decimal exchangeRate = paymentOrder.Exchange_Rate;
                decimal total = request.InvoiceNo.IsNullOrEmpty() ? paymentOrder.Total : orderTransaction.Sum(e => e.Grand_Amount /*- e.Discount_Amount??0*/);
                decimal tax = request.InvoiceNo.IsNullOrEmpty() ? paymentOrder.Order.Tax??0 : total * (paymentOrder.Order.Tax ?? 0) / 100;

                var cashierUserId = PrefixUserId + paymentOrder.User.UserName;
                var dataResponse = new SellInvoiceResponse()
                {
                    Id = invoice.Id,
                    InvoiceNo = invoice.InvoiceNo,
                    Pos_Id = invoice.Order.ChangeShift.Pos_Id,
                    Received = paymentOrder.Received ?? 0.00m,
                    Total = total ,
                    Total_Kh = total * exchangeRate,   
                    OrderId  = paymentOrder.Order_Id,
                    Change = paymentOrder.Change ?? 0.00m,
                    Customer_Type = paymentOrder.CustomerType.NameKh!,
                    Tax = invoice.Order.Tax,
                    TaxKh = tax * exchangeRate,
                    ExchangeRate = exchangeRate,
                    Discount = paymentOrder.Discount,
                    Cashier_Id = cashierUserId,
                    Cashier_Name = user.Name,
                    Company_Name = user.Company.Name,
                    Company_Address = user.Company.Address,
                    Company_Contact = user.Company.Contact,
                    Company_NameKh = user.Company.NameKh!,
                    ChangeKh = paymentOrder.ChangeKh ?? 0,
                    ReceivedKh = paymentOrder.ReceivedKh ??0,
                    OrderTransaction = orderTransaction,  
                    Print_Date = paymentOrder.Transaction_Date,
                    //DeliveryFee = ,
                    Description = "Thank you for choose Red Ant Express !!! \n Receipt required for Exchange or Return items"
                };

                return result > 0 ? Response<SellInvoiceResponse>.Success(dataResponse, result, "Successfully") : Response<SellInvoiceResponse>.Fail();
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }


        public string GenerateInvoiceNumber(int posId, int shiftId, string prefixShop, string prefixInvoiceType)
        {
            // Get the current year (last two digits)
            string currentYear = DateTime.Now.ToString("yyMMdd");  
            // Get the last invoice number for the given POS ID
            string lastInvoiceNumber = _repo.GetQueryable().Include(e => e.Order.User!.Company)
                                       .Where(e => e.Order.ShiftId == shiftId && e.Order.User.Company.Code.ToString() == prefixShop)
                                       .OrderByDescending(i => i.PrintDate).Select(i => i.InvoiceNo)
                                       .FirstOrDefault()!;

            string posIdString = posId.ToString("D2"); // Ensure POS ID is formatted to at least 3 digits
            // Extract last 7 digits from lastInvoiceNumber
            string lastInvoiceNo = lastInvoiceNumber?.Substring(lastInvoiceNumber.Length - 3)!;

            if (!string.IsNullOrEmpty(lastInvoiceNo) && int.TryParse(lastInvoiceNo, out int lastNumber))
            {
                lastNumber++; // Increment the last number
                string formattedInvoiceNumber = lastNumber.ToString("D3"); // Format last number as 7 digits
                return $"{prefixInvoiceType}{prefixShop}-{posIdString}-{currentYear}{formattedInvoiceNumber}";
            }
            return $"{prefixInvoiceType}{prefixShop}-{posIdString}-{currentYear}001"; // Default starting value
        }

        #endregion
        #region Api for Get by Invoice number Old schema database
        /*public Response<SellInvoiceResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetQueryable()
                        .Include(e => e.Order.OrderPayments)
                        .Include(e => e.Order.OrderDetails)
                        .Include(e => e.Order.User.Company)
                        .FirstOrDefault(e=>e.InvoiceNo.ToLower() == key.Id.ToLower());

                if (data == null)
                {
                    return Response<SellInvoiceResponse>.Fail("Invoice not found");
                }
                var payments = data.Order.OrderPayments!.First();
                var orderDetails = data.Order.OrderDetails;
                var company = data.Order.User.Company;
                var customerType = _repoCustomerType.GetAll();

                var products = _repoProduct.GetAll();

                var cashierUserId = PrefixUserId + payments.User.UserName;
                var result = new SellInvoiceResponse()
                {
                    Id = data.Id,
                    InvoiceNo = data.InvoiceNo*//*.ToString("D9")*//*,
                    OrderId = data.OrderId,
                    Total = payments.Total,
                    Total_Kh = payments.Total_Kh,
                    Tax = data.Order.Tax ?? 0,
                    TaxKh = data.Order.Tax * company.Exchange_Rate ?? 0,
                    ExchangeRate = payments.Exchange_Rate,
                    Discount = payments.Discount ?? 0,
                    Received = payments.Received ?? 0,
                    Change = payments.Change ?? 0,
                    Cashier_Id = cashierUserId *//*data.Order.Reference_Id*//*,
                    Cashier_Name = data.Order.User!.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Contact = company.Contact,
                    Customer_Type = customerType.First(c => c.Id == payments.CustomerTypeId).NameKh!,
                    Print_Date = data.PrintDate,
                    Company_Address = company.Name,
                    //--Description = "Good Luck",
                    OrderTransaction = data.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Qty = e.Qty,
                        Price = e.Price,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Discount_Amount = e.Discount_Amount,
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount,
                    }).ToList(),
                };
                return Response<SellInvoiceResponse>.Success(result, 1, "Successfully")!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }*/
        public Response<SellInvoiceResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetQueryable()
                        .Include(e => e.Order.OrderPayments)
                        .Include(e => e.Order.OrderDetails)
                        .Include(e => e.Order.User.Company)
                        .FirstOrDefault(e => e.InvoiceNo.ToLower() == key.Id.ToLower());

                if (data == null)
                {
                    return Response<SellInvoiceResponse?>.Fail("Invoice not found");
                }
                var order = data.Order;
                var orderDetails = data.Order.OrderDetails;
                var company = data.Order.User?.Company;
                var customerType = _repoCustomerType.GetAll();
                var exchangeRate = order.ExchangeRate;

                var products = _repoProduct.GetAll();

                var cashierUserId = PrefixUserId + order.User?.UserName;
                var result = new SellInvoiceResponse()
                {
                    Id = data.Id,
                    InvoiceNo = data.InvoiceNo/*.ToString("D9")*/,
                    OrderId = data.OrderId,
                    Total = order.Grand_Total,
                    Total_Kh = order.Grand_Total * exchangeRate,
                    Tax = data.Order.Tax ?? 0,
                    TaxKh = data.Order.Tax * exchangeRate ?? 0,
                    ExchangeRate = exchangeRate,
                    Discount = order.Total_Discount,
                    Received = order.Received ?? 0,
                    Change = order.Change ?? 0,
                    Cashier_Id = cashierUserId,
                    Cashier_Name = data.Order.User!.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Contact = company.Contact,
                    //Customer_Type = order.CustomerTypeCode /*customerType.First(c => c.Id == order?.CustomerTypeCode).NameKh!*/,
                    Print_Date = data.PrintDate,
                    Company_Address = company.Name,
                    //--Description = "Good Luck",
                    OrderTransaction = data.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Qty = e.Qty,
                        Price = e.Price,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Discount_Amount = e.Discount_Amount,
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount,
                    }).ToList(),
                };
                return Response<SellInvoiceResponse>.Success(result, 1, "Successfully")!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion

        #region Api for Get all Inovices 
        public Response<List<SellInvoiceResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetQueryable()
                        .Include(e => e.Order.OrderPayments)
                        .Include(e=>e.Order.OrderDetails)
                        .Include(e => e.Order.User.Company).ToList();
                
                if(data.Count() <= 0)
                {
                    return Response<List<SellInvoiceResponse>>.Success();
                }
                var payments = data.First()!.Order.OrderPayments!.First();
                var orderDetails = data.First().Order.OrderDetails;
                var company = data.First().Order.User.Company;
                var customerType = _repoCustomerType.GetAll();

                var products = _repoProduct.GetAll();
                var cashierUserId = PrefixUserId + payments.User.UserName;

                var result = data.Select(e => new SellInvoiceResponse()
                {
                    Id = e.Id,
                    InvoiceNo = e.InvoiceNo/*.ToString("D9")*/,
                    OrderId = e.OrderId,
                    Total = payments.Total,
                    Total_Kh = payments.Total_Kh,
                    Tax = e.Order.Tax ?? 0,
                    TaxKh = e.Order.Tax * company.Exchange_Rate ?? 0,
                    ExchangeRate = payments.Exchange_Rate,
                    Discount = payments.Discount ?? 0,
                    Received = payments.Received ?? 0,
                    Change = payments.Change ?? 0,
                    Cashier_Id = cashierUserId /*e.Order.Reference_Id*/,
                    Cashier_Name = e.Order.User!.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Contact = company.Contact,
                    Customer_Type = customerType.First(c=>c.Id==payments.CustomerTypeId).NameKh!,
                    Print_Date = e.PrintDate,
                    Company_Address = company.Name,
                    Description = "Good Luck",
                    OrderTransaction = e.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Qty = e.Qty,
                        Price = e.Price,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Discount_Amount = e.Discount_Amount,
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount,
                    }).ToList(),
                }).ToList();
                return Response<List<SellInvoiceResponse>>.Success(result, result.Count(), "Successfully")!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion

        /*#region Api for Reprint By Last Inovice Old Schema Database
        public async Task<Response<SellInvoiceResponse>> ReprintByLast(ReprintInvoiceByLast request)
        {
            try
            {
                var invoices = await _repo.GetQueryable()
                    .Where(e => e.Order.Pos_Id == request.PosId)
                    .OrderByDescending(e => e.Order.OrderPayments.Max(p => p.Code))
                    .Take(1)
                    .Include(e => e.Order.User.Company)
                    .Include(e => e.Order.OrderPayments)
                    .Include(e => e.InvoiceDetails)
                    .Include(e => e.Order.OrderDetails)
                    .ToListAsync();

                if (!invoices.Any())
                {
                    return Response<SellInvoiceResponse>.NotFound("Invoice No not found.");
                }
                var customerType = _repoCustomerType.GetAll().ToList();
                var payment = invoices.First().Order.OrderPayments.First();
                var company = payment.User.Company;

                var products = _repoProduct.GetAll();
                var cashierUserId = PrefixUserId + payment.User.UserName;

                var result = invoices.Select(e => new SellInvoiceResponse()
                {
                    Id = e.Id,
                    InvoiceNo = e.InvoiceNo.ToString(),
                    Total = payment.Total,
                    Total_Kh = payment.Total_Kh,
                    Tax = e.Order.Tax,
                    TaxKh = e.Order.Tax * company.Exchange_Rate,
                    Discount = payment.Discount,
                    Received = payment.Received ?? 0.00m,
                    Change = payment.Change ?? 0.00m,
                    OrderId = e.OrderId,
                    Pos_Id = e.Order.Pos_Id,
                    Cashier_Id = cashierUserId ,
                    Cashier_Name = payment.User.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Address = company.Address,
                    Company_Contact = company.Contact,
                    Customer_Type = customerType.First(e=>e.Id== payment.CustomerTypeId).Name,
                    ExchangeRate = company.Exchange_Rate,
                    Print_Date = e.PrintDate,
                    OrderTransaction = e.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Code == e.Product_Code).Name,
                        Product_Code = products.FirstOrDefault(p => p.Code == e.Product_Code).Code,
                        Price = e.Price,
                        Qty = e.Qty,
                        Size = products.FirstOrDefault(p => p.Code == e.Product_Code)?.Size,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Amount = e.Discount_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount
                    }).ToList()
                }).First();

                invoices.First().PrintDate = DateTime.Now;
                _repo.Update(invoices.First());

                return _repo.SaveChanges() > 0
                    ? Response<SellInvoiceResponse>.Success(result, 1, "Successfully")
                    : Response<SellInvoiceResponse>.Fail("Failed");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion*/

        #region Api for Reprint By Last Inovice New Schema Database
        public async Task<Response<SellInvoiceResponse>> ReprintByLast(ReprintInvoiceByLast request)
        {
            try
            {
                var invoices = await _repo.GetQueryable()
                    .Where(e => e.Order.ShiftId == request.ShiftId && e.IsPaid == true)
                    .Include(e=>e.Order.ChangeShift)
                    .Include(e => e.Order.User.Company)
                    .Include(e => e.Order.OrderDetails)
                    .OrderByDescending(e=>e.InvoiceNo)
                    .ToListAsync();

                if (!invoices.Any())
                {
                    return Response<SellInvoiceResponse>.NotFound("Invoice No not found.");
                }
                var customerType = _repoCustomerType.GetAll().ToList();
                var order = invoices.First()?.Order;
                var company = order.User!.Company;

                var products = _repoProduct.GetAll();
                var cashierUserId = PrefixUserId + order.User.UserName;

                /*var invoice = new SellInvoice()
                {
                    InvoiceNo = GenerateInvoiceNumber(order.Pos_Id),
                    Pos_Id = order.Pos_Id,
                    IsDeleted = false,
                    Id = Guid.NewGuid().ToString(),
                    IsPaid = false,
                    OldInvoiceNo = invoices.First().InvoiceNo,
                    OrderId = order.Id,
                    PrintDate = DateTime.Now,
                    Status = Status.Enable,
                };*/

                var result = invoices.Select(e => new SellInvoiceResponse()
                {
                    Id = e.Id,
                    InvoiceNo = e.InvoiceNo,
                    OldInvoiceNo = e.OldInvoiceNo,
                    Total = order.Grand_Total,
                    Total_Kh = order.Grand_Total * order.ExchangeRate,
                    Tax = e.Order.Tax,
                    TaxKh = e.Order.Tax * company.Exchange_Rate,
                    Discount = order.Total_Discount,
                    Received = order.Received ?? 0.00m,
                    Change = order.Change ?? 0.00m,
                    ChangeKh = order.ChangeKh ?? 0.00m,
                    ReceivedKh = order.ReceivedKh ?? 0.00m,
                    OrderId = e.OrderId,
                    Pos_Id = e.Order.ChangeShift.Pos_Id,
                    Cashier_Id = cashierUserId,
                    Cashier_Name = order.User.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Address = company.Address,
                    Company_Contact = company.Contact,
                    Customer_Type = order?.CustomerType,
                    ExchangeRate = company.Exchange_Rate,
                    Print_Date = e.PrintDate,
                    OrderTransaction = e.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Code == e.Product_Code)?.Name!,
                        Product_Code = products.FirstOrDefault(p => p.Code == e.Product_Code)?.Code!,
                        Price = e.Price,
                        Qty = e.Qty,
                        Size = ParseSizeFromJson(products.FirstOrDefault(p => p.Code == e.Product_Code)?.Size!),
                        Sub_Amount = e.Sub_Amount,
                        Discount_Amount = e.Discount_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount
                    }).ToList()
                }).First();

                //_repo.Add(invoice);
                /* invoices.First().PrintDate = DateTime.Now;
                _repo.Update(invoices.First());*/

                return Response<SellInvoiceResponse>.Success(result, 1, "Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion

        #region Api for Reprint By Inovice Number Old Schema 
        /*public Response<SellInvoiceResponse> ReprintByNo(ReprintInvoiceByNo request)
        {
            try
            {
                var invoices = _repo.GetQueryable().Include(e=>e.Order.User.Company)
                            .Include(e=>e.InvoiceDetails)
                            .Include(e=>e.Order.OrderDetails)
                            .Include(e=>e.Order.OrderPayments)
                            .Where(e=>e.InvoiceNo.ToString().ToLower() == request.InvoiceNo.ToLower()).ToList();
                if(!invoices.Any())
                {
                    return Response<SellInvoiceResponse>.NotFound("Invoice No not found.");
                }
                var payment = invoices.First().Order.OrderPayments.First();
                var company = payment.User.Company;
                var customerType = _repoCustomerType.GetAll().FirstOrDefault(e=>e.Id==payment.CustomerTypeId).NameKh;

                var products = _repoProduct.GetAll().ToList();
                var cashierUserId = PrefixUserId + payment.User.UserName;

                var result = invoices.Select(e => new SellInvoiceResponse()
                {
                    Id = e.Id,
                    InvoiceNo = e.InvoiceNo.ToString(),
                    Total = payment.Total,
                    Total_Kh = payment.Total_Kh,
                    Tax = e.Order.Tax,
                    TaxKh = e.Order.Tax * company.Exchange_Rate,
                    Discount = payment.Discount,
                    Received = payment.Received ??0.00m,
                    Change = payment.Change ?? 0.00m,
                    ChangeKh = payment.ChangeKh ?? 0.00m,
                    ReceivedKh = payment.ReceivedKh ?? 0.00m,
                    OrderId = e.OrderId,
                    Pos_Id = e.Order.Pos_Id,
                    Cashier_Id = cashierUserId *//*e.Order.Reference_Id*//*,
                    Cashier_Name = payment.User.Name,
                    Company_Name = company.Name,
                    Company_NameKh = company.NameKh!,
                    Company_Address = company.Address,
                    Company_Contact = company.Contact,
                    Customer_Type = customerType!,
                    //DeliveryFee = ,
                    ExchangeRate = company.Exchange_Rate,
                    Print_Date = e.PrintDate,
                    OrderTransaction = e.Order.OrderDetails!.Select(e=>new OrderDetailResponse()
                    {
                        Id = e.Id,  
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Price = e.Price,
                        Qty = e.Qty,
                        Size = products.FirstOrDefault(p => p.Id == e.Product_Code)?.Size,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Amount = e.Discount_Amount,
                        Discount_Percent = e.Discount_Percent,  
                        Total_Discount = e.Total_Discount,
                        Grand_Amount = e.Grand_Amount 
                    }).ToList()
                });
                invoices.First().PrintDate = DateTime.Now;
                _repo.Update(invoices.First());
                _repo.SaveChanges();

                return Response<SellInvoiceResponse>.Success(result.First(), 1,"Successfully");
            }catch (Exception ex)
            {
                return Response<SellInvoiceResponse>.Fail(ex.Message);
            }
        }*/
        #endregion

        #region Api for Reprint By Inovice Number New Schema
        public Response<SellInvoiceResponse> ReprintByNo(ReprintInvoiceByNo request)
        {
            try
            {
                var invoices = _repo.GetQueryable().Include(e => e.Order.User.Company)
                               .Include(e => e.InvoiceDetails)
                               .Include(e => e.Order.OrderDetails)
                               .Include(e=>e.Order.ChangeShift)
                               .Where(e => e.InvoiceNo.ToString().ToLower() == request.InvoiceNo.ToLower()).ToList()
                               .OrderByDescending(e=>e.PrintDate);

                if (!invoices.Any())
                {
                    return Response<SellInvoiceResponse>.NotFound("Invoice number not found.");
                }

                var invoice = invoices.FirstOrDefault(e=>e.ShiftId == request?.ShiftId);

                var products = _repoProduct.GetAll().ToList();
                var result = new SellInvoiceResponse();

                if (invoice != null)
                {
                    var order_ = invoice.Order;
                    var company_ = invoice.Order.User?.Company;
                    result = new SellInvoiceResponse()
                    {
                        InvoiceNo = invoice.InvoiceNo,
                        Cashier_Id = order_.Reference_Id,
                        Cashier_Name = order_.User.Name,
                        Change = order_.Change,
                        ChangeKh = order_.ChangeKh,
                        Company_Address = company_.Address,
                        Company_Contact = company_.Contact,
                        Company_Name = company_.Name,
                        Company_NameKh = company_.NameKh,
                        Customer_Type = order_.CustomerType,
                        Tax = order_.Tax,
                        ExchangeRate = order_.ExchangeRate,
                        Discount = order_.Total_Discount,
                        Id = invoice.Id,
                        OldInvoiceNo = invoice.OldInvoiceNo,
                        OrderId = order_.Id,
                        Pos_Id = order_.ChangeShift.Pos_Id,
                        Print_Date = DateTime.Now,
                        Received = order_.Received,
                        ReceivedKh = order_.ReceivedKh,
                        Status = request.InvoiceNo.Contains(_prefixSellInvoice) ? OrderStatus.Close : order_.Order_Status,
                        TaxKh = order_.Tax,
                        Total = order_.Grand_Total,
                        Total_Kh = order_.Grand_Total * company_.Exchange_Rate,
                        OrderTransaction = order_.OrderDetails.Select(e => new OrderDetailResponse()
                        {
                            Id = e.Id,
                            Product_Id = e.Product_Id,
                            Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                            Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                            Price = e.Price,
                            Qty = e.Qty,
                            Size = products.FirstOrDefault(p => p.Id == e.Product_Code)?.Size,
                            Sub_Amount = e.Sub_Amount,
                            Discount_Amount = e.Discount_Amount,
                            Discount_Percent = e.Discount_Percent,
                            Total_Discount = e.Total_Discount,
                            Grand_Amount = e.Grand_Amount,
                        }).ToList()
                    };
                }
                else
                {
                    var order = invoices.First().Order;
                    var company = order.User?.Company;

                    var cashierUserId = PrefixUserId + order.User?.UserName;

                    decimal exchangeRate = (order.Order_Status == OrderStatus.Return) ? company.SaleExchangeRate ?? 0 : order.ExchangeRate;

                    result = invoices.Select(e => new SellInvoiceResponse()
                    {
                        Id = e.Id,
                        InvoiceNo = request.InvoiceNo,
                        OldInvoiceNo = e.OldInvoiceNo,
                        Total = order.Grand_Total,
                        Total_Kh = order.Grand_Total * exchangeRate,
                        Tax = e.Order.Tax,
                        TaxKh = e.Order.Tax * exchangeRate,
                        Discount = order.Total_Discount,
                        Change = order.Change ?? 0.00m,
                        ChangeKh = order.ChangeKh,
                        Received = order.Received ?? 0.00m,
                        ReceivedKh = order.ReceivedKh ?? 0.00m,
                        OrderId = e.OrderId,
                        Pos_Id = e.Order.ChangeShift.Pos_Id,
                        Cashier_Id = cashierUserId,
                        Cashier_Name = order.User.Name,
                        Company_Name = company.Name,
                        Company_NameKh = company.NameKh!,
                        Company_Address = company.Address,
                        Company_Contact = company.Contact,
                        Customer_Type = order.CustomerType!,
                        ExchangeRate = exchangeRate,
                        Print_Date = e.PrintDate,
                        Status = request.InvoiceNo.Contains(_prefixSellInvoice) ? OrderStatus.Close : order.Order_Status,
                        OrderTransaction = e.Order.OrderDetails!.Select(e => new OrderDetailResponse()
                        {
                            Id = e.Id,
                            Product_Id = e.Product_Id,
                            Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                            Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                            Price = e.Price,
                            Qty = e.Qty,
                            Size = products.FirstOrDefault(p => p.Id == e.Product_Code)?.Size,
                            Sub_Amount = e.Sub_Amount,
                            Discount_Amount = e.Discount_Amount,
                            Discount_Percent = e.Discount_Percent,
                            Total_Discount = e.Total_Discount,
                            Grand_Amount = e.Grand_Amount
                        }).ToList()
                    }).First();
                }

                return Response<SellInvoiceResponse>.Success(result, 1, "Successfully");
            }
            catch (Exception ex)
            {
                return Response<SellInvoiceResponse>.Fail(ex.Message);
            }
        }
        #endregion

        #region Api for Update sell invoice
        public Response<string> Update(SellInvoiceUpdateReq req)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Api for disable Sell Inoice
        public Response<string> Delete(SellInvoiceDisableReq request)
        {
            try
            {
                var invoice = _repo.GetAll().Where(e=>e.InvoiceNo == request.InvoiceNo).FirstOrDefault();
                if(invoice == null)
                {
                    return Response<string>.Fail("Invoice not found.");
                }
                invoice.Status = Status.Disable;
                _repo.Update(invoice);
                _repo.SaveChanges(); 

                return Response<string>.Success("Disable invoice successfully");
            }catch (Exception ex)
            {
                _repo.Rollback();
                return Response<string>.Fail(ex.Message);
            }
        }

        public Response<SellInvoiceResponse> CreateSellInvoice(InvoiceCreateReq request)
        {
            try
            {
                var order = _repoOrder.GetQueryable()
                                    .Include(e => e.User.Company)
                                    .Include(e => e.ChangeShift)
                                    .Include(e => e.OrderDetails).FirstOrDefault(e => e.Id == request.OrderId);

                var returnOrder = _repoReturnOrder.GetQueryable().Include(e => e.Details).FirstOrDefault(e => e.OrderId == order!.Id);

                if (order == null)
                {
                    return Response<SellInvoiceResponse>.NotFound("Order payment does not existing.");
                }

                var invoice = new SellInvoice();
                var invoiceType = request.InvoiceNo.IsNullOrEmpty() ? _prefixSellInvoice : _prefixReturnInvoice;
                var invoiceNo = GenerateInvoiceNumber(order.ChangeShift.Pos_Id, order.ShiftId, order.User!.Company.Code.ToString()!, invoiceType);
                // For return Order 
                if (!request.InvoiceNo.IsNullOrEmpty())
                {
                    var oldInvoice = _repo.GetQueryable().Include(e=>e.Order.ChangeShift).FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);
                    invoice = new SellInvoice()
                    {
                        Id = Guid.NewGuid().ToString(),
                        InvoiceNo = invoiceNo,
                        OrderId = order.Id,
                        PrintDate = DateTime.Now,
                        IsPaid = false ,
                        Status = Status.Enable,
                        IsDeleted = false,
                        OldInvoiceNo = oldInvoice?.InvoiceNo,
                        OrderReturnId = returnOrder?.Id,
                        ShiftId = order.ShiftId,
                    };
                }
                else // for invoice close order
                {
                    invoice = new SellInvoice()
                    {
                        Id = Guid.NewGuid().ToString(),
                        InvoiceNo = invoiceNo,
                        OrderId = order.Id,
                        PrintDate = DateTime.Now,
                        IsPaid = true,
                        Status = Status.Enable,
                        IsDeleted = false,
                        ShiftId = order.ShiftId
                    };
                }
                _repo.Add(invoice);

                var products = _repoProduct.GetAll().ToList();

                // Return Data to print
                var user = order.User;
                var orderTransaction = new List<OrderDetailResponse>();
                if (request.InvoiceNo != null)
                {
                    var currentReturnProduct = new List<ReturnOrderDetail>();
                    foreach (var item in request.ReturnDetails!)
                    {
                        var temp = returnOrder!.Details?.FirstOrDefault(e => e.ProductId == item.ProductId);
                        currentReturnProduct.Add(temp!);
                    }
                     
                    orderTransaction = currentReturnProduct.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.ProductId,
                        Discount_Percent = e.Discount_Percent,
                        Discount_Amount = e.Discount_Amount,
                        Total_Discount = e.Total_Discount,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.ProductId)!.Code,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.ProductId)!.Name,
                        Price = e.Price,
                        Grand_Amount = e.Total,
                        Qty = e.Qty,
                        Sub_Amount = e.Total,
                        Status = OrderItemStatus.Cancel,
                    }).ToList();
                }
                else
                {
                    orderTransaction = order.OrderDetails!.Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Id = e.Product_Id,
                        Discount_Amount = e.Discount_Amount,
                        Discount_Percent = e.Discount_Percent,
                        Total_Discount = e.Total_Discount,
                        Price = e.Price,
                        Grand_Amount = e.Grand_Amount ,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Name,
                        Qty = e.Qty,
                        Sub_Amount = e.Sub_Amount,
                        //Size = ParseSizeFromJson(e.Product.Size),
                        Status = e.Status,

                    }).ToList();
                }
                //decimal exchangeRate = order.User.Company.Exchange_Rate;
                decimal exchangeRate = 0;
                if (order.Order_Status == OrderStatus.Return)
                {
                    exchangeRate = order.User?.Company.SaleExchangeRate??0;
                }
                else
                {
                    exchangeRate = order.ExchangeRate;
                }
                decimal total = request.InvoiceNo.IsNullOrEmpty() ? order.Grand_Total : orderTransaction.Sum(e => e.Grand_Amount);
                decimal tax = request.InvoiceNo.IsNullOrEmpty() ? order.Tax ?? 0 : total * (order.Tax ?? 0) / 100;

                var cashierUserId = PrefixUserId + order.User?.UserName;
                //var customerType = _repoCustomerType.GetAll().FirstOrDefault(e => e.Code == order.CustomerTypeCode);
                var dataResponse = new SellInvoiceResponse()
                {
                    Id = invoice.Id,
                    InvoiceNo = invoice.InvoiceNo,
                    OldInvoiceNo = invoice.OldInvoiceNo, 
                    Pos_Id = invoice.Order.ChangeShift.Pos_Id,
                    Received = order.Received ?? 0.00m,
                    Total = total,
                    Total_Kh = total * exchangeRate,
                    OrderId = order.Id,
                    Change = order.Change ?? 0.00m,
                    Customer_Type = order?.CustomerType,
                    Tax = invoice.Order.Tax,
                    TaxKh = invoice.Order.Tax * exchangeRate,
                    ExchangeRate = exchangeRate,
                    Discount = order?.Total_Discount,
                    Cashier_Id = cashierUserId,
                    Cashier_Name = user?.Name!,
                    Company_Name = user!.Company.Name,
                    Company_Address = user.Company.Address,
                    Company_Contact = user.Company.Contact,
                    Company_NameKh = user.Company.NameKh!,
                    //--ChangeKh = order!.Change * exchangeRate,
                    ChangeKh = order!.ChangeKh,
                    ReceivedKh = order.ReceivedKh ?? 0,
                    OrderTransaction = orderTransaction,
                    Print_Date = order.Order_Date,
                    DeliveryFee = order.Delivery,
                    Description = "Thank you for choose Red Ant Express !!!\n Receipt required for Exchange or Return items"
                };

                var result = _repo.SaveChanges();

                return result > 0 ? Response<SellInvoiceResponse>.Success(dataResponse, 1, "Successfully")
                                  : Response<SellInvoiceResponse>.Fail("Failed");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                return Response<SellInvoiceResponse>.Fail(ex.Message);
            }
        }

        private string ParseSizeFromJson(string sizeJsonString)
        {
            try
            {
                if(string.IsNullOrEmpty(sizeJsonString))
                {
                    return string.Empty;
                }
                // Parse the JSON string into a JArray
                var sizeJson = JArray.Parse(sizeJsonString);
                // Get the first option from the options array
                var firstOption = sizeJson?.FirstOrDefault()?["options"]?.FirstOrDefault()?["option"];
                // Convert the first option to string
                return firstOption?.ToString()!;
            }
            catch  
            {
                return string.Empty; 
            }
        }
        #endregion
    }
}
