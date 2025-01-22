using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Customer;
using CashierPOS.Model.Models.CustomerType;
using CashierPOS.Model.Models.GiftCoupon;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.Model.Models.PaymentType;
using CashierPOS.Model.Models.Source;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.Testing;
using CashierPOS.UI.View.View_PopUp;
using CashierPOS.UI.View.View_PopUp.PaymenMethod;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using ReaLTaiizor.Controls;
using System.ComponentModel.DataAnnotations;
namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_PaymentOption : Form
    {
        private IParentView _parentView;
        private OrderCreateReq _data = null!;
        private ReturnOrderResponse _dataReturn { get; set; } = new();
        private HoldOrderResponse _holdOrder { get; set; } = null!;
        public PopUp_PaymentOption(IParentView parentView, OrderCreateReq data = null!, ReturnOrderResponse returnData = null!, HoldOrderResponse holdOrder = null!)
        {
            _parentView = parentView;
            InitializeComponent();
            InitializeEventHandeler();
            if (data != null && holdOrder == null)
            {
                _data = data;
            }
            else if (holdOrder != null)
            {
                _holdOrder = holdOrder;
            }
            else if (returnData != null) { _dataReturn = returnData; /*AsignValueForReturn();*/ }
            AsignValue();
        }

        private decimal? _cachedExchangeRate;
        private decimal _exchangeRate
        {
            get
            {
                if (_parentView.ReturnOrder?.Details?.Count == 0)
                {
                    if (!_cachedExchangeRate.HasValue)
                    {
                        _cachedExchangeRate = AppStoreContext.CurrentUser?.ExchangeRate ?? 0;
                    }
                }
                else
                {
                    _cachedExchangeRate = AppStoreContext.CurrentUser.SaleExchangeRate ?? 0;
                }
                return _cachedExchangeRate.Value;
            }
        }

        private OrderResponse GetOrder { get; set; } = new();
        private void PopUp_PaymentOption_Load()
        {
            PopulateCustomerTypesComboBox();
            PopulateSellTypeComboBox();
            comboBoxGiftCoupon_SelectedIndexChanged();
            InitDataPaymentMethod();
        }

        private async void InitDataPaymentMethod()
        {
            var service = new PaymentTypeService();
            _paymentTypes = await service.GetAll();

            var servcice_ = new PaymentMethodService();
            _paymentMethods = await servcice_.GetAllAsync();
        }

        //Asign Value on Cash Payment for Total Pay USD and KH
        private void AsignValue()
        {
            CustomerInformation();
            if (_holdOrder != null)
            {
                var totalPayKh = CustomStyle.RoundUpCurrencyKh(_holdOrder.TotalKh);
                txtTotalPay.Text = "$ " + _holdOrder.Total.ToString("N2");
                txtTotalPayKh.Text = totalPayKh.ToString("N0");
            }
            else if (_dataReturn?.Details?.Count > 0)
            {
                ReadOnlyForShowReturn();
                //var total = _dataReturn.Details;
                var totalPayKh = _dataReturn.Total * _exchangeRate;

                txtboxCusEmail.Text = _dataReturn.CustomerName ?? "N/A";
                txtboxEarning.Text = _dataReturn.Exarning == null ? "N/A" : _dataReturn.Exarning.ToString();
                txtTotalPay.Text = "- $ " + _dataReturn.Total.ToString("N2");
                txtTotalPayKh.Text = "- " + CustomStyle.RoundUpCurrencyKh(totalPayKh).ToString("N0");
                txtboxCusPhone.Text = _dataReturn.CustomerContact ?? "N/A";
                txtboxCusId.Text = _dataReturn.CustomerCode ?? "N/A";
                txtboxCusName.Text = _dataReturn.CustomerName ?? "N/A";
            }
            else
            {
                var dataOrder = _data.OrderDetails.Where(e => e.Status == OrderItemStatus.Close)
                               .Sum(e => (e.Qty * e.Price) - (e.Qty * e.Discount_Amount)) ?? 0;
                var totalPayKh = CustomStyle.RoundUpCurrencyKh(dataOrder * _exchangeRate);

                txtTotalPay.Text = "$ " + dataOrder.ToString("N2");
                txtTotalPayKh.Text = totalPayKh.ToString("N0");
                /*decimal? discount = 0;
                var dataOrder = _data.OrderDetails.Where(e => e.Status == OrderItemStatus.Close);
                foreach (var product in dataOrder)
                {
                    var discountAmount = (product.Discount_Amount != 0 && product.Discount_Amount != null) ? product.Discount_Amount
                                   : (product.Discount_Percent * product.Price) / 100;
                    discount += (discountAmount ?? 0) * product.Qty;
                }
                var total = dataOrder.Sum(e => e.Qty * e.Price) - discount??0;
               
                var totalPayKh = CustomStyle.RoundUpCurrencyKh(total * ExchangeRate);

                txtTotalPay.Text = "$ " + total.ToString("N2");
                txtTotalPayKh.Text = totalPayKh.ToString("N0");*/
            }
        }

        private bool _canPayment { get; set; } = false;
        private async Task<SellInvoiceResponse> CreateOrder()
        {
            var service = new OrderService();
            if (_data == null) return null!;

            var orderDetail = new List<OrderDetailCreateReq>();
            foreach (var item in _data.OrderDetails)
            {
                if (item.Discount_Percent > 0)
                {
                    item.Discount_Amount = 0;
                }
                else if (item.Discount_Amount > 0)
                {
                    item.Discount_Percent = 0;
                }
                orderDetail.Add(item);
            }
            CustomerTypes customerType = CustomerTypes.General; // Default value
            if (comboBoxCustomerType.SelectedItem != null)
            {
                // Cast the selected item to CustomerTypes enum
                if (Enum.TryParse(comboBoxCustomerType.SelectedItem.ToString(), out CustomerTypes selectedCustomerType))
                {
                    customerType = selectedCustomerType;
                }
            }

            decimal received = ConvertStringToDecimal(txtReceive.Text);
            decimal receivedKh = ConvertStringToDecimal(txtReceiveKh.Text);
            var customerCode = txtboxCusId.Text.Trim();
            var customerId = _customers.FirstOrDefault(e => e.CustomerCode == customerCode);

            var orderData = new OrderCreateReq()
            {
                ShiftId = _data.ShiftId,
                Order_Status = _data.Order_Status,
                SellType = SellType.InStored,
                Received = received,
                ReceivedKh = receivedKh,
                Remaining = ConvertStringToDecimal(txtRemaining.Text),
                RemainingKh = ConvertStringToDecimal(txtRemainingKH.Text),
                Change = ConvertStringToDecimal(txtChange.Text),
                ChangeKh = ConvertStringToDecimal(txtChangeKh.Text),
                //CustomerTypeCode = customerTypeCode,
                CustomerType = (customerId == null) ? customerType : CustomerTypes.Loyality,
                PaymentTypeCode = _paymentTypes.Any() ? _getValuePaymentType ?? _paymentTypes.First().Code : null,
                //PaymentMethodId = PaymentMethodId,
                PaymentMethodId = GetPaymentMethodId(),
                CustomerId = string.IsNullOrEmpty(customerId?.CustomerId) ? null : customerId?.CustomerId,
                ReasonTypeId = null,
                OrderDetails = _data.OrderDetails?.Select(e => new OrderDetailCreateReq()
                {
                    Price = e.Price,
                    Discount_Percent = e.Discount_Percent,
                    Discount_Amount = e.Discount_Amount,
                    Product_Id = e.Product_Id,
                    Qty = e.Qty,
                    ReasonCode = e?.ReasonCode,
                    Status = e.Status,
                }).ToList()!,
                DeleveryFee = 0,
            };
            //-- Error Code Here Date : 12-03-2024
            var order = await service.CreateOrderWithInoivceAsync(orderData);
            if (order?.Status != (int)ResponseStatus.Success)
            {
                MessageBox.Show(order?.Message ?? "Failed to Create Payment", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
            return order.Result!;
            // Added Date: 13-05-2024
            /*this.TopMost = false;
            this.Close();
            PopUp_Background.ClosePopUp();

            var invoice = new PopUp_Recipt(_parentView, order.Result!);
            invoice.ShowInTaskbar = false;
            PopUp_Background.Form = invoice;
            PopUp_Background.ShowPopUp();*/
        }
        //For Close form Payment
        private void btnClosePayment_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private static List<CustomerTypeResponse> selectCustomers = new();
        private static List<SourceResponse> selectSource = new();
        private static List<GiftCouponResponse> selectGiftCoupon = new();

        // Function select Customer Type
        /*private async void comboBoxCustomerType_SelectedIndexChanged()
        {
            var customerService = new CustomerTypeService();
            selectCustomers = await customerService.GetAllAsync();

            if (_dataReturn?.Details.Count > 0)
            {
                //--InitializeDataForReturn();
                var customerType = selectCustomers.FirstOrDefault(item => item.Code == _dataReturn.CustomerTypeCode);
                comboBoxCustomerType.Items.Add(customerType?.Name);
                comboBoxCustomerType.SelectedItem = customerType?.Code;
                comboBoxCustomerType.Enabled = false;
            }
            else
            {
                foreach (var item in selectCustomers)
                {
                    comboBoxCustomerType.Items.Add(item.Name);
                    comboBoxCustomerType.SelectedItem = item.Code;
                }
            }
            comboBoxCustomerType.SelectedIndex = 0;
        }*/
        private void PopulateCustomerTypesComboBox()
        {
            comboBoxCustomerType.Items.Clear();
            // Loop through enum values and add them to the ComboBox
            foreach (CustomerTypes customerType in Enum.GetValues(typeof(CustomerTypes)))
            {
                // Get the display name attribute of the enum value
                var displayNameAttribute = typeof(CustomerTypes)
                    .GetField(customerType.ToString())
                    .GetCustomAttributes(typeof(DisplayAttribute), false)
                    .FirstOrDefault() as DisplayAttribute;
                // Add the display name to the ComboBox
                comboBoxCustomerType.Items.Add(displayNameAttribute?.Name ?? customerType.ToString());
            }
            // Select the first item by default
            comboBoxCustomerType.SelectedIndex = 0;
        }

        //function select Source
        /*private async void comboBoxSource_SelectedIndexChanged()
        {
            var sourceService = new SourceService();
            selectSource = await sourceService.GetAllAsync();
            if (_dataReturn?.Details.Count > 0)
            {
                //--InitializeDataForReturn();
                var source = selectSource?.FirstOrDefault(item => item.Id == _dataReturn.SourceId);
                comboBoxSource.Items.Add(source?.Name);
                comboBoxSource.SelectedItem = source?.Id;
                comboBoxSource.Enabled = false;
            }
            else
            {
                foreach (var item in selectSource)
                {
                    comboBoxSource.Items.Add(item.Name);
                    comboBoxSource.SelectedItem = item.Id;
                }
            }
            comboBoxSource.SelectedIndex = 0;
        }*/
        private void PopulateSellTypeComboBox()
        {
            comboBoxSource.Items.Clear();
            // Loop through enum values and add them to the ComboBox
            foreach (SellType sellType in Enum.GetValues(typeof(SellType)))
            {
                // Get the display name attribute of the enum value
                var displayNameAttribute = typeof(SellType)
                    .GetField(sellType.ToString())
                    .GetCustomAttributes(typeof(DisplayAttribute), false)
                    .FirstOrDefault() as DisplayAttribute;
                // Add the display name to the ComboBox
                comboBoxSource.Items.Add(displayNameAttribute?.Name ?? sellType.ToString());
            }
            // Select the first item by default
            comboBoxSource.SelectedIndex = 0;
        }


        //Function Select Gift Coupon
        private void comboBoxGiftCoupon_SelectedIndexChanged()
        {
            selectGiftCoupon = new List<GiftCouponResponse>()
            {
                
            };
            foreach (var item in selectGiftCoupon)
            {
                comboBoxGiftCoupon.Items.Add(item.Name);
                comboBoxGiftCoupon.SelectedItem = item.Id;
            }
            comboBoxGiftCoupon.Items.Add(new GiftCouponResponse() { Id = "0", Name = " -- Select -- " });
            comboBoxGiftCoupon.DisplayMember = "Name";
            comboBoxGiftCoupon.SelectedIndex = 0;
        }


        //Function button Back Payment
        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        //
        private void CloseForm()
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }
        //Function Charge & Print
        private async void btnChargePrint_Click(object sender, EventArgs e)
        {
            if (_dataReturn.Details == null)
            {
                //For Alert Input Receive befor Pay Cash
                if (txtReceive.Text.Trim() == "0.00" && txtReceiveKh.Text.Trim() == "​  0​")
                {
                    MessageBox.Show("Please input Receive before Pay Cash.");
                    return;
                }
                //For Alert Input Receive equal TotalPay
                else if (CustomStyle.ConvertStringToDecimal(txtReceive.Text, "$") < CustomStyle.ConvertStringToDecimal(txtTotalPay.Text, "$"))
                {
                    MessageBox.Show("Receive is Wrong!  Please input Receive again.");
                }
            }
            // For return order 
            else if (_dataReturn?.Details!.Count > 0)
            {
                // Update Return Order to Order
                var isReturned = await CreateReturnOrder();
                if (isReturned)
                {
                    IsReturned(this, isReturned);
                    //CreatePaymentForReturn();
                    _parentView.LoadDataApi();
                    _parentView.UpdateProductData();
                }
            }
            else if (_holdOrder != null)
            {
                CreatePaymentForHoldOrder();
            }
            // For Normal order 
            else
            {
                // GetOrder = await CreateOrder();
                var dataResponse = await CreateOrder();
                if (dataResponse != null)
                {
                    this.TopMost = false;
                    this.Close();
                    PopUp_Background.ClosePopUp();

                    var invoice = new PopUp_Recipt(_parentView, dataResponse);
                    invoice.ShowInTaskbar = false;
                    PopUp_Background.Form = invoice;
                    PopUp_Background.ShowPopUp();

                    _parentView.LoadDataApi();
                    _parentView.UpdateProductData();
                }
            }
        }

        public event EventHandler<bool> IsReturned = null!;
        private async Task<bool> CreateReturnOrder()
        {
            var orderService = new OrderService();
            var orderReturnReq = new OrderReturnReq()
            {
                InvoiceNo = _parentView.ReturnOrder.InvoiveNo,
                ProductIds = _parentView.ReturnOrder.Details?.Select(e => e.Product_Id).ToList(),
                ReasonReturnId = _parentView.ReturnOrder.ReasonReturnId,
                ApprovedByUserId = _parentView.ReturnOrder.ApprovedByUserId,
            };
            var data = await orderService.ReturnOrderAsync(orderReturnReq);
            if (data.Status == (int)ResponseStatus.Success)
            {
                AppStoreContext.ClearCurrentUserApprove();

                PopUp_Background.ClosePopUp();
                this.Close();   //-- add: 16-05-2024
                // Added Date: 13-05-2024
                this.TopMost = false;
                var invoice = new PopUp_ReturnInvoice(_parentView, data.Result!);
                PopUp_Background.Form = invoice;
                invoice.ShowInTaskbar = false;
                PopUp_Background.ShowPopUp();
                return true;
            }
            return false;
        }


        //Function Create Payment for Return
        private async void CreatePaymentForHoldOrder()
        {
            CustomerTypes customerType = CustomerTypes.General; // Default value
            if (comboBoxCustomerType.SelectedItem != null)
            {
                // Cast the selected item to CustomerTypes enum
                if (Enum.TryParse(comboBoxCustomerType.SelectedItem.ToString(), out CustomerTypes selectedCustomerType))
                {
                    customerType = selectedCustomerType;
                }
            }
            SellType saleType = SellType.InStored; // Default value
            if (comboBoxCustomerType.SelectedItem != null)
            {
                // Cast the selected item to CustomerTypes enum
                if (Enum.TryParse(comboBoxSource.SelectedItem?.ToString(), out SellType selectedSellType))
                {
                    saleType = selectedSellType;
                }
            }
            decimal received = ConvertStringToDecimal(txtReceive.Text);
            decimal receivedKh = ConvertStringToDecimal(txtReceiveKh.Text);
            var customerCode = txtboxCusId.Text.Trim();
            var customerId = _customers.FirstOrDefault(e => e.CustomerCode == customerCode);
            var datRequest = new HoldOrderUpdateReq()
            {
                OrderDetails = _holdOrder.OrderDetails?.Select(e => new OrderDetailCreateReq()
                {
                    Price = e.Price,
                    Discount_Percent = e.Discount_Percent,
                    Product_Id = e.Product_Id,
                    Qty = e.Qty,
                    ReasonCode = e.ReasonCode,
                    Status = e.Status,
                }).ToList(),
                DeleveryFee = 0,
                OrderId = _holdOrder.OrderId,
                Status = OrderStatus.Close,
                Received = received,
                ReceivedKh = receivedKh,
                CustomerId = customerId?.CustomerId,
                CustomerType = customerType,
                Remaining = received,
                RemainingKh = receivedKh,
                Change = ConvertStringToDecimal(txtChange.Text),
                ChangeKh = ConvertStringToDecimal(txtChangeKh.Text),
                PaymentTypeCode = _paymentTypes.Any() ? _getValuePaymentType ?? _paymentTypes.First().Code : null,
                PaymentMethodId = PaymentMethodId,
                SellType = saleType,

            };
            var service = new OrderService();
            var dataResponse = await service.UpdateHoldOrder(datRequest);
            if (dataResponse?.Status == (int)ResponseStatus.Success)
            {
                this.Close();
                PopUp_Background.ClosePopUp();
                this.TopMost = false;

                var invoice = new PopUp_Recipt(_parentView, dataResponse.Result!);
                invoice.ShowInTaskbar = false;
                PopUp_Background.Form = invoice;
                PopUp_Background.ShowPopUp();

                _parentView.LoadDataApi();
                _parentView.UpdateProductData();

                /* this.TopMost = false
                this.Close();
                PopUp_Background.ClosePopUp();
                var invoice = new PopUp_Recipt(_parentView, dataResponse?.Result!);
                //invoice.ShowInTaskbar = false;
                PopUp_Background.Form = invoice;
                PopUp_Background.ShowPopUp();*/
            }
            else
            {
                MessageBox.Show(dataResponse?.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Function Change Color On Cash Payment
        private void ChangeColorButton(HopeButton activeBtn, bool click)
        {
            if (click)
            {
                activeBtn.PrimaryColor = Color.SeaGreen;
            }
            else
            {
                activeBtn.PrimaryColor = Color.DodgerBlue;
            }
        }

        // Get payment method 
        private List<PaymentTypeResponse> _paymentTypes = new();
        private List<PaymentMethodResponse> _paymentMethods = new();
        //public int PaymentMethodCode { get; set; } = 0;
        public string PaymentMethodId { get; set; } = "";
        //Function for Create Payment
        private async void CreatePayment()
        {
            string customerTypeCode = "";
            if (comboBoxCustomerType.SelectedItem != null)
            {
                //CustomerTypeResponse selectedItem = selectCustomers.FirstOrDefault(item => item.Name == comboBoxCustomerType.SelectedItem.ToString())!;
                var selectedItem = comboBoxCustomerType.SelectedValue?.ToString();

                if (selectedItem != null)
                {
                    customerTypeCode = selectedItem;
                }
            }
            string SourceId = "";
            if (comboBoxSource.SelectedItem != null)
            {
                SourceResponse selectedItem = selectSource.FirstOrDefault(item => item.Name == comboBoxSource.SelectedItem.ToString())!;

                if (selectedItem != null)
                {
                    SourceId = selectedItem.Id;
                }
            }
            decimal received = ConvertStringToDecimal(txtReceive.Text);
            decimal receivedKh = ConvertStringToDecimal(txtReceiveKh.Text);
            /*--- var totalRecevied = 0m;
            if (received != 0 && receivedKh != 0)
            {
                totalRecevied = GetOrder.Total;
            }*/
            var service = new OrderPaymentService();
            PaymentMethodId = GetPaymentMethodId();

            var customerCode = txtboxCusId.Text.Trim();
            var dataInOrder = new OrderPaymentCreateReq()
            {
                Order_Id = GetOrder.OrderId,
                /*--Received = totalRecevied == 0 ? received : totalRecevied,
                ReceivedKh = totalRecevied == 0 ? receivedKh : 0,*/
                Received = received,
                ReceivedKh = receivedKh,
                Remaining = ConvertStringToDecimal(txtRemaining.Text),
                RemainingKh = ConvertStringToDecimal(txtRemainingKH.Text),
                Change = ConvertStringToDecimal(txtChange.Text),
                ChangeKh = ConvertStringToDecimal(txtChangeKh.Text),
                SourceId = SourceId,
                CustomerTypeCode = customerTypeCode,
                PaymentTypeCode = _getValuePaymentType ?? _paymentTypes.First().Code,
                PaymentMethodId = PaymentMethodId,
                CustomerCode = string.IsNullOrEmpty(customerCode) ? null : customerCode,
            };

            var data = await service.CreatePaymentAsync(dataInOrder);
            if (data != null)
            {
                this.Close();
                PopUp_Background.ClosePopUp();

                var invoice = new PopUp_Recipt(_parentView, data);
                invoice.ShowInTaskbar = false;
                PopUp_Background.Form = invoice;
                PopUp_Background.ShowPopUp();
            }
            else
            {
                MessageBox.Show("       Payment Failed.     ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ConvertStringToDecimal(string value)
        {
            string cleanedValue = value.Replace("$", "");
            return (decimal.TryParse(cleanedValue, out decimal result)) ? result : 0;
        }


        #region For custome style in file .designer.cs
        private string _getValuePaymentType { get; set; } = null!;
        private void btnCash_Click(object sender, EventArgs e)
        {
            decimal received = ConvertStringToDecimal(txtReceive.Text);
            decimal receivedKh = ConvertStringToDecimal(txtReceiveKh.Text);
            if (received != 0 && receivedKh != 0)
            {
                var payment_usd = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.USD.ToString()))?.Id;
                PaymentMethodId = payment_usd ?? "";
            }
            else if (receivedKh != 0 && received == 0)
            {
                var payment_ = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.KHR.ToString()))?.Id;
                PaymentMethodId = payment_ ?? "";
            }
            else
            {
                var payment_usd = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.USD.ToString()))?.Id;
                PaymentMethodId = payment_usd ?? "";
            }
            ChangeColorButton(btnCash, true);
        }

        private string GetPaymentMethodId()
        {
            decimal received = ConvertStringToDecimal(txtReceive.Text);
            decimal receivedKh = ConvertStringToDecimal(txtReceiveKh.Text);
            var paymentCode = "";
            if (received != 0 && receivedKh != 0)
            {
                paymentCode = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.USD.ToString()))?.Id;
            }
            else if (receivedKh != 0 && received == 0)
            {
                paymentCode = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.KHR.ToString()))?.Id;
            }
            else
            {
                paymentCode = _paymentMethods.FirstOrDefault(m => m.Name.Contains(CashPaymentType.USD.ToString()))?.Id;
            }
            return paymentCode!;
        }

        private TextBox currentTextBox = null!; // Maintain a reference to the currently selected textbox

        private void InputNumber(object sender, EventArgs e)
        {
            HopeButton button = (HopeButton)sender;

            if (currentTextBox != null)
            {
                if (currentTextBox.Text == "$0.00")
                    currentTextBox.Text = "";

                if (button.Text == ".")
                {
                    if (!currentTextBox.Text.Contains("."))
                    {
                        currentTextBox.Text += button.Text;
                    }
                }
                else
                {
                    button.Tag = button.Text;
                    currentTextBox.Text += button.Tag;
                }
                currentTextBox.SelectionStart = currentTextBox.Text.Length;
                currentTextBox.SelectionLength = 0;
            }
        }

        // Set the currentTextBox whenever a textbox is selected (e.g., when it gets focus)
        private void TextBoxSelected(object sender, EventArgs e)
        {
            currentTextBox = (TextBox)sender;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentTextBox != null && currentTextBox.Text.Length > 0)
            {
                int cursorPosition = currentTextBox.SelectionStart;
                if (cursorPosition > 0)
                {
                    currentTextBox.Text = currentTextBox.Text.Remove(cursorPosition - 1, 1);
                    currentTextBox.SelectionStart = cursorPosition - 1;
                    currentTextBox.SelectionLength = 0;
                }
            }
            if (string.IsNullOrEmpty(txtReceive.Text) && string.IsNullOrEmpty(txtReceiveKh.Text))
            {
                _canPayment = false;
                btnChargePrint.Enabled = _canPayment;
                //--btnChargeEInvoice.Enabled = _canPayment;
            }
        }
        #endregion

        #region Searching For customer Data 
        private List<CustomerResponse> _customers = new List<CustomerResponse>();
        private async void InitializeCustomerData()
        {
            var service = new CustomerService();
            _customers = await service.GetAll();
        }

        private void txtboxCusId_TextChanged(object sender, EventArgs e)
        {
            string data = txtboxCusId.Text.Trim();
            if (data.Length >= 8)
            {
                CompareCustomerData(data, txtboxCusId);
            }
        }

        private void CompareCustomerData(string dataCompare, TextBox currentTextbox)
        {
            if (_dataReturn.Details?.Count > 0) return;

            var data = dataCompare.Trim().ToLower();
            var customer = _customers.FirstOrDefault(e => e.Contact == data
                            || e.CustomerCode.ToLower() == data
                            || e.CustomerName.ToLower() == data
            );
            if (customer != null)
            {
                AssignCustomerData(customer);
            }
            else
            {
                ClearTextBox(currentTextbox);
                AssignCustomerDataToBtnRadio(null, null);
            }
            // Move cursor to the end of the text in txtCode TextBox
            txtboxCusId.SelectionStart = txtboxCusId.Text.Length;
            // Move cursor to the end of the text in txtContact TextBox
            txtboxCusPhone.SelectionStart = txtboxCusPhone.Text.Length;
        }

        private void ClearTextBox(TextBox currentTextbox)
        {
            if (currentTextbox == txtboxCusId)
            {
                txtboxCusName.Clear();
                txtboxCusPhone.Clear();
            }
            else if (currentTextbox == txtboxCusName)
            {
                txtboxCusId.Clear();
                txtboxCusPhone.Clear();
            }
            else if (currentTextbox == txtboxCusPhone)
            {
                txtboxCusId.Clear();
                txtboxCusName.Clear();
            }
        }

        private void AssignCustomerData(CustomerResponse customer)
        {
            txtboxCusId.Text = customer?.CustomerCode;
            txtboxCusName.Text = customer?.CustomerName;
            txtboxCusPhone.Text = customer?.Contact;
            txtboxCusEmail.Text = customer?.Email ?? "N/A";
            txtboxEarning.Text = "$ " + customer?.EarningAmount.ToString("N2") ?? "0.00";

            AssignCustomerDataToBtnRadio(customer?.Gender, customer?.Nationaltity);
        }

        private void txtboxCusPhone_TextChanged(object sender, EventArgs e)
        {
            string formattedNumber = CustomStyle.FormatPhoneNumber(txtboxCusPhone.Text);
            txtboxCusPhone.Text = formattedNumber;
            txtboxCusPhone.SelectionStart = txtboxCusPhone.TextLength;
            string data = txtboxCusPhone.Text.Trim();
            if (data.Length > 8)
            {
                CompareCustomerData(data, txtboxCusPhone);
            }
        }
        #endregion

        #region Formate input data to 10000 show as 10,000
        private void txtReceiveKh_TextChanged(object sender, EventArgs e)
        {
            var data = CustomStyle.FormatAmountCurrency(txtReceiveKh.Text);
            txtReceiveKh.Text = data;
            txtboxCusPhone.SelectionStart = txtboxCusPhone.TextLength;
        }
        #endregion

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            ChangeColorButton(btnCash, false);
            ChangeColorButton(btnCreditCard, true);
            this.Hide();
            var form = new PopUp_PaymentMethod(/*_parentView,*/ this);
            form.IsCancel += Form_IsCancel;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.Show();
        }

        private void Form_IsCancel(object? sender, bool e)
        {
            this.Show();
            ChangeColorButton(btnCreditCard, false);
        }

        private void btnChargeeInvoice_Click(object sender, EventArgs e)
        {
            if (_dataReturn?.Details?.Count > 0) return;

            chargeAndEInvoice();
        }

        private async void chargeAndEInvoice()
        {
            var dataResponse = await CreateOrder();
            var invoice = new UC_SellInvoice(dataResponse);
            ExportPDF.ExportPdfFile(invoice);
            this.Close();
            PopUp_Background.ClosePopUp();

            _parentView.Carts.Clear();
            _parentView.LoadDataApi();
            _parentView.ViewPOS_LoadingData();
        }
    }

}