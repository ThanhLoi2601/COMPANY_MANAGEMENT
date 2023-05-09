using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.FormLeader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListManager = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.grbInformationLd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDManager = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateLd = new System.Windows.Forms.Button();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.txtPasswordLd = new System.Windows.Forms.TextBox();
            this.txtBasicSalaryLd = new System.Windows.Forms.TextBox();
            this.txtAddressLd = new System.Windows.Forms.TextBox();
            this.txtEmailLd = new System.Windows.Forms.TextBox();
            this.txtIDCardLd = new System.Windows.Forms.TextBox();
            this.txtNameLd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpkDateOfBirthLd = new System.Windows.Forms.DateTimePicker();
            this.lbPasswordLd = new System.Windows.Forms.Label();
            this.lbBasicSalaryLd = new System.Windows.Forms.Label();
            this.lbAddressLd = new System.Windows.Forms.Label();
            this.lbEmailLd = new System.Windows.Forms.Label();
            this.lbIDCardLd = new System.Windows.Forms.Label();
            this.lbDateOfBirthLd = new System.Windows.Forms.Label();
            this.lbNameLd = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAbsenceLetterLd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btDistributionLd = new System.Windows.Forms.Button();
            this.btContact = new System.Windows.Forms.Button();
            this.btMyInfor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.grbInformationLd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvListManager);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(581, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(677, 534);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Manager";
            // 
            // dgvListManager
            // 
            this.dgvListManager.BackgroundColor = System.Drawing.Color.White;
            this.dgvListManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListManager.Location = new System.Drawing.Point(6, 27);
            this.dgvListManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListManager.Name = "dgvListManager";
            this.dgvListManager.RowHeadersWidth = 51;
            this.dgvListManager.RowTemplate.Height = 29;
            this.dgvListManager.Size = new System.Drawing.Size(671, 242);
            this.dgvListManager.TabIndex = 0;
            this.dgvListManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListManager_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvListStaff);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox2.Location = new System.Drawing.Point(0, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(677, 263);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Staff";
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStaff.Location = new System.Drawing.Point(6, 27);
            this.dgvListStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.RowHeadersWidth = 51;
            this.dgvListStaff.RowTemplate.Height = 29;
            this.dgvListStaff.Size = new System.Drawing.Size(671, 240);
            this.dgvListStaff.TabIndex = 1;
            this.dgvListStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellClick);
            // 
            // grbInformationLd
            // 
            this.grbInformationLd.BackColor = System.Drawing.Color.White;
            this.grbInformationLd.Controls.Add(this.label1);
            this.grbInformationLd.Controls.Add(this.txtIDManager);
            this.grbInformationLd.Controls.Add(this.flowLayoutPanel1);
            this.grbInformationLd.Controls.Add(this.txtPasswordLd);
            this.grbInformationLd.Controls.Add(this.txtBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.txtAddressLd);
            this.grbInformationLd.Controls.Add(this.txtEmailLd);
            this.grbInformationLd.Controls.Add(this.txtIDCardLd);
            this.grbInformationLd.Controls.Add(this.txtNameLd);
            this.grbInformationLd.Controls.Add(this.txtID);
            this.grbInformationLd.Controls.Add(this.dtpkDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbPasswordLd);
            this.grbInformationLd.Controls.Add(this.lbBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.lbAddressLd);
            this.grbInformationLd.Controls.Add(this.lbEmailLd);
            this.grbInformationLd.Controls.Add(this.lbIDCardLd);
            this.grbInformationLd.Controls.Add(this.lbDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbNameLd);
            this.grbInformationLd.Controls.Add(this.lbID);
            this.grbInformationLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grbInformationLd.Location = new System.Drawing.Point(6, 68);
            this.grbInformationLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInformationLd.Name = "grbInformationLd";
            this.grbInformationLd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInformationLd.Size = new System.Drawing.Size(536, 533);
            this.grbInformationLd.TabIndex = 5;
            this.grbInformationLd.TabStop = false;
            this.grbInformationLd.Text = "INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(60, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Manager";
            // 
            // txtIDManager
            // 
            this.txtIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIDManager.Location = new System.Drawing.Point(159, 387);
            this.txtIDManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDManager.Name = "txtIDManager";
            this.txtIDManager.Size = new System.Drawing.Size(294, 27);
            this.txtIDManager.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateLd);
            this.flowLayoutPanel1.Controls.Add(this.btInsertLd);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteLd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(63, 465);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 46);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btUpdateLd
            // 
            this.btUpdateLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btUpdateLd.Location = new System.Drawing.Point(3, 2);
            this.btUpdateLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdateLd.Name = "btUpdateLd";
            this.btUpdateLd.Size = new System.Drawing.Size(125, 38);
            this.btUpdateLd.TabIndex = 0;
            this.btUpdateLd.Text = "Update";
            this.btUpdateLd.UseVisualStyleBackColor = true;
            // 
            // btInsertLd
            // 
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btInsertLd.Location = new System.Drawing.Point(134, 2);
            this.btInsertLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(125, 38);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.Text = "Insert";
            this.btInsertLd.UseVisualStyleBackColor = true;
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDeleteLd.Location = new System.Drawing.Point(265, 2);
            this.btDeleteLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(125, 38);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.Text = "Delete";
            this.btDeleteLd.UseVisualStyleBackColor = true;
            // 
            // txtPasswordLd
            // 
            this.txtPasswordLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPasswordLd.Location = new System.Drawing.Point(159, 431);
            this.txtPasswordLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordLd.Name = "txtPasswordLd";
            this.txtPasswordLd.Size = new System.Drawing.Size(294, 27);
            this.txtPasswordLd.TabIndex = 17;
            this.txtPasswordLd.UseSystemPasswordChar = true;
            // 
            // txtBasicSalaryLd
            // 
            this.txtBasicSalaryLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBasicSalaryLd.Location = new System.Drawing.Point(159, 338);
            this.txtBasicSalaryLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBasicSalaryLd.Name = "txtBasicSalaryLd";
            this.txtBasicSalaryLd.Size = new System.Drawing.Size(294, 27);
            this.txtBasicSalaryLd.TabIndex = 15;
            // 
            // txtAddressLd
            // 
            this.txtAddressLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtAddressLd.Location = new System.Drawing.Point(159, 293);
            this.txtAddressLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressLd.Name = "txtAddressLd";
            this.txtAddressLd.Size = new System.Drawing.Size(294, 27);
            this.txtAddressLd.TabIndex = 14;
            // 
            // txtEmailLd
            // 
            this.txtEmailLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtEmailLd.Location = new System.Drawing.Point(159, 247);
            this.txtEmailLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailLd.Name = "txtEmailLd";
            this.txtEmailLd.Size = new System.Drawing.Size(294, 27);
            this.txtEmailLd.TabIndex = 13;
            // 
            // txtIDCardLd
            // 
            this.txtIDCardLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIDCardLd.Location = new System.Drawing.Point(159, 200);
            this.txtIDCardLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCardLd.Name = "txtIDCardLd";
            this.txtIDCardLd.Size = new System.Drawing.Size(294, 27);
            this.txtIDCardLd.TabIndex = 12;
            // 
            // txtNameLd
            // 
            this.txtNameLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNameLd.Location = new System.Drawing.Point(159, 109);
            this.txtNameLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameLd.Name = "txtNameLd";
            this.txtNameLd.Size = new System.Drawing.Size(294, 27);
            this.txtNameLd.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID.Location = new System.Drawing.Point(159, 69);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(294, 27);
            this.txtID.TabIndex = 10;
            // 
            // dtpkDateOfBirthLd
            // 
            this.dtpkDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpkDateOfBirthLd.Location = new System.Drawing.Point(159, 157);
            this.dtpkDateOfBirthLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDateOfBirthLd.Name = "dtpkDateOfBirthLd";
            this.dtpkDateOfBirthLd.Size = new System.Drawing.Size(294, 27);
            this.dtpkDateOfBirthLd.TabIndex = 9;
            this.dtpkDateOfBirthLd.Value = new System.DateTime(2023, 3, 22, 8, 52, 31, 0);
            // 
            // lbPasswordLd
            // 
            this.lbPasswordLd.AutoSize = true;
            this.lbPasswordLd.BackColor = System.Drawing.Color.White;
            this.lbPasswordLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPasswordLd.Location = new System.Drawing.Point(66, 437);
            this.lbPasswordLd.Name = "lbPasswordLd";
            this.lbPasswordLd.Size = new System.Drawing.Size(75, 18);
            this.lbPasswordLd.TabIndex = 8;
            this.lbPasswordLd.Text = "Password";
            // 
            // lbBasicSalaryLd
            // 
            this.lbBasicSalaryLd.AutoSize = true;
            this.lbBasicSalaryLd.BackColor = System.Drawing.Color.White;
            this.lbBasicSalaryLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbBasicSalaryLd.Location = new System.Drawing.Point(60, 341);
            this.lbBasicSalaryLd.Name = "lbBasicSalaryLd";
            this.lbBasicSalaryLd.Size = new System.Drawing.Size(88, 18);
            this.lbBasicSalaryLd.TabIndex = 6;
            this.lbBasicSalaryLd.Text = "Basic salary";
            // 
            // lbAddressLd
            // 
            this.lbAddressLd.AutoSize = true;
            this.lbAddressLd.BackColor = System.Drawing.Color.White;
            this.lbAddressLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbAddressLd.Location = new System.Drawing.Point(60, 299);
            this.lbAddressLd.Name = "lbAddressLd";
            this.lbAddressLd.Size = new System.Drawing.Size(62, 18);
            this.lbAddressLd.TabIndex = 5;
            this.lbAddressLd.Text = "Address";
            // 
            // lbEmailLd
            // 
            this.lbEmailLd.AutoSize = true;
            this.lbEmailLd.BackColor = System.Drawing.Color.White;
            this.lbEmailLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbEmailLd.Location = new System.Drawing.Point(63, 253);
            this.lbEmailLd.Name = "lbEmailLd";
            this.lbEmailLd.Size = new System.Drawing.Size(45, 18);
            this.lbEmailLd.TabIndex = 4;
            this.lbEmailLd.Text = "Email";
            // 
            // lbIDCardLd
            // 
            this.lbIDCardLd.AutoSize = true;
            this.lbIDCardLd.BackColor = System.Drawing.Color.White;
            this.lbIDCardLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbIDCardLd.Location = new System.Drawing.Point(63, 207);
            this.lbIDCardLd.Name = "lbIDCardLd";
            this.lbIDCardLd.Size = new System.Drawing.Size(58, 18);
            this.lbIDCardLd.TabIndex = 3;
            this.lbIDCardLd.Text = "ID Card";
            // 
            // lbDateOfBirthLd
            // 
            this.lbDateOfBirthLd.AutoSize = true;
            this.lbDateOfBirthLd.BackColor = System.Drawing.Color.White;
            this.lbDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbDateOfBirthLd.Location = new System.Drawing.Point(57, 161);
            this.lbDateOfBirthLd.Name = "lbDateOfBirthLd";
            this.lbDateOfBirthLd.Size = new System.Drawing.Size(88, 18);
            this.lbDateOfBirthLd.TabIndex = 2;
            this.lbDateOfBirthLd.Text = "Date of birth";
            // 
            // lbNameLd
            // 
            this.lbNameLd.AutoSize = true;
            this.lbNameLd.BackColor = System.Drawing.Color.White;
            this.lbNameLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbNameLd.Location = new System.Drawing.Point(63, 115);
            this.lbNameLd.Name = "lbNameLd";
            this.lbNameLd.Size = new System.Drawing.Size(48, 18);
            this.lbNameLd.TabIndex = 1;
            this.lbNameLd.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.White;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbID.Location = new System.Drawing.Point(66, 75);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 18);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btAbsenceLetterLd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btDistributionLd);
            this.panel1.Controls.Add(this.btContact);
            this.panel1.Controls.Add(this.btMyInfor);
            this.panel1.Location = new System.Drawing.Point(1, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 536);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(282, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 56);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(368, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 38);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "LEADER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.grbInformationLd);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(282, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 604);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMPANY_MANAGEMENT.Properties.Resources.business_logo_design_template_78655edda18bc1196ab28760f1535baa_screen;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btAbsenceLetterLd
            // 
            this.btAbsenceLetterLd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btAbsenceLetterLd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAbsenceLetterLd.FlatAppearance.BorderSize = 0;
            this.btAbsenceLetterLd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btAbsenceLetterLd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbsenceLetterLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btAbsenceLetterLd.ForeColor = System.Drawing.Color.White;
            this.btAbsenceLetterLd.Image = global::COMPANY_MANAGEMENT.Properties.Resources.home_60px;
            this.btAbsenceLetterLd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbsenceLetterLd.Location = new System.Drawing.Point(0, 408);
            this.btAbsenceLetterLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAbsenceLetterLd.Name = "btAbsenceLetterLd";
            this.btAbsenceLetterLd.Size = new System.Drawing.Size(279, 124);
            this.btAbsenceLetterLd.TabIndex = 16;
            this.btAbsenceLetterLd.Text = "HOME";
            this.btAbsenceLetterLd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAbsenceLetterLd.UseVisualStyleBackColor = false;
            this.btAbsenceLetterLd.Click += new System.EventHandler(this.btHome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::COMPANY_MANAGEMENT.Properties.Resources.tasks_60px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 120);
            this.button1.TabIndex = 15;
            this.button1.Text = "PROJECT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btProject_Click);
            // 
            // btDistributionLd
            // 
            this.btDistributionLd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btDistributionLd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDistributionLd.FlatAppearance.BorderSize = 0;
            this.btDistributionLd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btDistributionLd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDistributionLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDistributionLd.ForeColor = System.Drawing.Color.White;
            this.btDistributionLd.Image = global::COMPANY_MANAGEMENT.Properties.Resources.Task_60px;
            this.btDistributionLd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDistributionLd.Location = new System.Drawing.Point(0, 183);
            this.btDistributionLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDistributionLd.Name = "btDistributionLd";
            this.btDistributionLd.Size = new System.Drawing.Size(279, 105);
            this.btDistributionLd.TabIndex = 14;
            this.btDistributionLd.Text = "DISTRIBUTION";
            this.btDistributionLd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDistributionLd.UseVisualStyleBackColor = false;
            this.btDistributionLd.Click += new System.EventHandler(this.btDistributionLd_Click_1);
            // 
            // btContact
            // 
            this.btContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btContact.FlatAppearance.BorderSize = 0;
            this.btContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btContact.ForeColor = System.Drawing.Color.White;
            this.btContact.Image = global::COMPANY_MANAGEMENT.Properties.Resources.commercial_64px;
            this.btContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContact.Location = new System.Drawing.Point(0, 95);
            this.btContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btContact.Name = "btContact";
            this.btContact.Size = new System.Drawing.Size(279, 88);
            this.btContact.TabIndex = 13;
            this.btContact.Text = "CONTACT";
            this.btContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btContact.UseVisualStyleBackColor = false;
            this.btContact.Click += new System.EventHandler(this.btContact_Click);
            // 
            // btMyInfor
            // 
            this.btMyInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btMyInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMyInfor.FlatAppearance.BorderSize = 0;
            this.btMyInfor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btMyInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMyInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btMyInfor.ForeColor = System.Drawing.Color.White;
            this.btMyInfor.Image = global::COMPANY_MANAGEMENT.Properties.Resources.profile_64px;
            this.btMyInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMyInfor.Location = new System.Drawing.Point(0, 0);
            this.btMyInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMyInfor.Name = "btMyInfor";
            this.btMyInfor.Size = new System.Drawing.Size(279, 95);
            this.btMyInfor.TabIndex = 12;
            this.btMyInfor.Text = "INFORMATION";
            this.btMyInfor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMyInfor.UseVisualStyleBackColor = false;
            this.btMyInfor.Click += new System.EventHandler(this.btMyInfor_Click);
            // 
            // FLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLeader";
            this.Text = "FLeader";
            this.Load += new System.EventHandler(this.FLeader_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.grbInformationLd.ResumeLayout(false);
            this.grbInformationLd.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dgvListManager;
        private GroupBox groupBox2;
        private DataGridView dgvListStaff;
        private GroupBox grbInformationLd;
        private Label label1;
        private TextBox txtIDManager;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btUpdateLd;
        private Button btInsertLd;
        private Button btDeleteLd;
        private TextBox txtPasswordLd;
        private TextBox txtBasicSalaryLd;
        private TextBox txtAddressLd;
        private TextBox txtEmailLd;
        private TextBox txtIDCardLd;
        private TextBox txtNameLd;
        private TextBox txtID;
        private DateTimePicker dtpkDateOfBirthLd;
        private Label lbPasswordLd;
        private Label lbBasicSalaryLd;
        private Label lbAddressLd;
        private Label lbEmailLd;
        private Label lbIDCardLd;
        private Label lbDateOfBirthLd;
        private Label lbNameLd;
        private Label lbID;
        private Panel panel1;
        private Button btAbsenceLetterLd;
        private Button button1;
        private Button btDistributionLd;
        private Button btContact;
        private Button btMyInfor;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
    }
}