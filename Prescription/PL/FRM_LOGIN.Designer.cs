namespace Prescription.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 56);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuThinButton27);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(291, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 391);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(109, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المستخدم";
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.HintForeColor = System.Drawing.Color.Empty;
            this.txt_username.HintText = "";
            this.txt_username.isPassword = false;
            this.txt_username.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_username.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_username.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_username.LineThickness = 3;
            this.txt_username.Location = new System.Drawing.Point(-3, 155);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(242, 30);
            this.txt_username.TabIndex = 3;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(151, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "كلمة السر";
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = true;
            this.txt_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(-3, 273);
            this.txt_password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(242, 30);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuThinButton27.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "تسجيل الدخول";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton27.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.Location = new System.Drawing.Point(8, 330);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(228, 54);
            this.bunifuThinButton27.TabIndex = 6;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(825, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FRM_LOGIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
    }
}