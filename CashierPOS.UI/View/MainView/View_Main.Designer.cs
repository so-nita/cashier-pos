namespace CashierPOS.UI.View
{
    partial class View_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Main));
            Main_panel = new Panel();
            btnCloseApplication = new Button();
            textBoxSearch = new TextBox();
            panel1 = new Panel();
            lbUserId = new Label();
            lbPosId = new Label();
            picUserProfile = new PictureBox();
            labelUserName = new Label();
            labelUserID = new Label();
            label = new Label();
            labelPOSID = new Label();
            label5 = new Label();
            lbCurrentDate = new Label();
            pictureBox3 = new PictureBox();
            picLogo = new PictureBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox2 = new PictureBox();
            panelCenter = new Panel();
            Main_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Main_panel
            // 
            Main_panel.BackColor = Color.FromArgb(215, 234, 213);
            Main_panel.Controls.Add(btnCloseApplication);
            Main_panel.Controls.Add(textBoxSearch);
            Main_panel.Controls.Add(panel1);
            Main_panel.Controls.Add(pictureBox3);
            Main_panel.Controls.Add(picLogo);
            Main_panel.Controls.Add(cyberButton1);
            Main_panel.Controls.Add(pictureBox2);
            Main_panel.Dock = DockStyle.Top;
            Main_panel.Location = new Point(0, 0);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(1270, 72);
            Main_panel.TabIndex = 0;
            // 
            // btnCloseApplication
            // 
            btnCloseApplication.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseApplication.BackgroundImage = Properties.Resources.can_t1;
            btnCloseApplication.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseApplication.FlatAppearance.BorderSize = 0;
            btnCloseApplication.FlatStyle = FlatStyle.Flat;
            btnCloseApplication.Location = new Point(1238, 5);
            btnCloseApplication.Name = "btnCloseApplication";
            btnCloseApplication.Size = new Size(25, 25);
            btnCloseApplication.TabIndex = 7;
            btnCloseApplication.Cursor = Cursors.Hand;
            btnCloseApplication.UseVisualStyleBackColor = true;
            btnCloseApplication.Click += btnCloseApplication_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Times New Roman", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.ForeColor = SystemColors.ControlText;
            textBoxSearch.Location = new Point(182, 28);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search by name or barcode";
            textBoxSearch.Size = new Size(244, 16);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(lbUserId);
            panel1.Controls.Add(lbPosId);
            panel1.Controls.Add(picUserProfile);
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(labelUserID);
            panel1.Controls.Add(label);
            panel1.Controls.Add(labelPOSID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbCurrentDate);
            panel1.Location = new Point(575, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 40);
            panel1.TabIndex = 0;
            // 
            // lbUserId
            // 
            lbUserId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbUserId.Font = new Font("Times New Roman", 9.75F);
            lbUserId.Location = new Point(185, 12);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new Size(60, 19);
            lbUserId.TabIndex = 4;
            lbUserId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPosId
            // 
            lbPosId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbPosId.Font = new Font("Times New Roman", 9.75F);
            lbPosId.Location = new Point(295, 12);
            lbPosId.Name = "lbPosId";
            lbPosId.Size = new Size(55, 19);
            lbPosId.TabIndex = 3;
            lbPosId.Text = " ";
            lbPosId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picUserProfile
            // 
            picUserProfile.Location = new Point(8, 3);
            picUserProfile.Name = "picUserProfile";
            picUserProfile.Size = new Size(39, 30);
            picUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picUserProfile.TabIndex = 1;
            picUserProfile.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUserName.Font = new Font("Times New Roman", 9.75F);
            labelUserName.Location = new Point(50, 11);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(130, 20);
            labelUserName.TabIndex = 2;
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUserID
            // 
            labelUserID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelUserID.Font = new Font("Times New Roman", 9.75F);
            labelUserID.Location = new Point(245, 12);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(60, 19);
            labelUserID.TabIndex = 2;
            labelUserID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 9.75F);
            label.Location = new Point(187, 11);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 2;
            // 
            // labelPOSID
            // 
            labelPOSID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelPOSID.Font = new Font("Times New Roman", 9.75F);
            labelPOSID.Location = new Point(352, 12);
            labelPOSID.Name = "labelPOSID";
            labelPOSID.Size = new Size(50, 19);
            labelPOSID.TabIndex = 2;
            labelPOSID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F);
            label5.Location = new Point(331, 11);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 2;
            // 
            // lbCurrentDate
            // 
            lbCurrentDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbCurrentDate.AutoSize = true;
            lbCurrentDate.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCurrentDate.Location = new Point(415, 11);
            lbCurrentDate.Name = "lbCurrentDate";
            lbCurrentDate.Size = new Size(222, 16);
            lbCurrentDate.TabIndex = 2;
            lbCurrentDate.Text = "Mondy, 08 Janury 2024  07:00:00 AM";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.icons8_search_301;
            pictureBox3.Location = new Point(158, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.King_Mart_Logo;
            picLogo.Location = new Point(21, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(68, 65);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.White;
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.SeaGreen;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Black;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(142, 16);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(298, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 1;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 1;
            cyberButton1.Timer_RGB = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.icons8_search_301;
            pictureBox2.Location = new Point(158, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.White;
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 72);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1270, 792);
            panelCenter.TabIndex = 1;
            // 
            // View_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 864);
            Controls.Add(panelCenter);
            Controls.Add(Main_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Main";
            Load += View_Main_Load;
            Main_panel.ResumeLayout(false);
            Main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void View_Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        private Panel Main_panel;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBox1;
        private Label labelPOS_ID;
        private Label labelUserName;
        private Label labelUserName_ID;
        private Label labelDateTime;
        private PictureBox pictureBox2;
        private TextBox textBoxSearch;
        private Panel panelCenter;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private Label lbUserId;
        private Label label3;
        private Label label;
        private Label label5;
        private PictureBox picUserProfile;
        private PictureBox picLogo;
        private Label labelPOSID;
        private Label lbCurrentDate;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label labelUserID;
        private Label lbPosId;
        private Button btnCloseApplication;
    }
}