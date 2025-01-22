using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Customer;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using ReaLTaiizor.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_PaymentOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.

        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeEventHandeler()
        {
            // Get All Customers
            InitializeCustomerData();
            this.ActiveControl = txtReceive;
            txtReceive.Focus();
            txtReceive.Text = string.Empty;
            PopUp_PaymentOption_Load();
            // Customer ID
            txtboxCusId.MaxLength = 9;
            txtboxCusId.Enter += CustomStyle.OnMouseHover_Placeholder;
            //txtboxCusId.Leave += CustomStyle.OnMouseLeave_Placeholder;

            // Earning ($)
            txtboxEarning.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxEarning.Leave += CustomStyle.OnMouseLeave_Placeholder;
            txtboxEarning.KeyPress += CustomStyle.ValidationNumberOnly;

            // Customer Name
            txtboxCusName.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxCusName.Leave += CustomStyle.OnMouseLeave_Placeholder;
            txtboxCusName.KeyPress += CustomStyle.ValidationTextOnly;
            txtboxCusName.Enabled = false;

            // Customer Phone
            txtboxCusPhone.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxCusPhone.Leave += CustomStyle.OnMouseLeave_Placeholder;
            txtboxCusPhone.KeyPress += CustomStyle.ValidationNumberOnly;

            // Customer Email
            txtboxCusEmail.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxCusEmail.Leave += CustomStyle.OnMouseLeave_Placeholder;
            txtboxCusEmail.Enabled = false;

            // Price Receive
            txtReceive.Enter += OnMouseHover_Placeholder;
            txtReceive.Leave += OnMouseLeave_Placeholder;
            txtReceive.KeyPress += CustomStyle.ValidationNumberOnly;
            txtReceive.GotFocus += TextBoxSelected;
            txtReceive.TextChanged += CalculateOnMouse_Leave;

            // Price Receive KH
            txtReceiveKh.Enter += OnMouseHover_Placeholder;
            txtReceiveKh.Leave += OnMouseLeave_Placeholder;
            txtReceiveKh.KeyPress += CustomStyle.ValidationNumberOnly;
            txtReceiveKh.GotFocus += TextBoxSelected;
            txtReceiveKh.TextChanged += CalculateOnMouse_Leave;
            /*txtReceiveKh.Text = "​​  0​ ៛";
            txtReceiveKh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);*/

            // Price Remaining
            txtRemaining.Enter += OnMouseHover_Placeholder;
            txtRemaining.Leave += OnMouseLeave_Placeholder;
            txtRemaining.KeyPress += CustomStyle.ValidationNumberOnly;
            txtRemaining.GotFocus += TextBoxSelected;

            // Price Change
            txtChange.Enter += OnMouseHover_Placeholder;
            txtChange.Leave += OnMouseLeave_Placeholder;
            txtChange.KeyPress += CustomStyle.ValidationNumberOnly;
            txtChange.GotFocus += TextBoxSelected;


            // Price Remaining KH
            txtRemainingKH.Enter += OnMouseHover_Placeholder;
            txtRemainingKH.Leave += OnMouseLeave_Placeholder;
            txtRemainingKH.KeyPress += CustomStyle.ValidationNumberOnly;
            txtRemainingKH.GotFocus += TextBoxSelected;
            //txtRemainingKH.Text = "​​  0​ ៛";
            txtRemainingKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // Price Change KH
            txtChangeKh.Enter += OnMouseHover_Placeholder;
            txtChangeKh.Leave += OnMouseLeave_Placeholder;
            txtChangeKh.KeyPress += CustomStyle.ValidationNumberOnly;
            txtChangeKh.GotFocus += TextBoxSelected;
            //txtChangeKh.Text = "​​  0​ ៛";
            txtRemainingKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        // Create Radion Button for Gender and Nationality
        private void CustomerInformation()
        {
            // Clear existing radio buttons
            if (_dataReturn.Details.Count==0)
            {
                // Add gender radio buttons
                foreach (Gender gender in Enum.GetValues(typeof(Gender)))
                {
                    var ttt = gender.ToString();
                    var radioButton = RadioButton(ttt);
                    panelGender.Controls.Add(radioButton);
                }
                // Add nationality radio buttons
                foreach (Nationality nationality in Enum.GetValues(typeof(Nationality)))
                {
                    var ttt = nationality.ToString();
                    var radioButton = RadioButton(ttt);
                    panelNationality.Controls.Add(radioButton);
                }
            }
            else
            {
                AssignCustomerDataToBtnRadio(_dataReturn?.Gender, _dataReturn?.Nationality);
            }
        }

        private void AssignCustomerDataToBtnRadio(string _gender, string _nationality)
        {
            panelGender.Controls.Clear();
            panelNationality.Controls.Clear();
            // Add gender radio buttons
            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
            {
                var ttt = gender.ToString();
                var radioButton = RadioButton(ttt);
                if (radioButton.Text == _gender)
                {
                    radioButton.Checked = true;
                }
                radioButton.Enabled = false;
                panelGender.Controls.Add(radioButton);
            }
            // Add nationality radio buttons
            foreach (Nationality nationality in Enum.GetValues(typeof(Nationality)))
            {
                var nationalityData = nationality.ToString();
                var radioButton = RadioButton(nationalityData);
                if (radioButton.Text == _nationality)
                {
                    radioButton.Checked = true;
                }
                radioButton.Enabled = false;
                panelNationality.Controls.Add(radioButton);
            }
        }
        private void ReadOnlyForShowReturn()
        {
            //--btnClosePayment.Enabled = false;
            //--btnBack.Enabled = false;
            btnChargePrint.Enabled = true;
            //--btnChargeEInvoice.Enabled = true;

            txtboxCusId.Enabled = false;
            txtReceive.Enabled = false;
            txtReceiveKh.Enabled = false;
            txtboxCusEmail.Enabled = false;
            txtboxCusName.Enabled = false;
            txtboxCusPhone.Enabled = false;
            txtboxEarning.Enabled = false;
        }

        private MetroRadioButton RadioButton(string name)
        {
            return new MetroRadioButton()
            {
                BackgroundColor = Color.White,
                BorderColor = Color.FromArgb(155, 155, 155),
                CheckSignColor = Color.FromArgb(65, 177, 225),
                CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked,
                DisabledBorderColor = Color.FromArgb(205, 205, 205),
                Font = new Font("Times New Roman", 12F),
                IsDerivedStyle = true,
                Margin = new Padding(0, 10, 0, 0),
                Name = "radionNationality",
                Size = new Size(81, 17),
                Style = ReaLTaiizor.Enum.Metro.Style.Light,
                Text = name,
            };
        }

        private void OnMouseLeave_Placeholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = textBox.Tag.ToString();
                }
            }
        }
        private List<string> _test = new List<string> { "textBoxPriceReceive", "textBoxPriceReceiveKH" };

        private void OnMouseHover_Placeholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == textBox.Tag.ToString())
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
                else if (textBox.Text != textBox.Tag.ToString())
                {
                    var text = textBox.Text;
                    textBox.Text = text;
                }
            }
        }
        private void ChangeValue(TextBox txtDollar, TextBox txtKhmer)
        {

            if (txtDollar is TextBox && txtKhmer is TextBox)
            {
                for (var item = 0; item < _test.Count; item++)
                {
                    if (_test[item] == txtDollar.Tag.ToString())
                    {
                        decimal value = Convert.ToDecimal(txtDollar.Text);
                        txtDollar.Text = txtDollar.Text;
                        txtKhmer.Text = (value * _exchangeRate).ToString();
                    }
                    else
                    {
                        decimal value = Convert.ToDecimal(txtKhmer.Text);
                        txtKhmer.Text = txtDollar.Text;
                        txtDollar.Text = (value / _exchangeRate).ToString();
                    }
                }
            }
        }

        /// </summary>

        private void InitializeComponent()
        {
            panelPaymentForm = new System.Windows.Forms.Panel();
            panelNationality = new FlowLayoutPanel();
            panelGender = new FlowLayoutPanel();
            comboBoxGiftCoupon = new DungeonComboBox();
            comboBoxSource = new DungeonComboBox();
            txtboxCusEmail = new TextBox();
            txtboxMainCusEmail = new CyberTextBox();
            txtboxCusPhone = new TextBox();
            txtboxMainCusPhone = new CyberTextBox();
            txtboxCusName = new TextBox();
            txtboxMainCusName = new CyberTextBox();
            txtboxCusId = new TextBox();
            txtboxEarning = new TextBox();
            txtboxMainCusId = new CyberTextBox();
            txtboxMainEarning = new CyberTextBox();
            lbNameNationality = new Label();
            lbNameGender = new Label();
            btnCreditCard = new HopeButton();
            btnCash = new HopeButton();
            btnChargeEInvoice = new HopeButton();
            panelMainCashPayment = new System.Windows.Forms.Panel();
            txtReceive = new TextBox();
            textBox1 = new TextBox();
            textBoxchangeKh = new TextBox();
            textBoxRemainKh = new TextBox();
            textBoxReKH = new Label();
            textBoxUSD = new Label();
            txtChangeKh = new TextBox();
            txtRemainingKH = new TextBox();
            txtReceiveKh = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtChange = new TextBox();
            txtRemaining = new TextBox();
            btnNum9 = new HopeButton();
            btnNum0 = new HopeButton();
            btnNum8 = new HopeButton();
            btnNum7 = new HopeButton();
            btnNum6 = new HopeButton();
            btnNumPoint = new HopeButton();
            btnNum5 = new HopeButton();
            btnNum4 = new HopeButton();
            btnNum3 = new HopeButton();
            btnDel = new HopeButton();
            btnNum2 = new HopeButton();
            btnNum1 = new HopeButton();
            lbNameChange = new Label();
            lbNameRemaining = new Label();
            lbNameReceive = new Label();
            txtTotalPayKh = new Label();
            txtTotalPay = new Label();
            lbNameTotalPay = new Label();
            btnCashPayment = new HopeButton();
            comboBoxCustomerType = new DungeonComboBox();
            lbNameGiftCoupon = new Label();
            lbNameCustomerEmail = new Label();
            lbNameEarning = new Label();
            lbNameSource = new Label();
            lbNameMainCustomerPhone = new Label();
            lbNameCustomerName = new Label();
            btnChargePrint = new HopeButton();
            btnBack = new HopeButton();
            lbNameCustomerType = new Label();
            lbCustomerID = new Label();
            panelHeaderPaymentOption = new System.Windows.Forms.Panel();
            btnClosePayment = new System.Windows.Forms.Button();
            lbNamePaymentOption = new Label();
            panelPaymentForm.SuspendLayout();
            panelMainCashPayment.SuspendLayout();
            panelHeaderPaymentOption.SuspendLayout();
            SuspendLayout();
            // 
            // panelPaymentForm
            // 
            panelPaymentForm.BackColor = Color.FromArgb(176, 215, 181);
            panelPaymentForm.Controls.Add(panelNationality);
            panelPaymentForm.Controls.Add(panelGender);
            panelPaymentForm.Controls.Add(comboBoxGiftCoupon);
            panelPaymentForm.Controls.Add(comboBoxSource);
            panelPaymentForm.Controls.Add(txtboxCusEmail);
            panelPaymentForm.Controls.Add(txtboxMainCusEmail);
            panelPaymentForm.Controls.Add(txtboxCusPhone);
            panelPaymentForm.Controls.Add(txtboxMainCusPhone);
            panelPaymentForm.Controls.Add(txtboxCusName);
            panelPaymentForm.Controls.Add(txtboxMainCusName);
            panelPaymentForm.Controls.Add(txtboxCusId);
            panelPaymentForm.Controls.Add(txtboxEarning);
            panelPaymentForm.Controls.Add(txtboxMainCusId);
            panelPaymentForm.Controls.Add(txtboxMainEarning);
            panelPaymentForm.Controls.Add(lbNameNationality);
            panelPaymentForm.Controls.Add(lbNameGender);
            panelPaymentForm.Controls.Add(btnCreditCard);
            panelPaymentForm.Controls.Add(btnCash);
            panelPaymentForm.Controls.Add(btnChargeEInvoice);
            panelPaymentForm.Controls.Add(panelMainCashPayment);
            panelPaymentForm.Controls.Add(comboBoxCustomerType);
            panelPaymentForm.Controls.Add(lbNameGiftCoupon);
            panelPaymentForm.Controls.Add(lbNameCustomerEmail);
            panelPaymentForm.Controls.Add(lbNameEarning);
            panelPaymentForm.Controls.Add(lbNameSource);
            panelPaymentForm.Controls.Add(lbNameMainCustomerPhone);
            panelPaymentForm.Controls.Add(lbNameCustomerName);
            panelPaymentForm.Controls.Add(btnChargePrint);
            panelPaymentForm.Controls.Add(btnBack);
            panelPaymentForm.Controls.Add(lbNameCustomerType);
            panelPaymentForm.Controls.Add(lbCustomerID);
            panelPaymentForm.Controls.Add(panelHeaderPaymentOption);
            panelPaymentForm.Location = new Point(0, 0);
            panelPaymentForm.Name = "panelPaymentForm";
            panelPaymentForm.Size = new Size(1015, 538);
            panelPaymentForm.TabIndex = 2;
            // 
            // panelNationality
            // 
            panelNationality.AllowDrop = true;
            panelNationality.BackColor = Color.Transparent;
            panelNationality.Font = new Font("Times New Roman", 36F);
            panelNationality.ForeColor = Color.FromArgb(245, 245, 245);
            panelNationality.Location = new Point(206, 329);
            panelNationality.Name = "panelNationality";
            panelNationality.Size = new Size(100, 187);
            panelNationality.TabIndex = 90;
            panelNationality.Tag = "Cyber";
            // 
            // panelGender
            // 
            panelGender.AllowDrop = true;
            panelGender.BackColor = Color.Transparent;
            panelGender.Font = new Font("Times New Roman", 36F);
            panelGender.ForeColor = Color.FromArgb(245, 245, 245);
            panelGender.Location = new Point(24, 329);
            panelGender.Name = "panelGender";
            panelGender.Size = new Size(100, 146);
            panelGender.TabIndex = 89;
            panelGender.Tag = "Cyber";
            // 
            // comboBoxGiftCoupon
            // 
            comboBoxGiftCoupon.BackColor = Color.White;
            comboBoxGiftCoupon.ColorA = Color.FromArgb(16, 107, 67);
            comboBoxGiftCoupon.ColorB = Color.FromArgb(16, 107, 67);
            comboBoxGiftCoupon.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxGiftCoupon.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxGiftCoupon.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxGiftCoupon.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxGiftCoupon.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxGiftCoupon.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxGiftCoupon.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxGiftCoupon.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxGiftCoupon.DropDownHeight = 300;
            comboBoxGiftCoupon.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGiftCoupon.Font = new Font("Segoe UI", 10F);
            comboBoxGiftCoupon.ForeColor = Color.Black;
            comboBoxGiftCoupon.HoverSelectionColor = Color.Empty;
            comboBoxGiftCoupon.IntegralHeight = false;
            comboBoxGiftCoupon.ItemHeight = 26;
            comboBoxGiftCoupon.Location = new Point(478, 236);
            comboBoxGiftCoupon.Name = "comboBoxGiftCoupon";
            comboBoxGiftCoupon.Size = new Size(170, 32);
            comboBoxGiftCoupon.StartIndex = 0;
            comboBoxGiftCoupon.TabIndex = 58;
            // 
            // comboBoxSource
            // 
            comboBoxSource.BackColor = Color.White;
            comboBoxSource.ColorA = Color.FromArgb(16, 107, 67);
            comboBoxSource.ColorB = Color.FromArgb(16, 107, 67);
            comboBoxSource.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxSource.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxSource.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxSource.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxSource.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxSource.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxSource.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxSource.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSource.DropDownHeight = 300;
            comboBoxSource.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSource.Font = new Font("Segoe UI", 10F);
            comboBoxSource.ForeColor = Color.Black;
            comboBoxSource.HoverSelectionColor = Color.Empty;
            comboBoxSource.IntegralHeight = false;
            comboBoxSource.ItemHeight = 26;
            comboBoxSource.Location = new Point(144, 190);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(170, 32);
            comboBoxSource.StartIndex = 0;
            comboBoxSource.TabIndex = 57;
            // 
            // txtboxCusEmail
            // 
            txtboxCusEmail.BackColor = Color.White;
            txtboxCusEmail.BorderStyle = BorderStyle.None;
            txtboxCusEmail.Font = new Font("Times New Roman", 11.25F);
            txtboxCusEmail.ForeColor = Color.Black;
            txtboxCusEmail.Location = new Point(488, 194);
            txtboxCusEmail.Name = "txtboxCusEmail";
            txtboxCusEmail.PlaceholderText = " someone@example.com";
            txtboxCusEmail.Size = new Size(152, 18);
            txtboxCusEmail.TabIndex = 56;
            txtboxCusEmail.Tag = "";
            // 
            // txtboxMainCusEmail
            // 
            txtboxMainCusEmail.Alpha = 20;
            txtboxMainCusEmail.BackColor = Color.Transparent;
            txtboxMainCusEmail.Background_WidthPen = 1F;
            txtboxMainCusEmail.BackgroundPen = true;
            txtboxMainCusEmail.ColorBackground = Color.White;
            txtboxMainCusEmail.ColorBackground_Pen = Color.White;
            txtboxMainCusEmail.ColorLighting = Color.White;
            txtboxMainCusEmail.ColorPen_1 = Color.White;
            txtboxMainCusEmail.ColorPen_2 = Color.White;
            txtboxMainCusEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainCusEmail.Font = new Font("Times New Roman", 8F);
            txtboxMainCusEmail.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainCusEmail.Lighting = false;
            txtboxMainCusEmail.LinearGradientPen = false;
            txtboxMainCusEmail.Location = new Point(478, 184);
            txtboxMainCusEmail.Name = "txtboxMainCusEmail";
            txtboxMainCusEmail.PenWidth = 15;
            txtboxMainCusEmail.RGB = false;
            txtboxMainCusEmail.Rounding = true;
            txtboxMainCusEmail.RoundingInt = 40;
            txtboxMainCusEmail.Size = new Size(170, 35);
            txtboxMainCusEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainCusEmail.TabIndex = 55;
            txtboxMainCusEmail.Tag = "Cyber";
            txtboxMainCusEmail.TextButton = "";
            txtboxMainCusEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainCusEmail.Timer_RGB = 300;
            // 
            // txtboxCusPhone
            // 
            txtboxCusPhone.BackColor = Color.White;
            txtboxCusPhone.BorderStyle = BorderStyle.None;
            txtboxCusPhone.Font = new Font("Times New Roman", 11.25F);
            txtboxCusPhone.ForeColor = Color.Black;
            txtboxCusPhone.Location = new Point(488, 139);
            txtboxCusPhone.MaxLength = 12;
            txtboxCusPhone.Name = "txtboxCusPhone";
            txtboxCusPhone.PlaceholderText = "000 000 0000";
            txtboxCusPhone.Size = new Size(152, 18);
            txtboxCusPhone.TabIndex = 54;
            txtboxCusPhone.TextChanged += txtboxCusPhone_TextChanged;
            // 
            // txtboxMainCusPhone
            // 
            txtboxMainCusPhone.Alpha = 20;
            txtboxMainCusPhone.BackColor = Color.Transparent;
            txtboxMainCusPhone.Background_WidthPen = 1F;
            txtboxMainCusPhone.BackgroundPen = true;
            txtboxMainCusPhone.ColorBackground = Color.White;
            txtboxMainCusPhone.ColorBackground_Pen = Color.White;
            txtboxMainCusPhone.ColorLighting = Color.White;
            txtboxMainCusPhone.ColorPen_1 = Color.White;
            txtboxMainCusPhone.ColorPen_2 = Color.White;
            txtboxMainCusPhone.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainCusPhone.Font = new Font("Times New Roman", 8F);
            txtboxMainCusPhone.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainCusPhone.Lighting = false;
            txtboxMainCusPhone.LinearGradientPen = false;
            txtboxMainCusPhone.Location = new Point(478, 129);
            txtboxMainCusPhone.Name = "txtboxMainCusPhone";
            txtboxMainCusPhone.PenWidth = 15;
            txtboxMainCusPhone.RGB = false;
            txtboxMainCusPhone.Rounding = true;
            txtboxMainCusPhone.RoundingInt = 40;
            txtboxMainCusPhone.Size = new Size(170, 35);
            txtboxMainCusPhone.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainCusPhone.TabIndex = 53;
            txtboxMainCusPhone.Tag = "Cyber";
            txtboxMainCusPhone.TextButton = "";
            txtboxMainCusPhone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainCusPhone.Timer_RGB = 300;
            // 
            // txtboxCusName
            // 
            txtboxCusName.BackColor = Color.White;
            txtboxCusName.BorderStyle = BorderStyle.None;
            txtboxCusName.Font = new Font("Times New Roman", 11.25F);
            txtboxCusName.ForeColor = Color.Black;
            txtboxCusName.Location = new Point(488, 88);
            txtboxCusName.Name = "txtboxCusName";
            txtboxCusName.PlaceholderText = "Customer Name";
            txtboxCusName.Size = new Size(152, 18);
            txtboxCusName.TabIndex = 52;
            txtboxCusName.Tag = "";
            // 
            // txtboxMainCusName
            // 
            txtboxMainCusName.Alpha = 20;
            txtboxMainCusName.BackColor = Color.Transparent;
            txtboxMainCusName.Background_WidthPen = 1F;
            txtboxMainCusName.BackgroundPen = true;
            txtboxMainCusName.ColorBackground = Color.White;
            txtboxMainCusName.ColorBackground_Pen = Color.White;
            txtboxMainCusName.ColorLighting = Color.White;
            txtboxMainCusName.ColorPen_1 = Color.White;
            txtboxMainCusName.ColorPen_2 = Color.White;
            txtboxMainCusName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainCusName.Font = new Font("Times New Roman", 8F);
            txtboxMainCusName.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainCusName.Lighting = false;
            txtboxMainCusName.LinearGradientPen = false;
            txtboxMainCusName.Location = new Point(478, 78);
            txtboxMainCusName.Name = "txtboxMainCusName";
            txtboxMainCusName.PenWidth = 15;
            txtboxMainCusName.RGB = false;
            txtboxMainCusName.Rounding = true;
            txtboxMainCusName.RoundingInt = 40;
            txtboxMainCusName.Size = new Size(170, 35);
            txtboxMainCusName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainCusName.TabIndex = 51;
            txtboxMainCusName.Tag = "Cyber";
            txtboxMainCusName.TextButton = "";
            txtboxMainCusName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainCusName.Timer_RGB = 300;
            // 
            // txtboxCusId
            // 
            txtboxCusId.BackColor = Color.White;
            txtboxCusId.BorderStyle = BorderStyle.None;
            txtboxCusId.Font = new Font("Times New Roman", 11.25F);
            txtboxCusId.ForeColor = Color.Black;
            txtboxCusId.Location = new Point(154, 88);
            txtboxCusId.Name = "txtboxCusId";
            txtboxCusId.PlaceholderText = "Scan or input";
            txtboxCusId.Size = new Size(152, 18);
            txtboxCusId.TabIndex = 50;
            txtboxCusId.TextChanged += txtboxCusId_TextChanged;
            // 
            // txtboxEarning
            // 
            txtboxEarning.BackColor = Color.White;
            txtboxEarning.BorderStyle = BorderStyle.None;
            txtboxEarning.Enabled = false;
            txtboxEarning.Font = new Font("Times New Roman", 11.25F);
            txtboxEarning.ForeColor = Color.Black;
            txtboxEarning.Location = new Point(154, 247);
            txtboxEarning.Name = "txtboxEarning";
            txtboxEarning.PlaceholderText = "$ 0.00";
            txtboxEarning.Size = new Size(152, 18);
            txtboxEarning.TabIndex = 48;
            // 
            // txtboxMainCusId
            // 
            txtboxMainCusId.Alpha = 20;
            txtboxMainCusId.BackColor = Color.Transparent;
            txtboxMainCusId.Background_WidthPen = 1F;
            txtboxMainCusId.BackgroundPen = true;
            txtboxMainCusId.ColorBackground = Color.White;
            txtboxMainCusId.ColorBackground_Pen = Color.White;
            txtboxMainCusId.ColorLighting = Color.White;
            txtboxMainCusId.ColorPen_1 = Color.White;
            txtboxMainCusId.ColorPen_2 = Color.White;
            txtboxMainCusId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainCusId.Font = new Font("Times New Roman", 8F);
            txtboxMainCusId.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainCusId.Lighting = false;
            txtboxMainCusId.LinearGradientPen = false;
            txtboxMainCusId.Location = new Point(144, 78);
            txtboxMainCusId.Name = "txtboxMainCusId";
            txtboxMainCusId.PenWidth = 15;
            txtboxMainCusId.RGB = false;
            txtboxMainCusId.Rounding = true;
            txtboxMainCusId.RoundingInt = 40;
            txtboxMainCusId.Size = new Size(170, 35);
            txtboxMainCusId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainCusId.TabIndex = 49;
            txtboxMainCusId.Tag = "Cyber";
            txtboxMainCusId.TextButton = "";
            txtboxMainCusId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainCusId.Timer_RGB = 300;
            // 
            // txtboxMainEarning
            // 
            txtboxMainEarning.Alpha = 20;
            txtboxMainEarning.BackColor = Color.Transparent;
            txtboxMainEarning.Background_WidthPen = 1F;
            txtboxMainEarning.BackgroundPen = true;
            txtboxMainEarning.ColorBackground = Color.White;
            txtboxMainEarning.ColorBackground_Pen = Color.White;
            txtboxMainEarning.ColorLighting = Color.White;
            txtboxMainEarning.ColorPen_1 = Color.White;
            txtboxMainEarning.ColorPen_2 = Color.White;
            txtboxMainEarning.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainEarning.Font = new Font("Times New Roman", 8F);
            txtboxMainEarning.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainEarning.Lighting = false;
            txtboxMainEarning.LinearGradientPen = false;
            txtboxMainEarning.Location = new Point(144, 236);
            txtboxMainEarning.Name = "txtboxMainEarning";
            txtboxMainEarning.PenWidth = 15;
            txtboxMainEarning.RGB = false;
            txtboxMainEarning.Rounding = true;
            txtboxMainEarning.RoundingInt = 40;
            txtboxMainEarning.Size = new Size(170, 35);
            txtboxMainEarning.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainEarning.TabIndex = 47;
            txtboxMainEarning.Tag = "Cyber";
            txtboxMainEarning.TextButton = "";
            txtboxMainEarning.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainEarning.Timer_RGB = 300;
            // 
            // lbNameNationality
            // 
            lbNameNationality.AutoSize = true;
            lbNameNationality.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbNameNationality.ForeColor = SystemColors.WindowText;
            lbNameNationality.Location = new Point(223, 295);
            lbNameNationality.Name = "lbNameNationality";
            lbNameNationality.Size = new Size(83, 19);
            lbNameNationality.TabIndex = 37;
            lbNameNationality.Text = "Nationality";
            // 
            // lbNameGender
            // 
            lbNameGender.AutoSize = true;
            lbNameGender.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbNameGender.ForeColor = SystemColors.WindowText;
            lbNameGender.Location = new Point(22, 295);
            lbNameGender.Name = "lbNameGender";
            lbNameGender.Size = new Size(59, 19);
            lbNameGender.TabIndex = 36;
            lbNameGender.Text = "Gender";
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackColor = Color.FromArgb(176, 215, 181);
            btnCreditCard.BorderColor = Color.FromArgb(220, 223, 230);
            btnCreditCard.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCreditCard.DangerColor = Color.FromArgb(245, 108, 108);
            btnCreditCard.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCreditCard.Enabled = false;
            btnCreditCard.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCreditCard.ForeColor = SystemColors.WindowText;
            btnCreditCard.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCreditCard.InfoColor = Color.FromArgb(144, 147, 153);
            btnCreditCard.Location = new Point(504, 356);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.PrimaryColor = Color.DodgerBlue;
            btnCreditCard.Size = new Size(120, 36);
            btnCreditCard.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCreditCard.TabIndex = 35;
            btnCreditCard.Text = "Credit Card";
            btnCreditCard.TextColor = Color.Black;
            btnCreditCard.WarningColor = Color.FromArgb(230, 162, 60);
            btnCreditCard.Click += btnCreditCard_Click;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.FromArgb(176, 215, 181);
            btnCash.BorderColor = Color.FromArgb(220, 223, 230);
            btnCash.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCash.DangerColor = Color.FromArgb(245, 108, 108);
            btnCash.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCash.Enabled = false;
            btnCash.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCash.ForeColor = SystemColors.WindowText;
            btnCash.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCash.InfoColor = Color.FromArgb(144, 147, 153);
            btnCash.Location = new Point(504, 307);
            btnCash.Name = "btnCash";
            btnCash.PrimaryColor = Color.DodgerBlue;
            btnCash.Size = new Size(120, 36);
            btnCash.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCash.TabIndex = 34;
            btnCash.Text = "Cash ";
            btnCash.TextColor = Color.Black;
            btnCash.WarningColor = Color.FromArgb(230, 162, 60);
            btnCash.Click += btnCash_Click;
            // 
            // btnChargeEInvoice
            // 
            btnChargeEInvoice.BorderColor = Color.FromArgb(220, 223, 230);
            btnChargeEInvoice.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnChargeEInvoice.Cursor = Cursors.Hand;
            btnChargeEInvoice.DangerColor = Color.FromArgb(245, 108, 108);
            btnChargeEInvoice.DefaultColor = Color.FromArgb(255, 255, 255);
            btnChargeEInvoice.Enabled = false;
            btnChargeEInvoice.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnChargeEInvoice.ForeColor = SystemColors.WindowText;
            btnChargeEInvoice.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnChargeEInvoice.InfoColor = Color.FromArgb(144, 147, 153);
            btnChargeEInvoice.Location = new Point(674, 475);
            btnChargeEInvoice.Name = "btnChargeEInvoice";
            btnChargeEInvoice.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnChargeEInvoice.Size = new Size(154, 37);
            btnChargeEInvoice.SuccessColor = Color.FromArgb(103, 194, 58);
            btnChargeEInvoice.TabIndex = 33;
            btnChargeEInvoice.Text = "Charge & eInvoice";
            btnChargeEInvoice.TextColor = Color.Black;
            btnChargeEInvoice.WarningColor = Color.FromArgb(230, 162, 60);
            btnChargeEInvoice.Click += btnChargeeInvoice_Click;
            // 
            // panelMainCashPayment
            // 
            panelMainCashPayment.Controls.Add(txtReceive);
            panelMainCashPayment.Controls.Add(textBox1);
            panelMainCashPayment.Controls.Add(textBoxchangeKh);
            panelMainCashPayment.Controls.Add(textBoxRemainKh);
            panelMainCashPayment.Controls.Add(textBoxReKH);
            panelMainCashPayment.Controls.Add(textBoxUSD);
            panelMainCashPayment.Controls.Add(txtChangeKh);
            panelMainCashPayment.Controls.Add(txtRemainingKH);
            panelMainCashPayment.Controls.Add(txtReceiveKh);
            panelMainCashPayment.Controls.Add(label4);
            panelMainCashPayment.Controls.Add(label3);
            panelMainCashPayment.Controls.Add(label2);
            panelMainCashPayment.Controls.Add(label1);
            panelMainCashPayment.Controls.Add(txtChange);
            panelMainCashPayment.Controls.Add(txtRemaining);
            panelMainCashPayment.Controls.Add(btnNum9);
            panelMainCashPayment.Controls.Add(btnNum0);
            panelMainCashPayment.Controls.Add(btnNum8);
            panelMainCashPayment.Controls.Add(btnNum7);
            panelMainCashPayment.Controls.Add(btnNum6);
            panelMainCashPayment.Controls.Add(btnNumPoint);
            panelMainCashPayment.Controls.Add(btnNum5);
            panelMainCashPayment.Controls.Add(btnNum4);
            panelMainCashPayment.Controls.Add(btnNum3);
            panelMainCashPayment.Controls.Add(btnDel);
            panelMainCashPayment.Controls.Add(btnNum2);
            panelMainCashPayment.Controls.Add(btnNum1);
            panelMainCashPayment.Controls.Add(lbNameChange);
            panelMainCashPayment.Controls.Add(lbNameRemaining);
            panelMainCashPayment.Controls.Add(lbNameReceive);
            panelMainCashPayment.Controls.Add(txtTotalPayKh);
            panelMainCashPayment.Controls.Add(txtTotalPay);
            panelMainCashPayment.Controls.Add(lbNameTotalPay);
            panelMainCashPayment.Controls.Add(btnCashPayment);
            panelMainCashPayment.Location = new Point(685, 64);
            panelMainCashPayment.Name = "panelMainCashPayment";
            panelMainCashPayment.Size = new Size(327, 392);
            panelMainCashPayment.TabIndex = 32;
            // 
            // txtReceive
            // 
            txtReceive.BackColor = Color.FromArgb(176, 215, 181);
            txtReceive.BorderStyle = BorderStyle.None;
            txtReceive.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceive.ForeColor = SystemColors.WindowText;
            txtReceive.Location = new Point(141, 108);
            txtReceive.Name = "txtReceive";
            txtReceive.PlaceholderText = "0.00";
            txtReceive.Size = new Size(64, 19);
            txtReceive.TabIndex = 74;
            txtReceive.Tag = "";
            txtReceive.Text = "    ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(176, 215, 181);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(300, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(7, 19);
            textBox1.TabIndex = 73;
            textBox1.Tag = "៛";
            textBox1.Text = "៛";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxchangeKh
            // 
            textBoxchangeKh.BackColor = Color.FromArgb(176, 215, 181);
            textBoxchangeKh.BorderStyle = BorderStyle.None;
            textBoxchangeKh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxchangeKh.ForeColor = SystemColors.WindowText;
            textBoxchangeKh.Location = new Point(300, 189);
            textBoxchangeKh.Name = "textBoxchangeKh";
            textBoxchangeKh.Size = new Size(7, 19);
            textBoxchangeKh.TabIndex = 72;
            textBoxchangeKh.Tag = "៛";
            textBoxchangeKh.Text = "៛";
            textBoxchangeKh.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxRemainKh
            // 
            textBoxRemainKh.BackColor = Color.FromArgb(176, 215, 181);
            textBoxRemainKh.BorderStyle = BorderStyle.None;
            textBoxRemainKh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRemainKh.ForeColor = SystemColors.WindowText;
            textBoxRemainKh.Location = new Point(300, 149);
            textBoxRemainKh.Name = "textBoxRemainKh";
            textBoxRemainKh.Size = new Size(7, 19);
            textBoxRemainKh.TabIndex = 71;
            textBoxRemainKh.Tag = "៛";
            textBoxRemainKh.Text = "៛";
            textBoxRemainKh.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxReKH
            // 
            textBoxReKH.AutoSize = true;
            textBoxReKH.BackColor = Color.FromArgb(176, 215, 181);
            textBoxReKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxReKH.ForeColor = SystemColors.WindowText;
            textBoxReKH.Location = new Point(300, 108);
            textBoxReKH.Name = "textBoxReKH";
            textBoxReKH.Size = new Size(14, 19);
            textBoxReKH.TabIndex = 68;
            textBoxReKH.Tag = "៛";
            textBoxReKH.Text = "៛";
            // 
            // textBoxUSD
            // 
            textBoxUSD.AutoSize = true;
            textBoxUSD.BackColor = Color.FromArgb(176, 215, 181);
            textBoxUSD.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUSD.ForeColor = SystemColors.WindowText;
            textBoxUSD.Location = new Point(126, 108);
            textBoxUSD.Name = "textBoxUSD";
            textBoxUSD.Size = new Size(17, 19);
            textBoxUSD.TabIndex = 70;
            textBoxUSD.Tag = "";
            textBoxUSD.Text = "$";
            // 
            // txtChangeKh
            // 
            txtChangeKh.BackColor = Color.FromArgb(176, 215, 181);
            txtChangeKh.BorderStyle = BorderStyle.None;
            txtChangeKh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChangeKh.ForeColor = SystemColors.WindowText;
            txtChangeKh.Location = new Point(223, 189);
            txtChangeKh.Name = "txtChangeKh";
            txtChangeKh.Size = new Size(75, 19);
            txtChangeKh.TabIndex = 69;
            txtChangeKh.Tag = "​​  0​";
            txtChangeKh.Text = "​  0​";
            txtChangeKh.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRemainingKH
            // 
            txtRemainingKH.BackColor = Color.FromArgb(176, 215, 181);
            txtRemainingKH.BorderStyle = BorderStyle.None;
            txtRemainingKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingKH.ForeColor = SystemColors.WindowText;
            txtRemainingKH.Location = new Point(223, 149);
            txtRemainingKH.Name = "txtRemainingKH";
            txtRemainingKH.Size = new Size(75, 19);
            txtRemainingKH.TabIndex = 68;
            txtRemainingKH.Tag = "​​  0​";
            txtRemainingKH.Text = "​​  0​";
            txtRemainingKH.TextAlign = HorizontalAlignment.Right;
            // 
            // txtReceiveKh
            // 
            txtReceiveKh.BackColor = Color.FromArgb(176, 215, 181);
            txtReceiveKh.BorderStyle = BorderStyle.None;
            txtReceiveKh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceiveKh.ForeColor = SystemColors.WindowText;
            txtReceiveKh.Location = new Point(225, 108);
            txtReceiveKh.Name = "txtReceiveKh";
            txtReceiveKh.PlaceholderText = "0.00";
            txtReceiveKh.Size = new Size(75, 19);
            txtReceiveKh.TabIndex = 67;
            txtReceiveKh.Tag = "";
            txtReceiveKh.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(206, 187);
            label4.Name = "label4";
            label4.Size = new Size(16, 19);
            label4.TabIndex = 66;
            label4.Text = " :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(206, 148);
            label3.Name = "label3";
            label3.Size = new Size(16, 19);
            label3.TabIndex = 65;
            label3.Text = " :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(206, 107);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 64;
            label2.Text = " :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(206, 66);
            label1.Name = "label1";
            label1.Size = new Size(16, 19);
            label1.TabIndex = 63;
            label1.Text = " :";
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.FromArgb(176, 215, 181);
            txtChange.BorderStyle = BorderStyle.None;
            txtChange.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChange.ForeColor = SystemColors.WindowText;
            txtChange.Location = new Point(131, 188);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(78, 19);
            txtChange.TabIndex = 62;
            txtChange.Tag = "$ 0.00        ";
            txtChange.Text = "$ 0.00        ";
            // 
            // txtRemaining
            // 
            txtRemaining.BackColor = Color.FromArgb(176, 215, 181);
            txtRemaining.BorderStyle = BorderStyle.None;
            txtRemaining.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemaining.ForeColor = SystemColors.WindowText;
            txtRemaining.Location = new Point(130, 148);
            txtRemaining.Name = "txtRemaining";
            txtRemaining.Size = new Size(78, 19);
            txtRemaining.TabIndex = 61;
            txtRemaining.Tag = "$ 0.00        ";
            txtRemaining.Text = "$ 0.00        ";
            // 
            // btnNum9
            // 
            btnNum9.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum9.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum9.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum9.ForeColor = SystemColors.WindowText;
            btnNum9.HoverTextColor = Color.DodgerBlue;
            btnNum9.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum9.Location = new Point(170, 329);
            btnNum9.Name = "btnNum9";
            btnNum9.PrimaryColor = Color.White;
            btnNum9.Size = new Size(66, 45);
            btnNum9.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum9.TabIndex = 60;
            btnNum9.Tag = "";
            btnNum9.Text = "9";
            btnNum9.TextColor = Color.Black;
            btnNum9.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum9.Click += InputNumber;
            // 
            // btnNum0
            // 
            btnNum0.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum0.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum0.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum0.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum0.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum0.ForeColor = SystemColors.WindowText;
            btnNum0.HoverTextColor = Color.DodgerBlue;
            btnNum0.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum0.Location = new Point(243, 329);
            btnNum0.Name = "btnNum0";
            btnNum0.PrimaryColor = Color.White;
            btnNum0.Size = new Size(66, 45);
            btnNum0.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum0.TabIndex = 59;
            btnNum0.Tag = "";
            btnNum0.Text = "0";
            btnNum0.TextColor = Color.Black;
            btnNum0.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum0.Click += InputNumber;
            // 
            // btnNum8
            // 
            btnNum8.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum8.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum8.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum8.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum8.ForeColor = SystemColors.WindowText;
            btnNum8.HoverTextColor = Color.DodgerBlue;
            btnNum8.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum8.Location = new Point(97, 329);
            btnNum8.Name = "btnNum8";
            btnNum8.PrimaryColor = Color.White;
            btnNum8.Size = new Size(66, 45);
            btnNum8.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum8.TabIndex = 58;
            btnNum8.Tag = "";
            btnNum8.Text = "8";
            btnNum8.TextColor = Color.Black;
            btnNum8.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum8.Click += InputNumber;
            // 
            // btnNum7
            // 
            btnNum7.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum7.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum7.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum7.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum7.ForeColor = SystemColors.WindowText;
            btnNum7.HoverTextColor = Color.DodgerBlue;
            btnNum7.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum7.Location = new Point(25, 329);
            btnNum7.Name = "btnNum7";
            btnNum7.PrimaryColor = Color.White;
            btnNum7.Size = new Size(66, 45);
            btnNum7.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum7.TabIndex = 57;
            btnNum7.Tag = "";
            btnNum7.Text = "7";
            btnNum7.TextColor = Color.Black;
            btnNum7.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum7.Click += InputNumber;
            // 
            // btnNum6
            // 
            btnNum6.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum6.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum6.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum6.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum6.ForeColor = SystemColors.WindowText;
            btnNum6.HoverTextColor = Color.DodgerBlue;
            btnNum6.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum6.Location = new Point(170, 278);
            btnNum6.Name = "btnNum6";
            btnNum6.PrimaryColor = Color.White;
            btnNum6.Size = new Size(66, 45);
            btnNum6.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum6.TabIndex = 56;
            btnNum6.Tag = "";
            btnNum6.Text = "6";
            btnNum6.TextColor = Color.Black;
            btnNum6.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum6.Click += InputNumber;
            // 
            // btnNumPoint
            // 
            btnNumPoint.BorderColor = Color.FromArgb(220, 223, 230);
            btnNumPoint.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNumPoint.DangerColor = Color.FromArgb(245, 108, 108);
            btnNumPoint.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNumPoint.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNumPoint.ForeColor = SystemColors.WindowText;
            btnNumPoint.HoverTextColor = Color.DodgerBlue;
            btnNumPoint.InfoColor = Color.FromArgb(144, 147, 153);
            btnNumPoint.Location = new Point(243, 278);
            btnNumPoint.Name = "btnNumPoint";
            btnNumPoint.PrimaryColor = Color.White;
            btnNumPoint.Size = new Size(66, 45);
            btnNumPoint.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNumPoint.TabIndex = 55;
            btnNumPoint.Tag = "";
            btnNumPoint.Text = ".";
            btnNumPoint.TextColor = Color.Black;
            btnNumPoint.WarningColor = Color.FromArgb(230, 162, 60);
            btnNumPoint.Click += InputNumber;
            // 
            // btnNum5
            // 
            btnNum5.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum5.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum5.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum5.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum5.ForeColor = SystemColors.WindowText;
            btnNum5.HoverTextColor = Color.DodgerBlue;
            btnNum5.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum5.Location = new Point(97, 278);
            btnNum5.Name = "btnNum5";
            btnNum5.PrimaryColor = Color.White;
            btnNum5.Size = new Size(66, 45);
            btnNum5.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum5.TabIndex = 54;
            btnNum5.Tag = "";
            btnNum5.Text = "5";
            btnNum5.TextColor = Color.Black;
            btnNum5.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum5.Click += InputNumber;
            // 
            // btnNum4
            // 
            btnNum4.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum4.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum4.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum4.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum4.ForeColor = SystemColors.WindowText;
            btnNum4.HoverTextColor = Color.DodgerBlue;
            btnNum4.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum4.Location = new Point(25, 278);
            btnNum4.Name = "btnNum4";
            btnNum4.PrimaryColor = Color.White;
            btnNum4.Size = new Size(66, 45);
            btnNum4.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum4.TabIndex = 53;
            btnNum4.Tag = "";
            btnNum4.Text = "4";
            btnNum4.TextColor = Color.Black;
            btnNum4.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum4.Click += InputNumber;
            // 
            // btnNum3
            // 
            btnNum3.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum3.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum3.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum3.ForeColor = SystemColors.WindowText;
            btnNum3.HoverTextColor = Color.DodgerBlue;
            btnNum3.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum3.Location = new Point(170, 227);
            btnNum3.Name = "btnNum3";
            btnNum3.PrimaryColor = Color.White;
            btnNum3.Size = new Size(66, 45);
            btnNum3.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum3.TabIndex = 52;
            btnNum3.Tag = "";
            btnNum3.Text = "3";
            btnNum3.TextColor = Color.Black;
            btnNum3.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum3.Click += InputNumber;
            // 
            // btnDel
            // 
            btnDel.BorderColor = Color.FromArgb(220, 223, 230);
            btnDel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDel.DangerColor = Color.FromArgb(245, 108, 108);
            btnDel.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnDel.ForeColor = SystemColors.WindowText;
            btnDel.HoverTextColor = Color.DodgerBlue;
            btnDel.InfoColor = Color.FromArgb(144, 147, 153);
            btnDel.Location = new Point(243, 227);
            btnDel.Name = "btnDel";
            btnDel.PrimaryColor = Color.White;
            btnDel.Size = new Size(66, 45);
            btnDel.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDel.TabIndex = 51;
            btnDel.Text = "Del";
            btnDel.TextColor = Color.Black;
            btnDel.WarningColor = Color.FromArgb(230, 162, 60);
            btnDel.Click += btnDel_Click;
            // 
            // btnNum2
            // 
            btnNum2.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum2.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum2.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum2.ForeColor = SystemColors.WindowText;
            btnNum2.HoverTextColor = Color.DodgerBlue;
            btnNum2.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum2.Location = new Point(97, 227);
            btnNum2.Name = "btnNum2";
            btnNum2.PrimaryColor = Color.White;
            btnNum2.Size = new Size(66, 45);
            btnNum2.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum2.TabIndex = 50;
            btnNum2.Tag = "";
            btnNum2.Text = "2";
            btnNum2.TextColor = Color.Black;
            btnNum2.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum2.Click += InputNumber;
            // 
            // btnNum1
            // 
            btnNum1.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum1.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum1.DefaultColor = Color.White;
            btnNum1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum1.ForeColor = SystemColors.WindowText;
            btnNum1.HoverTextColor = Color.DodgerBlue;
            btnNum1.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum1.Location = new Point(25, 227);
            btnNum1.Name = "btnNum1";
            btnNum1.PrimaryColor = Color.White;
            btnNum1.Size = new Size(66, 45);
            btnNum1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum1.TabIndex = 49;
            btnNum1.Tag = "";
            btnNum1.Text = "1";
            btnNum1.TextColor = Color.Black;
            btnNum1.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum1.Click += InputNumber;
            // 
            // lbNameChange
            // 
            lbNameChange.AutoSize = true;
            lbNameChange.Font = new Font("Times New Roman", 12F);
            lbNameChange.ForeColor = SystemColors.WindowText;
            lbNameChange.Location = new Point(20, 187);
            lbNameChange.Name = "lbNameChange";
            lbNameChange.Size = new Size(90, 19);
            lbNameChange.TabIndex = 46;
            lbNameChange.Text = "Change        :";
            // 
            // lbNameRemaining
            // 
            lbNameRemaining.AutoSize = true;
            lbNameRemaining.Font = new Font("Times New Roman", 12F);
            lbNameRemaining.ForeColor = SystemColors.WindowText;
            lbNameRemaining.Location = new Point(20, 147);
            lbNameRemaining.Name = "lbNameRemaining";
            lbNameRemaining.Size = new Size(90, 19);
            lbNameRemaining.TabIndex = 43;
            lbNameRemaining.Text = "Remaining    :";
            // 
            // lbNameReceive
            // 
            lbNameReceive.AutoSize = true;
            lbNameReceive.Font = new Font("Times New Roman", 12F);
            lbNameReceive.ForeColor = SystemColors.WindowText;
            lbNameReceive.Location = new Point(21, 107);
            lbNameReceive.Name = "lbNameReceive";
            lbNameReceive.Size = new Size(88, 19);
            lbNameReceive.TabIndex = 40;
            lbNameReceive.Text = "Receive       :";
            // 
            // txtTotalPayKh
            // 
            txtTotalPayKh.Font = new Font("Times New Roman", 12F);
            txtTotalPayKh.ForeColor = SystemColors.WindowText;
            txtTotalPayKh.Location = new Point(225, 67);
            txtTotalPayKh.Name = "txtTotalPayKh";
            txtTotalPayKh.Size = new Size(75, 20);
            txtTotalPayKh.TabIndex = 39;
            txtTotalPayKh.Tag = "​  0​";
            txtTotalPayKh.Text = "1,000,000";
            txtTotalPayKh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalPay
            // 
            txtTotalPay.AutoSize = true;
            txtTotalPay.Font = new Font("Times New Roman", 12F);
            txtTotalPay.ForeColor = SystemColors.WindowText;
            txtTotalPay.Location = new Point(126, 67);
            txtTotalPay.Name = "txtTotalPay";
            txtTotalPay.Size = new Size(81, 19);
            txtTotalPay.TabIndex = 38;
            txtTotalPay.Text = "$ 0.00        ";
            // 
            // lbNameTotalPay
            // 
            lbNameTotalPay.AutoSize = true;
            lbNameTotalPay.Font = new Font("Times New Roman", 12F);
            lbNameTotalPay.ForeColor = SystemColors.WindowText;
            lbNameTotalPay.Location = new Point(19, 67);
            lbNameTotalPay.Name = "lbNameTotalPay";
            lbNameTotalPay.Size = new Size(89, 19);
            lbNameTotalPay.TabIndex = 37;
            lbNameTotalPay.Text = "Total Pay     :";
            // 
            // btnCashPayment
            // 
            btnCashPayment.BackColor = Color.FromArgb(176, 215, 181);
            btnCashPayment.BorderColor = Color.FromArgb(220, 223, 230);
            btnCashPayment.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCashPayment.DangerColor = Color.FromArgb(245, 108, 108);
            btnCashPayment.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCashPayment.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCashPayment.ForeColor = SystemColors.WindowText;
            btnCashPayment.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCashPayment.InfoColor = Color.FromArgb(144, 147, 153);
            btnCashPayment.Location = new Point(21, 13);
            btnCashPayment.Name = "btnCashPayment";
            btnCashPayment.PrimaryColor = Color.DodgerBlue;
            btnCashPayment.Size = new Size(288, 36);
            btnCashPayment.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCashPayment.TabIndex = 36;
            btnCashPayment.Text = "  Cash Payment";
            btnCashPayment.TextColor = Color.Black;
            btnCashPayment.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // comboBoxCustomerType
            // 
            comboBoxCustomerType.BackColor = Color.White;
            comboBoxCustomerType.ColorA = Color.FromArgb(16, 107, 67);
            comboBoxCustomerType.ColorB = Color.FromArgb(16, 107, 67);
            comboBoxCustomerType.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxCustomerType.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxCustomerType.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxCustomerType.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxCustomerType.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxCustomerType.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxCustomerType.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxCustomerType.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxCustomerType.DropDownHeight = 300;
            comboBoxCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerType.Font = new Font("Segoe UI", 10F);
            comboBoxCustomerType.ForeColor = Color.Black;
            comboBoxCustomerType.HoverSelectionColor = Color.Empty;
            comboBoxCustomerType.IntegralHeight = false;
            comboBoxCustomerType.ItemHeight = 26;
            comboBoxCustomerType.Location = new Point(144, 135);
            comboBoxCustomerType.Name = "comboBoxCustomerType";
            comboBoxCustomerType.Size = new Size(170, 32);
            comboBoxCustomerType.StartIndex = 0;
            comboBoxCustomerType.TabIndex = 0;
            // 
            // lbNameGiftCoupon
            // 
            lbNameGiftCoupon.AutoSize = true;
            lbNameGiftCoupon.Font = new Font("Times New Roman", 12F);
            lbNameGiftCoupon.ForeColor = SystemColors.WindowText;
            lbNameGiftCoupon.Location = new Point(346, 244);
            lbNameGiftCoupon.Name = "lbNameGiftCoupon";
            lbNameGiftCoupon.Size = new Size(106, 19);
            lbNameGiftCoupon.TabIndex = 24;
            lbNameGiftCoupon.Text = "Gift Coupon ($)";
            // 
            // lbNameCustomerEmail
            // 
            lbNameCustomerEmail.AutoSize = true;
            lbNameCustomerEmail.Font = new Font("Times New Roman", 12F);
            lbNameCustomerEmail.ForeColor = SystemColors.WindowText;
            lbNameCustomerEmail.Location = new Point(346, 192);
            lbNameCustomerEmail.Name = "lbNameCustomerEmail";
            lbNameCustomerEmail.Size = new Size(105, 19);
            lbNameCustomerEmail.TabIndex = 23;
            lbNameCustomerEmail.Text = "Customer Email";
            // 
            // lbNameEarning
            // 
            lbNameEarning.AutoSize = true;
            lbNameEarning.Font = new Font("Times New Roman", 12F);
            lbNameEarning.ForeColor = SystemColors.WindowText;
            lbNameEarning.Location = new Point(22, 244);
            lbNameEarning.Name = "lbNameEarning";
            lbNameEarning.Size = new Size(76, 19);
            lbNameEarning.TabIndex = 14;
            lbNameEarning.Text = "Earning ($)";
            // 
            // lbNameSource
            // 
            lbNameSource.AutoSize = true;
            lbNameSource.Font = new Font("Times New Roman", 12F);
            lbNameSource.ForeColor = SystemColors.WindowText;
            lbNameSource.Location = new Point(22, 192);
            lbNameSource.Name = "lbNameSource";
            lbNameSource.Size = new Size(52, 19);
            lbNameSource.TabIndex = 13;
            lbNameSource.Text = "Source";
            // 
            // lbNameMainCustomerPhone
            // 
            lbNameMainCustomerPhone.AutoSize = true;
            lbNameMainCustomerPhone.Font = new Font("Times New Roman", 12F);
            lbNameMainCustomerPhone.Location = new Point(345, 137);
            lbNameMainCustomerPhone.Name = "lbNameMainCustomerPhone";
            lbNameMainCustomerPhone.Size = new Size(110, 19);
            lbNameMainCustomerPhone.TabIndex = 10;
            lbNameMainCustomerPhone.Text = "Customer Phone";
            // 
            // lbNameCustomerName
            // 
            lbNameCustomerName.AutoSize = true;
            lbNameCustomerName.Font = new Font("Times New Roman", 12F);
            lbNameCustomerName.Location = new Point(345, 85);
            lbNameCustomerName.Name = "lbNameCustomerName";
            lbNameCustomerName.Size = new Size(109, 19);
            lbNameCustomerName.TabIndex = 9;
            lbNameCustomerName.Text = "Customer Name";
            // 
            // btnChargePrint
            // 
            btnChargePrint.BackColor = Color.FromArgb(176, 215, 181);
            btnChargePrint.BorderColor = Color.FromArgb(220, 223, 230);
            btnChargePrint.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnChargePrint.Cursor = Cursors.Hand;
            btnChargePrint.DangerColor = Color.FromArgb(245, 108, 108);
            btnChargePrint.DefaultColor = Color.FromArgb(255, 255, 255);
            btnChargePrint.Enabled = false;
            btnChargePrint.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnChargePrint.ForeColor = SystemColors.WindowText;
            btnChargePrint.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnChargePrint.InfoColor = Color.FromArgb(144, 147, 153);
            btnChargePrint.Location = new Point(840, 475);
            btnChargePrint.Name = "btnChargePrint";
            btnChargePrint.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnChargePrint.Size = new Size(154, 37);
            btnChargePrint.SuccessColor = Color.FromArgb(103, 194, 58);
            btnChargePrint.TabIndex = 8;
            btnChargePrint.Text = "Charge & Print";
            btnChargePrint.TextColor = Color.Black;
            btnChargePrint.WarningColor = Color.FromArgb(230, 162, 60);
            btnChargePrint.Click += btnChargePrint_Click;
            // 
            // btnBack
            // 
            btnBack.BorderColor = Color.FromArgb(220, 223, 230);
            btnBack.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnBack.Cursor = Cursors.Hand;
            btnBack.DangerColor = Color.FromArgb(245, 108, 108);
            btnBack.DefaultColor = Color.FromArgb(255, 255, 255);
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.WindowText;
            btnBack.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnBack.InfoColor = Color.FromArgb(144, 147, 153);
            btnBack.Location = new Point(548, 475);
            btnBack.Name = "btnBack";
            btnBack.PrimaryColor = Color.Red;
            btnBack.Size = new Size(76, 37);
            btnBack.SuccessColor = Color.FromArgb(103, 194, 58);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.Black;
            btnBack.WarningColor = Color.FromArgb(230, 162, 60);
            btnBack.Click += btnBack_Click;
            // 
            // lbNameCustomerType
            // 
            lbNameCustomerType.AutoSize = true;
            lbNameCustomerType.Font = new Font("Times New Roman", 12F);
            lbNameCustomerType.ForeColor = SystemColors.WindowText;
            lbNameCustomerType.Location = new Point(22, 137);
            lbNameCustomerType.Name = "lbNameCustomerType";
            lbNameCustomerType.Size = new Size(102, 19);
            lbNameCustomerType.TabIndex = 2;
            lbNameCustomerType.Text = "Customer Type";
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Font = new Font("Times New Roman", 12F);
            lbCustomerID.ForeColor = SystemColors.WindowText;
            lbCustomerID.Location = new Point(22, 85);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(88, 19);
            lbCustomerID.TabIndex = 1;
            lbCustomerID.Text = "Customer ID";
            // 
            // panelHeaderPaymentOption
            // 
            panelHeaderPaymentOption.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderPaymentOption.Controls.Add(btnClosePayment);
            panelHeaderPaymentOption.Controls.Add(lbNamePaymentOption);
            panelHeaderPaymentOption.Font = new Font("Times New Roman", 14.25F);
            panelHeaderPaymentOption.Location = new Point(0, 0);
            panelHeaderPaymentOption.Name = "panelHeaderPaymentOption";
            panelHeaderPaymentOption.Size = new Size(1015, 48);
            panelHeaderPaymentOption.TabIndex = 0;
            // 
            // btnClosePayment
            // 
            btnClosePayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClosePayment.BackgroundImage = Properties.Resources.icon_close22;
            btnClosePayment.BackgroundImageLayout = ImageLayout.Zoom;
            btnClosePayment.Cursor = Cursors.Hand;
            btnClosePayment.FlatAppearance.BorderSize = 0;
            btnClosePayment.FlatStyle = FlatStyle.Flat;
            btnClosePayment.Location = new Point(985, 8);
            btnClosePayment.Name = "btnClosePayment";
            btnClosePayment.Size = new Size(22, 22);
            btnClosePayment.TabIndex = 6;
            btnClosePayment.UseVisualStyleBackColor = true;
            btnClosePayment.Click += btnClosePayment_Click;
            // 
            // lbNamePaymentOption
            // 
            lbNamePaymentOption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbNamePaymentOption.AutoSize = true;
            lbNamePaymentOption.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNamePaymentOption.ForeColor = Color.White;
            lbNamePaymentOption.Location = new Point(431, 11);
            lbNamePaymentOption.Name = "lbNamePaymentOption";
            lbNamePaymentOption.Size = new Size(147, 23);
            lbNamePaymentOption.TabIndex = 1;
            lbNamePaymentOption.Text = "Payment Option";
            // 
            // PopUp_PaymentOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 536);
            Controls.Add(panelPaymentForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_PaymentOption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Payment";
            panelPaymentForm.ResumeLayout(false);
            panelPaymentForm.PerformLayout();
            panelMainCashPayment.ResumeLayout(false);
            panelMainCashPayment.PerformLayout();
            panelHeaderPaymentOption.ResumeLayout(false);
            panelHeaderPaymentOption.PerformLayout();
            ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color c = (Color)comboBoxCustomerType.SelectedItem;
        }

        #endregion

        private System.Windows.Forms.Panel panelPaymentForm;
        private Label lbNameMainCustomerPhone;
        private Label lbNameCustomerName;
        private HopeButton btnChargePrint;
        private HopeButton btnBack;
        private Label lbNameCustomerType;
        private Label lbCustomerID;
        private System.Windows.Forms.Panel panelHeaderPaymentOption;
        private Label lbNamePaymentOption;
        private Label lbNameEarning;
        private Label lbNameSource;
        private Label lbNameGiftCoupon;
        private Label lbNameCustomerEmail;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCustomerType;
        private System.Windows.Forms.Panel panelMainCashPayment;
        private HopeButton btnChargeEInvoice;
        private HopeButton btnCreditCard;
        private HopeButton btnCash;
        private HopeButton btnCashPayment;
        private Label txtTotalPayKh;
        private Label txtTotalPay;
        private Label lbNameTotalPay;
        private Label lbNameRemaining;
        private Label lbNameReceive;
        private Label lbNameChange;
        private HopeButton btnNum3;
        private HopeButton btnDel;
        private HopeButton btnNum2;
        private HopeButton btnNum1;
        private HopeButton btnNum9;
        private HopeButton btnNum0;
        private HopeButton btnNum8;
        private HopeButton btnNum7;
        private HopeButton btnNum6;
        private HopeButton btnNumPoint;
        private HopeButton btnNum5;
        private HopeButton btnNum4;
        private Label lbNameNationality;
        private Label lbNameGender;
        private MetroRadioButton metroRadioButton2;
        private TextBox txtboxMainCustomerID;
        private TextBox txtboxEarning;
        private CyberTextBox txtboxMainEarning;
        private TextBox txtboxCusId;
        private CyberTextBox txtboxMainCusId;
        private TextBox txtboxCusName;
        private CyberTextBox txtboxMainCusName;
        private TextBox txtboxCusEmail;
        private CyberTextBox txtboxMainCusEmail;
        private TextBox txtboxCusPhone;
        private CyberTextBox txtboxMainCusPhone;
        private TextBox txtChange;
        private TextBox txtRemaining;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtReceiveKh;
        private TextBox txtChangeKh;
        private TextBox txtRemainingKH;

        private MetroRadioButton RadioButtonGender(Gender gender)
        {
            return new MetroRadioButton()
            {
                BackgroundColor = Color.White,
                BorderColor = Color.FromArgb(155, 155, 155),
                Checked = false,
                CheckSignColor = Color.FromArgb(65, 177, 225),
                CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked,
                DisabledBorderColor = Color.FromArgb(205, 205, 205),
                Font = new Font("Times New Roman", 12F),
                IsDerivedStyle = true,
                Name = "metroRadioFemale",
                Size = new Size(81, 17),
                Style = ReaLTaiizor.Enum.Metro.Style.Light,
                TabIndex = 38,
                Text = gender.ToString(),
                Tag = gender,
                ThemeAuthor = "Taiizor",
                ThemeName = "MetroLight",
            };
        }
        private decimal _saleExchangeRate => AppStoreContext.CurrentUser.SaleExchangeRate??0;
        private MetroRadioButton RadioButtonNationality(Nationality natonality)
        {
            return new MetroRadioButton()
            {
                BackgroundColor = Color.White,
                BorderColor = Color.FromArgb(155, 155, 155),
                Checked = false,
                CheckSignColor = Color.FromArgb(65, 177, 225),
                CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked,
                DisabledBorderColor = Color.FromArgb(205, 205, 205),
                Font = new Font("Times New Roman", 12F),
                IsDerivedStyle = true,
                Name = "metroRadioFemale",
                Size = new Size(81, 17),
                Style = ReaLTaiizor.Enum.Metro.Style.Light,
                TabIndex = 38,
                Text = natonality.ToString(),
                Tag = natonality,
                ThemeAuthor = "Taiizor",
                ThemeName = "MetroLight",
            };
        }

        #region Calculate Cash Payment on Receive
        private decimal _remain, _remainKh = -0;
        private void CalculateOnMouse_Leave(object sender, EventArgs e)
        {
            var received = CustomStyle.ConvertStringToDecimal(txtReceive.Text.Trim(), "$");
            var receivedKh = CustomStyle.ConvertStringToDecimal(txtReceiveKh.Text.Trim(), "៛");

            decimal totalPay = CustomStyle.ConvertStringToDecimal(txtTotalPay.Text.Trim(), "$");
            decimal totalPayKh = CustomStyle.ConvertStringToDecimal(txtTotalPayKh.Text.Trim(), "៛");

            decimal /*remain = 0.00m,*/ change = 0.00m, /*remainKh = 0,*/ changeKh = 0;

            decimal totalReceived = 0;
            decimal totalReceivedKh = 0;
            // For subRemain Kh
            if (received > 0)
            {
                // For kvas Money KH
                if (totalReceivedKh > 0)
                {
                    totalReceived = receivedKh / _exchangeRate;
                    _remain = receivedKh - totalReceivedKh;
                }
                else
                {
                    totalReceived = received;
                    _remain = received - totalPay;
                }
                // For Remain > 0
                if (_remain >= 0)
                {
                    change = _remain;
                    _remain = 0.00m;
                    // if $ ab luy $ tang os 
                    var changeRemainDollar = change % 5;
                    change = change - changeRemainDollar;
                    changeKh = changeRemainDollar * _saleExchangeRate;
                    /*_remainKh = _remain * _exchangeRate;
                    changeKh = totalReceived * _exchangeRate - totalPayKh;*/
                }
                else
                {
                    change = 0.00m;
                    _remainKh = totalReceived * _exchangeRate - totalPayKh;

                    txtRemainingKH.Enabled = false;
                    txtChangeKh.Enabled = false;
                }

                if (receivedKh >= 0)
                {
                    //decimal result = (receivedKh / _exchangeRate) + _remain;
                    var totalAmount = ((receivedKh / _exchangeRate) + received) - totalPay ;
                    var changeRemainDollar = totalAmount % 5;
                    /*change = totalAmount - changeRemainDollar;*/
                    decimal result = changeRemainDollar * _saleExchangeRate;
                    if (totalAmount > 0 && _remain <=0 )
                    {
                        //change = (changeRemainDollar % 5==0) ? change : changeRemainDollar;
                        change = totalAmount - changeRemainDollar;
                        changeKh = result;
                        _remain = 0.00m;
                        _remainKh = 0;
                    }
                    else
                    {
                        _remainKh = (_remain * _exchangeRate) + receivedKh;
                        _remain = _remainKh / _exchangeRate;
                        change = 0;
                        changeKh = 0;
                    }
                }
                //Condition when back txtReceive = ""
                if (txtReceive.Text.Trim() == "")
                {
                    change = 0.00m;
                    _remain = 0.00m;
                    txtRemainingKH.Enabled = false;
                    txtChangeKh.Enabled = false;
                }
                txtReceiveKh.Enabled = true;
                txtRemainingKH.Enabled = true;
                txtChangeKh.Enabled = true;
            }
            else if (receivedKh > 0)
            {
                if (totalReceived > 0)
                {
                    totalReceivedKh = received * _exchangeRate;
                    _remainKh = receivedKh - totalReceivedKh;
                }
                else
                {
                    var totalAmount = (receivedKh / _exchangeRate) - totalPay;
                    var changeRemainDollar = totalAmount % 5;
                    change = totalAmount - changeRemainDollar;
                    decimal result = changeRemainDollar * _saleExchangeRate;
                    if (totalAmount > 0 && _remain <= 0)
                    {
                        changeKh = result;
                        _remain = 0.00m;
                        _remainKh = 0;
                    }
                    else
                    {
                        _remainKh = receivedKh - totalPayKh;
                    }
                }
                // Kvas 
                if (_remainKh >= 0)
                {
                    var totalAmount = (receivedKh / _exchangeRate) - totalPay;
                    var changeRemainDollar = totalAmount % 5;
                    decimal result = changeRemainDollar * _saleExchangeRate;
                    change = totalAmount - changeRemainDollar;
                    changeKh = result;
                    //change = _remainKh / _exchangeRate;
                    _remainKh = 0;
                    _remain = 0.00m;
                }// ot kvas 
                else
                {
                    changeKh = 0;
                    _remain = _remainKh / _exchangeRate;
                    change = 0.00m;
                }

                // Disable dollar currency controls
                txtReceive.Enabled = true;
                txtChange.Enabled = true;
                txtRemaining.Enabled = true;
                txtRemainingKH.Enabled = true;
                txtChangeKh.Enabled = true;
            }
            else
            {
                change = 0.00m;
                _remain = 0.00m;
                _remainKh = 0.00m;
                txtReceive.Enabled = true;
                txtReceiveKh.Enabled = true;
            }

            _canPayment = (_remain >= 0 || _remainKh >= 0) || (received >= totalPay || receivedKh >= totalPayKh);
            if (_canPayment)
            {
                if(changeKh < 100 && change == 0)
                {
                    change = changeKh = 0.00m;
                }
                _remain = _remainKh = 0.00m;
            }
            btnChargePrint.Enabled = _canPayment;
            //--btnChargeEInvoice.Enabled = _canPayment;
            /*btnCash.Enabled = _canPayment;
            btnCreditCard.Enabled = _canPayment;*/

            txtReceiveKh.Text = CustomStyle.FormatAmountCurrency(txtReceiveKh.Text, "");
            //txtReceiveKh.Text = txtReceiveKh.Text?.Trim().Replace("៛", "");
            var formateChangeKh = CustomStyle.RoundUpCurrencyKh(changeKh);

            txtChange.Text = "$ " + change.ToString("N2").Replace("-", "");
            txtRemaining.Text = "$ " + _remain.ToString("N2").Replace("-", "");
            //--txtChangeKh.Text = changeKh.ToString("N0").Replace("-", "");
            txtChangeKh.Text = formateChangeKh.ToString("N0").Replace("-", "");
            txtRemainingKH.Text = _remainKh.ToString("N0").Replace("-", "");
        }
        #endregion

        private System.Windows.Forms.Button btnClosePayment;
        private Label textBoxUSD;
        private Label textBoxReKH;
        private TextBox textBoxchangeKh;
        private TextBox textBoxRemainKh;
        private TextBox textBox1;
        private TextBox txtReceive;
        private DungeonComboBox comboBoxSource;
        private DungeonComboBox comboBoxGiftCoupon;
        private FlowLayoutPanel panelNationality;
        private FlowLayoutPanel panelGender;
    }
}