using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    partial class FLeader
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
            this.grbInformationLd = new System.Windows.Forms.GroupBox();
            this.txtPasswordLd = new System.Windows.Forms.TextBox();
            this.txtKPILd = new System.Windows.Forms.TextBox();
            this.txtBasicSalaryLd = new System.Windows.Forms.TextBox();
            this.txtAddressLd = new System.Windows.Forms.TextBox();
            this.txtEmailLd = new System.Windows.Forms.TextBox();
            this.txtIDCardLd = new System.Windows.Forms.TextBox();
            this.txtNameLd = new System.Windows.Forms.TextBox();
            this.txtIDLd = new System.Windows.Forms.TextBox();
            this.dtpkDateOfBirthLd = new System.Windows.Forms.DateTimePicker();
            this.lbPasswordLd = new System.Windows.Forms.Label();
            this.lbKPILd = new System.Windows.Forms.Label();
            this.lbBasicSalaryLd = new System.Windows.Forms.Label();
            this.lbAddressLd = new System.Windows.Forms.Label();
            this.lbEmailLd = new System.Windows.Forms.Label();
            this.lbIDCardLd = new System.Windows.Forms.Label();
            this.lbDateOfBirthLd = new System.Windows.Forms.Label();
            this.lbNameLd = new System.Windows.Forms.Label();
            this.lbIDLd = new System.Windows.Forms.Label();
            this.gvLeader = new System.Windows.Forms.DataGridView();
            this.grbOptionLd = new System.Windows.Forms.GroupBox();
            this.btDistributionLd = new System.Windows.Forms.Button();
            this.btSalaryDetailsLd = new System.Windows.Forms.Button();
            this.btKPIDetailsLd = new System.Windows.Forms.Button();
            this.btCheckInOutLd = new System.Windows.Forms.Button();
            this.btAbsenceLetterLd = new System.Windows.Forms.Button();
            this.btListManagerLd = new System.Windows.Forms.Button();
            this.btListStaffLd = new System.Windows.Forms.Button();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.btUpdateLd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grbInformationLd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeader)).BeginInit();
            this.grbOptionLd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInformationLd
            // 
            this.grbInformationLd.Controls.Add(this.flowLayoutPanel1);
            this.grbInformationLd.Controls.Add(this.txtPasswordLd);
            this.grbInformationLd.Controls.Add(this.txtKPILd);
            this.grbInformationLd.Controls.Add(this.txtBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.txtAddressLd);
            this.grbInformationLd.Controls.Add(this.txtEmailLd);
            this.grbInformationLd.Controls.Add(this.txtIDCardLd);
            this.grbInformationLd.Controls.Add(this.txtNameLd);
            this.grbInformationLd.Controls.Add(this.txtIDLd);
            this.grbInformationLd.Controls.Add(this.dtpkDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbPasswordLd);
            this.grbInformationLd.Controls.Add(this.lbKPILd);
            this.grbInformationLd.Controls.Add(this.lbBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.lbAddressLd);
            this.grbInformationLd.Controls.Add(this.lbEmailLd);
            this.grbInformationLd.Controls.Add(this.lbIDCardLd);
            this.grbInformationLd.Controls.Add(this.lbDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbNameLd);
            this.grbInformationLd.Controls.Add(this.lbIDLd);
            this.grbInformationLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbInformationLd.Location = new System.Drawing.Point(1, 1);
            this.grbInformationLd.Name = "grbInformationLd";
            this.grbInformationLd.Size = new System.Drawing.Size(407, 517);
            this.grbInformationLd.TabIndex = 0;
            this.grbInformationLd.TabStop = false;
            this.grbInformationLd.Text = "INFORMATION";
            // 
            // txtPasswordLd
            // 
            this.txtPasswordLd.Location = new System.Drawing.Point(102, 431);
            this.txtPasswordLd.Name = "txtPasswordLd";
            this.txtPasswordLd.Size = new System.Drawing.Size(250, 30);
            this.txtPasswordLd.TabIndex = 17;
            // 
            // txtKPILd
            // 
            this.txtKPILd.Location = new System.Drawing.Point(102, 378);
            this.txtKPILd.Name = "txtKPILd";
            this.txtKPILd.Size = new System.Drawing.Size(250, 30);
            this.txtKPILd.TabIndex = 16;
            // 
            // txtBasicSalaryLd
            // 
            this.txtBasicSalaryLd.Location = new System.Drawing.Point(102, 331);
            this.txtBasicSalaryLd.Name = "txtBasicSalaryLd";
            this.txtBasicSalaryLd.Size = new System.Drawing.Size(250, 30);
            this.txtBasicSalaryLd.TabIndex = 15;
            // 
            // txtAddressLd
            // 
            this.txtAddressLd.Location = new System.Drawing.Point(102, 280);
            this.txtAddressLd.Name = "txtAddressLd";
            this.txtAddressLd.Size = new System.Drawing.Size(250, 30);
            this.txtAddressLd.TabIndex = 14;
            // 
            // txtEmailLd
            // 
            this.txtEmailLd.Location = new System.Drawing.Point(102, 233);
            this.txtEmailLd.Name = "txtEmailLd";
            this.txtEmailLd.Size = new System.Drawing.Size(250, 30);
            this.txtEmailLd.TabIndex = 13;
            // 
            // txtIDCardLd
            // 
            this.txtIDCardLd.Location = new System.Drawing.Point(102, 182);
            this.txtIDCardLd.Name = "txtIDCardLd";
            this.txtIDCardLd.Size = new System.Drawing.Size(250, 30);
            this.txtIDCardLd.TabIndex = 12;
            // 
            // txtNameLd
            // 
            this.txtNameLd.Location = new System.Drawing.Point(102, 85);
            this.txtNameLd.Name = "txtNameLd";
            this.txtNameLd.Size = new System.Drawing.Size(250, 30);
            this.txtNameLd.TabIndex = 11;
            // 
            // txtIDLd
            // 
            this.txtIDLd.Location = new System.Drawing.Point(102, 35);
            this.txtIDLd.Name = "txtIDLd";
            this.txtIDLd.Size = new System.Drawing.Size(250, 30);
            this.txtIDLd.TabIndex = 10;
            // 
            // dtpkDateOfBirthLd
            // 
            this.dtpkDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkDateOfBirthLd.Location = new System.Drawing.Point(102, 145);
            this.dtpkDateOfBirthLd.Name = "dtpkDateOfBirthLd";
            this.dtpkDateOfBirthLd.Size = new System.Drawing.Size(250, 24);
            this.dtpkDateOfBirthLd.TabIndex = 9;
            // 
            // lbPasswordLd
            // 
            this.lbPasswordLd.AutoSize = true;
            this.lbPasswordLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPasswordLd.Location = new System.Drawing.Point(3, 439);
            this.lbPasswordLd.Name = "lbPasswordLd";
            this.lbPasswordLd.Size = new System.Drawing.Size(75, 18);
            this.lbPasswordLd.TabIndex = 8;
            this.lbPasswordLd.Text = "Password";
            // 
            // lbKPILd
            // 
            this.lbKPILd.AutoSize = true;
            this.lbKPILd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKPILd.Location = new System.Drawing.Point(3, 386);
            this.lbKPILd.Name = "lbKPILd";
            this.lbKPILd.Size = new System.Drawing.Size(31, 18);
            this.lbKPILd.TabIndex = 7;
            this.lbKPILd.Text = "KPI";
            // 
            // lbBasicSalaryLd
            // 
            this.lbBasicSalaryLd.AutoSize = true;
            this.lbBasicSalaryLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBasicSalaryLd.Location = new System.Drawing.Point(3, 339);
            this.lbBasicSalaryLd.Name = "lbBasicSalaryLd";
            this.lbBasicSalaryLd.Size = new System.Drawing.Size(88, 18);
            this.lbBasicSalaryLd.TabIndex = 6;
            this.lbBasicSalaryLd.Text = "Basic salary";
            // 
            // lbAddressLd
            // 
            this.lbAddressLd.AutoSize = true;
            this.lbAddressLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddressLd.Location = new System.Drawing.Point(3, 288);
            this.lbAddressLd.Name = "lbAddressLd";
            this.lbAddressLd.Size = new System.Drawing.Size(62, 18);
            this.lbAddressLd.TabIndex = 5;
            this.lbAddressLd.Text = "Address";
            // 
            // lbEmailLd
            // 
            this.lbEmailLd.AutoSize = true;
            this.lbEmailLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmailLd.Location = new System.Drawing.Point(3, 241);
            this.lbEmailLd.Name = "lbEmailLd";
            this.lbEmailLd.Size = new System.Drawing.Size(45, 18);
            this.lbEmailLd.TabIndex = 4;
            this.lbEmailLd.Text = "Email";
            // 
            // lbIDCardLd
            // 
            this.lbIDCardLd.AutoSize = true;
            this.lbIDCardLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIDCardLd.Location = new System.Drawing.Point(3, 190);
            this.lbIDCardLd.Name = "lbIDCardLd";
            this.lbIDCardLd.Size = new System.Drawing.Size(58, 18);
            this.lbIDCardLd.TabIndex = 3;
            this.lbIDCardLd.Text = "ID Card";
            // 
            // lbDateOfBirthLd
            // 
            this.lbDateOfBirthLd.AutoSize = true;
            this.lbDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateOfBirthLd.Location = new System.Drawing.Point(3, 145);
            this.lbDateOfBirthLd.Name = "lbDateOfBirthLd";
            this.lbDateOfBirthLd.Size = new System.Drawing.Size(88, 18);
            this.lbDateOfBirthLd.TabIndex = 2;
            this.lbDateOfBirthLd.Text = "Date of birth";
            // 
            // lbNameLd
            // 
            this.lbNameLd.AutoSize = true;
            this.lbNameLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameLd.Location = new System.Drawing.Point(3, 93);
            this.lbNameLd.Name = "lbNameLd";
            this.lbNameLd.Size = new System.Drawing.Size(48, 18);
            this.lbNameLd.TabIndex = 1;
            this.lbNameLd.Text = "Name";
            // 
            // lbIDLd
            // 
            this.lbIDLd.AutoSize = true;
            this.lbIDLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIDLd.Location = new System.Drawing.Point(3, 43);
            this.lbIDLd.Name = "lbIDLd";
            this.lbIDLd.Size = new System.Drawing.Size(22, 18);
            this.lbIDLd.TabIndex = 0;
            this.lbIDLd.Text = "ID";
            // 
            // gvLeader
            // 
            this.gvLeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLeader.Location = new System.Drawing.Point(414, 1);
            this.gvLeader.Name = "gvLeader";
            this.gvLeader.RowHeadersWidth = 51;
            this.gvLeader.RowTemplate.Height = 29;
            this.gvLeader.Size = new System.Drawing.Size(530, 517);
            this.gvLeader.TabIndex = 1;
            // 
            // grbOptionLd
            // 
            this.grbOptionLd.Controls.Add(this.btDistributionLd);
            this.grbOptionLd.Controls.Add(this.btSalaryDetailsLd);
            this.grbOptionLd.Controls.Add(this.btKPIDetailsLd);
            this.grbOptionLd.Controls.Add(this.btCheckInOutLd);
            this.grbOptionLd.Controls.Add(this.btAbsenceLetterLd);
            this.grbOptionLd.Controls.Add(this.btListManagerLd);
            this.grbOptionLd.Controls.Add(this.btListStaffLd);
            this.grbOptionLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbOptionLd.Location = new System.Drawing.Point(950, 1);
            this.grbOptionLd.Name = "grbOptionLd";
            this.grbOptionLd.Size = new System.Drawing.Size(148, 517);
            this.grbOptionLd.TabIndex = 2;
            this.grbOptionLd.TabStop = false;
            this.grbOptionLd.Text = "Option";
            // 
            // btDistributionLd
            // 
            this.btDistributionLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDistributionLd.Location = new System.Drawing.Point(0, 449);
            this.btDistributionLd.Name = "btDistributionLd";
            this.btDistributionLd.Size = new System.Drawing.Size(142, 49);
            this.btDistributionLd.TabIndex = 9;
            this.btDistributionLd.Text = "Distribution";
            this.btDistributionLd.UseVisualStyleBackColor = true;
            // 
            // btSalaryDetailsLd
            // 
            this.btSalaryDetailsLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalaryDetailsLd.Location = new System.Drawing.Point(0, 378);
            this.btSalaryDetailsLd.Name = "btSalaryDetailsLd";
            this.btSalaryDetailsLd.Size = new System.Drawing.Size(142, 56);
            this.btSalaryDetailsLd.TabIndex = 8;
            this.btSalaryDetailsLd.Text = "Salary Details";
            this.btSalaryDetailsLd.UseVisualStyleBackColor = true;
            // 
            // btKPIDetailsLd
            // 
            this.btKPIDetailsLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btKPIDetailsLd.Location = new System.Drawing.Point(0, 306);
            this.btKPIDetailsLd.Name = "btKPIDetailsLd";
            this.btKPIDetailsLd.Size = new System.Drawing.Size(142, 51);
            this.btKPIDetailsLd.TabIndex = 7;
            this.btKPIDetailsLd.Text = "KPI Details";
            this.btKPIDetailsLd.UseVisualStyleBackColor = true;
            // 
            // btCheckInOutLd
            // 
            this.btCheckInOutLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckInOutLd.Location = new System.Drawing.Point(0, 241);
            this.btCheckInOutLd.Name = "btCheckInOutLd";
            this.btCheckInOutLd.Size = new System.Drawing.Size(142, 48);
            this.btCheckInOutLd.TabIndex = 6;
            this.btCheckInOutLd.Text = "Check In/Out";
            this.btCheckInOutLd.UseVisualStyleBackColor = true;
            // 
            // btAbsenceLetterLd
            // 
            this.btAbsenceLetterLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAbsenceLetterLd.Location = new System.Drawing.Point(0, 174);
            this.btAbsenceLetterLd.Name = "btAbsenceLetterLd";
            this.btAbsenceLetterLd.Size = new System.Drawing.Size(142, 51);
            this.btAbsenceLetterLd.TabIndex = 5;
            this.btAbsenceLetterLd.Text = "Absence Letter";
            this.btAbsenceLetterLd.UseVisualStyleBackColor = true;
            // 
            // btListManagerLd
            // 
            this.btListManagerLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btListManagerLd.Location = new System.Drawing.Point(0, 108);
            this.btListManagerLd.Name = "btListManagerLd";
            this.btListManagerLd.Size = new System.Drawing.Size(142, 55);
            this.btListManagerLd.TabIndex = 4;
            this.btListManagerLd.Text = "List Manager";
            this.btListManagerLd.UseVisualStyleBackColor = true;
            // 
            // btListStaffLd
            // 
            this.btListStaffLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btListStaffLd.Location = new System.Drawing.Point(0, 43);
            this.btListStaffLd.Name = "btListStaffLd";
            this.btListStaffLd.Size = new System.Drawing.Size(142, 50);
            this.btListStaffLd.TabIndex = 3;
            this.btListStaffLd.Text = "List Staff";
            this.btListStaffLd.UseVisualStyleBackColor = true;
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteLd.Location = new System.Drawing.Point(265, 3);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(125, 48);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.Text = "Delete";
            this.btDeleteLd.UseVisualStyleBackColor = true;
            // 
            // btInsertLd
            // 
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInsertLd.Location = new System.Drawing.Point(134, 3);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(125, 48);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.Text = "Insert";
            this.btInsertLd.UseVisualStyleBackColor = true;
            // 
            // btUpdateLd
            // 
            this.btUpdateLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdateLd.Location = new System.Drawing.Point(3, 3);
            this.btUpdateLd.Name = "btUpdateLd";
            this.btUpdateLd.Size = new System.Drawing.Size(125, 48);
            this.btUpdateLd.TabIndex = 0;
            this.btUpdateLd.Text = "Update";
            this.btUpdateLd.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateLd);
            this.flowLayoutPanel1.Controls.Add(this.btInsertLd);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteLd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 460);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 57);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // FLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 520);
            this.Controls.Add(this.grbOptionLd);
            this.Controls.Add(this.gvLeader);
            this.Controls.Add(this.grbInformationLd);
            this.Name = "FLeader";
            this.Text = "FLeader";
            this.grbInformationLd.ResumeLayout(false);
            this.grbInformationLd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeader)).EndInit();
            this.grbOptionLd.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbInformationLd;
        private TextBox txtPasswordLd;
        private TextBox txtKPILd;
        private TextBox txtBasicSalaryLd;
        private TextBox txtAddressLd;
        private TextBox txtEmailLd;
        private TextBox txtIDCardLd;
        private TextBox txtNameLd;
        private TextBox txtIDLd;
        private DateTimePicker dtpkDateOfBirthLd;
        private Label lbPasswordLd;
        private Label lbKPILd;
        private Label lbBasicSalaryLd;
        private Label lbAddressLd;
        private Label lbEmailLd;
        private Label lbIDCardLd;
        private Label lbDateOfBirthLd;
        private Label lbNameLd;
        private Label lbIDLd;
        private DataGridView gvLeader;
        private GroupBox grbOptionLd;
        private Button btDistributionLd;
        private Button btSalaryDetailsLd;
        private Button btKPIDetailsLd;
        private Button btCheckInOutLd;
        private Button btAbsenceLetterLd;
        private Button btListManagerLd;
        private Button btListStaffLd;
        private Button btDeleteLd;
        private Button btInsertLd;
        private Button btUpdateLd;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}