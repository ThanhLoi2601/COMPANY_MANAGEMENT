﻿namespace COMPANY_MANAGEMENT
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
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbLeader = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labMaDN = new System.Windows.Forms.Label();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.labMK = new System.Windows.Forms.Label();
            this.btDNhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.Location = new System.Drawing.Point(0, 21);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(65, 24);
            this.rbStaff.TabIndex = 0;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(111, 21);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(95, 24);
            this.rbManager.TabIndex = 1;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbLeader
            // 
            this.rbLeader.AutoSize = true;
            this.rbLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeader.Location = new System.Drawing.Point(255, 21);
            this.rbLeader.Name = "rbLeader";
            this.rbLeader.Size = new System.Drawing.Size(82, 24);
            this.rbLeader.TabIndex = 3;
            this.rbLeader.TabStop = true;
            this.rbLeader.Text = "Leader";
            this.rbLeader.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStaff);
            this.groupBox1.Controls.Add(this.rbLeader);
            this.groupBox1.Controls.Add(this.rbManager);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDNhap);
            this.groupBox2.Controls.Add(this.txtMK);
            this.groupBox2.Controls.Add(this.labMK);
            this.groupBox2.Controls.Add(this.txtMaDN);
            this.groupBox2.Controls.Add(this.labMaDN);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 256);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐĂNG NHẬP";
            // 
            // labMaDN
            // 
            this.labMaDN.AutoSize = true;
            this.labMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaDN.Location = new System.Drawing.Point(16, 103);
            this.labMaDN.Name = "labMaDN";
            this.labMaDN.Size = new System.Drawing.Size(126, 20);
            this.labMaDN.TabIndex = 5;
            this.labMaDN.Text = "Mã đăng nhập";
            // 
            // txtMaDN
            // 
            this.txtMaDN.Location = new System.Drawing.Point(168, 96);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(261, 30);
            this.txtMaDN.TabIndex = 6;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(168, 153);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(261, 27);
            this.txtMK.TabIndex = 8;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // labMK
            // 
            this.labMK.AutoSize = true;
            this.labMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMK.Location = new System.Drawing.Point(16, 160);
            this.labMK.Name = "labMK";
            this.labMK.Size = new System.Drawing.Size(85, 20);
            this.labMK.TabIndex = 7;
            this.labMK.Text = "Mật khẩu";
            // 
            // btDNhap
            // 
            this.btDNhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDNhap.Location = new System.Drawing.Point(349, 197);
            this.btDNhap.Name = "btDNhap";
            this.btDNhap.Size = new System.Drawing.Size(144, 48);
            this.btDNhap.TabIndex = 9;
            this.btDNhap.Text = "Đăng nhập";
            this.btDNhap.UseVisualStyleBackColor = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 262);
            this.Controls.Add(this.groupBox2);
            this.Name = "FLogin";
            this.Text = "LOG IN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbLeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label labMK;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.Label labMaDN;
        private System.Windows.Forms.Button btDNhap;
    }
}

