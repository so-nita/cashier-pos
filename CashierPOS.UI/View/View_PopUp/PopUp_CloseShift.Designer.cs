using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.UI.CustomStyles;
using ReaLTaiizor.Util;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_CloseShift
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
        
        //Label Payment Name
        private int lableBoxYOffSet { get; set; } = 10;
        //Input Textbox Main
        private int panelYOffSet { get; set; } = 10;
        //Input Textbox 
        private int textboxYOffSet { get; set; } = 19;

        //Label Dynamic All Payment Name
        private void CreateLabelPaymentName(string paymentName)
        {
            panelListPaymentMethod.Location = new Point(5, 121);
            var lable = new Label();
            lable.Font = new Font("Times New Roman", 12F);
            lable.ForeColor = SystemColors.WindowText;
            lable.Location = new Point(28, lableBoxYOffSet);
            lable.Name = $"lb{paymentName}";
            lable.Size = new Size(160, 35);
            lable.Text = paymentName;
            lable.TextAlign = ContentAlignment.MiddleLeft;
            lable.Padding = new Padding(0,5,0,0);
            //--panelCloseShiftForm.Controls.Add(lable);
            panelListPaymentMethod.Controls.Add(lable);

            lableBoxYOffSet += 44;
        }

        // Textbox Input of all Payment Name
        private void CreatePanelHoverTextBox(PaymentMethodResponse data)
        {
            TextBox textBox = new TextBox()
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                ForeColor = Color.Black,
                Location = new Point(230, textboxYOffSet),
                Name = $"{data.Id}",
                //Name = $"{data.Code}",
                PlaceholderText = data.Name.Contains("KHR") ? "0 ​៛" : "$ 0.00",
                Size = new Size(203, 35),
                TabIndex = 18,
                //--Tag = $"{data.Currency}",
                Tag = $"{data.Name}",
                Font = new Font("Times New Roman", 11.25F),
                
            };
            textBox.TextChanged += TextBox_TextChanged;
            textBox.KeyPress += ValidationNumberOnly!;

            panelListPaymentMethod.Controls.Add(textBox);

            textboxYOffSet += 44;

            ReaLTaiizor.Controls.CyberTextBox txtboxMainPanel = new ReaLTaiizor.Controls.CyberTextBox()
            {
                Alpha = 20,
                BackColor = Color.Transparent,
                Background_WidthPen = 1F,
                BackgroundPen = true,
                ColorBackground = Color.White,
                ColorBackground_Pen = Color.White,
                ColorLighting = Color.White,
                ColorPen_1 = Color.White,
                ColorPen_2 = Color.White,
                CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom,
                Font = new Font("Times New Roman", 11.25F),
                ForeColor = Color.FromArgb(245, 245, 245),
                LinearGradientPen = false,
                Location = new Point(218, panelYOffSet),
                PenWidth = 15,
                RGB = false,
                Name = data.Id,
                Rounding = true,
                RoundingInt = 40,
                Size = new Size(221, 35),
                SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality,
                TabIndex = 5,
                TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit,
                Timer_RGB = 300,
                
            };

            //--panelCloseShiftForm.Controls.Add(txtboxMainPanel);
            panelListPaymentMethod.Controls.Add(txtboxMainPanel);
            panelYOffSet += 44;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var text = "";
                if (textBox.Tag.ToString().Contains("KHR"))
                {
                    text = CustomStyle.FormatAmountCurrency(textBox.Text, "​៛");
                    textBox.SelectionStart = (text.Length - 3) <=0 ? 0: text.Length-3;
                }
                else
                {
                    text = CustomStyle.FormatAmountCurrency(textBox.Text, "$");
                    textBox.SelectionStart = text.Length;
                }
                textBox.Text = text;
            }
        }

        /// </summary>
        private void InitializeComponent()
        {
            panelCloseShiftForm = new Panel();
            panelListPaymentMethod = new Panel();
            lbCashAmount = new Label();
            lbPaymentType = new Label();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderCloseShift = new Panel();
            btnCloseShift = new Button();
            lbNameCloseShift = new Label();
            panelCloseShiftForm.SuspendLayout();
            panelHeaderCloseShift.SuspendLayout();
            SuspendLayout();
            // 
            // panelCloseShiftForm
            // 
            panelCloseShiftForm.AutoSize = true;
            panelCloseShiftForm.BackColor = Color.FromArgb(176, 215, 181);
            panelCloseShiftForm.Controls.Add(panelListPaymentMethod);
            panelCloseShiftForm.Controls.Add(lbCashAmount);
            panelCloseShiftForm.Controls.Add(lbPaymentType);
            panelCloseShiftForm.Controls.Add(btnSave);
            panelCloseShiftForm.Controls.Add(btnCancle);
            panelCloseShiftForm.Controls.Add(panelHeaderCloseShift);
            panelCloseShiftForm.Dock = DockStyle.Fill;
            panelCloseShiftForm.Location = new Point(0, 0);
            panelCloseShiftForm.Name = "panelCloseShiftForm";
            panelCloseShiftForm.Size = new Size(475, 265);
            panelCloseShiftForm.TabIndex = 1;
            // 
            // panelListPaymentMethod
            // 
            panelListPaymentMethod.AutoSize = true;
            panelListPaymentMethod.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            panelListPaymentMethod.Location = new Point(22, 121);
            panelListPaymentMethod.Name = "panelListPaymentMethod";
            panelListPaymentMethod.Size = new Size(435, 25);
            panelListPaymentMethod.TabIndex = 22;
            panelListPaymentMethod.Text = "Cash Amount";
            // 
            // lbCashAmount
            // 
            lbCashAmount.AutoSize = true;
            lbCashAmount.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbCashAmount.Location = new Point(218, 80);
            lbCashAmount.Name = "lbCashAmount";
            lbCashAmount.Size = new Size(120, 22);
            lbCashAmount.TabIndex = 21;
            lbCashAmount.Text = "Cash Amount";
            // 
            // lbPaymentType
            // 
            lbPaymentType.AutoSize = true;
            lbPaymentType.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbPaymentType.Location = new Point(26, 80);
            lbPaymentType.Name = "lbPaymentType";
            lbPaymentType.Size = new Size(126, 22);
            lbPaymentType.TabIndex = 20;
            lbPaymentType.Text = "Payment Type";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(176, 215, 181);
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(370, 184);
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
            btnCancle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancle.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancle.ButtonType = HopeButtonType.Primary;
            btnCancle.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancle.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancle.Location = new Point(283, 184);
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
            // panelHeaderCloseShift
            // 
            panelHeaderCloseShift.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderCloseShift.Controls.Add(btnCloseShift);
            panelHeaderCloseShift.Controls.Add(lbNameCloseShift);
            panelHeaderCloseShift.Dock = DockStyle.Top;
            panelHeaderCloseShift.Location = new Point(0, 0);
            panelHeaderCloseShift.Name = "panelHeaderCloseShift";
            panelHeaderCloseShift.Size = new Size(475, 48);
            panelHeaderCloseShift.TabIndex = 0;
            // 
            // btnCloseShift
            // 
            btnCloseShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseShift.BackgroundImage = Properties.Resources.can_t1;
            btnCloseShift.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseShift.FlatAppearance.BorderSize = 0;
            btnCloseShift.FlatStyle = FlatStyle.Flat;
            btnCloseShift.Location = new Point(447, 8);
            btnCloseShift.Name = "btnCloseShift";
            btnCloseShift.Size = new Size(22, 22);
            btnCloseShift.TabIndex = 4;
            btnCloseShift.UseVisualStyleBackColor = true;
            btnCloseShift.Click += btnCloseShift_Click;
            // 
            // lbNameCloseShift
            // 
            lbNameCloseShift.AutoSize = true;
            lbNameCloseShift.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameCloseShift.ForeColor = Color.White;
            lbNameCloseShift.Location = new Point(185, 13);
            lbNameCloseShift.Name = "lbNameCloseShift";
            lbNameCloseShift.Size = new Size(99, 22);
            lbNameCloseShift.TabIndex = 1;
            lbNameCloseShift.Text = "Close Shift";
            // 
            // PopUp_CloseShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(475, 265);
            Controls.Add(panelCloseShiftForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_CloseShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Close";
            panelCloseShiftForm.ResumeLayout(false);
            panelCloseShiftForm.PerformLayout();
            panelHeaderCloseShift.ResumeLayout(false);
            panelHeaderCloseShift.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCloseShiftForm;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private Panel panelHeaderCloseShift;
        private Label lbNameCloseShift;
        private Label lbCashAmount;
        private Label lbPaymentType;
        private Button btnCloseShift;
        private Panel panelListPaymentMethod;
    }
}