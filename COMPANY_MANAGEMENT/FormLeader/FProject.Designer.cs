using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class FProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProject));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateProject = new System.Windows.Forms.Button();
            this.btInsertProject = new System.Windows.Forms.Button();
            this.btDeleteProject = new System.Windows.Forms.Button();
            this.btTask = new System.Windows.Forms.Button();
            this.grbProject = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grbListProject = new System.Windows.Forms.GroupBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.grbListTask = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.chProj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbProject.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.grbListTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTask)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateProject);
            this.flowLayoutPanel1.Controls.Add(this.btInsertProject);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteProject);
            this.flowLayoutPanel1.Controls.Add(this.btTask);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 152);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btUpdateProject
            // 
            this.btUpdateProject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdateProject.BackgroundImage")));
            this.btUpdateProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btUpdateProject.FlatAppearance.BorderSize = 0;
            this.btUpdateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateProject.Location = new System.Drawing.Point(4, 2);
            this.btUpdateProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btUpdateProject.Name = "btUpdateProject";
            this.btUpdateProject.Size = new System.Drawing.Size(164, 66);
            this.btUpdateProject.TabIndex = 0;
            this.btUpdateProject.UseVisualStyleBackColor = true;
            this.btUpdateProject.Click += new System.EventHandler(this.btUpdateProject_Click);
            // 
            // btInsertProject
            // 
            this.btInsertProject.FlatAppearance.BorderSize = 0;
            this.btInsertProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsertProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertProject.Image = ((System.Drawing.Image)(resources.GetObject("btInsertProject.Image")));
            this.btInsertProject.Location = new System.Drawing.Point(176, 2);
            this.btInsertProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btInsertProject.Name = "btInsertProject";
            this.btInsertProject.Size = new System.Drawing.Size(170, 66);
            this.btInsertProject.TabIndex = 1;
            this.btInsertProject.UseVisualStyleBackColor = true;
            this.btInsertProject.Click += new System.EventHandler(this.btInsertProject_Click);
            // 
            // btDeleteProject
            // 
            this.btDeleteProject.FlatAppearance.BorderSize = 0;
            this.btDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteProject.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteProject.Image")));
            this.btDeleteProject.Location = new System.Drawing.Point(4, 72);
            this.btDeleteProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btDeleteProject.Name = "btDeleteProject";
            this.btDeleteProject.Size = new System.Drawing.Size(164, 66);
            this.btDeleteProject.TabIndex = 2;
            this.btDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeleteProject.UseVisualStyleBackColor = true;
            this.btDeleteProject.Click += new System.EventHandler(this.btDeleteProject_Click);
            // 
            // btTask
            // 
            this.btTask.FlatAppearance.BorderSize = 0;
            this.btTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTask.Image = global::COMPANY_MANAGEMENT.Properties.Resources.Task_60px;
            this.btTask.Location = new System.Drawing.Point(176, 72);
            this.btTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(170, 66);
            this.btTask.TabIndex = 3;
            this.btTask.Text = "ADD TASK";
            this.btTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTask.UseVisualStyleBackColor = true;
            this.btTask.Click += new System.EventHandler(this.btTask_Click);
            // 
            // grbProject
            // 
            this.grbProject.Controls.Add(this.tabControl1);
            this.grbProject.Controls.Add(this.cbbStatus);
            this.grbProject.Controls.Add(this.dtDateEnd);
            this.grbProject.Controls.Add(this.dtDateStart);
            this.grbProject.Controls.Add(this.txtName);
            this.grbProject.Controls.Add(this.txtID);
            this.grbProject.Controls.Add(this.rtxtContent);
            this.grbProject.Controls.Add(this.lblStatus);
            this.grbProject.Controls.Add(this.lblContent);
            this.grbProject.Controls.Add(this.lblDateEnd);
            this.grbProject.Controls.Add(this.lblDateStart);
            this.grbProject.Controls.Add(this.lblName);
            this.grbProject.Controls.Add(this.lblID);
            this.grbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.grbProject.Location = new System.Drawing.Point(14, 11);
            this.grbProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbProject.Name = "grbProject";
            this.grbProject.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbProject.Size = new System.Drawing.Size(392, 652);
            this.grbProject.TabIndex = 27;
            this.grbProject.TabStop = false;
            this.grbProject.Text = "INFORMATION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 457);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 190);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btLoadHightLight);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(244, 70);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(116, 73);
            this.btLoadHightLight.TabIndex = 45;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Red";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(204, 20);
            this.label18.TabIndex = 42;
            this.label18.Text = "Warning is about to expire";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Not started yet";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SkyBlue;
            this.label15.Location = new System.Drawing.Point(3, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "SkyBlue";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(118, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 44;
            this.label20.Text = "Change data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(3, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 41;
            this.label17.Text = "Orange";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Overdue";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(8, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Yellow";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(108, 424);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(273, 28);
            this.cbbStatus.TabIndex = 35;
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateEnd.Location = new System.Drawing.Point(108, 197);
            this.dtDateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(273, 27);
            this.dtDateEnd.TabIndex = 34;
            // 
            // dtDateStart
            // 
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateStart.Location = new System.Drawing.Point(108, 137);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(273, 27);
            this.dtDateStart.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtName.Location = new System.Drawing.Point(108, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID.Location = new System.Drawing.Point(108, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(273, 27);
            this.txtID.TabIndex = 28;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rtxtContent.Location = new System.Drawing.Point(108, 245);
            this.rtxtContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(273, 163);
            this.rtxtContent.TabIndex = 27;
            this.rtxtContent.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 430);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(7, 245);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(67, 20);
            this.lblContent.TabIndex = 25;
            this.lblContent.Text = "Content";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnd.Location = new System.Drawing.Point(7, 203);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(77, 20);
            this.lblDateEnd.TabIndex = 24;
            this.lblDateEnd.Text = "Date end";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStart.Location = new System.Drawing.Point(7, 143);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(84, 20);
            this.lblDateStart.TabIndex = 23;
            this.lblDateStart.Text = "Date start";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(7, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // grbListProject
            // 
            this.grbListProject.Controls.Add(this.chProj);
            this.grbListProject.Controls.Add(this.dgvProject);
            this.grbListProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListProject.Location = new System.Drawing.Point(403, 11);
            this.grbListProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListProject.Name = "grbListProject";
            this.grbListProject.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListProject.Size = new System.Drawing.Size(822, 305);
            this.grbListProject.TabIndex = 28;
            this.grbListProject.TabStop = false;
            this.grbListProject.Text = "List Project";
            // 
            // dgvProject
            // 
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProject.BackgroundColor = System.Drawing.Color.White;
            this.dgvProject.ColumnHeadersHeight = 29;
            this.dgvProject.Location = new System.Drawing.Point(7, 23);
            this.dgvProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(551, 269);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick_1);
            // 
            // grbListTask
            // 
            this.grbListTask.Controls.Add(this.chTask);
            this.grbListTask.Controls.Add(this.dgvTask);
            this.grbListTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListTask.Location = new System.Drawing.Point(406, 320);
            this.grbListTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListTask.Name = "grbListTask";
            this.grbListTask.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListTask.Size = new System.Drawing.Size(819, 343);
            this.grbListTask.TabIndex = 29;
            this.grbListTask.TabStop = false;
            this.grbListTask.Text = "List Tasks of all Projects";
            // 
            // dgvTask
            // 
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.BackgroundColor = System.Drawing.Color.White;
            this.dgvTask.ColumnHeadersHeight = 29;
            this.dgvTask.Location = new System.Drawing.Point(8, 23);
            this.dgvTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 29;
            this.dgvTask.Size = new System.Drawing.Size(547, 316);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // chProj
            // 
            chartArea1.Name = "ChartArea1";
            this.chProj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chProj.Legends.Add(legend1);
            this.chProj.Location = new System.Drawing.Point(565, 23);
            this.chProj.Name = "chProj";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chProj.Series.Add(series1);
            this.chProj.Size = new System.Drawing.Size(250, 269);
            this.chProj.TabIndex = 1;
            this.chProj.Text = "chProj";
            // 
            // chTask
            // 
            chartArea2.Name = "ChartArea1";
            this.chTask.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chTask.Legends.Add(legend2);
            this.chTask.Location = new System.Drawing.Point(562, 23);
            this.chTask.Name = "chTask";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chTask.Series.Add(series2);
            this.chTask.Size = new System.Drawing.Size(257, 315);
            this.chTask.TabIndex = 2;
            this.chTask.Text = "chTask";
            // 
            // FProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 674);
            this.Controls.Add(this.grbListTask);
            this.Controls.Add(this.grbListProject);
            this.Controls.Add(this.grbProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FProject";
            this.Load += new System.EventHandler(this.FProject_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbProject.ResumeLayout(false);
            this.grbProject.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbListProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.grbListTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btUpdateProject;
        private Button btInsertProject;
        private Button btDeleteProject;
        private GroupBox grbProject;
        private Button btTask;
        private Label lblContent;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblName;
        private Label lblID;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtID;
        private RichTextBox rtxtContent;
        private DateTimePicker dtDateEnd;
        private DateTimePicker dtDateStart;
        private ComboBox cbbStatus;
        private GroupBox grbListProject;
        private DataGridView dgvProject;
        private GroupBox grbListTask;
        private DataGridView dgvTask;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btLoadHightLight;
        private Label label9;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label20;
        private Label label17;
        private Label label11;
        private Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTask;
    }
}