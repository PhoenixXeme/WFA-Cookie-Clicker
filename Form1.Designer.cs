namespace WFA_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btn_cookie = new Button();
            panel2 = new Panel();
            btn_settings = new Button();
            btn_shop = new Button();
            btn_home = new Button();
            panel3 = new Panel();
            lbl_gems = new Label();
            lbl_gem = new Label();
            lbl_cookie = new Label();
            lbl_cookies = new Label();
            shop1 = new Shop();
            btn_save = new Button();
            settings1 = new Settings();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 2);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 1;
            label1.Text = "Cookie Clicker";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 33);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "v0.1";
            label2.Click += label2_Click;
            // 
            // btn_cookie
            // 
            btn_cookie.BackgroundImageLayout = ImageLayout.None;
            btn_cookie.FlatAppearance.BorderSize = 0;
            btn_cookie.FlatStyle = FlatStyle.Flat;
            btn_cookie.Image = (Image)resources.GetObject("btn_cookie.Image");
            btn_cookie.Location = new Point(276, 200);
            btn_cookie.Name = "btn_cookie";
            btn_cookie.Size = new Size(138, 131);
            btn_cookie.TabIndex = 3;
            btn_cookie.UseVisualStyleBackColor = false;
            btn_cookie.Click += btn_cookie_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_settings);
            panel2.Controls.Add(btn_shop);
            panel2.Controls.Add(btn_home);
            panel2.Location = new Point(3, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 456);
            panel2.TabIndex = 4;
            // 
            // btn_settings
            // 
            btn_settings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_settings.Image = (Image)resources.GetObject("btn_settings.Image");
            btn_settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_settings.Location = new Point(-4, 401);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(120, 55);
            btn_settings.TabIndex = 0;
            btn_settings.Text = "Settings";
            btn_settings.TextAlign = ContentAlignment.MiddleRight;
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_shop
            // 
            btn_shop.FlatStyle = FlatStyle.Flat;
            btn_shop.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_shop.Image = (Image)resources.GetObject("btn_shop.Image");
            btn_shop.ImageAlign = ContentAlignment.MiddleLeft;
            btn_shop.Location = new Point(3, 64);
            btn_shop.Name = "btn_shop";
            btn_shop.Size = new Size(104, 55);
            btn_shop.TabIndex = 0;
            btn_shop.Text = "Shop";
            btn_shop.TextAlign = ContentAlignment.MiddleRight;
            btn_shop.UseVisualStyleBackColor = true;
            btn_shop.Click += btn_shop_Click;
            // 
            // btn_home
            // 
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(3, 3);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(104, 55);
            btn_home.TabIndex = 0;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleRight;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_gems);
            panel3.Controls.Add(lbl_gem);
            panel3.Controls.Add(lbl_cookie);
            panel3.Controls.Add(lbl_cookies);
            panel3.Location = new Point(121, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 36);
            panel3.TabIndex = 5;
            // 
            // lbl_gems
            // 
            lbl_gems.AutoSize = true;
            lbl_gems.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gems.Location = new Point(193, 0);
            lbl_gems.Name = "lbl_gems";
            lbl_gems.Size = new Size(69, 25);
            lbl_gems.TabIndex = 0;
            lbl_gems.Text = "Gem's:";
            // 
            // lbl_gem
            // 
            lbl_gem.AutoSize = true;
            lbl_gem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gem.Location = new Point(261, 0);
            lbl_gem.Name = "lbl_gem";
            lbl_gem.Size = new Size(23, 25);
            lbl_gem.TabIndex = 0;
            lbl_gem.Text = "0";
            // 
            // lbl_cookie
            // 
            lbl_cookie.AutoSize = true;
            lbl_cookie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cookie.Location = new Point(86, 2);
            lbl_cookie.Name = "lbl_cookie";
            lbl_cookie.Size = new Size(31, 25);
            lbl_cookie.TabIndex = 0;
            lbl_cookie.Text = "10";
            // 
            // lbl_cookies
            // 
            lbl_cookies.AutoSize = true;
            lbl_cookies.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cookies.Location = new Point(3, 2);
            lbl_cookies.Name = "lbl_cookies";
            lbl_cookies.Size = new Size(87, 25);
            lbl_cookies.TabIndex = 0;
            lbl_cookies.Text = "Cookie's:";
            lbl_cookies.Click += lbl_cookies_Click;
            // 
            // shop1
            // 
            shop1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shop1.BackColor = SystemColors.ActiveBorder;
            shop1.BorderStyle = BorderStyle.FixedSingle;
            shop1.Location = new Point(126, 80);
            shop1.MainForm = null;
            shop1.MaximumSize = new Size(524, 400);
            shop1.MinimumSize = new Size(524, 400);
            shop1.Name = "shop1";
            shop1.Size = new Size(524, 400);
            shop1.TabIndex = 6;
            shop1.Load += shop1_Load;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_save.Location = new Point(121, 454);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(81, 34);
            btn_save.TabIndex = 7;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.MiddleRight;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // settings1
            // 
            settings1.BackColor = SystemColors.ActiveBorder;
            settings1.BorderStyle = BorderStyle.FixedSingle;
            settings1.Location = new Point(127, 80);
            settings1.MaximumSize = new Size(524, 400);
            settings1.MinimumSize = new Size(524, 400);
            settings1.Name = "settings1";
            settings1.Size = new Size(524, 400);
            settings1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(663, 494);
            Controls.Add(btn_save);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_cookie);
            Controls.Add(shop1);
            Controls.Add(settings1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(679, 533);
            Name = "Form1";
            Text = "Cookie Clicker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button btn_cookie;
        private Panel panel2;
        private Button btn_home;
        private Button btn_settings;
        private Button btn_shop;
        private Panel panel3;
        private Label lbl_gems;
        private Label lbl_cookies;
        private Label lbl_gem;
        private Label lbl_cookie;
        private Shop shop1;
        private Button btn_save;
        private Settings settings1;
    }
}