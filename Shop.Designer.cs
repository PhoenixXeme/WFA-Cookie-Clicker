namespace WFA_Clicker
{
    partial class Shop
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            lbl_stoneUpgOwned = new Label();
            btn_stoneUpgBuy = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 8);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Shop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 4);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Click Upgrade's";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbl_stoneUpgOwned);
            panel2.Controls.Add(btn_stoneUpgBuy);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 328);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 38);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Cost Own";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 60);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "40";
            // 
            // lbl_stoneUpgOwned
            // 
            lbl_stoneUpgOwned.AutoSize = true;
            lbl_stoneUpgOwned.Location = new Point(150, 60);
            lbl_stoneUpgOwned.Name = "lbl_stoneUpgOwned";
            lbl_stoneUpgOwned.Size = new Size(13, 15);
            lbl_stoneUpgOwned.TabIndex = 4;
            lbl_stoneUpgOwned.Text = "0";
            // 
            // btn_stoneUpgBuy
            // 
            btn_stoneUpgBuy.FlatStyle = FlatStyle.Flat;
            btn_stoneUpgBuy.Location = new Point(3, 56);
            btn_stoneUpgBuy.Name = "btn_stoneUpgBuy";
            btn_stoneUpgBuy.Size = new Size(116, 23);
            btn_stoneUpgBuy.TabIndex = 3;
            btn_stoneUpgBuy.Text = "Stone (+1)";
            btn_stoneUpgBuy.UseVisualStyleBackColor = true;
            btn_stoneUpgBuy.Click += btn_stoneUpgBuy_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(524, 400);
            MinimumSize = new Size(524, 400);
            Name = "Shop";
            Size = new Size(522, 398);
            Load += Shop_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Button btn_stoneUpgBuy;
        private Label lbl_stoneUpgOwned;
        private Label label4;
        private Label label2;
    }
}
