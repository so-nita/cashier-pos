namespace CashierPOS.UI.View.View_PopUp
{
    partial class PopUp_CreditCard
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp_CreditCard));
            panelCreditCard = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelHeaderCreditCard = new Panel();
            btnCloseShift = new Button();
            lbNameCloseShift = new Label();
            panelCreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeaderCreditCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCreditCard
            // 
            panelCreditCard.BackColor = Color.FromArgb(176, 215, 181);
            panelCreditCard.Controls.Add(label1);
            panelCreditCard.Controls.Add(pictureBox3);
            panelCreditCard.Controls.Add(pictureBox2);
            panelCreditCard.Controls.Add(pictureBox1);
            panelCreditCard.Controls.Add(panelHeaderCreditCard);
            panelCreditCard.Location = new Point(0, 0);
            panelCreditCard.Name = "panelCreditCard";
            panelCreditCard.Size = new Size(420, 315);
            panelCreditCard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 111);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(36, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 50);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(36, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(36, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelHeaderCreditCard
            // 
            panelHeaderCreditCard.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderCreditCard.Controls.Add(btnCloseShift);
            panelHeaderCreditCard.Controls.Add(lbNameCloseShift);
            panelHeaderCreditCard.Location = new Point(0, 0);
            panelHeaderCreditCard.Name = "panelHeaderCreditCard";
            panelHeaderCreditCard.Size = new Size(420, 48);
            panelHeaderCreditCard.TabIndex = 1;
            // 
            // btnCloseShift
            // 
            btnCloseShift.BackgroundImage = Properties.Resources.can_t1;
            btnCloseShift.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseShift.FlatAppearance.BorderSize = 0;
            btnCloseShift.FlatStyle = FlatStyle.Flat;
            btnCloseShift.Location = new Point(397, 8);
            btnCloseShift.Name = "btnCloseShift";
            btnCloseShift.Size = new Size(15, 14);
            btnCloseShift.TabIndex = 4;
            btnCloseShift.UseVisualStyleBackColor = true;
            // 
            // lbNameCloseShift
            // 
            lbNameCloseShift.AutoSize = true;
            lbNameCloseShift.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameCloseShift.ForeColor = Color.White;
            lbNameCloseShift.Location = new Point(156, 13);
            lbNameCloseShift.Name = "lbNameCloseShift";
            lbNameCloseShift.Size = new Size(109, 22);
            lbNameCloseShift.TabIndex = 1;
            lbNameCloseShift.Text = "Credit Card";
            // 
            // PopUp_CreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 314);
            Controls.Add(panelCreditCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_CreditCard";
            Text = "PopUp_CreditCard";
            panelCreditCard.ResumeLayout(false);
            panelCreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeaderCreditCard.ResumeLayout(false);
            panelHeaderCreditCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCreditCard;
        private Panel panelHeaderCreditCard;
        private Button btnCloseShift;
        private Label lbNameCloseShift;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}