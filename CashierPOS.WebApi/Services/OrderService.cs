using AutoMapper;
using Newtonsoft.Json.Linq;
using CashierPOS.Model.Models;
using CashierPOS.Model.Constants;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using Microsoft.OpenApi.Extensions;
using Microsoft.EntityFrameworkCore;
using CashierPOS.Model.Models.Order;
using Microsoft.IdentityModel.Tokens;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using System.ComponentModel.DataAnnotations;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.WebApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repo;
        private readonly IRepository<OrderDetail> _repoDetail;
        private readonly IRepository<Product> _repoProduct;
		// private readonly IRepository<OrderPayment> _repoOrderPayment;
		// private readonly IMapper _mapper;
		private readonly IRepository<ChangeShift> _repoShift;
        private readonly IRepository<SellInvoice> _repoInvoice;
        private readonly IRepository<ReturnOrder> _repoReturn;
        private readonly IRepository<User> _repoUser;
        private readonly IRepository<ReturnOrderDetail> _repoReturnDetail;
        private readonly IRepository<CustomerType> _repoCustomerType;
        private readonly IRepository<Customer> _repoCustomer;
        private readonly ISellInvoiceService _invoice;

        public OrderService(IRepository<Order> repo,
                            IRepository<Product> repoProduct, IRepository<OrderDetail> repoDetail, IRepository<OrderPayment> receipt,
                            IRepository<ChangeShift> repoShift,/* IMapper mapper,*/ IRepository<SellInvoice> invoice, IRepository<ReturnOrder> returnOrder,
                            IRepository<User> repoUser, IRepository<ReturnOrderDetail> repoReturnDetail, IRepository<CustomerType> repoCustomerType,
                            IRepository<Customer> customer, ISellInvoiceService sellInvoice)
        {
            _repo = repo;
            _repoProduct = repoProduct;
            _repoDetail = repoDetail;
            //_repoOrderPayment = receipt;
            _repoShift = repoShift;
            // _mapper = mapper;
            _repoInvoice = invoice;
            _repoReturn = returnOrder;
            _repoUser = repoUser;
            _repoReturnDetail = repoReturnDetail;
            _repoCustomerType = repoCustomerType;
            _repoCustomer = customer;
            _invoice = sellInvoice;
        }

        public Response<string> Create(OrderCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<OrderCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(dataErrors.First());
                }
                // get by pos id
                var shift = _repoShift.GetQueryable().Include(e => e.User)
                            //.FirstOrDefault(e => e.UserLogId == request.Shift_Id && e.Shift_Status == ShiftStatus.Open && e.Company.Is_Deleted == false);
                            .FirstOrDefault(e => e.UserLogId == request.ShiftId && e.Shift_Status == ShiftStatus.Open && e.Company.Is_Deleted == false);

                if (shift == null)
                {
                    return Response<string>.Fail("Please Open Shift");
                }

                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetAll();
                var orderId = Guid.NewGuid().ToString();
                var productSell = new List<Product>();
                decimal taxAmount = 0;

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);

                    if (product != null)
                    {
                        taxAmount += CalculatePriceIncludingTax(product.Price, product.Tax);
                        var discount = product.Price * item.Discount_Percent / 100;
                        var orderDetail = new OrderDetail()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Order_Id = orderId,
                            Product_Id = product.Id,
                            Product_Code = product.Code,
                            Discount_Percent = item.Discount_Percent,
                            Discount_Amount = discount * item.Qty,
                            Price = product.Price,
                            Qty = item.Qty,
                            Sub_Amount = item.Qty * product.Price,
                            Grand_Amount = (item.Qty * product.Price) - discount ?? 0,
                            Create_At = DateTime.Now,
                            Status = item.Status ?? OrderItemStatus.Close
                        };
                        product.Qty -= item.Qty;

                        orderDetails.Add(orderDetail);
                        productSell.Add(product);
                    }
                }
                var subtotal = orderDetails.Sum(e => e.Grand_Amount);
                //--var taxAmount = subtotal * request.Tax / 100;
                var totalDiscount = orderDetails.Sum(e => e.Discount_Amount ?? 0);
                var order = new Order()
                {
                    Id = orderId,
                    Tax = taxAmount,
                    Reference_Id = shift.Change_Shift_By,
                    //Pos_Id = shift.Pos_Id,
                    ShiftId = shift.Id,
                    Sub_Total = subtotal,
                    Total_Discount = totalDiscount,
                    Grand_Total = subtotal + taxAmount​ - totalDiscount,
                    Order_Status = request.Order_Status,
                    Order_Date = orderDetails.Last().Create_At,
                };

                _repo.Add(order);
                _repoDetail.AddRange(orderDetails);

                _repoProduct.UpdateRange(productSell);


                return _repo.SaveChanges() > 0 ? Response<string>.Success(string.Empty)
                                               : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        #region Create Order With return OrderData 
        public Response<OrderResponse> CreateOrder(OrderWithInvoiceCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<OrderWithInvoiceCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<OrderResponse>.Fail(dataErrors.First());
                }
                
                // get by pos id
                var shift = _repoShift.GetQueryable().Include(e => e.User.Company)
                            //--.FirstOrDefault(e => e.Pos_Id == request.Pos_Id && e.Shift_Status == ShiftStatus.Open && e.Company.Is_Deleted == false);
                            .FirstOrDefault(e => e.Id == request.Shift_Id && e.Shift_Status == ShiftStatus.Open && e.Company.Is_Deleted == false);

                if (shift == null)
                {
                    return Response<OrderResponse>.Fail("Plase Open Shift");
                }

                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetAll();
                var orderId = Guid.NewGuid().ToString();
                var productSell = new List<Product>();

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);

                    if (product != null)
                    {
                        decimal discount = 0;
                        if(item.Discount_Percent >0 )
                        {
                            discount = ((product.Price * item.Qty) * item.Discount_Percent??0)/ 100 ;
                        }
                        else if (item.Discount_Amount > 0)
                        {
                            discount =  item.Qty * item.Discount_Amount??0;
                        }
                        var orderDetail = new OrderDetail()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Order_Id = orderId,
                            Product_Id = product.Id,
                            Product_Code = product.Code,
                            Discount_Percent = item.Discount_Percent,
                            Discount_Amount = item.Discount_Amount,
                            Total_Discount = discount,
                            TaxType = product.Tax,
                            TaxAmount = CalculatePriceIncludingTax(product.Price, product.Tax),
                            Price = product.Price,
                            Qty = item.Qty,
                            Sub_Amount = item.Qty * product.Price,
                            Grand_Amount = (item.Qty * product.Price) - discount,
                            Create_At = DateTime.Now,
                            Status = item.Status ?? OrderItemStatus.Close,
                            ReasonId = item.ReasonCode ?? null,
                        };
                        product.Qty -= item.Qty;

                        orderDetails.Add(orderDetail);
                        productSell.Add(product);
                    }
                }
                var closedOrderDetails = orderDetails.Where(e => e.Status == OrderItemStatus.Close).ToList();

                var order = new Order()
                {
                    Id = orderId,
                    Tax = closedOrderDetails.Sum(e => e.TaxAmount),
                    Reference_Id = shift.Change_Shift_By,
                    ShiftId = shift.Id,
                    Sub_Total = closedOrderDetails.Sum(e => e.Sub_Amount),
                    Total_Discount = closedOrderDetails.Sum(e => e.Total_Discount ?? 0),
                    Grand_Total = closedOrderDetails.Sum(e => e.Grand_Amount),
                    Order_Status = request.Order_Status,
                    Order_Date = orderDetails.Last().Create_At,
                    OrderDetails = orderDetails,
                    Is_Deleted = false,
                    Company_Id = shift.Company_Id,
                    Cancelled_At = request.Order_Status == OrderStatus.Cancel ? DateTime.Now : null,
                    CustomerId = null,
                    CustomerType = null!,
                    ReasonTypeId = null,
                    Delivery = request.DeleveryFee,
                    DataSource = DataSourceType.window.ToString()
                };

                _repo.Add(order);
                // _repoDetail.AddRange(orderDetails);
                _repoProduct.UpdateRange(productSell);

                var exchangeRate = shift.Company.Exchange_Rate;
                var orderRespose = new OrderResponse()
                {
                    ShiftId = shift.Id,
                    OrderId = order.Id,
                    Tax = order.Tax,
                    OrderStatus = order.Order_Status,
                    TotalDiscount = order.Total_Discount,
                    ExchangeRate = exchangeRate,
                    Total = order.Grand_Total,
                    TotalKh = order.Grand_Total * exchangeRate,
                    OrderDate = order.Order_Date,
                };

                return _repo.SaveChanges() > 0 ? Response<OrderResponse>.Success(orderRespose, 1, "Create Successfully") 
                                               : Response<OrderResponse>.Fail("Something went wrong");
            }
            catch (Exception ex)
            {
                return Response<OrderResponse>.Fail(ex.Message);
            }
        }
        #endregion

        // Method to calculate price including tax based on tax type
        private static decimal CalculatePriceIncludingTax(decimal price, Tax tax)
        {
            switch (tax)
            {
                case Tax.VAT​:
                    return price * 0.1m; // Apply VAT (10%)
                case Tax.PLT​​:
                    return price * 0.13m; // Apply PLT (VAT + 3%)
                case Tax.none:
                default:
                    return 0; // No tax
            }
        }

        private Response<List<OrderResponse>>? GetAll()
        {
            try
            {
                var orders = _repo.GetQueryable()
                    .Include(e => e.OrderDetails)
                    .Include(e => e.User.Company)
                    .Where(e => e.Order_Status == OrderStatus.Close)
                    .ToList();
                //var products = _repoProduct.GetAll().ToList();
                var result = orders.Select(e => new OrderResponse()
                {
                    OrderDate = e.Order_Date,
                    ShiftId = e.ShiftId,
                    OrderId = e.Id,
                    Tax = e.Tax,
                    ExchangeRate = e.User!.Company.Exchange_Rate,
                    Total = e.Grand_Total,
                    TotalKh = e.Grand_Total * e.User.Company.Exchange_Rate,
                    OrderStatus = e.Order_Status,
                }).OrderByDescending(e => e.OrderDate).ToList();

                return Response<List<OrderResponse>>.Success(result, orders.Count(),"Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<OrderResponse?> Read(Key key)
        {
            try
            {
                var order = GetAll()!.Result!.FirstOrDefault(e => e.OrderId == key.Id);

                return Response<OrderResponse?>.Success(order);
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<OrderResponse>>? ReadAll()
        {
            try
            {
                var order = GetAll()!.Result!.ToList();

                return Response<List<OrderResponse>>.Success(order, order.Count);
            }
            catch (Exception ex)
            {
                return Response<List<OrderResponse>>.Fail(ex.Message);
            }
        }


        public Response<string> Update(OrderUpdateReq request)
        {
            try
            {
                var order = _repo.GetQueryable().Include(e => e.OrderDetails).First(e => e.Id == request.Id);

                if (order == null)
                {
                    return Response<string>.NotFound();
                }
                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetQueryable();

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);
                    var orderDetail = _repoDetail.GetQueryable().Include(e => e.Product).First(e => e.Id == item.Id);

                    if (orderDetail != null)
                    {
                        if (item.Product_Id.IsNullOrEmpty())
                        {
                            var result = UpdateOrderDetail(orderDetail!, item, product!);
                            orderDetails.Add(result!);
                        }
                        else
                        {
                            var result = UpdateOrderDetail(orderDetail!, item, orderDetail!.Product);
                            orderDetails.Add(result!);
                        }
                    }
                }

                order.Order_Status = request.Order_Status ?? order.Order_Status;
                order.Tax = orderDetails.Sum(e=>e.TaxAmount);
                order.Total_Discount = orderDetails.Sum(e => e.Total_Discount??0);
                order.Sub_Total = orderDetails.Sum(e => e.Sub_Amount);
                order.Grand_Total = orderDetails.Sum(e=>e.Grand_Amount) ;

                _repo.Update(order);
                _repoDetail.UpdateRange(orderDetails);

                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        #region Api Delete Order
        public Response<string> Delete(OrderDeleteReq request)
        {
            try
            {
                var order = new Order();
                if (request.Id != null)
                {
                    order = _repo.GetQueryable().Include(e => e.OrderDetails).First(s => s.Id == request.Id);
                    if (order == null)
                    {
                        return Response<string>.NotFound($"Order id : {request.Id} not found");
                    }
                    if (order.OrderDetails != null)
                    {
                        _repoDetail.DeleteRange(order.OrderDetails);
                    }
                    _repo.Delete(order);
                }
                else if (request.OrderDetails != null)
                {
                    var orderDetail = new List<OrderDetail>();
                    var updatedOrder = new Order();

                    foreach (var item in request.OrderDetails)
                    {
                        var itemDetail = _repoDetail.GetById(item.Id!);
                        if (itemDetail == null) return Response<string>.NotFound($"Order Detail Id: {itemDetail!.Id} not found");

                        orderDetail.Add(itemDetail);

                        if (orderDetail == null)
                        {
                            return Response<string>.NotFound($"Order id: {item.Id} not found");
                        }

                        order = _repo.GetById(itemDetail.Order_Id);
                        if (order == null)
                        {
                            return Response<string>.NotFound($"Order id: {itemDetail.Order_Id} not found");
                        }

                        var orderDetailToRemove = order.OrderDetails!.First(e => e.Id == itemDetail.Id);

                        order.OrderDetails!.Remove(orderDetailToRemove);
                        updatedOrder = CaculateOrder(order, order);
                    }

                    _repoDetail.DeleteRange(orderDetail);

                    _repo.Delete(updatedOrder);
                }


                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion

        private Order CaculateOrder(Order existOrder, Order newOrder)
        {
            var checkCloseOrder = newOrder.OrderDetails.Where(e => e.Status == OrderItemStatus.Close).ToList();
            if (existOrder != null && newOrder != null)
            {
                if(existOrder.Order_Status == OrderStatus.Return)
                {
                    existOrder.Sub_Total = newOrder.OrderDetails.Sum(e=>e.Sub_Amount);
                    existOrder.Grand_Total = newOrder.OrderDetails.Sum(e => e.Grand_Amount);
                    existOrder.Total_Discount = newOrder.OrderDetails.Sum(e => e.Total_Discount ?? 0);
                    return existOrder;
                }
                newOrder.OrderDetails = checkCloseOrder;
                existOrder.Sub_Total = newOrder.OrderDetails!.Sum(e => e.Sub_Amount);
                existOrder.Total_Discount = newOrder.OrderDetails!.Sum(e => e.Total_Discount) ?? 0;
                existOrder.Tax = newOrder.OrderDetails!.Sum(e => e.Grand_Amount * newOrder.Tax / 100) ?? 0;
                existOrder.Grand_Total = newOrder.Grand_Total; /*existOrder.Sub_Total + existOrder.Tax - existOrder.Total_Discount ?? 0;*/
                existOrder.ReasonTypeId = newOrder.ReasonTypeId;
                return existOrder;
            }
            return null!;
        }
        private OrderDetail UpdateOrderDetail(OrderDetail existDetail, OrderDetailUpdateReq item, Product product)
        {
            var itemSubTotal = item.Qty * product.Price;
            var detailDiscount = item.Discount_Percent ?? existDetail.Discount_Percent;

            existDetail.Qty = item.Qty.ToString() == null ? existDetail.Qty : item.Qty;
            existDetail.Price = product.Price;
            //--existDetail.Size = product.Size;
            //--existDetail.Product_Name = product.Name;
            existDetail.Product_Id = item.Product_Id ?? existDetail.Product_Id;
            existDetail.Discount_Percent = item.Discount_Percent ?? existDetail.Discount_Percent;
            existDetail.Discount_Amount = (detailDiscount * itemSubTotal) / 100;
            existDetail.Sub_Amount = itemSubTotal;
            existDetail.Grand_Amount = existDetail.Sub_Amount - existDetail.Discount_Amount ?? 0;
            return existDetail;
        }

        #region Api Hold Order
        public Response<string> Hold(Key orderId)
        {
            try
            {
                var order = _repo.GetById(orderId.Id!);
                if (order == null)
                {
                    return Response<string>.Fail();
                }
                order.Order_Status = OrderStatus.Hold;

                _repo.Update(order);
                var result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success("Hold Order successfully")
                                  : Response<string>.Fail("Something went wrong.");
            } catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        #endregion

        #region Api Cancel Order
        public Response<string> Cancel(OrderCancelReq request)
        {
            try
            {
                var order = _repo.GetQueryable().Include(e => e.OrderDetails).FirstOrDefault(e => e.Id == request.OrderId);
                if (order == null)
                {
                    return Response<string>.Fail();
                }
                var orderDetails = new List<OrderDetail>();
                if (order.OrderDetails!.Any())
                {
                    foreach (var item in order.OrderDetails!)
                    {
                        item.Status = OrderItemStatus.Cancel;
                        item.ReasonId = request.ReasonCode;
                        orderDetails.Add(item);
                    }
                    _repoDetail.UpdateRange(orderDetails);
                }
                order.Order_Status = OrderStatus.Cancel;
                order.ReasonTypeId = request.ReasonCode;
                order.Cancelled_At = DateTime.Now;

                _repo.Update(order);
                var result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success("Cancel Order successfully")
                                  : Response<string>.Fail("Something went wrong.");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }
        #endregion
        
        #region Api Return Order for old schema databse
        /*public Response<string> Return(OrderReturnReq request)
        {
            try
            {
                var receipt = _repoInvoice.GetQueryable().Include(e => e.Order.OrderDetails).Include(e => e.Order.OrderPayments)
                                      .FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);
                if (receipt == null)
                {
                    return Response<string>.Fail("Receipt No not found.");
                }
                var user = _repoUser.GetAll().First(e => e.Id == request.ApprovedByUserId);
                if (user == null) return Response<string>.Fail("User not found");

                var order = receipt.Order;
                var orderDetails = new List<OrderDetail>();

                var productReturn = order.OrderDetails.Where(e => request.ProductIds.Contains(e.Product_Id)).ToList();
                var products = _repoProduct.GetAll();

                var productReturned = new List<Product>();
                
                foreach (var  item in productReturn)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);
                    if (product != null)
                    {
                        item.Status = OrderItemStatus.Return;
                        item.ReasonCode = request.ProductCode;

                        product.Qty += item.Qty;
                        productReturned.Add(product);
                        orderDetails.Add(item);
                    }
                }
                var orderDetailCount = order.OrderDetails!.Where(e => e.Status == OrderItemStatus.Close).ToList();
                if (orderDetailCount.Count() <= 0)
                {
                    order.Order_Status = OrderStatus.Return;
                }
                order = CaculateOrder(order, order);
                order.ReasonTypeId = request.ReasonReturnId;

                var returnOrders = _repoReturn.GetQueryable().Include(e => e.Details).FirstOrDefault(e => e.OrderId == order.Id);
                var returnOrderDetails = returnOrders?.Details?.ToList() ?? new List<ReturnOrderDetail>();
                var returnOrder = returnOrders ?? new ReturnOrder
                {
                    Id = Guid.NewGuid().ToString(),
                    Pos_Id = order.Pos_Id,
                    OrderId = order.Id,
                    InvoiceNo = receipt.InvoiceNo,
                    ApprovedBy = request.ApprovedByUserId,
                    ApprovedByUserName = user.Name,
                    ReturnDate = DateTime.Now,
                    ReturnReasonCode = request.ReasonReturnId,
                    Sub_Total = orderDetails.Sum(e => e.Sub_Amount),
                    Total_Discount = orderDetails.Sum(e => e.Total_Discount),
                    Grand_Total = orderDetails.Sum(e => e.Grand_Amount)
                };
                returnOrder.Details = orderDetails.Select(e => new ReturnOrderDetail()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = e.Product_Id,
                    Qty = e.Qty,
                    Price = e.Price,
                    ReturnId = returnOrder.Id,
                    Total = e.Grand_Amount,
                    Sub_Amount = e.Sub_Amount,
                    Discount_Amount = e.Discount_Amount,
                    Total_Discount = e.Total_Discount,
                    Discount_Percent = e.Discount_Percent,
                    ProductCode = e.Product_Code,
                }).ToList();

                if (returnOrders == null)
                {
                    _repoReturn.Add(returnOrder);
                }
                else
                {
                    var returnDetails = returnOrder.Details;
                    returnOrderDetails.AddRange(returnDetails);
                    returnOrder.Details = returnOrderDetails;
                    returnOrder.Sub_Total = returnOrderDetails.Sum(e => e.Sub_Amount);
                    returnOrder.Grand_Total = returnOrderDetails.Sum(e => e.Total *//*- e.Total_Discount??0*//*);
                    returnOrder.Total_Discount = returnOrderDetails.Sum(e => e.Total_Discount);

                    _repoReturn.Update(returnOrder);
                    _repoReturnDetail.AddRange(returnDetails);
                }
                _repoProduct.UpdateRange(productReturned);
                _repoDetail.DeleteRange(orderDetails);
                _repo.Update(order);

                var result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success(null, 1, "Successfully") : Response<string>.Fail("Failed to return");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                //throw ex.InnerException!;
                return Response<string>.Fail("Failed to return");
            }
        }
        private Order HandleFullOrderReturn(Order order,string reasonCode)
        {
            order.Order_Status = OrderStatus.Return;
            var orderDetails = new List<OrderDetail>();
            foreach (var orderDetail in order.OrderDetails!)
            {
                orderDetail.Status = OrderItemStatus.Return;
                orderDetail.ReasonCode = reasonCode;
                orderDetails.Add(orderDetail);  
            }
            order.OrderDetails = orderDetails;
            return order;
        }*/
        #endregion


        #region Api Return Order Adjust With Print Invoice
        public Response<SellInvoiceResponse> Return(OrderReturnReq request)
        {
            try
            {
                var receipt = _repoInvoice.GetQueryable().Include(e => e.Order.OrderDetails) 
                                      .FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);
                if (receipt == null)
                {
                    return Response<SellInvoiceResponse>.Fail("Invoice No not found.");
                }
                var user = _repoUser.GetAll().First(e => e.Id == request.ApprovedByUserId);
                if (user == null) return Response<SellInvoiceResponse>.Fail("User not found");

                var order = receipt.Order;
                //var orderDetails = new List<OrderDetail>();
                var orderDetails = order.OrderDetails;

                var productReturn = order.OrderDetails?.Where(e => request.ProductIds!.Contains(e.Product_Id)).ToList();

                var products = _repoProduct.GetAll();

                var productReturned = new List<Product>();

                foreach (var item in productReturn!)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);
                    var orderDetail = orderDetails?.FirstOrDefault(e=>e.Product_Id == item.Product_Id);
                    //--if (product != null)
                    if (orderDetail != null)
                    {
                        /*-- item.Status = OrderItemStatus.Return;
                        item.ReasonId = request.ReasonReturnId;
                        orderDetails.Add(item);*/
                        product!.Qty += item.Qty;
                        productReturned.Add(product);
                        orderDetail.Status = OrderItemStatus.Return;
                        orderDetail.ReasonId = request.ReasonReturnId;
                    }
                }
                //orderDetails = productReturn.ToList();
                var orderDetailCount = order.OrderDetails!.Where(e => e.Status == OrderItemStatus.Close).ToList();
                if (orderDetailCount.Count() <= 0)
                {
                    order.Order_Status = OrderStatus.Return;
                }
                order = CaculateOrder(order, order);
                order.ReasonTypeId = request.ReasonReturnId;

                var returnOrders = _repoReturn.GetQueryable().Include(e => e.Details).FirstOrDefault(e => e.OrderId == order.Id);
                var returnOrderDetails = returnOrders?.Details?.ToList() ?? new List<ReturnOrderDetail>();
                var returnOrder = returnOrders ?? new ReturnOrder
                {
                    Id = Guid.NewGuid().ToString(),
                    //Pos_Id = order.Pos_Id,
                    ShiftId = order.ShiftId,
                    OrderId = order.Id,
                    InvoiceNo = receipt.InvoiceNo,
                    ApprovedBy = request.ApprovedByUserId,
                    ApprovedByUserName = user.Name,
                    ReturnDate = DateTime.Now,
                    ReturnReasonCode = request.ReasonReturnId,
                    Sub_Total = orderDetails!.Sum(e => e.Sub_Amount),
                    Total_Discount = orderDetails?.Sum(e => e.Total_Discount),
                    Grand_Total = orderDetails!.Sum(e => e.Grand_Amount)
                };

                var returnProducts = orderDetails?.Where(e => e.Status == OrderItemStatus.Return).ToList();
                if (returnOrderDetails.Count >0 )
                {
                    foreach (var item in returnOrderDetails)
                    {
                        var tmp = returnProducts?.FirstOrDefault(e => e.Product_Code == item.ProductCode);
                        if (tmp != null)
                        {
                            returnProducts!.Remove(tmp);
                        }
                    }
                }

                if (returnProducts?.Count == 0)
                {
                    return Response<SellInvoiceResponse>.Fail("Product have been returned");
                }

                returnOrder.Details = returnProducts?.Select(e => new ReturnOrderDetail()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = e.Product_Id,
                    Qty = e.Qty,
                    Price = e.Price,
                    ReturnId = returnOrder.Id,
                    Total = e.Grand_Amount,
                    Sub_Amount = e.Sub_Amount,
                    Discount_Amount = e.Discount_Amount,
                    Total_Discount = e.Total_Discount,
                    Discount_Percent = e.Discount_Percent,
                    ProductCode = e.Product_Code,
                    Reason_Id = Convert.ToInt32(e.ReasonId)
                }).ToList();

                if (returnOrders == null)
                {
                    _repoReturn.Add(returnOrder);
                }
                else
                {
                    var returnDetails = returnOrder.Details;
                    returnOrderDetails.AddRange(returnDetails!);
                    returnOrder.Details = returnOrderDetails;
                    returnOrder.Sub_Total = returnOrderDetails.Sum(e => e.Sub_Amount);
                    returnOrder.Grand_Total = returnOrderDetails.Sum(e => e.Total);
                    returnOrder.Total_Discount = returnOrderDetails.Sum(e => e.Total_Discount);

                    _repoReturn.Update(returnOrder);
                    _repoReturnDetail.AddRange(returnDetails!);
                }
                
                _repoProduct.UpdateRange(productReturned);
                _repoDetail.UpdateRange(orderDetails!);
                order.OrderDetails = orderDetails;
                _repo.Update(order);

                var result = _repo.SaveChanges();
                var returnDetailsId = returnProducts?.Select(e=> new ReturnOrderDetailsId() { ProductId = e.Product_Id}).ToList();
                var sellInvoice = CreateSellInvoice(order.Id, request.InvoiceNo, returnDetailsId!);
                
                return result > 0 ? Response<SellInvoiceResponse>.Success(sellInvoice, 1, "Successfully") 
                                  : Response<SellInvoiceResponse>.Fail("Failed to return");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                return Response<SellInvoiceResponse>.Fail(ex.Message);
            }
        }
        #endregion

        #region Api for search item in invoice for return order
        /*public Response<ReturnOrderResponse> GetReturnOrder (OrderReturnReq request)
        {
            try
            {
                var invoice = _repoInvoice.GetQueryable()
                              .Include(e=>e.Order.OrderPayments)
                              .Include(e=>e.Order.User.Company)
                              .Include(e => e.Order.OrderDetails).FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);

                if (invoice == null)
                {
                    return Response<ReturnOrderResponse>.Fail("Receipt not found.");
                }
                var productCode = request.ProductCode== "" ? null : request.ProductCode;
                if(productCode != null || !productCode.IsNullOrEmpty())
                {
                    var orderDetail = invoice.Order.OrderDetails;
                    var getByProduct = orderDetail!.Where(e => e.Product_Code == request.ProductCode).ToList();
                    if (!getByProduct.Any())
                    {
                        return Response<ReturnOrderResponse>.Fail("Product Barcode not found.");
                    }
                    invoice.Order.OrderDetails = getByProduct;
                }
                var customerType = _repoCustomerType.GetAll();
                var products = _repoProduct.GetAll().ToList();
                var exchangeRate = invoice.Order.User.Company.Exchange_Rate;
                var customer = _repoCustomer.GetAll().FirstOrDefault(e=>e.Code==invoice.Order.CustomerId);

                var total = invoice.Order.OrderDetails!.Sum(e => e.Grand_Amount);
                var data = new ReturnOrderResponse()
                {
                    PosId = invoice.Order.Pos_Id,
                    ApprovedByUserId = request.ApprovedByUserId,
                    ProductCode = request.ProductCode,
                    InvoiveId = invoice.Id,
                    InvoiveNo = invoice.InvoiceNo,
                    OrderId = invoice.OrderId,
                    ReasonReturnId = request.ReasonReturnId,
                    ExchangeRate = exchangeRate,
                    OrderDate = invoice.Order.Order_Date,
                    OrderStatus = invoice.Order.Order_Status,
                    Details = invoice.Order.OrderDetails!.Select(e=>new OrderDetailResponse()
                    {
                        Id = e.Id,  
                        Product_Code = products.FirstOrDefault(p=> p.Id == e.Product_Id)!.Code,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id).Name,
                        Product_Image = products.First(p=>p.Id==e.Product_Id).Image,
                        Price = e.Price,
                        Qty = e.Qty,
                        Size = ParseSizeFromJson(products.FirstOrDefault(p => p.Id == e.Product_Id)?.Size),
                        Status = e.Status,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Amount = e.Discount_Amount ?? 0,
                        Discount_Percent = e.Discount_Percent ?? 0,
                        Total_Discount = e.Total_Discount ?? 0,
                        Grand_Amount = e.Grand_Amount,
                    }).ToList(),
                    //CustomerTypeCode = customerType.First(e => e.Id == invoice.Order.OrderPayments.FirstOrDefault()?.CustomerTypeId).Code,
                    CustomerCode = customer.Code,
                    CustomerName = customer?.Name,
                    CustomerContact = customer?.Contact,
                    CustomerEmail = customer?.Email,
                    Exarning = customer?.EarningAmount,
                    Gender = customer?.Gender,
                    //--GiftCounponId = OrderPayment.gi,
                    Nationality = customer?.Nationality,
                    SourceId = invoice.Order.OrderPayments!.First().SourceId,
                    Total = total *//*invoice.Order.OrderDetails!.Sum(e=>(e.Qty * e.Price) - e.Discount_Amount??0)*//*,
                    TotalKh = total * exchangeRate *//*(invoice.Order.OrderDetails!.Sum(e => (e.Qty * e.Price) - e.Discount_Amount ?? 0)) * exchangeRate*//*
                };

                return data?.Details.Count > 0 ? Response<ReturnOrderResponse>.Success(data, 1, "Successfully")
                                               : Response<ReturnOrderResponse>.Fail("Invoice have been returned");
            }
            catch(Exception ex)
            {
                _repo.Rollback();   
                return Response<ReturnOrderResponse>.Fail(ex.Message);
            }
        }*/

        // New Update For new schema database
        public Response<ReturnOrderResponse> GetReturnOrder(OrderReturnReq request)
        {
            try
            {
                var invoice = _repoInvoice.GetQueryable()
                              //.Include(e => e.Order.OrderPayments)
                              .Include(e => e.Order.User.Company)
                              .Include(e => e.Order.OrderDetails).FirstOrDefault(e => e.InvoiceNo == request.InvoiceNo);

                if (invoice == null)
                {
                    return Response<ReturnOrderResponse>.Fail("Invoice not found.");
                }
                if(invoice.Order.Order_Status == OrderStatus.Return)
                {
                    return Response<ReturnOrderResponse>.Fail("Invoice have been return.");
                }
                var productCode = request.ProductCode == "" ? null : request.ProductCode;
                if (productCode != null || !productCode.IsNullOrEmpty())
                {
                    var orderDetail = invoice.Order.OrderDetails;
                    var getByProduct = orderDetail!.Where(e => e.Product_Code == request.ProductCode).ToList();
                    if (!getByProduct.Any())
                    {
                        return Response<ReturnOrderResponse>.Fail("Product Barcode not found.");
                    }
                    invoice.Order.OrderDetails = getByProduct;
                }
                //--var customerType = _repoCustomerType.GetAll();
                var products = _repoProduct.GetAll().ToList();
                var exchangeRate = invoice.Order.User.Company.Exchange_Rate;
                var customer = _repoCustomer.GetAll().FirstOrDefault(e => e.Code == invoice.Order.CustomerId);

                var total = invoice.Order.OrderDetails!.Sum(e => e.Grand_Amount);
                var data = new ReturnOrderResponse()
                {
                    ShiftId = invoice.Order.ShiftId,
                    ApprovedByUserId = request.ApprovedByUserId,
                    ProductCode = request.ProductCode,
                    InvoiveId = invoice.Id,
                    InvoiveNo = invoice.InvoiceNo,
                    OrderId = invoice.OrderId,
                    ReasonReturnId = request.ReasonReturnId,
                    ExchangeRate = exchangeRate,
                    OrderDate = invoice.Order.Order_Date,
                    OrderStatus = invoice.Order.Order_Status,
                    Details = invoice.Order.OrderDetails!.Where(e=>e.Status== OrderItemStatus.Close).Select(e => new OrderDetailResponse()
                    {
                        Id = e.Id,
                        Product_Code = products.FirstOrDefault(p => p.Id == e.Product_Id)!.Code,
                        Product_Id = e.Product_Id,
                        Product_Name = products.FirstOrDefault(p => p.Id == e.Product_Id).Name,
                        Product_Image = products.First(p => p.Id == e.Product_Id).Image,
                        Price = e.Price,
                        Qty = e.Qty,
                        Size = ParseSizeFromJson(products.FirstOrDefault(p => p.Id == e.Product_Id)?.Size),
                        Status = e.Status,
                        Sub_Amount = e.Sub_Amount,
                        Discount_Amount = e.Discount_Amount ?? 0,
                        Discount_Percent = e.Discount_Percent ?? 0,
                        Total_Discount = e.Total_Discount ?? 0,
                        Grand_Amount = e.Grand_Amount,
                    }).ToList(),
                    //CustomerTypeCode = customerType.First(e => e.Id == invoice.Order.OrderPayments.FirstOrDefault()?.CustomerTypeId).Code,
                    CustomerCode = customer?.Code,
                    CustomerName = customer?.Name,
                    CustomerContact = customer?.Contact,
                    CustomerEmail = customer?.Email,
                    Exarning = customer?.EarningAmount,
                    Gender = customer?.Gender,
                    //--GiftCounponId = OrderPayment.gi,
                    Nationality = customer?.Nationality,
                    //SourceId = invoice.Order.OrderPayments!.First().SourceId,
                    Total = total /*invoice.Order.OrderDetails!.Sum(e=>(e.Qty * e.Price) - e.Discount_Amount??0)*/,
                    TotalKh = total * exchangeRate /*(invoice.Order.OrderDetails!.Sum(e => (e.Qty * e.Price) - e.Discount_Amount ?? 0)) * exchangeRate*/
                };

                return data?.Details.Count > 0 ? Response<ReturnOrderResponse>.Success(data, 1, "Successfully")
                                               : Response<ReturnOrderResponse>.Fail("Invoice have been returned");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                return Response<ReturnOrderResponse>.Fail(ex.Message);
            }
        }
        // Method to parse JSON string and extract size value
        private string ParseSizeFromJson(string sizeJsonString)
        {
            try
            {
                // Parse the JSON string into a JArray
                var sizeJson = JArray.Parse(sizeJsonString);
                // Get the first option from the options array
                var firstOption = sizeJson?.FirstOrDefault()?["options"]?.FirstOrDefault()?["option"];
                // Convert the first option to string
                return firstOption?.ToString();
            }
            catch (Exception ex)
            {
                return string.Empty; // Return empty string in case of error
            }
        }
        #endregion

        public Response<List<HoldOrderResponse>> GetHoldOrder(HoldOrderGetRequest request)
        {
            try
            {
                var holdOrders = _repo.GetQueryable()
                                .Include(e=>e.OrderDetails)
                                .Include(e => e.User.Company)
                                //.Where(e=>e.Pos_Id == request.PosId && e.Order_Status == OrderStatus.Hold).ToList();
                                .Where(e=>e.ShiftId == request.ShiftId && e.Order_Status == OrderStatus.Hold).ToList();

                var data = new List<HoldOrderResponse>();

                if (holdOrders.Any())
                {
                    var products = _repoProduct.GetAll().ToList();
                    data = holdOrders.Select(e=>new HoldOrderResponse
                    {
                        OrderId = e.Id,
                        ExchangeRate = e.User!.Company.Exchange_Rate,
                        OrderDate = e.Order_Date,
                        OrderStatus = OrderStatus.Hold,
                        ShiftId = e.ShiftId,
                        Total = e.Grand_Total,
                        TotalKh = e.Grand_Total * e.User.Company.Exchange_Rate,
                        OrderDetails = e.OrderDetails?.Select(p => new OrderDetailResponse()
                        {
                            Id = p.Id,
                            Product_Code = products.FirstOrDefault(e=>e.Id == p.Product_Id)!.Code,
                            Product_Id = p.Product_Id,
                            Product_Name = products.FirstOrDefault(e => e.Id == p.Product_Id)!.Name,
                            Product_Image = products.First(pr => pr.Id == p.Product_Id).Image,
                            Price = p.Price,
                            Qty = p.Qty,
                            Size = ParseSizeFromJson(products.FirstOrDefault(e => e.Id == p.Product_Id)?.Size!),
                            Status = p.Status,
                            ReasonCode = p.ReasonId,
                            Sub_Amount = p.Sub_Amount,
                            Discount_Amount = p.Discount_Amount ?? 0,
                            Discount_Percent = p.Discount_Percent ?? 0,
                            Grand_Amount = p.Grand_Amount,
                        }).ToList(),
                    }).OrderBy(e => e.OrderDate).ToList();
                }

                return Response<List<HoldOrderResponse>>.Success(data, data.Count(), "Successfully");            
            }
            catch(Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        #region Api for Hold Update Date: 19-02-2024  
        public Response<SellInvoiceResponse> UpdateHoldToOrder(HoldOrderUpdateReq request)
        {
            try
            {
                var order = _repo.GetQueryable().Include(e => e.OrderDetails)
                            .Include(e=>e.User.Company)
                            .FirstOrDefault(e => e.Id == request.OrderId);
                if (order == null)
                {
                    return Response<SellInvoiceResponse>.Fail("Order id not found.");
                }

                var products = _repoProduct.GetAll().ToList();
                var existOrderDetails = new List<OrderDetail>();
                var newOrderDetails = new List<OrderDetail>();

                if (request.OrderDetails != null)
                {
                    foreach (var item in request.OrderDetails)
                    {
                        var orderDetail = order.OrderDetails?.FirstOrDefault(e => e.Product_Id == item.Product_Id);

                        if (orderDetail == null)
                        {
                            var product = products.FirstOrDefault(e => e.Id == item.Product_Id);

                            if (product != null)
                            {
                                //var discountAmount = (product.Price * item.Discount_Percent ?? 0) / 100;
                                decimal discountAmount = 0;
                                if(item.Discount_Percent > 0)
                                {
                                    discountAmount = (product.Price * item.Discount_Percent ?? 0)/100;
                                }
                                else
                                {
                                    discountAmount = item.Discount_Amount??0;
                                }
                                var subTotal = product.Price * item.Qty;

                                var newOrderDetail = new OrderDetail
                                {
                                    Id = Guid.NewGuid().ToString(),
                                    Order_Id = order.Id,
                                    Discount_Amount = discountAmount,
                                    Discount_Percent = item.Discount_Percent ?? 0,
                                    Price = product.Price,
                                    Product_Id = product.Id,
                                    Create_At = DateTime.Now,
                                    Sub_Amount = subTotal,
                                    Grand_Amount = subTotal - discountAmount,
                                    Qty = item.Qty,
                                    Product_Code = product.Code,
                                    ReasonId = item.ReasonCode,
                                    Status = (OrderItemStatus)item.Status!,
                                    TaxType = product.Tax,
                                    TaxAmount = CalculatePriceIncludingTax(product.Price, product.Tax),
                                    Total_Discount = discountAmount,
                                };
                                order.OrderDetails!.Add(newOrderDetail);
                                newOrderDetails.Add(newOrderDetail);
                            }
                        }
                        else
                        {
                            decimal discountAmount = 0;
                            if(item.Discount_Percent > 0)
                            {
                                discountAmount = item.Qty * (orderDetail.Price * item.Discount_Percent ?? 0)/100;
                                item.Discount_Amount = 0;
                            }
                            else
                            {
                                discountAmount = item.Discount_Amount??0;
                            }
                            decimal subAmount = item.Qty * orderDetail.Price;
                            //var disAmount = orderDetail.Price * (item.Discount_Percent ?? 0);
                            orderDetail.Qty = item.Qty;
                            orderDetail.Sub_Amount = subAmount;
                            orderDetail.Discount_Percent = item.Discount_Percent ?? 0;
                            orderDetail.Discount_Amount = item.Discount_Amount;
                            orderDetail.Total_Discount = discountAmount;
                            orderDetail.Status = item.Status??orderDetail.Status;
                            orderDetail.Grand_Amount = subAmount - discountAmount;

                            existOrderDetails.Add(orderDetail);
                        }
                    }
                    // Recalculate subtotal, tax amount, and total discount
                    
                    var subtotal = order.OrderDetails?.Where(e => e.Status == OrderItemStatus.Close).Sum(e => e.Sub_Amount) ?? 0;
                    //var taxAmount = subtotal * request.Tax??order.Tax / 100;
                    var totalDiscount = order.OrderDetails?.Sum(e => e.Total_Discount)?? 0;

                    // Update order properties
                    order.Sub_Total = subtotal;
                    order.Total_Discount = totalDiscount;
                    order.Grand_Total = subtotal - totalDiscount /*subtotal *//*+ taxAmount??0*//* - totalDiscount*/;
                    order.Received = request.Received;
                    order.ReceivedKh = request.ReceivedKh;
                    order.Remaining = request.Remaining;    
                    order.Change = request.Change;
                    order.CustomerId = request.CustomerId;
                    order.CustomerType = request.CustomerType.ToString()!;
                    order.Delivery = request.DeleveryFee;
                    order.SellType = request.SellType.ToString();
                    order.PaymentMethodId = request.PaymentMethodId!;
                    order.PaymentTypeCode = request.PaymentTypeCode!;
                    order.ExchangeRate = order.User!.Company.Exchange_Rate;

                    if (existOrderDetails.Any())
                    {
                        _repoDetail.UpdateRange(existOrderDetails);
                    }

                    if (newOrderDetails.Any())
                    {
                        _repoDetail.AddRange(newOrderDetails);
                    }
                }
                //order.Order_Status =  OrderStatus.Close;
                order.Order_Status =  request.Status;

                // Save changes
                var result = _repo.SaveChanges();
                var dataResponse = CreateSellInvoice(order.Id);
                dataResponse.OrderTransaction = dataResponse.OrderTransaction.Where(e => e.Status == OrderItemStatus.Close).ToList();

                return result > 0 ? Response<SellInvoiceResponse>.Success(dataResponse , 1,"Successfully") : Response<SellInvoiceResponse>.Fail("Fail to update order");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }

        public Response<SellInvoiceResponse> CreateOrderWithInvoice(OrderCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<OrderCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<SellInvoiceResponse>.Fail(dataErrors.First());
                }
                // get by pos id
                var shift = _repoShift.GetQueryable().Include(e => e.User.Company)
                            .FirstOrDefault(e => e.Id == request.ShiftId
                            && e.Shift_Status == ShiftStatus.Open && e.Company.Is_Deleted == false);

                if (shift == null)
                {
                    return Response<SellInvoiceResponse>.Fail("Plase Open Shift");
                }

                var orderDetails = new List<OrderDetail>();
                var customerType = _repoCustomerType.GetAll().FirstOrDefault(e => e.Id == request.CustomerId);
                var products = _repoProduct.GetAll();
                var orderId = Guid.NewGuid().ToString();
                var productSell = new List<Product>();

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);

                    if (product != null)
                    {
                        decimal discount = 0;
                        if (item.Discount_Percent > 0)
                        {
                            discount = ((product.Price * item.Qty) * item.Discount_Percent ?? 0) / 100;
                        }
                        else if (item.Discount_Amount > 0)
                        {
                            discount = item.Qty * item.Discount_Amount ?? 0;
                        }
                        var orderDetail = new OrderDetail()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Order_Id = orderId,
                            Product_Id = product.Id,
                            Product_Code = product.Code,
                            Discount_Percent = item.Discount_Percent,
                            Discount_Amount = item.Discount_Amount,
                            Total_Discount = discount,
                            TaxType = product.Tax,
                            TaxAmount = CalculatePriceIncludingTax(product.Price, product.Tax),
                            Price = product.Price,
                            Qty = item.Qty,
                            Sub_Amount = item.Qty * product.Price,
                            Grand_Amount = (item.Qty * product.Price) - discount,
                            Create_At = DateTime.Now,
                            Status = item.Status ?? OrderItemStatus.Close,
                            ReasonId = item.ReasonCode ?? null,
                        };
                        product.Qty -= item.Qty;

                        orderDetails.Add(orderDetail);
                        productSell.Add(product);
                    }
                }
                var closedOrderDetails = orderDetails.Where(e => e.Status == OrderItemStatus.Close).ToList();
                var sellType = request.SellType.GetAttributeOfType<DisplayAttribute>().Name;
                var order = new Order()
                {
                    Id = orderId,
                    ExchangeRate = shift.Company.Exchange_Rate,
                    Tax = closedOrderDetails.Sum(e => e.TaxAmount),
                    Reference_Id = shift.Change_Shift_By,
                    Company_Id = shift.Company_Id,
                    //Pos_Id = shift.Pos_Id,
                    ShiftId = shift.Id,
                    Sub_Total = closedOrderDetails.Sum(e => e.Sub_Amount),
                    Total_Discount = closedOrderDetails.Sum(e => e.Total_Discount ?? 0),
                    Grand_Total = closedOrderDetails.Sum(e => e.Grand_Amount),
                    Order_Status = request.Order_Status,
                    Order_Date = orderDetails.Last().Create_At,
                    OrderDetails = orderDetails,
                    Is_Deleted = false,
                    Change = request.Change,
                    ChangeKh = request.ChangeKh,
                    CustomerId = request.CustomerId,
                    //--CustomerTypeCode = request.CustomerTypeCode.IsNullOrEmpty() ? null : request.CustomerTypeCode,
                    CustomerType = request.CustomerType.ToString()!,
                    Received = request.Received,
                    ReceivedKh = request.ReceivedKh,
                    Remaining = request.Remaining,
                    RemainingKh = request.RemainingKh,
                    ReasonTypeId = request.ReasonTypeId,
                    SellType = sellType!.ToString(), 
                    PaymentTypeCode = request.PaymentTypeCode.IsNullOrEmpty() ? null : request.PaymentTypeCode,
                    PaymentMethodId = request.PaymentMethodId.IsNullOrEmpty() ? null : request.PaymentMethodId,
                    Cancelled_At = (request?.Order_Status == OrderStatus.Cancel) ? DateTime.Now : null,
                    Delivery = request!.DeleveryFee??0,
                    DataSource = DataSourceType.window.ToString()
                };

                _repo.Add(order);
                // _repoDetail.AddRange(orderDetails);
                _repoProduct.UpdateRange(productSell);
                _repo.SaveChanges();

                var sellInvoice = new SellInvoiceResponse();
                if(request.Order_Status == OrderStatus.Close)
                {
                    var temp = CreateSellInvoice(order.Id);
                    temp.OrderTransaction = temp.OrderTransaction.Where(e => e.Status == OrderItemStatus.Close).ToList();
                    sellInvoice = temp;
                }

                return Response<SellInvoiceResponse>.Success(sellInvoice, 1, "Create Successfully");
            }
            catch (Exception ex)
            {
                _repo.Rollback();
                return Response<SellInvoiceResponse>.Fail(ex.Message);
            }
        }

        private SellInvoiceResponse CreateSellInvoice(string orderId, string oldInvoiceNo = null!, List<ReturnOrderDetailsId> returnDetails = null!)
        {
            var invoiceReq = new InvoiceCreateReq()
            {
                OrderId = orderId,
                InvoiceNo = string.IsNullOrEmpty(oldInvoiceNo) ? null : oldInvoiceNo,
                ReturnDetails = returnDetails,
            };

            var data = _invoice.CreateSellInvoice(invoiceReq);
            if(data?.Status == (int)ResponseStatus.Success)
            {
                return data?.Result!;
            }

            _repo.Rollback();
            return null!;
        }

        #endregion
    }
}