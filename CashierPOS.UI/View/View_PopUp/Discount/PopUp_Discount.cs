using CashierPOS.Model.Models.Product;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.View_PopUp;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.IdentityModel.Tokens;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.Testing
{
    public partial class PopUp_Discount : Form
    {
        private readonly IParentView _parentView;
        public PopUp_Discount(IParentView parentView)
        {
            _parentView = parentView;
            InitializeComponent();
            InitializeEventHandeler();
            ActiveControl = txtboxDiscount;
        }
        private void Switch()
        {
            if (btnDiscountType.Checked)
            {
                txtboxDiscount.Text = "";
                txtboxDiscount.PlaceholderText = "0.00 $";
                Enablebtn_Percentage(false);
                txtboxDiscount.SelectionStart = txtboxDiscount.TextLength;
            }
            else
            {
                txtboxDiscount.Text = "";
                txtboxDiscount.PlaceholderText = "0 %";
                Enablebtn_Percentage(true);
                txtboxDiscount.SelectionStart = txtboxDiscount.TextLength;
            }
        }
        private void Switch_TypeDiscount_Load()
        {
            Switch();
        }
        private TextBox currentTextBox; // Maintain a reference to the currently selected textbox
        //method button for input number
        private void InputNumber(object sender, EventArgs e)
        {
            HopeButton button = (HopeButton)sender;
            if (currentTextBox != null)
            {
                if (currentTextBox.Text == "")
                    currentTextBox.Text = "";

                if (button.Text == ".")
                {
                    // Check if the current text ends with a percentage sign
                    if (currentTextBox.Text.Contains(".")) return;
                    if (currentTextBox.Text.EndsWith("%"))
                    {
                        // Remove the percentage sign
                        currentTextBox.Text = currentTextBox.Text.Remove(currentTextBox.Text.Length - 1);
                        // Append the decimal point and percentage sign
                        currentTextBox.Text += ".%";
                    }
                    else if (currentTextBox.Text.EndsWith("$"))
                    {
                        // Remove the percentage sign
                        currentTextBox.Text = currentTextBox.Text.Remove(currentTextBox.Text.Length - 1);
                        // Append the decimal point and percentage sign
                        currentTextBox.Text += ".$";
                    }
                    else
                    {
                        // Check if the current text already contains a decimal point
                        if (!currentTextBox.Text.Contains("."))
                        {
                            // Append the decimal point to the current text
                            currentTextBox.Text += button.Text;
                        }
                    }
                }
                else
                {
                    if (btnDiscountType.Checked) // $
                    {
                        if (currentTextBox.Text.StartsWith("0"))
                        {
                            txtboxDiscount.Text += "$";
                            if (txtboxDiscount.Text.StartsWith("0") && !txtboxDiscount.Text.Contains("."))
                            {
                                currentTextBox.Text = "";
                            }
                        }
                        txtboxDiscount.ForeColor = Color.Black;
                        var temp = currentTextBox.Text.Replace("$", "");
                        var checkData = CustomStyle.ConvertStringToDecimal(temp + button.Text, "$");
                        if (checkData > 100)
                        {
                            txtboxDiscount.Text = currentTextBox.Text;
                            MessageBox.Show("Discount must be smaller than 100%");
                            return;
                        }
                        temp += button.Text.ToString() + "$";
                        currentTextBox.Text = temp;
                    }
                    else // %
                    {
                        var temp = currentTextBox.Text.Replace("%", "");
                        currentTextBox.Text = temp;
                    }
                }
                if (!btnDiscountType.Checked && button.Text.Contains("%"))
                {
                    currentTextBox.Text = button.Text;
                }
                else if (!btnDiscountType.Checked && !button.Text.Contains("."))
                {
                    if (txtboxDiscount.Text.StartsWith("0"))
                    {
                        txtboxDiscount.Text += "";
                        if (txtboxDiscount.Text.StartsWith("0") && !txtboxDiscount.Text.Contains("."))
                        {
                            currentTextBox.Text = "";
                        }
                    }
                    var temp = currentTextBox.Text.Replace("%", "");
                    var checkData = Convert.ToDecimal(temp + button.Text);
                    if (checkData > 100)
                    {
                        txtboxDiscount.Text = temp +"%";
                        MessageBox.Show("Discount must be smaller than 100%");
                        return;
                    }
                    temp += button.Text.ToString() + "%";
                    currentTextBox.Text = temp;
                }
            }
            currentTextBox.SelectionStart = currentTextBox.Text.Length;
            currentTextBox.SelectionLength = currentTextBox.TextLength;
        }
        // Set the currentTextBox whenever a textbox is selected (e.g., when it gets focus)
        private void TextBoxSelected(object sender, EventArgs e)
        {
            currentTextBox = (TextBox)sender;
        }
        // Create button delete number
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentTextBox != null && currentTextBox.Text.Length > 0)
            {
                int cursorPosition = currentTextBox.SelectionStart;
                if (cursorPosition > 0 && currentTextBox.TextLength > 2)
                {
                    currentTextBox.Text = currentTextBox.Text.Remove(cursorPosition - 2, 1);
                    currentTextBox.SelectionStart = cursorPosition - 1;
                    currentTextBox.SelectionLength = currentTextBox.TextLength ;
                }
                else
                {
                    currentTextBox.Text = "";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private bool modifyingText = false; // Flag to indicate if text modification is in progress

        private void btnSave_Click(object sender, EventArgs e)
        {
            var products = new List<ProductResponse>();
            // For discount all products
            if(_parentView.ProductApplyDiscount == "" || _parentView.ProductApplyDiscount.IsNullOrEmpty())
            {
                products = _parentView.Carts;
                ApplyDiscount(products);
            }
            else
            {
                var productId = _parentView.ProductApplyDiscount;
                var product = _parentView.Carts.FirstOrDefault(e=>e.Id == productId);
                products.Add(product);
                ApplyDiscount(products);
            }
            /*var product = _parentView.Carts.FirstOrDefault(e=>e.Id == _parentView.ProductApplyDiscount);
            if(btnDiscountType.Checked) // discount is $
            {
                var discountAmount = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "$");
                product.DiscountAmount = discountAmount;
                //product.DiscountPercent = (discountAmount * 100) / product.Price;
            }
            else             // discount is %
            {
                var discountPer = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "%");
                product.DiscountPercent = discountPer;
                var discountAmoun = (discountPer * product.Price) / 100;
                product.DiscountAmount = discountAmoun;
            }*/
            _parentView.ProductApplyDiscount = "";
            _parentView.ViewPOS_LoadingData();
            this.Close();
            PopUp_Background.ClosePopUp();
        }
        private void ApplyDiscount(List<ProductResponse> products)
        {
            foreach (var item in products)
            {
                var product = _parentView.Carts.FirstOrDefault(e => e.Id == item.Id);
                if (btnDiscountType.Checked) // discount is $
                {
                    var discountAmount = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "$");
                    product.DiscountAmount = discountAmount /** product.Qty*/;
                    //product.DiscountPercent = (discountAmount * 100) / product.Price;
                }
                else             // discount is %
                {
                    var discountPer = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "%");
                    product.DiscountPercent = discountPer;
                    var discountAmoun = (discountPer * product.Price) / 100;
                    product.DiscountAmount = discountAmoun;
                }
            }
        }

        private List<ProductResponse> _products = new List<ProductResponse>();
        private void txtboxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (btnDiscountType.Checked) // Discount in $
            {
                if (_parentView.ProductApplyDiscount == "" || _parentView.ProductApplyDiscount.IsNullOrEmpty())
                {
                    IsDisocuntSmallerThanPrice(_parentView.Carts);
                }
                else
                {
                    var productDiscount = _parentView.Carts.FirstOrDefault(e => e.Id == _parentView.ProductApplyDiscount);
                    _products.Add(productDiscount!);
                    IsDisocuntSmallerThanPrice(_products);
                }

                /* var productDiscount = _parentView.Carts.FirstOrDefault(e => e.Id == _parentView.ProductApplyDiscount);
                txtboxDiscount.MaxLength = productDiscount!.Price.ToString().Length;

                // If the entered discount amount exceeds the product price and modification is not in progress
                if (!string.IsNullOrEmpty(txtboxDiscount.Text) && !modifyingText)
                {
                    var discountAmount = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "$");
                    if (discountAmount *//*>=*//* > productDiscount.Price)
                    {
                        modifyingText = true; // Set flag to indicate text modification
                        MessageBox.Show("Discount amount must be smaller than price of Item!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //--txtboxDiscount.Text = txtboxDiscount.Text.Substring(0, txtboxDiscount.Text.Length - 1);
                        txtboxDiscount.Text = discountAmount.ToString().Remove(0, txtboxDiscount.Text.Length - 1);
                        modifyingText = false; // Reset the flag after text modification
                    }
                }*/
            }
        }

        private bool IsDisocuntSmallerThanPrice(List<ProductResponse> products)
        {
            foreach (var product in products)
            {
                if (!string.IsNullOrEmpty(txtboxDiscount.Text) && !modifyingText)
                {
                    var discountAmount = CustomStyle.ConvertStringToDecimal(txtboxDiscount.Text.Trim(), "$");
                    if (discountAmount /*>=*/ > product.Price)
                    {
                        modifyingText = true; // Set flag to indicate text modification
                        MessageBox.Show("Discount amount must be smaller than price of Item !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //--txtboxDiscount.Text = txtboxDiscount.Text.Substring(0, txtboxDiscount.Text.Length - 1);
                        txtboxDiscount.Text = discountAmount.ToString().Remove(0, txtboxDiscount.Text.Length - 1);
                        modifyingText = false; // Reset the flag after text modification
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
