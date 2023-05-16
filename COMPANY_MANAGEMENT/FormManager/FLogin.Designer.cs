namespace COMPANY_MANAGEMENT
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.btDNhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.labMK = new System.Windows.Forms.Label();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.labMaDN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbLeader = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHienMK
            // 
            this.cbHienMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHienMK.ForeColor = System.Drawing.Color.White;
            this.cbHienMK.Location = new System.Drawing.Point(585, 291);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(4);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(137, 22);
            this.cbHienMK.TabIndex = 17;
            this.cbHienMK.Text = "Show password";
            this.cbHienMK.UseVisualStyleBackColor = false;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            this.cbHienMK.TextChanged += new System.EventHandler(this.cbHienMK_TextChanged);
            // 
            // btDNhap
            // 
            this.btDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btDNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btDNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDNhap.ForeColor = System.Drawing.Color.White;
            this.btDNhap.Location = new System.Drawing.Point(572, 382);
            this.btDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btDNhap.Name = "btDNhap";
            this.btDNhap.Size = new System.Drawing.Size(155, 42);
            this.btDNhap.TabIndex = 16;
            this.btDNhap.Text = "Login";
            this.btDNhap.UseVisualStyleBackColor = false;
            this.btDNhap.Click += new System.EventHandler(this.btDNhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.Color.Gray;
            this.txtMK.Location = new System.Drawing.Point(585, 244);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(257, 27);
            this.txtMK.TabIndex = 15;
            this.txtMK.Text = "Enter password";
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.Click += new System.EventHandler(this.txtMK_Click);
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.Enter += new System.EventHandler(this.txtMK_Enter);
            this.txtMK.Leave += new System.EventHandler(this.txtMK_Leave);
            // 
            // labMK
            // 
            this.labMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMK.AutoSize = true;
            this.labMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMK.ForeColor = System.Drawing.SystemColors.Control;
            this.labMK.Location = new System.Drawing.Point(451, 251);
            this.labMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMK.Name = "labMK";
            this.labMK.Size = new System.Drawing.Size(91, 20);
            this.labMK.TabIndex = 14;
            this.labMK.Text = "Password";
            // 
            // txtMaDN
            // 
            this.txtMaDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDN.ForeColor = System.Drawing.Color.Gray;
            this.txtMaDN.Location = new System.Drawing.Point(585, 187);
            this.txtMaDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(257, 27);
            this.txtMaDN.TabIndex = 13;
            this.txtMaDN.Text = "Enter username";
            this.txtMaDN.Click += new System.EventHandler(this.txtMaDN_Click);
            this.txtMaDN.TextChanged += new System.EventHandler(this.txtMaDN_TextChanged);
            this.txtMaDN.Enter += new System.EventHandler(this.txtMaDN_Enter);
            this.txtMaDN.Leave += new System.EventHandler(this.txtMaDN_Leave);
            // 
            // labMaDN
            // 
            this.labMaDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMaDN.AutoSize = true;
            this.labMaDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaDN.ForeColor = System.Drawing.SystemColors.Control;
            this.labMaDN.Location = new System.Drawing.Point(451, 194);
            this.labMaDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMaDN.Name = "labMaDN";
            this.labMaDN.Size = new System.Drawing.Size(100, 20);
            this.labMaDN.TabIndex = 12;
            this.labMaDN.Text = "User name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.rbStaff);
            this.groupBox1.Controls.Add(this.rbLeader);
            this.groupBox1.Controls.Add(this.rbManager);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(407, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(435, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(8, 26);
            this.rbStaff.Margin = new System.Windows.Forms.Padding(4);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(70, 24);
            this.rbStaff.TabIndex = 0;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbLeader
            // 
            this.rbLeader.AutoSize = true;
            this.rbLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeader.Location = new System.Drawing.Point(319, 26);
            this.rbLeader.Margin = new System.Windows.Forms.Padding(4);
            this.rbLeader.Name = "rbLeader";
            this.rbLeader.Size = new System.Drawing.Size(88, 24);
            this.rbLeader.TabIndex = 3;
            this.rbLeader.TabStop = true;
            this.rbLeader.Text = "Leader";
            this.rbLeader.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(147, 26);
            this.rbManager.Margin = new System.Windows.Forms.Padding(4);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(102, 24);
            this.rbManager.TabIndex = 1;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 42);
            this.panel1.TabIndex = 18;
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Image = global::COMPANY_MANAGEMENT.Properties.Resources.minimize_window_30px;
            this.btMin.Location = new System.Drawing.Point(707, 3);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(79, 37);
            this.btMin.TabIndex = 6;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::COMPANY_MANAGEMENT.Properties.Resources.close_window_30px;
            this.btClose.Location = new System.Drawing.Point(801, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(79, 34);
            this.btClose.TabIndex = 4;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 429);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::COMPANY_MANAGEMENT.Properties.Resources.business_logo_design_template_78655edda18bc1196ab28760f1535baa_screen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::COMPANY_MANAGEMENT.Properties.Resources.password_20px;
            this.pictureBox3.Location = new System.Drawing.Point(407, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::COMPANY_MANAGEMENT.Properties.Resources.user_9px;
            this.pictureBox2.Location = new System.Drawing.Point(406, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(895, 471);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btDNhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.labMK);
            this.Controls.Add(this.txtMaDN);
            this.Controls.Add(this.labMaDN);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLogin";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.Button btDNhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label labMK;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.Label labMaDN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbLeader;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btClose;
    }
}
