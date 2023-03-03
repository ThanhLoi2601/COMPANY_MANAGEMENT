namespace COMPANY_MANAGEMENT
{
    partial class FStaff
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
            this.dataStaff = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStaff
            // 
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(27, 11);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.RowHeadersWidth = 51;
            this.dataStaff.RowTemplate.Height = 24;
            this.dataStaff.Size = new System.Drawing.Size(736, 470);
            this.dataStaff.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "CheckIn/Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Absence letter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(869, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Payroll";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(869, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Assigned work";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(869, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "View personal information";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(869, 458);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Change password";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textOp
            // 
            this.textOp.AutoSize = true;
            this.textOp.Location = new System.Drawing.Point(866, 11);
            this.textOp.Name = "textOp";
            this.textOp.Size = new System.Drawing.Size(67, 16);
            this.textOp.TabIndex = 28;
            this.textOp.Text = "OPTIONS";
            this.textOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 493);
            this.Controls.Add(this.textOp);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataStaff);
            this.Name = "FStaff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label textOp;
    }
}

