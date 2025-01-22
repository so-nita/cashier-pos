using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_OpenShift
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
            //Pos ID
            txtboxPosID.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxPosID.Leave += CustomStyle.OnMouseLeave_Placeholder;

            //User ID
            txtboxUserID.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxUserID.Leave += CustomStyle.OnMouseLeave_Placeholder;

            //Cashier Name
            txtboxCashierName.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxCashierName.Leave += CustomStyle.OnMouseLeave_Placeholder;

            //Cash USD
            /*txtTotalCashUSD.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtTotalCashUSD.Leave += CustomStyle.OnMouseLeave_Placeholder;*/
            CustomStyle.AttachDynamicKeyEvent(txtTotalCashUSD, txtTotalCashKHR);
            //Input Text Only Number
            txtTotalCashUSD.MaxLength = 8;
            txtTotalCashUSD.KeyPress += CustomStyle.ValidationNumberOnly;

            //Cash KHR
            /*txtTotalCashKHR.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtTotalCashKHR.Leave += CustomStyle.OnMouseLeave_Placeholder;*/
            CustomStyle.AttachDynamicKeyEvent(txtTotalCashKHR, txtTotalCashUSD);

            //Input Text Only Number
            txtTotalCashKHR.MaxLength = 12;
            txtTotalCashKHR.KeyPress += CustomStyle.ValidationNumberOnly;

            txtboxOpenDate.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxOpenDate.Leave += CustomStyle.OnMouseLeave_Placeholder;
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelOpenShoftForm = new Panel();
            panelOpenShift = new Panel();
            txtTotalCashKHR = new TextBox();
            txtTotalCashKHRMain = new ReaLTaiizor.Controls.CyberTextBox();
            txtTotalCashUSD = new TextBox();
            txtTotalCashUSDMain = new ReaLTaiizor.Controls.CyberTextBox();
            lbTotalCashKH = new Label();
            lbTotalCashUSD = new Label();
            txtboxOpenDate = new TextBox();
            txtboxCashierName = new TextBox();
            txtboxUserID = new TextBox();
            txtboxPosID = new TextBox();
            txtboxMainCashierName = new ReaLTaiizor.Controls.CyberTextBox();
            txtboxMainOpenDate = new ReaLTaiizor.Controls.CyberTextBox();
            lbNameCashierName = new Label();
            lbNameOpenDate = new Label();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            txtboxMainUserID = new ReaLTaiizor.Controls.CyberTextBox();
            txtboxMainPosID = new ReaLTaiizor.Controls.CyberTextBox();
            lbNameUserID = new Label();
            lbNamePosID = new Label();
            panelHeaderOpenShift = new Panel();
            btnCloseOpenShift = new Button();
            lbNameOpenShift = new Label();
            panelOpenShoftForm.SuspendLayout();
            panelOpenShift.SuspendLayout();
            panelHeaderOpenShift.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpenShoftForm
            // 
            panelOpenShoftForm.BackColor = Color.FromArgb(176, 215, 181);
            panelOpenShoftForm.Controls.Add(panelOpenShift);
            panelOpenShoftForm.Controls.Add(txtboxOpenDate);
            panelOpenShoftForm.Controls.Add(txtboxCashierName);
            panelOpenShoftForm.Controls.Add(txtboxUserID);
            panelOpenShoftForm.Controls.Add(txtboxPosID);
            panelOpenShoftForm.Controls.Add(txtboxMainCashierName);
            panelOpenShoftForm.Controls.Add(txtboxMainOpenDate);
            panelOpenShoftForm.Controls.Add(lbNameCashierName);
            panelOpenShoftForm.Controls.Add(lbNameOpenDate);
            panelOpenShoftForm.Controls.Add(btnSave);
            panelOpenShoftForm.Controls.Add(btnCancle);
            panelOpenShoftForm.Controls.Add(txtboxMainUserID);
            panelOpenShoftForm.Controls.Add(txtboxMainPosID);
            panelOpenShoftForm.Controls.Add(lbNameUserID);
            panelOpenShoftForm.Controls.Add(lbNamePosID);
            panelOpenShoftForm.Controls.Add(panelHeaderOpenShift);
            panelOpenShoftForm.Font = new Font("Khmer OS Content", 9.75F);
            panelOpenShoftForm.ForeColor = Color.DarkGray;
            panelOpenShoftForm.Location = new Point(0, 0);
            panelOpenShoftForm.Name = "panelOpenShoftForm";
            panelOpenShoftForm.Size = new Size(722, 406);
            panelOpenShoftForm.TabIndex = 1;
            // 
            // panelOpenShift
            // 
            panelOpenShift.Controls.Add(txtTotalCashKHR);
            panelOpenShift.Controls.Add(txtTotalCashKHRMain);
            panelOpenShift.Controls.Add(txtTotalCashUSD);
            panelOpenShift.Controls.Add(txtTotalCashUSDMain);
            panelOpenShift.Controls.Add(lbTotalCashKH);
            panelOpenShift.Controls.Add(lbTotalCashUSD);
            panelOpenShift.Location = new Point(150, 201);
            panelOpenShift.Name = "panelOpenShift";
            panelOpenShift.Size = new Size(410, 134);
            panelOpenShift.TabIndex = 29;
            // 
            // txtTotalCashKHR
            // 
            txtTotalCashKHR.BackColor = Color.White;
            txtTotalCashKHR.BorderStyle = BorderStyle.None;
            txtTotalCashKHR.Font = new Font("Khmer OS Content", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCashKHR.ForeColor = Color.Black;
            txtTotalCashKHR.Location = new Point(157, 86);
            txtTotalCashKHR.Name = "txtTotalCashKHR";
            txtTotalCashKHR.PlaceholderText = "0​​ ៛";
            txtTotalCashKHR.Size = new Size(227, 27);
            txtTotalCashKHR.TabIndex = 33;
            txtTotalCashKHR.TextChanged += txtTotalCashKHR_TextChanged;
            // 
            // txtTotalCashKHRMain
            // 
            txtTotalCashKHRMain.Alpha = 20;
            txtTotalCashKHRMain.BackColor = Color.Transparent;
            txtTotalCashKHRMain.Background_WidthPen = 1F;
            txtTotalCashKHRMain.BackgroundPen = true;
            txtTotalCashKHRMain.ColorBackground = Color.White;
            txtTotalCashKHRMain.ColorBackground_Pen = Color.White;
            txtTotalCashKHRMain.ColorLighting = Color.White;
            txtTotalCashKHRMain.ColorPen_1 = Color.White;
            txtTotalCashKHRMain.ColorPen_2 = Color.White;
            txtTotalCashKHRMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTotalCashKHRMain.Font = new Font("Times New Roman", 8F);
            txtTotalCashKHRMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtTotalCashKHRMain.Lighting = false;
            txtTotalCashKHRMain.LinearGradientPen = false;
            txtTotalCashKHRMain.Location = new Point(147, 82);
            txtTotalCashKHRMain.Name = "txtTotalCashKHRMain";
            txtTotalCashKHRMain.PenWidth = 15;
            txtTotalCashKHRMain.RGB = false;
            txtTotalCashKHRMain.Rounding = true;
            txtTotalCashKHRMain.RoundingInt = 40;
            txtTotalCashKHRMain.Size = new Size(245, 35);
            txtTotalCashKHRMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTotalCashKHRMain.TabIndex = 32;
            txtTotalCashKHRMain.Tag = "Cyber";
            txtTotalCashKHRMain.TextButton = "";
            txtTotalCashKHRMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTotalCashKHRMain.Timer_RGB = 300;
            // 
            // txtTotalCashUSD
            // 
            txtTotalCashUSD.BackColor = Color.White;
            txtTotalCashUSD.BorderStyle = BorderStyle.None;
            txtTotalCashUSD.Font = new Font("Times New Roman", 11.5F);
            txtTotalCashUSD.ForeColor = Color.Black;
            txtTotalCashUSD.Location = new Point(157, 40);
            txtTotalCashUSD.Name = "txtTotalCashUSD";
            txtTotalCashUSD.PlaceholderText = "$ 0.00";
            txtTotalCashUSD.Size = new Size(227, 18);
            txtTotalCashUSD.TabIndex = 31;
            txtTotalCashUSD.TextChanged += txtTotalCashUSD_TextChanged;
            // 
            // txtTotalCashUSDMain
            // 
            txtTotalCashUSDMain.Alpha = 20;
            txtTotalCashUSDMain.BackColor = Color.Transparent;
            txtTotalCashUSDMain.Background_WidthPen = 1F;
            txtTotalCashUSDMain.BackgroundPen = true;
            txtTotalCashUSDMain.ColorBackground = Color.White;
            txtTotalCashUSDMain.ColorBackground_Pen = Color.White;
            txtTotalCashUSDMain.ColorLighting = Color.White;
            txtTotalCashUSDMain.ColorPen_1 = Color.White;
            txtTotalCashUSDMain.ColorPen_2 = Color.White;
            txtTotalCashUSDMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTotalCashUSDMain.Font = new Font("Times New Roman", 8F);
            txtTotalCashUSDMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtTotalCashUSDMain.Lighting = false;
            txtTotalCashUSDMain.LinearGradientPen = false;
            txtTotalCashUSDMain.Location = new Point(147, 31);
            txtTotalCashUSDMain.Name = "txtTotalCashUSDMain";
            txtTotalCashUSDMain.PenWidth = 15;
            txtTotalCashUSDMain.RGB = false;
            txtTotalCashUSDMain.Rounding = true;
            txtTotalCashUSDMain.RoundingInt = 40;
            txtTotalCashUSDMain.Size = new Size(245, 35);
            txtTotalCashUSDMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTotalCashUSDMain.TabIndex = 30;
            txtTotalCashUSDMain.Tag = "Cyber";
            txtTotalCashUSDMain.TextButton = "";
            txtTotalCashUSDMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTotalCashUSDMain.Timer_RGB = 300;
            // 
            // lbTotalCashKH
            // 
            lbTotalCashKH.AutoSize = true;
            lbTotalCashKH.Font = new Font("Times New Roman", 12F);
            lbTotalCashKH.ForeColor = SystemColors.WindowText;
            lbTotalCashKH.Location = new Point(10, 91);
            lbTotalCashKH.Name = "lbTotalCashKH";
            lbTotalCashKH.Size = new Size(121, 19);
            lbTotalCashKH.TabIndex = 29;
            lbTotalCashKH.Text = "Total Cash (KHR)";
            // 
            // lbTotalCashUSD
            // 
            lbTotalCashUSD.AutoSize = true;
            lbTotalCashUSD.Font = new Font("Times New Roman", 12F);
            lbTotalCashUSD.ForeColor = SystemColors.WindowText;
            lbTotalCashUSD.Location = new Point(10, 40);
            lbTotalCashUSD.Name = "lbTotalCashUSD";
            lbTotalCashUSD.Size = new Size(119, 19);
            lbTotalCashUSD.TabIndex = 28;
            lbTotalCashUSD.Text = "Total Cash (USD)";
            // 
            // txtboxOpenDate
            // 
            txtboxOpenDate.BackColor = Color.White;
            txtboxOpenDate.BorderStyle = BorderStyle.None;
            txtboxOpenDate.Enabled = false;
            txtboxOpenDate.Font = new Font("Times New Roman", 11.25F);
            txtboxOpenDate.ForeColor = Color.DarkGray;
            txtboxOpenDate.Location = new Point(464, 87);
            txtboxOpenDate.Name = "txtboxOpenDate";
            txtboxOpenDate.ReadOnly = true;
            txtboxOpenDate.Size = new Size(227, 18);
            txtboxOpenDate.TabIndex = 28;
            txtboxOpenDate.Tag = " Open Date / Time";
            txtboxOpenDate.Text = " Open Date / Time";
            // 
            // txtboxCashierName
            // 
            txtboxCashierName.BackColor = Color.White;
            txtboxCashierName.BorderStyle = BorderStyle.None;
            txtboxCashierName.Enabled = false;
            txtboxCashierName.Font = new Font("Times New Roman", 11.25F);
            txtboxCashierName.ForeColor = Color.DarkGray;
            txtboxCashierName.Location = new Point(464, 139);
            txtboxCashierName.Name = "txtboxCashierName";
            txtboxCashierName.ReadOnly = true;
            txtboxCashierName.Size = new Size(227, 18);
            txtboxCashierName.TabIndex = 22;
            txtboxCashierName.Tag = " Cashier Name";
            txtboxCashierName.Text = " Cashier Name";
            // 
            // txtboxUserID
            // 
            txtboxUserID.BackColor = Color.White;
            txtboxUserID.BorderStyle = BorderStyle.None;
            txtboxUserID.Enabled = false;
            txtboxUserID.Font = new Font("Times New Roman", 11.25F);
            txtboxUserID.ForeColor = Color.DarkGray;
            txtboxUserID.Location = new Point(104, 139);
            txtboxUserID.Name = "txtboxUserID";
            txtboxUserID.Size = new Size(172, 18);
            txtboxUserID.TabIndex = 20;
            txtboxUserID.Tag = " User ID";
            txtboxUserID.Text = " User ID";
            // 
            // txtboxPosID
            // 
            txtboxPosID.BackColor = Color.White;
            txtboxPosID.BorderStyle = BorderStyle.None;
            txtboxPosID.Enabled = false;
            txtboxPosID.Font = new Font("Times New Roman", 11.25F);
            txtboxPosID.ForeColor = Color.DarkGray;
            txtboxPosID.Location = new Point(104, 87);
            txtboxPosID.Name = "txtboxPosID";
            txtboxPosID.Size = new Size(172, 18);
            txtboxPosID.TabIndex = 19;
            txtboxPosID.Tag = " POS ID";
            txtboxPosID.Text = " POS ID";
            // 
            // txtboxMainCashierName
            // 
            txtboxMainCashierName.Alpha = 20;
            txtboxMainCashierName.BackColor = Color.Transparent;
            txtboxMainCashierName.Background_WidthPen = 1F;
            txtboxMainCashierName.BackgroundPen = true;
            txtboxMainCashierName.ColorBackground = Color.White;
            txtboxMainCashierName.ColorBackground_Pen = Color.White;
            txtboxMainCashierName.ColorLighting = Color.White;
            txtboxMainCashierName.ColorPen_1 = Color.White;
            txtboxMainCashierName.ColorPen_2 = Color.White;
            txtboxMainCashierName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainCashierName.Font = new Font("Arial", 8F);
            txtboxMainCashierName.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainCashierName.Lighting = false;
            txtboxMainCashierName.LinearGradientPen = false;
            txtboxMainCashierName.Location = new Point(454, 129);
            txtboxMainCashierName.Name = "txtboxMainCashierName";
            txtboxMainCashierName.PenWidth = 15;
            txtboxMainCashierName.RGB = false;
            txtboxMainCashierName.Rounding = true;
            txtboxMainCashierName.RoundingInt = 40;
            txtboxMainCashierName.Size = new Size(245, 35);
            txtboxMainCashierName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainCashierName.TabIndex = 12;
            txtboxMainCashierName.Tag = "Cyber";
            txtboxMainCashierName.TextButton = "";
            txtboxMainCashierName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainCashierName.Timer_RGB = 300;
            // 
            // txtboxMainOpenDate
            // 
            txtboxMainOpenDate.Alpha = 20;
            txtboxMainOpenDate.BackColor = Color.Transparent;
            txtboxMainOpenDate.Background_WidthPen = 1F;
            txtboxMainOpenDate.BackgroundPen = true;
            txtboxMainOpenDate.ColorBackground = Color.White;
            txtboxMainOpenDate.ColorBackground_Pen = Color.White;
            txtboxMainOpenDate.ColorLighting = Color.White;
            txtboxMainOpenDate.ColorPen_1 = Color.White;
            txtboxMainOpenDate.ColorPen_2 = Color.White;
            txtboxMainOpenDate.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainOpenDate.Font = new Font("Arial", 8F);
            txtboxMainOpenDate.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainOpenDate.Lighting = false;
            txtboxMainOpenDate.LinearGradientPen = false;
            txtboxMainOpenDate.Location = new Point(454, 77);
            txtboxMainOpenDate.Name = "txtboxMainOpenDate";
            txtboxMainOpenDate.PenWidth = 15;
            txtboxMainOpenDate.RGB = false;
            txtboxMainOpenDate.Rounding = true;
            txtboxMainOpenDate.RoundingInt = 40;
            txtboxMainOpenDate.Size = new Size(245, 35);
            txtboxMainOpenDate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainOpenDate.TabIndex = 11;
            txtboxMainOpenDate.Tag = "Cyber";
            txtboxMainOpenDate.TextButton = "";
            txtboxMainOpenDate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainOpenDate.Timer_RGB = 300;
            // 
            // lbNameCashierName
            // 
            lbNameCashierName.AutoSize = true;
            lbNameCashierName.Font = new Font("Times New Roman", 12F);
            lbNameCashierName.ForeColor = SystemColors.WindowText;
            lbNameCashierName.Location = new Point(310, 137);
            lbNameCashierName.Name = "lbNameCashierName";
            lbNameCashierName.Size = new Size(96, 19);
            lbNameCashierName.TabIndex = 10;
            lbNameCashierName.Text = "Cashier Name";
            // 
            // lbNameOpenDate
            // 
            lbNameOpenDate.AutoSize = true;
            lbNameOpenDate.Font = new Font("Times New Roman", 12F);
            lbNameOpenDate.ForeColor = SystemColors.WindowText;
            lbNameOpenDate.Location = new Point(310, 85);
            lbNameOpenDate.Name = "lbNameOpenDate";
            lbNameOpenDate.Size = new Size(117, 19);
            lbNameOpenDate.TabIndex = 9;
            lbNameOpenDate.Text = "Open Date / Time";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(176, 215, 181);
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(607, 345);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnSave.Size = new Size(73, 32);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancle.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancle.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancle.Location = new Point(509, 345);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(73, 32);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancle.Click += btnCancle_Click;
            // 
            // txtboxMainUserID
            // 
            txtboxMainUserID.Alpha = 20;
            txtboxMainUserID.BackColor = Color.Transparent;
            txtboxMainUserID.Background_WidthPen = 1F;
            txtboxMainUserID.BackgroundPen = true;
            txtboxMainUserID.ColorBackground = Color.White;
            txtboxMainUserID.ColorBackground_Pen = Color.White;
            txtboxMainUserID.ColorLighting = Color.White;
            txtboxMainUserID.ColorPen_1 = Color.White;
            txtboxMainUserID.ColorPen_2 = Color.White;
            txtboxMainUserID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainUserID.Font = new Font("Arial", 8F);
            txtboxMainUserID.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainUserID.Lighting = false;
            txtboxMainUserID.LinearGradientPen = false;
            txtboxMainUserID.Location = new Point(95, 129);
            txtboxMainUserID.Name = "txtboxMainUserID";
            txtboxMainUserID.PenWidth = 15;
            txtboxMainUserID.RGB = false;
            txtboxMainUserID.Rounding = true;
            txtboxMainUserID.RoundingInt = 40;
            txtboxMainUserID.Size = new Size(188, 35);
            txtboxMainUserID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainUserID.TabIndex = 6;
            txtboxMainUserID.Tag = "Cyber";
            txtboxMainUserID.TextButton = "";
            txtboxMainUserID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainUserID.Timer_RGB = 300;
            // 
            // txtboxMainPosID
            // 
            txtboxMainPosID.Alpha = 20;
            txtboxMainPosID.BackColor = Color.Transparent;
            txtboxMainPosID.Background_WidthPen = 1F;
            txtboxMainPosID.BackgroundPen = true;
            txtboxMainPosID.ColorBackground = Color.White;
            txtboxMainPosID.ColorBackground_Pen = Color.White;
            txtboxMainPosID.ColorLighting = Color.White;
            txtboxMainPosID.ColorPen_1 = Color.White;
            txtboxMainPosID.ColorPen_2 = Color.White;
            txtboxMainPosID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainPosID.Font = new Font("Arial", 8F);
            txtboxMainPosID.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainPosID.Lighting = false;
            txtboxMainPosID.LinearGradientPen = false;
            txtboxMainPosID.Location = new Point(95, 77);
            txtboxMainPosID.Name = "txtboxMainPosID";
            txtboxMainPosID.PenWidth = 15;
            txtboxMainPosID.RGB = false;
            txtboxMainPosID.Rounding = true;
            txtboxMainPosID.RoundingInt = 40;
            txtboxMainPosID.Size = new Size(188, 35);
            txtboxMainPosID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainPosID.TabIndex = 5;
            txtboxMainPosID.Tag = "Cyber";
            txtboxMainPosID.TextButton = "";
            txtboxMainPosID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainPosID.Timer_RGB = 300;
            // 
            // lbNameUserID
            // 
            lbNameUserID.AutoSize = true;
            lbNameUserID.Font = new Font("Times New Roman", 12F);
            lbNameUserID.ForeColor = SystemColors.WindowText;
            lbNameUserID.Location = new Point(16, 137);
            lbNameUserID.Name = "lbNameUserID";
            lbNameUserID.Size = new Size(58, 19);
            lbNameUserID.TabIndex = 2;
            lbNameUserID.Text = "User ID";
            // 
            // lbNamePosID
            // 
            lbNamePosID.AutoSize = true;
            lbNamePosID.Font = new Font("Times New Roman", 12F);
            lbNamePosID.ForeColor = SystemColors.WindowText;
            lbNamePosID.Location = new Point(16, 85);
            lbNamePosID.Name = "lbNamePosID";
            lbNamePosID.Size = new Size(59, 19);
            lbNamePosID.TabIndex = 1;
            lbNamePosID.Text = "POS ID";
            // 
            // panelHeaderOpenShift
            // 
            panelHeaderOpenShift.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderOpenShift.Controls.Add(btnCloseOpenShift);
            panelHeaderOpenShift.Controls.Add(lbNameOpenShift);
            panelHeaderOpenShift.Location = new Point(0, 0);
            panelHeaderOpenShift.Name = "panelHeaderOpenShift";
            panelHeaderOpenShift.Size = new Size(722, 48);
            panelHeaderOpenShift.TabIndex = 0;
            // 
            // btnCloseOpenShift
            // 
            btnCloseOpenShift.BackgroundImage = Properties.Resources.can_t1;
            btnCloseOpenShift.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseOpenShift.Cursor = Cursors.Hand;
            btnCloseOpenShift.FlatAppearance.BorderSize = 0;
            btnCloseOpenShift.FlatStyle = FlatStyle.Flat;
            btnCloseOpenShift.Location = new Point(695, 8);
            btnCloseOpenShift.Name = "btnCloseOpenShift";
            btnCloseOpenShift.Size = new Size(20, 20);
            btnCloseOpenShift.TabIndex = 7;
            btnCloseOpenShift.UseVisualStyleBackColor = true;
            btnCloseOpenShift.Click += btnCloseOpenShift_Click;
            // 
            // lbNameOpenShift
            // 
            lbNameOpenShift.AutoSize = true;
            lbNameOpenShift.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameOpenShift.ForeColor = Color.White;
            lbNameOpenShift.Location = new Point(311, 14);
            lbNameOpenShift.Name = "lbNameOpenShift";
            lbNameOpenShift.Size = new Size(97, 22);
            lbNameOpenShift.TabIndex = 1;
            lbNameOpenShift.Text = "Open Shift";
            // 
            // PopUp_OpenShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 406);
            Controls.Add(panelOpenShoftForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_OpenShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_FormOpenShift";
            Load += InitailizeLoad_Component;
            panelOpenShoftForm.ResumeLayout(false);
            panelOpenShoftForm.PerformLayout();
            panelOpenShift.ResumeLayout(false);
            panelOpenShift.PerformLayout();
            panelHeaderOpenShift.ResumeLayout(false);
            panelHeaderOpenShift.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOpenShoftForm;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainUserID;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainPosID;
        private Label lbNameUserID;
        private Label lbNamePosID;
        private Panel panelHeaderOpenShift;
        private Label lbNameOpenShift;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainOpenDate;
        private Label lbNameCashierName;
        private Label lbNameOpenDate;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainCashierName;
        private TextBox txtboxPosID;
        private TextBox txtboxUserID;
        private TextBox txtboxCashierName;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private TextBox txtboxOpenDate;
        private Button btnCloseOpenShift;
        private Panel panelOpenShift;
        private TextBox txtTotalCashKHR;
        private ReaLTaiizor.Controls.CyberTextBox txtTotalCashKHRMain;
        private TextBox txtTotalCashUSD;
        private ReaLTaiizor.Controls.CyberTextBox txtTotalCashUSDMain;
        private Label lbTotalCashKH;
        private Label lbTotalCashUSD;
    }
}