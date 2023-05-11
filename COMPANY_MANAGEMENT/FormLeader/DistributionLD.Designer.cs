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
            this.grBProj = new System.Windows.Forms.GroupBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.grBTasks = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.grBMan = new System.Windows.Forms.GroupBox();
            this.dgvListManager = new System.Windows.Forms.DataGridView();
            this.grbListDistribution = new System.Windows.Forms.GroupBox();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.txtIDManager = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtIDTask = new System.Windows.Forms.TextBox();
            this.lblNameManager = new System.Windows.Forms.Label();
            this.lblIDManager = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblIDTask = new System.Windows.Forms.Label();
            this.dgvDistribution = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grBProj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.grBTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.grBMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).BeginInit();
            this.grbListDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).BeginInit();
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
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(0, 24);
            this.dgvProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(389, 346);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick);
            this.dgvProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellContentClick);
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
            this.grbListDistribution.Controls.Add(this.btInsertLd);
            this.grbListDistribution.Controls.Add(this.txtManagerName);
            this.grbListDistribution.Controls.Add(this.btDeleteLd);
            this.grbListDistribution.Controls.Add(this.txtIDManager);
            this.grbListDistribution.Controls.Add(this.txtTaskName);
            this.grbListDistribution.Controls.Add(this.txtIDTask);
            this.grbListDistribution.Controls.Add(this.lblNameManager);
            this.grbListDistribution.Controls.Add(this.lblIDManager);
            this.grbListDistribution.Controls.Add(this.lblTaskName);
            this.grbListDistribution.Controls.Add(this.lblIDTask);
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
            // btInsertLd
            // 
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertLd.Location = new System.Drawing.Point(635, 176);
            this.btInsertLd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(171, 51);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.Text = "Insert";
            this.btInsertLd.UseVisualStyleBackColor = true;
            this.btInsertLd.Click += new System.EventHandler(this.btInsertLd_Click);
            // 
            // txtManagerName
            // 
            this.txtManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.Location = new System.Drawing.Point(984, 99);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(190, 28);
            this.txtManagerName.TabIndex = 23;
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteLd.Location = new System.Drawing.Point(887, 176);
            this.btDeleteLd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(171, 51);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.Text = "Delete";
            this.btDeleteLd.UseVisualStyleBackColor = true;
            this.btDeleteLd.Click += new System.EventHandler(this.btDeleteLd_Click);
            // 
            // txtIDManager
            // 
            this.txtIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDManager.Location = new System.Drawing.Point(984, 40);
            this.txtIDManager.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDManager.Name = "txtIDManager";
            this.txtIDManager.Size = new System.Drawing.Size(190, 28);
            this.txtIDManager.TabIndex = 22;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(607, 99);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(216, 28);
            this.txtTaskName.TabIndex = 21;
            // 
            // txtIDTask
            // 
            this.txtIDTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTask.Location = new System.Drawing.Point(607, 40);
            this.txtIDTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDTask.Name = "txtIDTask";
            this.txtIDTask.Size = new System.Drawing.Size(216, 28);
            this.txtIDTask.TabIndex = 20;
            // 
            // lblNameManager
            // 
            this.lblNameManager.AutoSize = true;
            this.lblNameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameManager.Location = new System.Drawing.Point(844, 102);
            this.lblNameManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameManager.Name = "lblNameManager";
            this.lblNameManager.Size = new System.Drawing.Size(132, 22);
            this.lblNameManager.TabIndex = 5;
            this.lblNameManager.Text = "Name Manager";
            // 
            // lblIDManager
            // 
            this.lblIDManager.AutoSize = true;
            this.lblIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDManager.Location = new System.Drawing.Point(846, 43);
            this.lblIDManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDManager.Name = "lblIDManager";
            this.lblIDManager.Size = new System.Drawing.Size(102, 22);
            this.lblIDManager.TabIndex = 4;
            this.lblIDManager.Text = "ID Manager";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(497, 106);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(102, 22);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Name Task";
            // 
            // lblIDTask
            // 
            this.lblIDTask.AutoSize = true;
            this.lblIDTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTask.Location = new System.Drawing.Point(497, 48);
            this.lblIDTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDTask.Name = "lblIDTask";
            this.lblIDTask.Size = new System.Drawing.Size(72, 22);
            this.lblIDTask.TabIndex = 2;
            this.lblIDTask.Text = "ID Task";
            // 
            // dgvDistribution
            // 
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
            this.grbListDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).EndInit();
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
    }
}