using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class DistributionLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistributionLD));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grBProj = new System.Windows.Forms.GroupBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.grBTasks = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.grBMan = new System.Windows.Forms.GroupBox();
            this.dgvListManager = new System.Windows.Forms.DataGridView();
            this.grbListDistribution = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDis = new System.Windows.Forms.TabPage();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.lblIDTask = new System.Windows.Forms.Label();
            this.txtIDManager = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblIDManager = new System.Windows.Forms.Label();
            this.txtIDTask = new System.Windows.Forms.TextBox();
            this.lblNameManager = new System.Windows.Forms.Label();
            this.tbHelp = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvDistribution = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chDis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grBProj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.grBTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.grBMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).BeginInit();
            this.grbListDistribution.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDis.SuspendLayout();
            this.tbHelp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDis)).BeginInit();
            this.SuspendLayout();
            // 
            // grBProj
            // 
            this.grBProj.Controls.Add(this.dgvProject);
            this.grBProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBProj.Location = new System.Drawing.Point(7, 10);
            this.grBProj.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBProj.Name = "grBProj";
            this.grBProj.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBProj.Size = new System.Drawing.Size(389, 374);
            this.grBProj.TabIndex = 0;
            this.grBProj.TabStop = false;
            this.grBProj.Text = "List Project";
            // 
            // dgvProject
            // 
            this.dgvProject.BackgroundColor = System.Drawing.Color.White;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(0, 24);
            this.dgvProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(389, 346);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick);
            // 
            // grBTasks
            // 
            this.grBTasks.Controls.Add(this.dgvTask);
            this.grBTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBTasks.Location = new System.Drawing.Point(398, 11);
            this.grBTasks.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBTasks.Name = "grBTasks";
            this.grBTasks.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBTasks.Size = new System.Drawing.Size(415, 373);
            this.grBTasks.TabIndex = 1;
            this.grBTasks.TabStop = false;
            this.grBTasks.Text = "List Task";
            // 
            // dgvTask
            // 
            this.dgvTask.BackgroundColor = System.Drawing.Color.White;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(6, 24);
            this.dgvTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 29;
            this.dgvTask.Size = new System.Drawing.Size(406, 345);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // grBMan
            // 
            this.grBMan.Controls.Add(this.dgvListManager);
            this.grBMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBMan.Location = new System.Drawing.Point(818, 10);
            this.grBMan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBMan.Name = "grBMan";
            this.grBMan.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grBMan.Size = new System.Drawing.Size(421, 373);
            this.grBMan.TabIndex = 1;
            this.grBMan.TabStop = false;
            this.grBMan.Text = "List Manager";
            // 
            // dgvListManager
            // 
            this.dgvListManager.BackgroundColor = System.Drawing.Color.White;
            this.dgvListManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListManager.Location = new System.Drawing.Point(0, 24);
            this.dgvListManager.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListManager.Name = "dgvListManager";
            this.dgvListManager.RowHeadersWidth = 51;
            this.dgvListManager.RowTemplate.Height = 29;
            this.dgvListManager.Size = new System.Drawing.Size(409, 346);
            this.dgvListManager.TabIndex = 2;
            this.dgvListManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListManager_CellClick);
            // 
            // grbListDistribution
            // 
            this.grbListDistribution.Controls.Add(this.tabControl1);
            this.grbListDistribution.Controls.Add(this.dgvDistribution);
            this.grbListDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListDistribution.Location = new System.Drawing.Point(7, 404);
            this.grbListDistribution.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListDistribution.Name = "grbListDistribution";
            this.grbListDistribution.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListDistribution.Size = new System.Drawing.Size(1232, 269);
            this.grbListDistribution.TabIndex = 2;
            this.grbListDistribution.TabStop = false;
            this.grbListDistribution.Text = "List Distribution";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDis);
            this.tabControl1.Controls.Add(this.tbHelp);
            this.tabControl1.Location = new System.Drawing.Point(486, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 251);
            this.tabControl1.TabIndex = 28;
            // 
            // tbDis
            // 
            this.tbDis.Controls.Add(this.btInsertLd);
            this.tbDis.Controls.Add(this.txtManagerName);
            this.tbDis.Controls.Add(this.btDeleteLd);
            this.tbDis.Controls.Add(this.lblIDTask);
            this.tbDis.Controls.Add(this.txtIDManager);
            this.tbDis.Controls.Add(this.lblTaskName);
            this.tbDis.Controls.Add(this.txtTaskName);
            this.tbDis.Controls.Add(this.lblIDManager);
            this.tbDis.Controls.Add(this.txtIDTask);
            this.tbDis.Controls.Add(this.lblNameManager);
            this.tbDis.Location = new System.Drawing.Point(4, 34);
            this.tbDis.Name = "tbDis";
            this.tbDis.Padding = new System.Windows.Forms.Padding(3);
            this.tbDis.Size = new System.Drawing.Size(738, 213);
            this.tbDis.TabIndex = 0;
            this.tbDis.Text = "Distribution";
            this.tbDis.UseVisualStyleBackColor = true;
            // 
            // btInsertLd
            // 
            this.btInsertLd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInsertLd.BackgroundImage")));
            this.btInsertLd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInsertLd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertLd.Location = new System.Drawing.Point(174, 144);
            this.btInsertLd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(171, 51);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInsertLd.UseVisualStyleBackColor = true;
            this.btInsertLd.Click += new System.EventHandler(this.btInsertLd_Click);
            // 
            // txtManagerName
            // 
            this.txtManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.Location = new System.Drawing.Point(523, 92);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(190, 28);
            this.txtManagerName.TabIndex = 23;
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeleteLd.BackgroundImage")));
            this.btDeleteLd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDeleteLd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteLd.Location = new System.Drawing.Point(431, 144);
            this.btDeleteLd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(171, 51);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeleteLd.UseVisualStyleBackColor = true;
            this.btDeleteLd.Click += new System.EventHandler(this.btDeleteLd_Click);
            // 
            // lblIDTask
            // 
            this.lblIDTask.AutoSize = true;
            this.lblIDTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTask.Location = new System.Drawing.Point(36, 41);
            this.lblIDTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDTask.Name = "lblIDTask";
            this.lblIDTask.Size = new System.Drawing.Size(72, 22);
            this.lblIDTask.TabIndex = 2;
            this.lblIDTask.Text = "ID Task";
            // 
            // txtIDManager
            // 
            this.txtIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDManager.Location = new System.Drawing.Point(523, 33);
            this.txtIDManager.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDManager.Name = "txtIDManager";
            this.txtIDManager.Size = new System.Drawing.Size(190, 28);
            this.txtIDManager.TabIndex = 22;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(36, 99);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(102, 22);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Name Task";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(146, 92);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(216, 28);
            this.txtTaskName.TabIndex = 21;
            // 
            // lblIDManager
            // 
            this.lblIDManager.AutoSize = true;
            this.lblIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDManager.Location = new System.Drawing.Point(385, 36);
            this.lblIDManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDManager.Name = "lblIDManager";
            this.lblIDManager.Size = new System.Drawing.Size(102, 22);
            this.lblIDManager.TabIndex = 4;
            this.lblIDManager.Text = "ID Manager";
            // 
            // txtIDTask
            // 
            this.txtIDTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTask.Location = new System.Drawing.Point(146, 33);
            this.txtIDTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDTask.Name = "txtIDTask";
            this.txtIDTask.Size = new System.Drawing.Size(216, 28);
            this.txtIDTask.TabIndex = 20;
            // 
            // lblNameManager
            // 
            this.lblNameManager.AutoSize = true;
            this.lblNameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameManager.Location = new System.Drawing.Point(383, 95);
            this.lblNameManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameManager.Name = "lblNameManager";
            this.lblNameManager.Size = new System.Drawing.Size(132, 22);
            this.lblNameManager.TabIndex = 5;
            this.lblNameManager.Text = "Name Manager";
            // 
            // tbHelp
            // 
            this.tbHelp.Controls.Add(this.groupBox4);
            this.tbHelp.Location = new System.Drawing.Point(4, 34);
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tbHelp.Size = new System.Drawing.Size(738, 213);
            this.tbHelp.TabIndex = 1;
            this.tbHelp.Text = "Help";
            this.tbHelp.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chDis);
            this.groupBox4.Controls.Add(this.btLoadHightLight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(726, 201);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(282, 115);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(140, 72);
            this.btLoadHightLight.TabIndex = 36;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Red";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Overdue";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(1, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Orange";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(116, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 25);
            this.label16.TabIndex = 31;
            this.label16.Text = "Not started yet";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(116, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(238, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "Warning is about to expire";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(116, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 25);
            this.label20.TabIndex = 35;
            this.label20.Text = "Change data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(6, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 25);
            this.label19.TabIndex = 34;
            this.label19.Text = "Yellow";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SkyBlue;
            this.label15.Location = new System.Drawing.Point(1, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "SkyBlue";
            // 
            // dgvDistribution
            // 
            this.dgvDistribution.BackgroundColor = System.Drawing.Color.White;
            this.dgvDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribution.Location = new System.Drawing.Point(6, 27);
            this.dgvDistribution.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvDistribution.Name = "dgvDistribution";
            this.dgvDistribution.RowHeadersWidth = 51;
            this.dgvDistribution.RowTemplate.Height = 29;
            this.dgvDistribution.Size = new System.Drawing.Size(473, 238);
            this.dgvDistribution.TabIndex = 1;
            this.dgvDistribution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistribution_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1218, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________";
            // 
            // chDis
            // 
            chartArea1.Name = "ChartArea1";
            this.chDis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDis.Legends.Add(legend1);
            this.chDis.Location = new System.Drawing.Point(423, 11);
            this.chDis.Name = "chDis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chDis.Series.Add(series1);
            this.chDis.Size = new System.Drawing.Size(300, 184);
            this.chDis.TabIndex = 37;
            this.chDis.Text = "chDis";
            // 
            // DistributionLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbListDistribution);
            this.Controls.Add(this.grBMan);
            this.Controls.Add(this.grBTasks);
            this.Controls.Add(this.grBProj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "DistributionLD";
            this.Text = "DistributionLD";
            this.Load += new System.EventHandler(this.DistributionLD_Load);
            this.grBProj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.grBTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.grBMan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).EndInit();
            this.grbListDistribution.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbDis.ResumeLayout(false);
            this.tbDis.PerformLayout();
            this.tbHelp.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grBProj;
        private DataGridView dgvProject;
        private GroupBox grBTasks;
        private DataGridView dgvTask;
        private GroupBox grBMan;
        private DataGridView dgvListManager;
        private GroupBox grbListDistribution;
        private DataGridView dgvDistribution;
        private Label lblNameManager;
        private Label lblIDManager;
        private Label lblTaskName;
        private Label lblIDTask;
        private TextBox txtManagerName;
        private TextBox txtIDManager;
        private TextBox txtTaskName;
        private TextBox txtIDTask;
        private Button btInsertLd;
        private Button btDeleteLd;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tbDis;
        private TabPage tbHelp;
        private GroupBox groupBox4;
        private Button btLoadHightLight;
        private Label label9;
        private Label label11;
        private Label label17;
        private Label label16;
        private Label label18;
        private Label label20;
        private Label label19;
        private Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDis;
    }
}