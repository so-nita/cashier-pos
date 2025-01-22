using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.WebApi.Models.RequestModel.ChangeShift;
using Microsoft.EntityFrameworkCore;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.ChangeShift;
using CashierPOS.Model.Constants;

namespace CashierPOS.WebApi.Services
{
    public class ChangeShiftService : IChangeShiftService
    {
        private readonly IRepository<ChangeShift> _repo;
        private readonly IRepository<UserLog> _repoUserLog;
        private readonly IRepository<Order> _repoOrder;
        private readonly IRepository<ChangeShiftDetail> _repoShiftDetail;
        private readonly IRepository<PaymentMethod> _repoPayment;
        private readonly IRepository<SellInvoice> _repoInvoice;
        private readonly IRepository<ReturnOrder> _repoReturnOrder;
        private readonly IRepository<Product> _repoProduct;

        public ChangeShiftService(IRepository<ChangeShift> repo, IRepository<UserLog> repoUserLog, IRepository<Order> repoOrder,
            IRepository<ChangeShiftDetail> details, IRepository<PaymentMethod> payment, IRepository<SellInvoice> invoice,
            IRepository<ReturnOrder> returnOrder, IRepository<Product> product)
        {
            _repo = repo;
            _repoUserLog = repoUserLog;
            _repoOrder = repoOrder;
            _repoShiftDetail = details;
            _repoPayment = payment;
            _repoInvoice = invoice;
            _repoReturnOrder = returnOrder;
            //_repoOrderPayment = repoOrderPayment;
            _repoProduct = product;
        }

        public Response<string> Create(ChangeShiftCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<ChangeShiftCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(data: dataErrors.First().ToString());
                }
                var log = _repoUserLog.GetQueryable().Include(e=>e.User.Company).FirstOrDefault(e => e.Id == request.UserLogId);

                if (log == null || log.Action != ActionLog.LogIn) 
                {
                    return Response<string>.Fail();
                }
                var changeShift = new ChangeShift()
                {
                    Pos_Id = log.PosId,
                    UserLogId = log.Id,
                    Start_Shift = DateTime.Now,
                    Change_Shift_By = log.User_Id,
                    Company_Id = log.User.Company_Id,
                    Start_Balance = request.Start_Balance,
                    Start_Balance_Kh = request.Start_Balance_Kh ?? 0,    
                    Company_Name = log.User.Company.Name,
                    Shift_Status = ShiftStatus.Open,
                };
                _repo.Add(changeShift); 
                
                var result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success() : Response<string>.Fail();
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<OpenShiftResponse> OpenShift(ChangeShiftCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<ChangeShiftCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<OpenShiftResponse>.Fail(dataErrors.First().ToString());
                }
                var log = _repoUserLog.GetQueryable().Include(e => e.User.Company).FirstOrDefault(e => e.Id == request.UserLogId);

                if (log == null || log.Action != ActionLog.LogIn)
                {
                    return Response<OpenShiftResponse>.Fail();
                }
                var changeShift = new ChangeShift()
                {
                    //Id = Guid.NewGuid().ToString(),
                    Pos_Id = log.PosId,
                    UserLogId = log.Id,
                    Start_Shift = DateTime.Now,
                    Change_Shift_By = log.User_Id,
                    Company_Id = log.User.Company_Id,
                    Start_Balance = request.Start_Balance,
                    Start_Balance_Kh = request.Start_Balance_Kh ?? 0,
                    Company_Name = log.User.Company.Name,
                    Shift_Status = ShiftStatus.Open,
                };
                _repo.Add(changeShift);

                var result = _repo.SaveChanges();
                var response = new OpenShiftResponse()
                {
                    ShiftId = changeShift.Id,
                    UserLogId = changeShift.UserLogId,
                };
                
                return result > 0 ? Response<OpenShiftResponse>.Success(response, 1) : Response<OpenShiftResponse>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<ChangeShiftResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetQueryable().Include(e => e.User).Where(e => e.Id.ToString() == key.Id).Select(e => new ChangeShiftResponse()
                {
                    Id = e.Id,
                    UserLogId = e.UserLogId,
                    Change_Shift_By = e.Change_Shift_By,
                    Change_Shift_Name = e.User.Name,
                    Start_Balance = e.Start_Balance,
                    Start_Balance_Kh = e.Start_Balance_Kh,
                    End_Balance = e.End_Balance,
                    Company_Id = e.Company_Id,
                    Company_Name = e.Company_Name,
                    Start_Shift = e.Start_Shift,
                    End_Shift = e.End_Shift,
                    Total_Sale = e.Total_Sale,
                    Total_Discount  = e.Total_Discount,
                    Total_Tax = e.Total_Tax,
                    Net_Sale = e.Net_Sale,
                    Print_Date = e.Print_Date,
                    Shift_Status = e.Shift_Status.ToString()
                });
                return Response<ChangeShiftResponse?>.Success(data.First(),data.Count());
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<ChangeShiftResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetQueryable().Include(e => e.User)?.Select(e => new ChangeShiftResponse()
                {
                    Id = e.Id,
                    UserLogId = e.UserLogId,
                    Change_Shift_By = e.Change_Shift_By,
                    Change_Shift_Name = e.User.Name,
                    Start_Shift = e.Start_Shift,
                    End_Shift = e.End_Shift,
                    Start_Balance = e.Start_Balance,
                    Start_Balance_Kh = e.Start_Balance_Kh,
                    End_Balance = e.End_Balance,
                    Total_Sale = e.Total_Sale,
                    Total_Discount = e.Total_Discount,
                    Total_Tax = e.Total_Tax,
                    Net_Sale = e.Net_Sale,
                    Company_Id = e.Company_Id,
                    Company_Name = e.Company_Name,
                    Shift_Status = e.Shift_Status.ToString(),
                    Print_Date = e.Print_Date,  
                }).ToList();
                return Response<List<ChangeShiftResponse>>.Success(data,data.Count());
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> CloseShift(ChangeShiftCloseReq request)
        {
            try
            {
                var changeShift = _repo.GetQueryable().Include(e=>e.Company)/*.Include(e=>e.Orders)*/
                                  //.FirstOrDefault(e => e.Pos_Id == request.PosId && e.Shift_Status == ShiftStatus.Open);
                                  .FirstOrDefault(e => e.Id == request.ShiftId && e.Shift_Status == ShiftStatus.Open);
                
                if (changeShift == null)
                {
                    return Response<string>.Fail("Shift already closed.");
                }
                changeShift.End_Shift = DateTime.Now;

                var orders = _repoOrder.GetAll().Where(e => e.ShiftId == request.ShiftId && e.Order_Status == OrderStatus.Close).ToList();

                //--var orders = changeShift.Orders.Where(e => e.Order_Status == OrderStatus.Close).ToList();
                decimal exchangeRate = changeShift.Company.Exchange_Rate;
                var totalSale = orders.Sum(e => e.Grand_Total);
                var tax = orders.Sum(e => e.Tax);
                var discount = orders.Sum(e => e.Total_Discount);
                var startBalace = changeShift.Start_Balance_Kh / changeShift.Company.Exchange_Rate;
                var openTill = changeShift.Start_Balance + startBalace;
                var changed = orders.Sum(e => e.Change);
                var netSale = totalSale /*- changed */;

                var changeShiftDetails = new List<ChangeShiftDetail>();

                var paymentMethods = _repoPayment.GetAll().ToList();
                var payments = request.Payments.DistinctBy(e => e.PaymentId).ToList();

                decimal closeAmountDollar=0, closeAmountReil=0;
                foreach (var payment in payments)
                {
                    var detail = paymentMethods.Where(e => e.Id == payment.PaymentId);
                    if (detail != null)
                    {
                        var data = detail.Select(e => new ChangeShiftDetail()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Amount = payment.Amount ?? 0,
                            ChangeShift_Id = changeShift.Id,
                            Create_At = DateTime.Now,
                            PaymentMethod_Id = e.Id,
                        }).First();
                        if (detail.FirstOrDefault()!.Name.Contains("CASH(KHR)"))
                        {
                            closeAmountReil += data.Amount;
                        }
                        else
                        {
                            closeAmountDollar += data.Amount; 
                        }
                        changeShiftDetails.Add(data);
                    }
                }

                changeShift.Shift_Status = ShiftStatus.Close;
                changeShift.Total_Sale = orders.Sum(e => e.Sub_Total);
                changeShift.Total_Discount = discount;
                changeShift.Total_Tax = tax;
                changeShift.Total_Changed = changed;
                
                changeShift.Net_Sale = netSale;
                changeShift.End_Balance = openTill + closeAmountDollar + closeAmountReil/exchangeRate;

                
                _repoShiftDetail.AddRange(changeShiftDetails);
                _repo.Update(changeShift);

                var result = _repo.SaveChanges();
                return result>0 ? Response<string>.Success("Close shift Successfully") : Response<string>.Fail();
            }catch (Exception ex)
            {
                return Response<string>.Fail(ex.InnerException!.Message);
            }
        }

        /*public Response<CloseShiftSummaryRqsponse> PrintSummaryShift(CloseShiftPrintSummaryReq request)
        {
            try
            {
                var shift = _repo.GetQueryable().Include(e=>e.Orders).Include(e=>e.Company).Include(e=>e.ChangeShiftDetails)
                    .FirstOrDefault(e => e.Pos_Id == request.PosId && e.Shift_Status == ShiftStatus.Close);

                if (shift == null)
                {
                    return Response<CloseShiftSummaryRqsponse>.Fail();
                }
                var invoices = _repoInvoice.GetQueryable().Include(e=>e.Order)
                               .Where(e => e.Order.Pos_Id == shift.Pos_Id).OrderByDescending(e => e.InvoiceNo);

                var firstInvoiceNo = invoices.Last()!.InvoiceNo;
                var lastInvoiceNo = invoices.First()!.InvoiceNo;

                var orders = shift.Orders;
                
                if (orders == null) 
                {
                    return Response<CloseShiftSummaryRqsponse>.Success();
                }

                var totalInvoice = orders.Where(e => e.Order_Status == OrderStatus.Close);
                var totalDisocunt = new List<OrderPayment>();
                var toltalInvoiceRefund = orders.Where(e => e.Order_Status == OrderStatus.Return);

                foreach (var item in orders)
                {
                    var dataDiscount = item.OrderPayments.Where(e=>e.Discount!=0 && e.Status==OrderStatus.Close).FirstOrDefault();
                    totalDisocunt.Add(dataDiscount!);
                }

                var saleSmmary = new List<TransactionTypeSummary>()
                {
                    new TransactionTypeSummary { Transaction = TransactionType.Sale.ToString(), Qty = invoices.Count(), Total = invoices.Sum(e=>e.Order.Sub_Total) },
                    new TransactionTypeSummary { Transaction = TransactionType.Refund.ToString(), Qty = toltalInvoiceRefund.Count(), Total = toltalInvoiceRefund.Sum(e=>e.Sub_Total) },
                    new TransactionTypeSummary{Transaction = TransactionType.Discount.ToString(),Qty = totalDisocunt.Count(), Total = totalDisocunt.Sum(e=>e.Total)}
                };

                var discountSummary = new List<DiscountSummary>();
                
                var result = new CloseShiftSummaryRqsponse()
                {
                    OpenDate = shift.Start_Shift,
                    CloseDate = shift.End_Shift ?? DateTime.Now,
                    StartBalance = shift.Start_Balance,
                    EndBalance = shift.End_Balance ?? 0.00m,
                    PosId = shift.Pos_Id.ToString("D9"),
                    UserName = shift.Change_Shift_By,  
                    CloseInvoiceNo = lastInvoiceNo,
                    OpenInvoiceNo = firstInvoiceNo,
                    CompanyName = shift.Company_Name,
                    CompanyAddress = shift.Company.Address,
                    CompanyContact = shift.Company.Contact,
                    SaleSummary = saleSmmary,
                    DiscountSummary = discountSummary,
                    PaymemtSummary = shift.ChangeShiftDetails.Select(e => new SellPaymentMethod()
                    {
                        PaymentName = e.PaymentMethod.Name,
                        Amount = e.Amount,
                        PaymentId = e.PaymentMethod_Id
                    }).ToList(),
                    PrintDate = DateTime.Now,
                };

                return Response<CloseShiftSummaryRqsponse>.Success(result,1,"Successfully.");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }*/

        public Response<CloseShiftSummaryRqsponse> PrintSummaryShift(CloseShiftPrintSummaryReq request)
        {
            try
            {
                var shift = _repo.GetQueryable().Include(e => e.User.Company).Include(e => e.ChangeShiftDetails) 
                            .FirstOrDefault(e => /*e.Pos_Id*/ e.Id == request.ShiftId /*request.PosId*/);

                if (shift == null)
                {
                    return Response<CloseShiftSummaryRqsponse>.Fail("Shift not found");
                }

                if(shift.Shift_Status != ShiftStatus.Close)
                {
                    return Response<CloseShiftSummaryRqsponse>.Fail("Please close shift");
                }

                var orders = _repoOrder.GetQueryable().Include(e=>e.OrderDetails).Where(e => /*e.Pos_Id*/ e.ShiftId == shift.Id).ToList();
                if (orders == null)
                {
                    return Response<CloseShiftSummaryRqsponse>.Success();
                }

                var allOrderIds = orders.Select(e => e.Id);
                if (allOrderIds == null)
                {
                    return Response<CloseShiftSummaryRqsponse>.Fail();
                }

                var invoices = _repoInvoice.GetAll().Where(e => orders.Any(i=>i.Id == e.OrderId /*&& e.IsPaid==true*/)).OrderBy(e => e.InvoiceNo).ToList();
               
                var returnOrder = _repoReturnOrder.GetAll().Where(e => e.ShiftId == shift.Id).ToList();
                
                var totalInvoiceRefund = new List<ReturnOrder>();

                decimal totalVat = 0, totalPlt = 0, totalNonVat = 0;
                
                var totalVoid = orders.Where(e => e.Order_Status == OrderStatus.Cancel).ToList();
                var products = _repoProduct.GetAll().ToList();

                // Get distinct tax types from all order details
                var taxTypes = orders.SelectMany(order => order.OrderDetails.Select(detail => detail.TaxType)).Distinct();
                // Dictionary to store the total tax amount for each tax type
                var taxTypeTotals = new Dictionary<Tax, decimal>();
                // Iterate through each tax type
                foreach (var taxType in taxTypes)
                {
                    // Sum the tax amounts for the current tax type
                    decimal taxTypeTotal = orders.SelectMany(order => order.OrderDetails.Where(detail => detail.TaxType == taxType))
                                           .Sum(detail => detail.TaxAmount);
                    // Store the total tax amount for the current tax type
                    taxTypeTotals.Add(taxType, taxTypeTotal);
                    // Update total VAT, PLT, and Non-VAT amounts based on the tax type
                    switch (taxType)
                    {
                        case Tax.VAT: totalVat += taxTypeTotal;
                            break;
                        case Tax.PLT: totalPlt += taxTypeTotal; 
                            break;
                        default: totalNonVat += taxTypeTotal; 
                            break;
                    }
                }

                #region Summary Refund and Discount Summary 
                var discountTypeAmounts = new List<DiscountSummary>();

                foreach (var order in orders)
                {
                    foreach (var od in order?.OrderDetails!)
                    {
                        var data = new DiscountSummary();
                        if (od.Discount_Amount != 0)
                        {
                            data = new DiscountSummary()
                            {
                                Amount = od.Total_Discount??0,
                                DiscountType = "Amount",
                                Qty = od.Qty,
                                Name = od.Discount_Amount.ToString()!
                            };
                        }
                        else
                        {
                            data = new DiscountSummary()
                            {
                                Amount = od.Total_Discount ?? 0,
                                DiscountType = "Percentage",
                                Qty = od.Qty,
                                Name = od.Discount_Percent.ToString()!
                            };
                        }
                        discountTypeAmounts.Add(data);
                    }

                    var matchingReturnOrder = returnOrder.FirstOrDefault(ro => ro.OrderId == order.Id);

                    if (matchingReturnOrder != null)
                    {
                        totalInvoiceRefund.Add(matchingReturnOrder);
                    }
                }
                // Group discounts by type and name, summing up the quantities and amounts
                var groupedDiscounts = discountTypeAmounts.GroupBy(d => new { d.DiscountType, d.Name })
                    .Select(g => new DiscountSummary
                    {
                        DiscountType = g.Key.DiscountType,
                        Qty = g.Sum(d => d.Qty),
                        Name = g.Key.Name,
                        Amount = g.Sum(d => d.Amount)
                    }).OrderBy(d => d.Name).ToList();

                var discountAmounts = new DiscountTypeSummary
                {
                    DiscountAmounts = groupedDiscounts.Where(e => e.DiscountType == "Amount" && !string.IsNullOrEmpty(e.Name)).ToList(),
                    DiscountPercentage = groupedDiscounts.Where(e => e.DiscountType == "Percentage").ToList(),
                };
                #endregion

                var exchangeRate = shift.User.Company.Exchange_Rate;

                #region Summary Payment Method 
                var paymentMethods = _repoPayment.GetAll().ToList();

                var paymentSummary = new List<SellPaymentMethod>();
                foreach (var paymentMethod in paymentMethods)
                {
                    var paymentType = shift?.ChangeShiftDetails?.FirstOrDefault(e => e.PaymentMethod_Id == paymentMethod.Id);
                    var totalAmount = paymentType?.Amount ?? 0;
                    if (paymentMethod.Name.Contains("KHR"))
                    {
                        totalAmount = totalAmount / exchangeRate;
                    }
                    var data = new SellPaymentMethod()
                    {
                        PaymentId = paymentMethod.Id,
                        PaymentName = paymentMethod.Name,
                        Amount = totalAmount, 
                    };
                    paymentSummary.Add(data);
                }
                #endregion

                var totalSale = orders.Sum(e => e.Sub_Total);
                var totalVoidAmount = totalVoid.Sum(e => e.Grand_Total);
                var totalReturnAmount = totalInvoiceRefund.Sum(e => e.Grand_Total);
                var subtotal = orders.Sum(e => e.Sub_Total) + totalReturnAmount;
                var totalDiscountAmount = orders.Sum(e => e.Total_Discount);
                var grandTotalAmount = orders.Where(e=>e.Order_Status == OrderStatus.Close).Sum(e=>e.Grand_Total) /*totalSale - totalReturnAmount - totalDiscountAmount*/;

                // Flatten the nested groupings and select cash payments
                var cashPayments = orders
                    .Where(order => order?.Order_Status == OrderStatus.Close)
                    .Select(payment =>
                    {
                        decimal change = 0m, changeKh = 0m;
                        if (payment?.Received != 0 && payment?.Change != 0)
                        {
                            change = payment!.Change ?? 0;
                        }
                        else if (payment.ReceivedKh != 0)
                        {
                            changeKh = payment.Change * payment.ExchangeRate ?? 0;
                        }
                        return new CashPayment
                        {
                            TotalChange = payment.Change ?? 0,
                            CashPaymentDollar = payment.Received - change ?? 0,
                            CashPaymentReil = payment.ReceivedKh - changeKh ?? 0,
                            QtyCashInReil = (payment.ReceivedKh != null && payment.ReceivedKh > 0 && payment.Received == 0) ? 1 : 0,
                            QtyCashInDollar = (payment.Received != null && payment.Received > 0) ? 1 : 0,
                        };
                    }).ToList();
                var totalDicountDollar = cashPayments.Sum(e => e.CashPaymentDollar) + (cashPayments.Sum(e=>e.CashPaymentReil) / exchangeRate);

                // Sum the cash payments for each property
                var openInvoiceNo = invoices.Any() ? invoices.First().InvoiceNo : "";      
                var closeInvoiceNo = invoices.Any() ? invoices.Where(e => e.IsPaid == true).Last().InvoiceNo : "";
                
                var openTill = shift!.Start_Balance + (shift.Start_Balance_Kh / exchangeRate);
                var closeAmount = cashPayments.Sum(e => e.CashPaymentDollar) + (cashPayments.Sum(e=>e.CashPaymentReil / exchangeRate));

                /*var paymentKHId = paymentSummary.FirstOrDefault(e => e.PaymentName.Contains("KHR"));
                var changeShiftReil = shift.ChangeShiftDetails.FirstOrDefault(e => e.PaymentMethod_Id == paymentKHId.PaymentId);*/

                var _result = new CloseShiftSummaryRqsponse()
                {
                    OpenDate = shift!.Start_Shift,
                    CloseDate = shift.End_Shift ?? DateTime.Now,
                    OpenTill = openTill,
                    OpenBalance = shift.Start_Balance,
                    OpenBalanceKh = shift.Start_Balance_Kh,
                    CloseBalance = closeAmount + openTill /*cashPayments.Sum(e=>e.CashPaymentDollar)*/,
                    CountedDifferentBalance = closeAmount - grandTotalAmount,
                    PosId = shift.Pos_Id.ToString("D9"),
                    UserName = shift.User.Name,
                    OpenInvoiceNo = openInvoiceNo,
                    CloseInvoiceNo = closeInvoiceNo,
                    CompanyName = shift.Company_Name,
                    CompanyNameKh = shift.Company.NameKh!,
                    CompanyAddress = shift.Company?.Address!,
                    CompanyContact = shift.Company?.Contact!,
                    QtyVoid = totalVoid.Count(),
                    TotalVoid = totalVoid.Sum(e => e.Grand_Total),
                    TotalVAT = totalVat,
                    TotalPLT = totalPlt,
                    TotalNonVAT = totalNonVat,
                    QtyReturnTransaction = totalInvoiceRefund.Count(),
                    TotalReturnTransaction = totalReturnAmount,
                    QtySubTotalSale = invoices.Count() - totalInvoiceRefund!.Count(),
                    QtySalesTransaction = orders.Count(),
                    TotalSalesTransaction = totalSale  - totalReturnAmount - totalDiscountAmount /*+ totalVoidAmount + totalReturnAmount*/,
                    TotalSale = totalSale,
                    SubTotal = grandTotalAmount,
                    NetSale = grandTotalAmount - totalVat - totalPlt /*shift.Net_Sale*/ ,
                    PaymemtSummary = paymentSummary?.Where(e => !e.PaymentName.StartsWith("CASH")).ToList() ?? new List<SellPaymentMethod>(),
                    CashPaymentSummary = new CashPayment()
                    {
                        CashPaymentReil = cashPayments?.Sum(payment => payment.CashPaymentReil) ?? 0 /*changeShiftReil.Amount*/,
                        QtyCashInDollar = cashPayments?.Count(payment => payment.QtyCashInDollar == 1) ?? 0,
                        CashPaymentDollar = cashPayments?.Sum(payment => payment.CashPaymentDollar) ?? 0,
                        QtyCashInReil = cashPayments?.Count(payment => payment.QtyCashInReil == 1) ?? 0
                    },
                    TotalPaymentSummary = totalDicountDollar,
                    QtyDiscountTransaction = groupedDiscounts.Where(e => Convert.ToDecimal(e.Amount) != 0).Sum(e => e.Qty),
                    TotalDiscountTransaction = totalDiscountAmount ,
                    DiscountSummary = discountAmounts,
                    Change = shift.Total_Changed,
                    TotalTillWithdrawal = 0 /*shift.Start_Balance*/,
                    CashierTotal = /*paymentSummary?.Sum(e=>e.Amount)*/ grandTotalAmount,
                    PrintDate = DateTime.Now,
                };
                // Update data in ChangeShift
                shift.Print_Date = DateTime.Now;
                _repo.Update(shift);
                _repo.SaveChanges();

                return Response<CloseShiftSummaryRqsponse>.Success(_result, 1, "Successfully");
            }
            catch (Exception ex)
            {
                return Response<CloseShiftSummaryRqsponse>.Fail(ex.Message);
            }
        }
        
        public Response<string> Update(ChangeShiftUpdateReq request)
        {
            try
            {
                var user = _repo.GetQueryable().Include(e => e.User).Where(e => e.Id.ToString() == request.Id);

                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }

        public Response<string> Delete(Key key)
        {
            try
            {
                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }
    }
     
}
