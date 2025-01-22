using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.Testing
{
    partial class Discount
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
            Search_Item.Enter += CustomStyle.OnMouseHover_Placeholder;
            Search_Item.Leave += CustomStyle.OnMouseLeave_Placeholder;
        }
        /// </summary>
        private void InitializeComponent()
        {
            ButtonApply = new ReaLTaiizor.Controls.HopeButton();
            lblDiscount = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            ButtonClose = new ReaLTaiizor.Controls.HopeButton();
            Search_Item = new ReaLTaiizor.Controls.SmallTextBox();
            label3 = new Label();
            label4 = new Label();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            panel_listitem = new FlowLayoutPanel();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            combox_discount = new ReaLTaiizor.Controls.DungeonComboBox();
            poisonDateTime2 = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonApply
            // 
            ButtonApply.BorderColor = Color.FromArgb(220, 223, 230);
            ButtonApply.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            ButtonApply.DangerColor = Color.FromArgb(245, 108, 108);
            ButtonApply.DefaultColor = Color.FromArgb(255, 255, 255);
            ButtonApply.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonApply.HoverTextColor = Color.FromArgb(48, 49, 51);
            ButtonApply.InfoColor = Color.FromArgb(144, 147, 153);
            ButtonApply.Location = new Point(391, 414);
            ButtonApply.Name = "ButtonApply";
            ButtonApply.PrimaryColor = Color.FromArgb(64, 158, 255);
            ButtonApply.Size = new Size(76, 30);
            ButtonApply.SuccessColor = Color.FromArgb(103, 194, 58);
            ButtonApply.TabIndex = 2;
            ButtonApply.Text = "Apply";
            ButtonApply.TextColor = Color.White;
            ButtonApply.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.BackColor = Color.White;
            lblDiscount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(193, 14);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(89, 19);
            lblDiscount.TabIndex = 8;
            lblDiscount.Text = "DISCOUNT";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblDiscount);
            materialCard1.Controls.Add(ButtonClose);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(479, 43);
            materialCard1.TabIndex = 9;
            // 
            // ButtonClose
            // 
            ButtonClose.BackColor = Color.White;
            ButtonClose.BorderColor = Color.FromArgb(220, 223, 230);
            ButtonClose.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            ButtonClose.DangerColor = Color.FromArgb(245, 108, 108);
            ButtonClose.DefaultColor = Color.FromArgb(255, 255, 255);
            ButtonClose.Font = new Font("Segoe UI", 12F);
            ButtonClose.HoverTextColor = Color.FromArgb(48, 49, 51);
            ButtonClose.InfoColor = Color.FromArgb(144, 147, 153);
            ButtonClose.Location = new Point(441, 14);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.PrimaryColor = Color.FromArgb(192, 64, 0);
            ButtonClose.Size = new Size(26, 20);
            ButtonClose.SuccessColor = Color.FromArgb(103, 194, 58);
            ButtonClose.TabIndex = 2;
            ButtonClose.Text = "X";
            ButtonClose.TextColor = Color.White;
            ButtonClose.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // Search_Item
            // 
            Search_Item.BackColor = Color.Transparent;
            Search_Item.BorderColor = Color.FromArgb(180, 180, 180);
            Search_Item.CustomBGColor = Color.White;
            Search_Item.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_Item.ForeColor = Color.Silver;
            Search_Item.Location = new Point(13, 109);
            Search_Item.MaxLength = 32767;
            Search_Item.Multiline = false;
            Search_Item.Name = "Search_Item";
            Search_Item.ReadOnly = false;
            Search_Item.Size = new Size(316, 25);
            Search_Item.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Search_Item.TabIndex = 12;
            Search_Item.Tag = "Search Item Discount";
            Search_Item.Text = "Search Item Discount";
            Search_Item.TextAlignment = HorizontalAlignment.Left;
            Search_Item.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 339);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "StartDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 339);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "EndDate";
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(12, 363);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(213, 29);
            poisonDateTime1.TabIndex = 12;
            // 
            // panel_listitem
            // 
            panel_listitem.AutoScroll = true;
            panel_listitem.Location = new Point(3, 30);
            panel_listitem.Name = "panel_listitem";
            panel_listitem.Size = new Size(314, 180);
            panel_listitem.TabIndex = 13;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel_listitem);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(12, 107);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(319, 212);
            materialCard2.TabIndex = 0;
            // 
            // combox_discount
            // 
            combox_discount.BackColor = Color.FromArgb(246, 246, 246);
            combox_discount.ColorA = Color.FromArgb(246, 132, 85);
            combox_discount.ColorB = Color.FromArgb(231, 108, 57);
            combox_discount.ColorC = Color.FromArgb(242, 241, 240);
            combox_discount.ColorD = Color.FromArgb(253, 252, 252);
            combox_discount.ColorE = Color.FromArgb(239, 237, 236);
            combox_discount.ColorF = Color.FromArgb(180, 180, 180);
            combox_discount.ColorG = Color.FromArgb(119, 119, 118);
            combox_discount.ColorH = Color.FromArgb(224, 222, 220);
            combox_discount.ColorI = Color.FromArgb(250, 249, 249);
            combox_discount.DrawMode = DrawMode.OwnerDrawFixed;
            combox_discount.DropDownHeight = 100;
            combox_discount.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_discount.Font = new Font("Segoe UI", 10F);
            combox_discount.ForeColor = Color.FromArgb(76, 76, 97);
            combox_discount.FormattingEnabled = true;
            combox_discount.HoverSelectionColor = Color.Empty;
            combox_discount.IntegralHeight = false;
            combox_discount.ItemHeight = 20;
            combox_discount.Location = new Point(122, 60);
            combox_discount.Name = "combox_discount";
            combox_discount.Size = new Size(209, 26);
            combox_discount.StartIndex = 0;
            combox_discount.TabIndex = 13;
            // 
            // poisonDateTime2
            // 
            poisonDateTime2.Location = new Point(263, 362);
            poisonDateTime2.MinimumSize = new Size(0, 29);
            poisonDateTime2.Name = "poisonDateTime2";
            poisonDateTime2.Size = new Size(213, 29);
            poisonDateTime2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 8;
            label2.Text = "DisCount Tpye:";
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 456);
            Controls.Add(label2);
            Controls.Add(combox_discount);
            Controls.Add(ButtonApply);
            Controls.Add(Search_Item);
            Controls.Add(poisonDateTime2);
            Controls.Add(poisonDateTime1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(materialCard1);
            Controls.Add(materialCard2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Discount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount";
            Load += InitailizeLoad_Component;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.HopeButton ButtonApply;
        private Label lblDiscount;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.SmallTextBox Search_Item;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.HopeButton ButtonClose;
        private FlowLayoutPanel panel_listitem;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.DungeonComboBox combox_discount;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime2;
        private Label label2;
    }
}