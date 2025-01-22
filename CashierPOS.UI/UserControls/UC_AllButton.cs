using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.Testing;
using CashierPOS.UI.View.View_PopUp.Customer;
using CashierPOS.UI.View.ViewStock;
using CashierPOS.UI.View_Content_Cashier;
using CashierPOS.UI.View_PopUp;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_AllButton : UserControl
    {
        private IParentView _parentView;
        public event EventHandler ButtonClick = null!;
        public OrderCreateReq Data { get; set; } = new();
        public ReturnOrderResponse DataReturnOrder { get; set; } = null!;

        public bool IsReturnMode
        {
            get
            {
                return IsReturn;
            }
            set
            {
                IsReturn = value;
            }
        }

        private readonly IMainView _mainView;

        public UC_AllButton(IMainView mainView, IParentView parentView = null!)
        {
            InitializeComponent();
            _mainView = mainView;
            _parentView = parentView;
            InitializeDataComponent();
            ChangeButton();
        }

        private async void btnCancle_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(sender, e);
            }
            if (IsReturn)
            {
                IsReturn = false;
                _parentView.ReturnOrder?.Details?.Clear();
                _parentView.Carts.Clear();
                _parentView.ViewPOS_LoadingData();
                return;
            }
            if (Data.OrderDetails.Count <= 0 && _parentView.HoldOrder == null)
            {
                MessageBox.Show("Plase Select item", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (_parentView.HoldOrder != null)
            {
                var order = new OrderResponse()
                {
                    OrderId = _parentView.HoldOrder.OrderId,
                };
                var form = new PopUp_Cancel(_parentView, order);

                PopUp_Background.Form = form;
                PopUp_Background.ShowPopUp();
            }
            else
            {
                var orderResponse = await CreateOrder();
                PopUp_Background.Form = new PopUp_Cancel(_parentView, orderResponse);
                PopUp_Background.ShowPopUp();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form = new PopUp_ApproveCode(_parentView);
            PopUp_Background.Form = form;
            IsReturn = true;
            PopUp_Background.ShowPopUp();
            if (form.BtnCancelClicked == true)
            {
                IsReturn = false;
            }
            UpdateButtonDisableForReturn();
        }

        public void UpdateButtonDisableForReturn()
        {
            // Test date : 01-03-2024
            //--btnCancle.Enabled = !IsReturn;
            if (IsReturn && _parentView.ReturnOrder.Details?.Count > 0)
            {
                btnHoldOrder.Enabled = false;
                btnReturn.Enabled = false;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(sender, e);
            }
            if (_parentView.ReturnOrder.Details!.Count > 0)
            {
                UpdateButtonDisableForReturn();
                // Select details from ReturnOrder where Product_Id exists in Carts
                var dataReturn = _parentView.ReturnOrder.Details.Where(detail => _parentView.Carts.Any(cart => cart.Id == detail.Product_Id)).ToList();
                decimal discount = 0;
                foreach (var product in dataReturn)
                {
                    var discountAmount = (product.Discount_Amount != 0 && product.Discount_Amount != null) ? product.Discount_Amount
                               : (product.Discount_Percent * product.Price) / 100;
                    discount += (discountAmount ?? 0) * product.Qty;
                }
                var total = dataReturn.Sum(e => e.Price * e.Qty) - discount;

                _parentView.ReturnOrder.Total = total;
                _parentView.ReturnOrder.Details = dataReturn;

                var form = new PopUp_PaymentOption(_parentView, null!, _parentView.ReturnOrder);
                form.IsReturned += Form_IsReturned;
                form.BringToFront();
                PopUp_Background.Form = form;
                PopUp_Background.ShowPopUp();
            }
            else if (Data.OrderDetails.Where(e => e.Status == OrderItemStatus.Close).Count() > 0 && Data.Order_Status == OrderStatus.Close && _parentView.HoldOrder == null)
            {
                var form = new PopUp_PaymentOption(_parentView, Data);
                PopUp_Background.Form = form;
                PopUp_Background.ShowPopUp();
            }
            else if (_parentView.HoldOrder != null)
            {
                CreateOrderForHoldOrder();
            }
            else
            {
                MessageBox.Show("Please add product to cart.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_IsReturned(object? sender, bool e)
        {
            IsReturn = false;
        }

        private void CreateOrderForHoldOrder()
        {
            var holdOrder = _parentView.HoldOrder;
            decimal totalDiscount = 0;
            var carts = _parentView.Carts.Where(e => e.Status == OrderItemStatus.Close.ToString()).ToList();
            foreach (var cartItem in carts)
            {
                // Check if the product from carts is not already in holdOrder
                var detail = holdOrder.OrderDetails?.FirstOrDefault(h => h.Product_Id == cartItem.Id);

                var discountAmount = (cartItem.DiscountAmount != 0 && cartItem.DiscountAmount != null) ? cartItem.DiscountAmount
                                      : (cartItem.DiscountPercent * cartItem.Price) / 100;
                decimal? discount = (discountAmount ?? 0) * cartItem.Qty;
                totalDiscount += discount ?? 0;

                if (detail == null)
                {
                    var newOrder = new OrderDetailResponse
                    {
                        Product_Id = cartItem.Id,
                        Price = cartItem.Price,
                        Qty = cartItem.Qty,
                        Status = Enum.Parse<OrderItemStatus>(cartItem.Status),
                        Sub_Amount = (cartItem.Price * cartItem.Qty) - discount ?? 0 /*(cartItem.Price *//*-*//** cartItem.DiscountPercent ?? 0) / 100*/,
                        ReasonCode = cartItem.ReasonCode
                    };
                    holdOrder.OrderDetails!.Add(newOrder);
                }
                else if (cartItem.Qty != detail.Qty || cartItem.Status != detail.Status.ToString())
                {
                    detail.Status = Enum.Parse<OrderItemStatus>(cartItem.Status);
                    detail.Qty = cartItem.Qty;
                    detail.Sub_Amount = (cartItem.Price * cartItem.Qty) - discount ?? 0 /*(cartItem.Price - cartItem.DiscountPercent ?? 0) / 100*/;
                }
            }
            var subTotal = holdOrder.OrderDetails!.Where(e => e.Status == OrderItemStatus.Close).Sum(s => s.Price * s.Qty);
            var grandTotal = subTotal - totalDiscount;
            holdOrder.Total = grandTotal;
            holdOrder.TotalKh = grandTotal * holdOrder.ExchangeRate;
            // Now holdOrder should contain products from carts that were not already present
            var form = new PopUp_PaymentOption(_parentView, null!, null!, holdOrder);
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }

        private async Task<OrderResponse> CreateOrder()
        {
            var service = new OrderService();
            if (Data == null) return null!;

            var orderData = new OrderWithInvoiceCreateReq()
            {
                Shift_Id = Data.ShiftId,
                Order_Status = Data.Order_Status,
                OrderDetails = Data.OrderDetails,
                DeleveryFee = Data.DeleveryFee,
            };

            var order = await service.CreateOrderAsync(orderData);

            if (order.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }

            return new OrderResponse()
            {
                OrderId = order.Result!.OrderId,
                ExchangeRate = order.Result.ExchangeRate,
                //-- Is_Delete = order.Result.Is_Delete,
                OrderDate = order.Result.OrderDate,
                ShiftId = order.Result.ShiftId,
                Total = order.Total,
                TotalKh = order.Result.TotalKh,
                OrderStatus = order.Result.OrderStatus,
            };
        }

        /*private async void CreateReturnOrder()
        {
            if (_parentView.ReturnOrder != null)
            {
                var orderService = new OrderService();
                *//*-- var orderReturnReq = new OrderReturnReq()
                 {
                     InvoiceNo = _parentView.ReturnOrder.InvoiveNo,
                     ProductCode = _parentView.ReturnOrder.ProductCode,
                     ReasonReturnCode = _parentView.ReturnOrder.ReasonReturnCode,
                     ApprovedByUserId = _parentView.ReturnOrder.ApprovedByUserId,
                 };*//*
                var orderReturnReq = new OrderReturnReq()
                {
                    InvoiceNo = _parentView.ReturnOrder.InvoiveNo,
                    ProductIds = _parentView.ReturnOrder.Details?.Select(e => e.Product_Id).ToList(),
                    ReasonReturnCode = _parentView.ReturnOrder.ReasonReturnCode,
                    ApprovedByUserId = _parentView.ReturnOrder.ApprovedByUserId,
                };
                var data = await orderService.ReturnOrderAsync(orderReturnReq);
                if (data.Status == (int)ResponseStatus.Success)
                {
                    IsReturn = false;

                    decimal total = _parentView.ReturnOrder.Details.Sum(e => e.Price * e.Qty - (e.Price * e.Discount_Amount ?? 0) / 100);
                    _parentView.ReturnOrder.Total = total;
                    _parentView.ReturnOrder.TotalKh = total * _parentView.ReturnOrder.ExchangeRate;
                    var form = new PopUp_PaymentOption(_parentView, null!, _parentView.ReturnOrder);
                    form.BringToFront();
                    PopUp_Background.Form = form;
                    PopUp_Background.ShowPopUp();
                }
            }
        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_isLog)
            {
                btnLogin.Text = "Logout";
                var form = new PopUp_Logout(_mainView);
                // Subscribe to the LogoutStatusChanged event
                form.LogoutStatusChanged += PopUpLogout_LogoutStatusChanged!;
                PopUp_Background.Form = form;
                PopUp_Background.ShowPopUp();
            }
            else
            {
                btnLogin.Text = "Login";
                var subForm = new PopUp_LoginForm();
                subForm.LoginSuccess += SubForm_LoginSuccess;
                PopUp_Background.Form = subForm;
                PopUp_Background.ShowPopUp();
                _isLog = subForm.IsUserLog ? true : false;
                _mainView.LoadData();
            }
            this.UC_AllButton_Load();
        }

        private void SubForm_LoginSuccess(object? sender, EventArgs e)
        {
            IsUserLoggedOut = false;
            this.IsUserLogged = false;
        }

        private void PopUpLogout_LogoutStatusChanged(object sender, bool isLogoutSuccessful)
        {
            if (isLogoutSuccessful)
            {
                if (_parentView != null)
                {
                    _parentView.CloseView();
                }
                else
                {

                    this.SetIsLogin(false);
                    AppStoreContext.ClearCurrentUser();
                    _mainView.CloseView();
                }
            }
        }
        //Function Change Button LogIn & LogOut
        public void ChangeButton()
        {
            var user = AppStoreContext.CurrentUser;
            btnLogin.Text = user != null ? "Logout" : "Login";

            if (user != null && user.ShiftStatus == ShiftStatus.Open)
            {
                btnOpenShift.Text = user.ShiftStatus == ShiftStatus.Open ? "Close Shift" : "Open Shift";
                IsOpenShift = true;
            }
            this.UC_AllButton_Load();
        }

        private void EnableButtonPay(bool canPay)
        {
            btnPayment.Enabled = canPay;
        }
        private void btnOpenShift_Click(object sender, EventArgs e)
        {
            if (IsOpenShift == false)
            {
                btnOpenShift.Text = "Open Shift";
                var shiftForm = new PopUp_OpenShift(_mainView);
                PopUp_Background.Form = shiftForm;
                PopUp_Background.ShowPopUp();
            }
            else
            {
                if (_parentView.NumberHoldOrder <= 0)
                {
                    var form = new PopUp_CloseShift();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    PopUp_Background.Form = form;
                    form.IsClosedShift += IsCloseShift_Click;
                    PopUp_Background.ShowPopUp();
                }
                else
                {
                    MessageBox.Show("Plase clear all hold order before close shift", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void IsCloseShift_Click(object? sender, bool response)
        {
            if (response)
            {
                /*IsOpenShift = false;
                btnOpenShift.Text = "Open Shift";
                btnOpenShift.Enabled = false;
                btnCashier.Enabled = false;
                btnLogin.Enabled = false;
                // _parentView.UserClosedShift();
                //--IsUserLogged = true;*/
                IsUserLogged = true;
                _mainView.AddController(new view_Content_Cashier(_mainView));
            }
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            var form = new PopUp_ReprintInvoice(_parentView);
            PopUp_Background.Form = form;
            form.ShowInTaskbar = false;
            PopUp_Background.ShowPopUp();
        }

        private async void btnCashier_Click(object sender, EventArgs e)
        {
            var user = AppStoreContext.CurrentUser;
            if (user == null)
            {
                MessageBox.Show("Plase open shift");
            }
            else if (user.ShiftStatus == ShiftStatus.Open)
            {
                MessageBox.Show("Plase close shift", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var service = new ChangeShiftService();
                //var invoice = await service.CreateReceiptSummaryCloseShift(user!.PosId.ToString());
                var invoice = await service.CreateReceiptSummaryCloseShift(user!.ShiftId.ToString());
                if (invoice?.Status != (int)ResponseStatus.Success)
                {
                    MessageBox.Show("   Someting went wrong.    ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var popupReceipt = new PopUp_ReceiptSummary(invoice.Result!);
                PopUp_Background.Form = popupReceipt;
                popupReceipt.ShowInTaskbar = false;
                PopUp_Background.ShowPopUp();
            }
        }

        public event EventHandler HoldOrderClicked = null!;
        private async void btnHoldOrder_Click(object sender, EventArgs e)
        {
            var cartStatus = _parentView.Carts.Where(e => e.Status == OrderItemStatus.Close.ToString()).Count();

            if (cartStatus != 0 && _parentView.HoldOrder == null)
            {
                var currentUser = AppStoreContext.CurrentUser;
                var dataRequest = new OrderWithInvoiceCreateReq()
                {
                    Shift_Id = currentUser.ShiftId,
                    Order_Status = OrderStatus.Hold,
                    DeleveryFee = 0,
                    OrderDetails = _parentView.Carts?.Select(e => new OrderDetailCreateReq()
                    {
                        Status = Enum.Parse<OrderItemStatus>(e.Status),
                        ReasonCode = e.ReasonCode,
                        Product_Id = e.Id,
                        Discount_Percent = e.DiscountPercent,
                        Discount_Amount = e.DiscountAmount,
                        Qty = e.Qty,
                    }).ToList()!,
                };
                var service = new OrderService();
                var dataResponse = await service.CreateOrderAsync(dataRequest);
                if (dataResponse?.Status != (int)ResponseStatus.Success)
                {
                    MessageBox.Show(dataResponse?.Message ?? "Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _parentView.NumberHoldOrder++;
                    _parentView.Carts?.Clear();
                    _parentView.ViewPOS_LoadingData();
                }
            }
            else if (_parentView.HoldOrder != null/* && dataRehold > 0*/)
            {
                await ReHoldOrderAsync();
            }
            else
            {
                _parentView.Carts.Clear();
                MessageBox.Show("Plase select item", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ReHoldOrderAsync()
        {
            var dataRehold = _parentView.Carts?.Where(e => e.Status != OrderItemStatus.Cancel.ToString()).Count() ?? 0;
            if (dataRehold == 0 && !string.IsNullOrEmpty(_parentView.HoldOrder.OrderId))
            {
                var service = new OrderService();
                var dataReq = new OrderDeleteReq()
                {
                    Id = _parentView.HoldOrder.OrderId,
                };
                var order = await service.DeleteOrderAsync(dataReq);
                _parentView.HoldOrder = null!;
                _parentView.ViewPOS_LoadingData();
                return;
            }
            if (HoldOrderChanged())
            {
                // Update the hold order
                await UpdateHoldOrder();
            }
            _parentView.NumberHoldOrder++;
            _parentView.Carts?.Clear();
            _parentView.HoldOrder = null!;
            _parentView.ViewPOS_LoadingData();
        }

        private bool HoldOrderChanged()
        {
            // Check if the details of any item in the hold order have changed
            foreach (var item in _parentView.Carts)
            {
                var oldItem = _parentView.HoldOrder.OrderDetails?.FirstOrDefault(d => d.Product_Id == item.Id);
                if (oldItem == null || oldItem.Qty != item.Qty
                    || oldItem.Status.ToString() != item.Status
                    || oldItem.Discount_Amount != item.DiscountAmount || oldItem.Discount_Percent != item.DiscountPercent)
                {
                    return true;
                }
            }
            return false;
        }

        private async Task UpdateHoldOrder()
        {
            var holdOrder = _parentView.HoldOrder;
            var dataRequest = new HoldOrderUpdateReq()
            {
                OrderId = _parentView.HoldOrder.OrderId,
                DeleveryFee = 0,
                Received = 0,
                ReceivedKh = 0,
                Remaining = 0,
                RemainingKh = 0,
                Change = 0,
                ChangeKh = 0,
                OrderDetails = _parentView.Carts.Select(item => new OrderDetailCreateReq
                {
                    Product_Id = item.Id,
                    Qty = item.Qty,
                    Status = Enum.Parse<OrderItemStatus>(item.Status, true),
                    ReasonCode = item.ReasonCode,
                    Discount_Amount = item.DiscountAmount,
                    Discount_Percent = item.DiscountPercent,
                }).ToList(),
                Status = OrderStatus.Hold,
                PaymentMethodId = null,
                CustomerId = null,
                PaymentTypeCode = null,
            };
            var service = new OrderService();
            var dataResponse = await service.UpdateHoldOrder(dataRequest);

            if (dataResponse?.Status != (int)ResponseStatus.Success)
            {
                MessageBox.Show(dataResponse?.Message ?? "Failed to update order", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //_parentView.NumberHoldOrder++;
                _parentView.Carts?.Clear();
                _parentView.ViewPOS_LoadingData();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var form = new PopUp_Customer();
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            /* if (string.IsNullOrEmpty(_parentView.ProductApplyDiscount))
             {
                 MessageBox.Show("   Please select the product   ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/
            var form = new PopUp_Discount(_parentView);
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var form = new PopUp_ProductStock();
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }
    }
}
