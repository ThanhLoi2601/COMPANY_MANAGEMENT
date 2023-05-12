namespace COMPANY_MANAGEMENT.FormStaff1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAnnounce = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btChangePass = new System.Windows.Forms.Button();
            this.btInform = new System.Windows.Forms.Button();
            this.btPayroll = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.btCheckInOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataStaff
            // 
            this.dataStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(0, 76);
            this.dataStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.ReadOnly = true;
            this.dataStaff.RowHeadersWidth = 51;
            this.dataStaff.RowTemplate.Height = 24;
            this.dataStaff.Size = new System.Drawing.Size(1334, 670);
            this.dataStaff.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.btAnnounce);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btChangePass);
            this.panel1.Controls.Add(this.btInform);
            this.panel1.Controls.Add(this.btPayroll);
            this.panel1.Controls.Add(this.btLetter);
            this.panel1.Controls.Add(this.btCheckInOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 792);
            this.panel1.TabIndex = 30;
            // 
            // btAnnounce
            // 
            this.btAnnounce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAnnounce.FlatAppearance.BorderSize = 0;
            this.btAnnounce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnounce.ForeColor = System.Drawing.Color.White;
            this.btAnnounce.Image = global::COMPANY_MANAGEMENT.Properties.Resources.commercial_26px;
            this.btAnnounce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnounce.Location = new System.Drawing.Point(0, 675);
            this.btAnnounce.Margin = new System.Windows.Forms.Padding(4);
            this.btAnnounce.Name = "btAnnounce";
            this.btAnnounce.Size = new System.Drawing.Size(284, 84);
            this.btAnnounce.TabIndex = 38;
            this.btAnnounce.Text = "ANNOUNCEMENT";
            this.btAnnounce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAnnounce.UseVisualStyleBackColor = true;
            this.btAnnounce.Click += new System.EventHandler(this.btAnnounce_Click);
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::COMPANY_MANAGEMENT.Properties.Resources.home_26px;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 591);
            this.btHome.Margin = new System.Windows.Forms.Padding(4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(284, 84);
            this.btHome.TabIndex = 37;
            this.btHome.Text = "HOME";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChangePass.FlatAppearance.BorderSize = 0;
            this.btChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.ForeColor = System.Drawing.Color.White;
            this.btChangePass.Image = global::COMPANY_MANAGEMENT.Properties.Resources.password_26px;
            this.btChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChangePass.Location = new System.Drawing.Point(0, 515);
            this.btChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(284, 76);
            this.btChangePass.TabIndex = 36;
            this.btChangePass.Text = "CHANGE PASSWORD";
            this.btChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChangePass.UseVisualStyleBackColor = true;
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click_1);
            // 
            // btInform
            // 
            this.btInform.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInform.FlatAppearance.BorderSize = 0;
            this.btInform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInform.ForeColor = System.Drawing.Color.White;
            this.btInform.Image = global::COMPANY_MANAGEMENT.Properties.Resources.profile_26px;
            this.btInform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInform.Location = new System.Drawing.Point(0, 439);
            this.btInform.Margin = new System.Windows.Forms.Padding(4);
            this.btInform.Name = "btInform";
            this.btInform.Size = new System.Drawing.Size(284, 76);
            this.btInform.TabIndex = 35;
            this.btInform.Text = "INFORMATION";
            this.btInform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInform.UseVisualStyleBackColor = true;
            this.btInform.Click += new System.EventHandler(this.btInform_Click_1);
            // 
            // btPayroll
            // 
            this.btPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPayroll.FlatAppearance.BorderSize = 0;
            this.btPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayroll.ForeColor = System.Drawing.Color.White;
            this.btPayroll.Image = global::COMPANY_MANAGEMENT.Properties.Resources.money_transfer_26px;
            this.btPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPayroll.Location = new System.Drawing.Point(0, 363);
            this.btPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.btPayroll.Name = "btPayroll";
            this.btPayroll.Size = new System.Drawing.Size(284, 76);
            this.btPayroll.TabIndex = 34;
            this.btPayroll.Text = "PAYROLL";
            this.btPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPayroll.UseVisualStyleBackColor = true;
            this.btPayroll.Click += new System.EventHandler(this.btPayroll_Click_1);
            // 
            // btLetter
            // 
            this.btLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLetter.FlatAppearance.BorderSize = 0;
            this.btLetter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLetter.ForeColor = System.Drawing.Color.White;
            this.btLetter.Image = global::COMPANY_MANAGEMENT.Properties.Resources.leave_26px1;
            this.btLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLetter.Location = new System.Drawing.Point(0, 287);
            this.btLetter.Margin = new System.Windows.Forms.Padding(4);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(284, 76);
            this.btLetter.TabIndex = 33;
            this.btLetter.Text = "ABSENCE LETTER";
            this.btLetter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLetter.UseVisualStyleBackColor = true;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click_1);
            // 
            // btCheckInOut
            // 
            this.btCheckInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCheckInOut.FlatAppearance.BorderSize = 0;
            this.btCheckInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btCheckInOut.Image = global::COMPANY_MANAGEMENT.Properties.Resources.checkmark_26px;
            this.btCheckInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckInOut.Location = new System.Drawing.Point(0, 206);
            this.btCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.btCheckInOut.Name = "btCheckInOut";
            this.btCheckInOut.Size = new System.Drawing.Size(284, 81);
            this.btCheckInOut.TabIndex = 21;
            this.btCheckInOut.Text = "CHECK IN/OUT";
            this.btCheckInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCheckInOut.UseVisualStyleBackColor = true;
            this.btCheckInOut.Click += new System.EventHandler(this.btCheckInOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 206);
            this.panel3.TabIndex = 32;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(64, 31);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(148, 144);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 42);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 48);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "DANH SÁCH CÔNG VIỆC ĐƯỢC PHÂN CÔNG";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dataStaff);
            this.panel5.Location = new System.Drawing.Point(284, 46);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1334, 746);
            this.panel5.TabIndex = 33;
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1618, 792);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FStaff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.FStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Button btInform;
        private System.Windows.Forms.Button btPayroll;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Button btCheckInOut;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btAnnounce;
    }
}
