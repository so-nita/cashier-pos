using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View.View_PopUp
{
    partial class PopUp_CreateItem
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
        /// </summary>
        private void InitializeComponentData()
        {
            txtCode.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtCode.Leave += CustomStyle.OnMouseLeave_Placeholder;

            txtCost.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtCost.Leave += CustomStyle.OnMouseLeave_Placeholder;

            txtPrice.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtPrice.Leave += CustomStyle.OnMouseLeave_Placeholder;

            txtName.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtName.Leave += CustomStyle.OnMouseLeave_Placeholder;

            txtNameKh.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtNameKh.Leave += CustomStyle.OnMouseLeave_Placeholder;

            txtDescription.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtDescription.Leave += CustomStyle.OnMouseLeave_Placeholder;
        }
        private void InitializeComponent()
        {
            lbNameKh = new Label();
            lbNamePassword = new Label();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            txtboxMainCusId = new ReaLTaiizor.Controls.MaterialCard();
            txtNameKh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            label4 = new Label();
            txtCode = new TextBox();
            panelMain = new Panel();
            materialCardProductImage = new ReaLTaiizor.Controls.MaterialCard();
            picBoxProduct = new PictureBox();
            comboCategory = new ReaLTaiizor.Controls.DungeonComboBox();
            txtName = new TextBox();
            materialCard6 = new ReaLTaiizor.Controls.MaterialCard();
            label6 = new Label();
            btnUploadImage = new ReaLTaiizor.Controls.HopeButton();
            materialCard5 = new ReaLTaiizor.Controls.MaterialCard();
            txtDescription = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            txtCost = new TextBox();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            panelMain.SuspendLayout();
            materialCardProductImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).BeginInit();
            materialCard5.SuspendLayout();
            SuspendLayout();
            // 
            // lbNameKh
            // 
            lbNameKh.AutoSize = true;
            lbNameKh.Font = new Font("Times New Roman", 12F);
            lbNameKh.ForeColor = SystemColors.WindowText;
            lbNameKh.Location = new Point(50, 168);
            lbNameKh.Name = "lbNameKh";
            lbNameKh.Size = new Size(69, 19);
            lbNameKh.TabIndex = 1;
            lbNameKh.Text = "Name Kh";
            // 
            // lbNamePassword
            // 
            lbNamePassword.AutoSize = true;
            lbNamePassword.Font = new Font("Times New Roman", 12F);
            lbNamePassword.ForeColor = SystemColors.WindowText;
            lbNamePassword.Location = new Point(50, 225);
            lbNamePassword.Name = "lbNamePassword";
            lbNamePassword.Size = new Size(43, 19);
            lbNamePassword.TabIndex = 2;
            lbNamePassword.Text = "Code";
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
            btnCancle.Location = new Point(622, 591);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(104, 35);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancle.Click += btnCancle_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(176, 215, 181);
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(759, 591);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnLogin.Size = new Size(104, 35);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Save";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            // 
            // txtboxMainCusId
            // 
            txtboxMainCusId.BackColor = Color.FromArgb(255, 255, 255);
            txtboxMainCusId.BackgroundImageLayout = ImageLayout.None;
            txtboxMainCusId.Depth = 0;
            txtboxMainCusId.Font = new Font("Times New Roman", 8F);
            txtboxMainCusId.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtboxMainCusId.Location = new Point(173, 159);
            txtboxMainCusId.Margin = new Padding(14);
            txtboxMainCusId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtboxMainCusId.Name = "txtboxMainCusId";
            txtboxMainCusId.Padding = new Padding(14);
            txtboxMainCusId.Size = new Size(360, 35);
            txtboxMainCusId.TabIndex = 52;
            txtboxMainCusId.Tag = "Cyber";
            // 
            // txtNameKh
            // 
            txtNameKh.BackColor = Color.White;
            txtNameKh.BorderStyle = BorderStyle.None;
            txtNameKh.Font = new Font("Times New Roman", 11.25F);
            txtNameKh.ForeColor = Color.DarkGray;
            txtNameKh.Location = new Point(183, 168);
            txtNameKh.Name = "txtNameKh";
            txtNameKh.Size = new Size(333, 18);
            txtNameKh.TabIndex = 53;
            txtNameKh.Tag = "Input Name Kh";
            txtNameKh.Text = "Input Name Kh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(50, 286);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 54;
            label1.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(50, 469);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 55;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(362, 38);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 56;
            label3.Text = "Create New Product";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.BackgroundImageLayout = ImageLayout.None;
            materialCard1.Depth = 0;
            materialCard1.Font = new Font("Times New Roman", 8F);
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(173, 216);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(360, 35);
            materialCard1.TabIndex = 54;
            materialCard1.Tag = "Cyber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(50, 345);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 57;
            label4.Text = "Price";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Times New Roman", 11.25F);
            txtCode.ForeColor = Color.DarkGray;
            txtCode.Location = new Point(183, 225);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(333, 18);
            txtCode.TabIndex = 55;
            txtCode.Tag = "Input Code";
            txtCode.Text = "Input Code";
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(materialCardProductImage);
            panelMain.Controls.Add(comboCategory);
            panelMain.Controls.Add(txtName);
            panelMain.Controls.Add(materialCard6);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(btnUploadImage);
            panelMain.Controls.Add(materialCard5);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(txtPrice);
            panelMain.Controls.Add(materialCard2);
            panelMain.Controls.Add(txtCost);
            panelMain.Controls.Add(materialCard3);
            panelMain.Controls.Add(txtCode);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(materialCard1);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtNameKh);
            panelMain.Controls.Add(txtboxMainCusId);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(btnCancle);
            panelMain.Controls.Add(lbNamePassword);
            panelMain.Controls.Add(lbNameKh);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(885, 635);
            panelMain.TabIndex = 1;
            // 
            // materialCardProductImage
            // 
            materialCardProductImage.BackColor = Color.FromArgb(255, 255, 255);
            materialCardProductImage.BackgroundImageLayout = ImageLayout.None;
            materialCardProductImage.Controls.Add(picBoxProduct);
            materialCardProductImage.Depth = 0;
            materialCardProductImage.Font = new Font("Times New Roman", 8F);
            materialCardProductImage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardProductImage.Location = new Point(674, 142);
            materialCardProductImage.Margin = new Padding(14);
            materialCardProductImage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCardProductImage.Name = "materialCardProductImage";
            materialCardProductImage.Padding = new Padding(14);
            materialCardProductImage.Size = new Size(190, 210);
            materialCardProductImage.TabIndex = 71;
            materialCardProductImage.Tag = "Cyber";
            // 
            // picBoxProduct
            // 
            picBoxProduct.Font = new Font("Times New Roman", 12F);
            picBoxProduct.ForeColor = SystemColors.WindowText;
            picBoxProduct.Location = new Point(0, 0);
            picBoxProduct.Name = "picBoxProduct";
            picBoxProduct.Size = new Size(190, 205);
            picBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxProduct.TabIndex = 64;
            picBoxProduct.TabStop = false;
            picBoxProduct.Text = "Description";
            // 
            // comboCategory
            // 
            comboCategory.BackColor = Color.White;
            comboCategory.ColorA = Color.FromArgb(246, 132, 85);
            comboCategory.ColorB = Color.FromArgb(231, 108, 57);
            comboCategory.ColorC = Color.FromArgb(242, 241, 240);
            comboCategory.ColorD = Color.FromArgb(253, 252, 252);
            comboCategory.ColorE = Color.FromArgb(239, 237, 236);
            comboCategory.ColorF = Color.FromArgb(180, 180, 180);
            comboCategory.ColorG = Color.FromArgb(119, 119, 118);
            comboCategory.ColorH = Color.FromArgb(224, 222, 220);
            comboCategory.ColorI = Color.FromArgb(250, 249, 249);
            comboCategory.DrawMode = DrawMode.OwnerDrawFixed;
            comboCategory.DropDownHeight = 100;
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategory.Font = new Font("Times New Roman", 11.25F);
            comboCategory.ForeColor = Color.DarkGray;
            comboCategory.HoverSelectionColor = Color.FromArgb(246, 132, 85);
            comboCategory.IntegralHeight = false;
            comboCategory.ItemHeight = 20;
            comboCategory.Location = new Point(173, 406);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(360, 26);
            comboCategory.StartIndex = 0;
            comboCategory.TabIndex = 62;
            comboCategory.Tag = " -- Select Category --";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 11.25F);
            txtName.ForeColor = Color.DarkGray;
            txtName.Location = new Point(183, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 18);
            txtName.TabIndex = 70;
            txtName.Tag = "Input name ";
            txtName.Text = "Input name ";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.BackgroundImageLayout = ImageLayout.None;
            materialCard6.Depth = 0;
            materialCard6.Font = new Font("Times New Roman", 8F);
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(173, 96);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(360, 35);
            materialCard6.TabIndex = 69;
            materialCard6.Tag = "Cyber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(50, 106);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 68;
            label6.Text = "Name";
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(176, 215, 181);
            btnUploadImage.BorderColor = Color.FromArgb(220, 223, 230);
            btnUploadImage.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUploadImage.DangerColor = Color.FromArgb(245, 108, 108);
            btnUploadImage.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUploadImage.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnUploadImage.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUploadImage.InfoColor = Color.FromArgb(144, 147, 153);
            btnUploadImage.Location = new Point(677, 394);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.PrimaryColor = Color.LightGray;
            btnUploadImage.Size = new Size(184, 32);
            btnUploadImage.SuccessColor = Color.Gray;
            btnUploadImage.TabIndex = 67;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.TextColor = Color.White;
            btnUploadImage.WarningColor = Color.FromArgb(230, 162, 60);
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.BackgroundImageLayout = ImageLayout.None;
            materialCard5.Controls.Add(txtDescription);
            materialCard5.Depth = 0;
            materialCard5.Font = new Font("Times New Roman", 8F);
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(173, 462);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(360, 93);
            materialCard5.TabIndex = 66;
            materialCard5.Tag = "Cyber";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Times New Roman", 11.25F);
            txtDescription.ForeColor = Color.DarkGray;
            txtDescription.Location = new Point(10, 8);
            txtDescription.MaximumSize = new Size(350, 93);
            txtDescription.MinimumSize = new Size(341, 18);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(341, 18);
            txtDescription.TabIndex = 62;
            txtDescription.Tag = "Input Description";
            txtDescription.Text = "Input Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(50, 407);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 62;
            label5.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Times New Roman", 11.25F);
            txtPrice.ForeColor = Color.DarkGray;
            txtPrice.Location = new Point(183, 345);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(333, 18);
            txtPrice.TabIndex = 61;
            txtPrice.Tag = "Input Price";
            txtPrice.Text = "Input Price";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BackgroundImageLayout = ImageLayout.None;
            materialCard2.Depth = 0;
            materialCard2.Font = new Font("Times New Roman", 8F);
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(173, 336);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(360, 35);
            materialCard2.TabIndex = 60;
            materialCard2.Tag = "Cyber";
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.White;
            txtCost.BorderStyle = BorderStyle.None;
            txtCost.Font = new Font("Times New Roman", 11.25F);
            txtCost.ForeColor = Color.DarkGray;
            txtCost.Location = new Point(183, 288);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(333, 18);
            txtCost.TabIndex = 59;
            txtCost.Tag = "Input Cost";
            txtCost.Text = "Input Cost";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.BackgroundImageLayout = ImageLayout.None;
            materialCard3.Depth = 0;
            materialCard3.Font = new Font("Times New Roman", 8F);
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(173, 279);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(360, 35);
            materialCard3.TabIndex = 58;
            materialCard3.Tag = "Cyber";
            // 
            // PopUp_CreateItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 642);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_CreateItem";
            Text = "PopUp_CreateItem";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            materialCardProductImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).EndInit();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbNameKh;
        private Label lbNamePassword;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
        private ReaLTaiizor.Controls.MaterialCard txtboxMainCusId;
        private TextBox txtNameKh;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label label4;
        private TextBox txtCode;
        private Panel panelMain;
        private TextBox txtPrice;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private TextBox txtCost;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.DungeonComboBox comboCategory;
        private Label label5;
        private PictureBox picBoxProduct;
        private ReaLTaiizor.Controls.MaterialCard materialCard5;
        private TextBox txtDescription;
        private ReaLTaiizor.Controls.HopeButton btnUploadImage;
        private TextBox txtName;
        private ReaLTaiizor.Controls.MaterialCard materialCard6;
        private Label label6;
        private ReaLTaiizor.Controls.MaterialCard materialCardProductImage;
    }
}