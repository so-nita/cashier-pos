namespace CashierPOS.UI.UserControls
{
    partial class UC_HoldCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbOrderNo = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbNameOrderItem = new Label();
            lbOrderItem = new Label();
            lbNameOrderDate = new Label();
            lbNameTotal = new Label();
            lbNameNo = new Label();
            btnReCart = new ReaLTaiizor.Controls.HopeButton();
            btnDelete = new ReaLTaiizor.Controls.HopeButton();
            lbTotal = new Label();
            lbOrderDate = new Label();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // lbOrderNo
            // 
            lbOrderNo.AutoSize = true;
            lbOrderNo.FlatStyle = FlatStyle.Flat;
            lbOrderNo.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderNo.Location = new Point(87, 32);
            lbOrderNo.Name = "lbOrderNo";
            lbOrderNo.Size = new Size(37, 13);
            lbOrderNo.TabIndex = 2;
            lbOrderNo.Text = "#0001";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lbNameOrderItem);
            materialCard1.Controls.Add(lbOrderItem);
            materialCard1.Controls.Add(lbNameOrderDate);
            materialCard1.Controls.Add(lbNameTotal);
            materialCard1.Controls.Add(lbNameNo);
            materialCard1.Controls.Add(btnReCart);
            materialCard1.Controls.Add(btnDelete);
            materialCard1.Controls.Add(lbTotal);
            materialCard1.Controls.Add(lbOrderDate);
            materialCard1.Controls.Add(lbOrderNo);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(450, 95);
            materialCard1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 70);
            label4.Name = "label4";
            label4.Size = new Size(11, 13);
            label4.TabIndex = 42;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 51);
            label3.Name = "label3";
            label3.Size = new Size(11, 13);
            label3.TabIndex = 41;
            label3.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 31);
            label2.Name = "label2";
            label2.Size = new Size(11, 13);
            label2.TabIndex = 40;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 13);
            label1.Name = "label1";
            label1.Size = new Size(11, 13);
            label1.TabIndex = 39;
            label1.Text = ":";
            // 
            // lbNameOrderItem
            // 
            lbNameOrderItem.AutoSize = true;
            lbNameOrderItem.FlatStyle = FlatStyle.Flat;
            lbNameOrderItem.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameOrderItem.Location = new Point(10, 51);
            lbNameOrderItem.Name = "lbNameOrderItem";
            lbNameOrderItem.Size = new Size(59, 13);
            lbNameOrderItem.TabIndex = 38;
            lbNameOrderItem.Text = "Total Item";
            // 
            // lbOrderItem
            // 
            lbOrderItem.AutoSize = true;
            lbOrderItem.FlatStyle = FlatStyle.Flat;
            lbOrderItem.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderItem.Location = new Point(87, 51);
            lbOrderItem.Name = "lbOrderItem";
            lbOrderItem.Size = new Size(13, 13);
            lbOrderItem.TabIndex = 37;
            lbOrderItem.Text = "1";
            // 
            // lbNameOrderDate
            // 
            lbNameOrderDate.AutoSize = true;
            lbNameOrderDate.FlatStyle = FlatStyle.Flat;
            lbNameOrderDate.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameOrderDate.Location = new Point(10, 13);
            lbNameOrderDate.Name = "lbNameOrderDate";
            lbNameOrderDate.Size = new Size(66, 13);
            lbNameOrderDate.TabIndex = 36;
            lbNameOrderDate.Text = "Order Date";
            // 
            // lbNameTotal
            // 
            lbNameTotal.AutoSize = true;
            lbNameTotal.FlatStyle = FlatStyle.Flat;
            lbNameTotal.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameTotal.Location = new Point(11, 70);
            lbNameTotal.Name = "lbNameTotal";
            lbNameTotal.Size = new Size(32, 13);
            lbNameTotal.TabIndex = 35;
            lbNameTotal.Text = "Total";
            // 
            // lbNameNo
            // 
            lbNameNo.AutoSize = true;
            lbNameNo.FlatStyle = FlatStyle.Flat;
            lbNameNo.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameNo.Location = new Point(10, 32);
            lbNameNo.Name = "lbNameNo";
            lbNameNo.Size = new Size(53, 13);
            lbNameNo.TabIndex = 34;
            lbNameNo.Text = "Order №";
            // 
            // btnReCart
            // 
            btnReCart.BorderColor = Color.FromArgb(220, 223, 230);
            btnReCart.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReCart.DangerColor = Color.FromArgb(245, 108, 108);
            btnReCart.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReCart.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReCart.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReCart.InfoColor = Color.FromArgb(144, 147, 153);
            btnReCart.Location = new Point(247, 35);
            btnReCart.Name = "btnReCart";
            btnReCart.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnReCart.Size = new Size(90, 30);
            btnReCart.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReCart.TabIndex = 22;
            btnReCart.Text = "Re-Cart";
            btnReCart.TextColor = Color.White;
            btnReCart.WarningColor = Color.FromArgb(230, 162, 60);
            btnReCart.Click += btnReCart_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_161;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.BorderColor = Color.FromArgb(220, 223, 230);
            btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnDelete.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDelete.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDelete.InfoColor = Color.FromArgb(144, 147, 153);
            btnDelete.Location = new Point(345, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.PrimaryColor = Color.Red;
            btnDelete.Size = new Size(90, 30);
            btnDelete.SuccessColor = Color.FromArgb(192, 0, 0);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnDelete.Click += btnDelete_Click;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.FromArgb(16, 107, 67);
            lbTotal.Location = new Point(76, 70);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(55, 12);
            lbTotal.TabIndex = 11;
            lbTotal.Text = "$ 4.25";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.FlatStyle = FlatStyle.Flat;
            lbOrderDate.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrderDate.Location = new Point(86, 13);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(111, 13);
            lbOrderDate.TabIndex = 10;
            lbOrderDate.Text = "08-02-2024 09:00PM";
            // 
            // UC_HoldCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UC_HoldCart";
            Size = new Size(450, 95);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbOrderNo;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label lbOrderDate;
        private Label lbTotal;
        private ReaLTaiizor.Controls.HopeButton btnDelete;
        private ReaLTaiizor.Controls.HopeButton btnReCart;
        private Label lbNameOrderDate;
        private Label lbNameTotal;
        private Label lbNameNo;
        private Label lbNameOrderItem;
        private Label lbOrderItem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}