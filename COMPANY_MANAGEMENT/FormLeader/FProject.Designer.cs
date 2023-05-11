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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateProject = new System.Windows.Forms.Button();
            this.btInsertProject = new System.Windows.Forms.Button();
            this.btDeleteProject = new System.Windows.Forms.Button();
            this.btTask = new System.Windows.Forms.Button();
            this.grbProject = new System.Windows.Forms.GroupBox();
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
            this.flowLayoutPanel1.SuspendLayout();
            this.grbProject.SuspendLayout();
            this.grbListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.grbListTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateProject);
            this.flowLayoutPanel1.Controls.Add(this.btInsertProject);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteProject);
            this.flowLayoutPanel1.Controls.Add(this.btTask);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 530);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 118);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btUpdateProject
            // 
            this.btUpdateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateProject.Location = new System.Drawing.Point(4, 2);
            this.btUpdateProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btUpdateProject.Name = "btUpdateProject";
            this.btUpdateProject.Size = new System.Drawing.Size(193, 52);
            this.btUpdateProject.TabIndex = 0;
            this.btUpdateProject.Text = "Update";
            this.btUpdateProject.UseVisualStyleBackColor = true;
            this.btUpdateProject.Click += new System.EventHandler(this.btUpdateProject_Click);
            // 
            // btInsertProject
            // 
            this.btInsertProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertProject.Location = new System.Drawing.Point(205, 2);
            this.btInsertProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btInsertProject.Name = "btInsertProject";
            this.btInsertProject.Size = new System.Drawing.Size(203, 52);
            this.btInsertProject.TabIndex = 1;
            this.btInsertProject.Text = "Insert";
            this.btInsertProject.UseVisualStyleBackColor = true;
            this.btInsertProject.Click += new System.EventHandler(this.btInsertProject_Click);
            // 
            // btDeleteProject
            // 
            this.btDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteProject.Location = new System.Drawing.Point(4, 58);
            this.btDeleteProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btDeleteProject.Name = "btDeleteProject";
            this.btDeleteProject.Size = new System.Drawing.Size(193, 53);
            this.btDeleteProject.TabIndex = 2;
            this.btDeleteProject.Text = "Delete";
            this.btDeleteProject.UseVisualStyleBackColor = true;
            this.btDeleteProject.Click += new System.EventHandler(this.btDeleteProject_Click);
            // 
            // btTask
            // 
            this.btTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTask.Location = new System.Drawing.Point(205, 58);
            this.btTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(203, 53);
            this.btTask.TabIndex = 3;
            this.btTask.Text = "Add Task";
            this.btTask.UseVisualStyleBackColor = true;
            this.btTask.Click += new System.EventHandler(this.btTask_Click);
            // 
            // grbProject
            // 
            this.grbProject.Controls.Add(this.cbbStatus);
            this.grbProject.Controls.Add(this.dtDateEnd);
            this.grbProject.Controls.Add(this.dtDateStart);
            this.grbProject.Controls.Add(this.txtName);
            this.grbProject.Controls.Add(this.txtID);
            this.grbProject.Controls.Add(this.rtxtContent);
            this.grbProject.Controls.Add(this.lblStatus);
            this.grbProject.Controls.Add(this.flowLayoutPanel1);
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
            this.grbProject.Size = new System.Drawing.Size(442, 652);
            this.grbProject.TabIndex = 27;
            this.grbProject.TabStop = false;
            this.grbProject.Text = "INFORMATION";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(108, 474);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(300, 28);
            this.cbbStatus.TabIndex = 35;
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateEnd.Location = new System.Drawing.Point(108, 197);
            this.dtDateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(300, 27);
            this.dtDateEnd.TabIndex = 34;
            // 
            // dtDateStart
            // 
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateStart.Location = new System.Drawing.Point(108, 137);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(300, 27);
            this.dtDateStart.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtName.Location = new System.Drawing.Point(108, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID.Location = new System.Drawing.Point(108, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 27);
            this.txtID.TabIndex = 28;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rtxtContent.Location = new System.Drawing.Point(108, 273);
            this.rtxtContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(300, 163);
            this.rtxtContent.TabIndex = 27;
            this.rtxtContent.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 480);
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
            this.lblContent.Location = new System.Drawing.Point(7, 273);
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
            this.grbListProject.Controls.Add(this.dgvProject);
            this.grbListProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListProject.Location = new System.Drawing.Point(457, 11);
            this.grbListProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListProject.Name = "grbListProject";
            this.grbListProject.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListProject.Size = new System.Drawing.Size(768, 305);
            this.grbListProject.TabIndex = 28;
            this.grbListProject.TabStop = false;
            this.grbListProject.Text = "List Project";
            // 
            // dgvProject
            // 
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProject.ColumnHeadersHeight = 29;
            this.dgvProject.Location = new System.Drawing.Point(7, 23);
            this.dgvProject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(761, 269);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick_1);
            // 
            // grbListTask
            // 
            this.grbListTask.Controls.Add(this.dgvTask);
            this.grbListTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListTask.Location = new System.Drawing.Point(457, 320);
            this.grbListTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListTask.Name = "grbListTask";
            this.grbListTask.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbListTask.Size = new System.Drawing.Size(768, 343);
            this.grbListTask.TabIndex = 29;
            this.grbListTask.TabStop = false;
            this.grbListTask.Text = "List Tasks of all Projects";
            // 
            // dgvTask
            // 
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.ColumnHeadersHeight = 29;
            this.dgvTask.Location = new System.Drawing.Point(8, 23);
            this.dgvTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 29;
            this.dgvTask.Size = new System.Drawing.Size(760, 316);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
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
            this.grbListProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.grbListTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
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
    }
}