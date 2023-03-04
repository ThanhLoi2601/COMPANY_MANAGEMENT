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
            this.btCheckInOut = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.btPayroll = new System.Windows.Forms.Button();
            this.btAssingedWork = new System.Windows.Forms.Button();
            this.btInform = new System.Windows.Forms.Button();
            this.btChangePass = new System.Windows.Forms.Button();
            this.grOption = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.grOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataStaff
            // 
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(27, 11);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.RowHeadersWidth = 51;
            this.dataStaff.RowTemplate.Height = 24;
            this.dataStaff.Size = new System.Drawing.Size(747, 437);
            this.dataStaff.TabIndex = 14;
            // 
            // btCheckInOut
            // 
            this.btCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckInOut.Location = new System.Drawing.Point(0, 45);
            this.btCheckInOut.Name = "btCheckInOut";
            this.btCheckInOut.Size = new System.Drawing.Size(196, 61);
            this.btCheckInOut.TabIndex = 21;
            this.btCheckInOut.Text = "CHECK IN/OUT";
            this.btCheckInOut.UseVisualStyleBackColor = true;
            this.btCheckInOut.Click += new System.EventHandler(this.btCheckInOut_Click);
            // 
            // btLetter
            // 
            this.btLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLetter.Location = new System.Drawing.Point(0, 112);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(196, 56);
            this.btLetter.TabIndex = 22;
            this.btLetter.Text = "ABSENCE LETTER";
            this.btLetter.UseVisualStyleBackColor = true;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click);
            // 
            // btPayroll
            // 
            this.btPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayroll.Location = new System.Drawing.Point(0, 174);
            this.btPayroll.Name = "btPayroll";
            this.btPayroll.Size = new System.Drawing.Size(196, 55);
            this.btPayroll.TabIndex = 23;
            this.btPayroll.Text = "SALARY DETAILS";
            this.btPayroll.UseVisualStyleBackColor = true;
            // 
            // btAssingedWork
            // 
            this.btAssingedWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAssingedWork.Location = new System.Drawing.Point(0, 235);
            this.btAssingedWork.Name = "btAssingedWork";
            this.btAssingedWork.Size = new System.Drawing.Size(196, 57);
            this.btAssingedWork.TabIndex = 24;
            this.btAssingedWork.Text = "ASSINGED WORK";
            this.btAssingedWork.UseVisualStyleBackColor = true;
            this.btAssingedWork.Click += new System.EventHandler(this.btAssingedWork_Click);
            // 
            // btInform
            // 
            this.btInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInform.Location = new System.Drawing.Point(0, 298);
            this.btInform.Name = "btInform";
            this.btInform.Size = new System.Drawing.Size(196, 55);
            this.btInform.TabIndex = 26;
            this.btInform.Text = "VIEW PERSONAL INFORMATION";
            this.btInform.UseVisualStyleBackColor = true;
            this.btInform.Click += new System.EventHandler(this.btInform_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.Location = new System.Drawing.Point(0, 359);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(196, 58);
            this.btChangePass.TabIndex = 27;
            this.btChangePass.Text = "CHANGE PASSWORD";
            this.btChangePass.UseVisualStyleBackColor = true;
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // grOption
            // 
            this.grOption.Controls.Add(this.btCheckInOut);
            this.grOption.Controls.Add(this.btLetter);
            this.grOption.Controls.Add(this.btChangePass);
            this.grOption.Controls.Add(this.btPayroll);
            this.grOption.Controls.Add(this.btInform);
            this.grOption.Controls.Add(this.btAssingedWork);
            this.grOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grOption.Location = new System.Drawing.Point(843, 11);
            this.grOption.Name = "grOption";
            this.grOption.Size = new System.Drawing.Size(196, 437);
            this.grOption.TabIndex = 29;
            this.grOption.TabStop = false;
            this.grOption.Text = "OPTION";
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 472);
            this.Controls.Add(this.grOption);
            this.Controls.Add(this.dataStaff);
            this.Name = "FStaff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.grOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.Button btCheckInOut;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Button btPayroll;
        private System.Windows.Forms.Button btAssingedWork;
        private System.Windows.Forms.Button btInform;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.GroupBox grOption;
    }
}

