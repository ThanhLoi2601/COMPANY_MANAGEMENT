namespace COMPANY_MANAGEMENT
{
    partial class FManager
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labHoTen = new System.Windows.Forms.Label();
            this.dGVStaff = new System.Windows.Forms.DataGridView();
            this.grOption = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btDistribution = new System.Windows.Forms.Button();
            this.btSalary = new System.Windows.Forms.Button();
            this.btKPI = new System.Windows.Forms.Button();
            this.btMyInfo = new System.Windows.Forms.Button();
            this.btCheckIn_Out = new System.Windows.Forms.Button();
            this.btJob = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.grInfo.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).BeginInit();
            this.grOption.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.grInfo);
            this.flowLayoutPanel1.Controls.Add(this.dGVStaff);
            this.flowLayoutPanel1.Controls.Add(this.grOption);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1471, 517);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.flowLayoutPanel3);
            this.grInfo.Controls.Add(this.txtPass);
            this.grInfo.Controls.Add(this.label8);
            this.grInfo.Controls.Add(this.txtKPI);
            this.grInfo.Controls.Add(this.label7);
            this.grInfo.Controls.Add(this.txtBasicSalary);
            this.grInfo.Controls.Add(this.txtAddress);
            this.grInfo.Controls.Add(this.label6);
            this.grInfo.Controls.Add(this.label5);
            this.grInfo.Controls.Add(this.txtIDCard);
            this.grInfo.Controls.Add(this.label4);
            this.grInfo.Controls.Add(this.txtEmail);
            this.grInfo.Controls.Add(this.label3);
            this.grInfo.Controls.Add(this.dtBirth);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.txtID);
            this.grInfo.Controls.Add(this.labHoTen);
            this.grInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfo.Location = new System.Drawing.Point(3, 3);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(412, 504);
            this.grInfo.TabIndex = 1;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "INFORMATION";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btUpdate);
            this.flowLayoutPanel3.Controls.Add(this.btInsert);
            this.flowLayoutPanel3.Controls.Add(this.btDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 453);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(409, 45);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(3, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(128, 42);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(137, 3);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(127, 42);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(270, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(128, 42);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(100, 418);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(238, 24);
            this.txtPass.TabIndex = 16;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // txtKPI
            // 
            this.txtKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKPI.Location = new System.Drawing.Point(100, 375);
            this.txtKPI.Name = "txtKPI";
            this.txtKPI.Size = new System.Drawing.Size(238, 24);
            this.txtKPI.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "KPI";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.Location = new System.Drawing.Point(100, 331);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(238, 24);
            this.txtBasicSalary.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(100, 283);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 24);
            this.txtAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Basic salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.Location = new System.Drawing.Point(100, 178);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(238, 24);
            this.txtIDCard.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID card";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(100, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // dtBirth
            // 
            this.dtBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirth.Location = new System.Drawing.Point(100, 135);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(238, 24);
            this.dtBirth.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(100, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 24);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of birth";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(100, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 24);
            this.txtID.TabIndex = 1;
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoTen.Location = new System.Drawing.Point(6, 39);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(22, 18);
            this.labHoTen.TabIndex = 0;
            this.labHoTen.Text = "ID";
            // 
            // dGVStaff
            // 
            this.dGVStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStaff.Location = new System.Drawing.Point(421, 3);
            this.dGVStaff.Name = "dGVStaff";
            this.dGVStaff.RowHeadersWidth = 51;
            this.dGVStaff.RowTemplate.Height = 24;
            this.dGVStaff.Size = new System.Drawing.Size(849, 504);
            this.dGVStaff.TabIndex = 0;
            this.dGVStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVStaff_CellClick);
            // 
            // grOption
            // 
            this.grOption.Controls.Add(this.flowLayoutPanel2);
            this.grOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grOption.Location = new System.Drawing.Point(1276, 3);
            this.grOption.Name = "grOption";
            this.grOption.Size = new System.Drawing.Size(181, 504);
            this.grOption.TabIndex = 0;
            this.grOption.TabStop = false;
            this.grOption.Text = "OPTION";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btDistribution);
            this.flowLayoutPanel2.Controls.Add(this.btSalary);
            this.flowLayoutPanel2.Controls.Add(this.btKPI);
            this.flowLayoutPanel2.Controls.Add(this.btMyInfo);
            this.flowLayoutPanel2.Controls.Add(this.btCheckIn_Out);
            this.flowLayoutPanel2.Controls.Add(this.btJob);
            this.flowLayoutPanel2.Controls.Add(this.btLetter);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(181, 459);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // btDistribution
            // 
            this.btDistribution.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDistribution.Location = new System.Drawing.Point(3, 3);
            this.btDistribution.Name = "btDistribution";
            this.btDistribution.Size = new System.Drawing.Size(175, 58);
            this.btDistribution.TabIndex = 8;
            this.btDistribution.Text = "DISTRIBUTION";
            this.btDistribution.UseVisualStyleBackColor = false;
            this.btDistribution.Click += new System.EventHandler(this.btDistribution_Click);
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalary.Location = new System.Drawing.Point(3, 67);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(175, 58);
            this.btSalary.TabIndex = 7;
            this.btSalary.Text = "SALARY DATAILS";
            this.btSalary.UseVisualStyleBackColor = false;
            this.btSalary.Click += new System.EventHandler(this.btSalary_Click);
            // 
            // btKPI
            // 
            this.btKPI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKPI.Location = new System.Drawing.Point(3, 131);
            this.btKPI.Name = "btKPI";
            this.btKPI.Size = new System.Drawing.Size(175, 58);
            this.btKPI.TabIndex = 6;
            this.btKPI.Text = "KPI DETAILS";
            this.btKPI.UseVisualStyleBackColor = false;
            this.btKPI.Click += new System.EventHandler(this.btKPI_Click);
            // 
            // btMyInfo
            // 
            this.btMyInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMyInfo.Location = new System.Drawing.Point(3, 195);
            this.btMyInfo.Name = "btMyInfo";
            this.btMyInfo.Size = new System.Drawing.Size(175, 57);
            this.btMyInfo.TabIndex = 3;
            this.btMyInfo.Text = "MY INFORMATION";
            this.btMyInfo.UseVisualStyleBackColor = false;
            this.btMyInfo.Click += new System.EventHandler(this.btMyInfo_Click);
            // 
            // btCheckIn_Out
            // 
            this.btCheckIn_Out.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCheckIn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckIn_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckIn_Out.Location = new System.Drawing.Point(3, 258);
            this.btCheckIn_Out.Name = "btCheckIn_Out";
            this.btCheckIn_Out.Size = new System.Drawing.Size(175, 68);
            this.btCheckIn_Out.TabIndex = 5;
            this.btCheckIn_Out.Text = "CHECK IN/OUT";
            this.btCheckIn_Out.UseVisualStyleBackColor = false;
            this.btCheckIn_Out.Click += new System.EventHandler(this.btCheckIn_Out_Click);
            // 
            // btJob
            // 
            this.btJob.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJob.Location = new System.Drawing.Point(3, 332);
            this.btJob.Name = "btJob";
            this.btJob.Size = new System.Drawing.Size(175, 53);
            this.btJob.TabIndex = 9;
            this.btJob.Text = "JOB";
            this.btJob.UseVisualStyleBackColor = false;
            this.btJob.Click += new System.EventHandler(this.btJob_Click);
            // 
            // btLetter
            // 
            this.btLetter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLetter.Location = new System.Drawing.Point(3, 391);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(175, 53);
            this.btLetter.TabIndex = 10;
            this.btLetter.Text = "ABSENCE LETTER";
            this.btLetter.UseVisualStyleBackColor = false;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click);
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 517);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FManager";
            this.Text = "MANAGER";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).EndInit();
            this.grOption.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.DataGridView dGVStaff;
        private System.Windows.Forms.GroupBox grOption;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btKPI;
        private System.Windows.Forms.Button btCheckIn_Out;
        private System.Windows.Forms.Button btMyInfo;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSalary;
        private System.Windows.Forms.Button btDistribution;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btJob;
        private System.Windows.Forms.Button btLetter;
    }
}