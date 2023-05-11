using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class FTask
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
            this.grbTask = new System.Windows.Forms.GroupBox();
            this.txtID_Project = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lblID_Project = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gvTask = new System.Windows.Forms.DataGridView();
            this.grbTask.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTask
            // 
            this.grbTask.Controls.Add(this.txtID_Project);
            this.grbTask.Controls.Add(this.cbbStatus);
            this.grbTask.Controls.Add(this.lblID_Project);
            this.grbTask.Controls.Add(this.dtDateEnd);
            this.grbTask.Controls.Add(this.dtDateStart);
            this.grbTask.Controls.Add(this.txtName);
            this.grbTask.Controls.Add(this.txtID);
            this.grbTask.Controls.Add(this.rtxtContent);
            this.grbTask.Controls.Add(this.lblStatus);
            this.grbTask.Controls.Add(this.flowLayoutPanel1);
            this.grbTask.Controls.Add(this.lblContent);
            this.grbTask.Controls.Add(this.lblDateEnd);
            this.grbTask.Controls.Add(this.lblDateStart);
            this.grbTask.Controls.Add(this.lblName);
            this.grbTask.Controls.Add(this.lblID);
            this.grbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.grbTask.Location = new System.Drawing.Point(2, 7);
            this.grbTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbTask.Name = "grbTask";
            this.grbTask.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbTask.Size = new System.Drawing.Size(610, 558);
            this.grbTask.TabIndex = 28;
            this.grbTask.TabStop = false;
            this.grbTask.Text = "INFORMATION";
            // 
            // txtID_Project
            // 
            this.txtID_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID_Project.Location = new System.Drawing.Point(106, 452);
            this.txtID_Project.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtID_Project.Name = "txtID_Project";
            this.txtID_Project.ReadOnly = true;
            this.txtID_Project.Size = new System.Drawing.Size(463, 27);
            this.txtID_Project.TabIndex = 38;
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(106, 409);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(465, 28);
            this.cbbStatus.TabIndex = 37;
            // 
            // lblID_Project
            // 
            this.lblID_Project.AutoSize = true;
            this.lblID_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblID_Project.Location = new System.Drawing.Point(7, 455);
            this.lblID_Project.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_Project.Name = "lblID_Project";
            this.lblID_Project.Size = new System.Drawing.Size(73, 18);
            this.lblID_Project.TabIndex = 35;
            this.lblID_Project.Text = "ID Project";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateEnd.Location = new System.Drawing.Point(108, 167);
            this.dtDateEnd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(463, 27);
            this.dtDateEnd.TabIndex = 34;
            // 
            // dtDateStart
            // 
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtDateStart.Location = new System.Drawing.Point(108, 122);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(463, 27);
            this.dtDateStart.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtName.Location = new System.Drawing.Point(108, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID.Location = new System.Drawing.Point(108, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(463, 27);
            this.txtID.TabIndex = 28;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rtxtContent.Location = new System.Drawing.Point(108, 220);
            this.rtxtContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(463, 162);
            this.rtxtContent.TabIndex = 27;
            this.rtxtContent.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(7, 410);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btInsert);
            this.flowLayoutPanel1.Controls.Add(this.btDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(81, 502);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 52);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btUpdate.Location = new System.Drawing.Point(4, 2);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(140, 43);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btInsert.Location = new System.Drawing.Point(152, 2);
            this.btInsert.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(140, 43);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDelete.Location = new System.Drawing.Point(300, 2);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(140, 43);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContent.Location = new System.Drawing.Point(7, 220);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 18);
            this.lblContent.TabIndex = 25;
            this.lblContent.Text = "Content";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateEnd.Location = new System.Drawing.Point(7, 173);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(67, 18);
            this.lblDateEnd.TabIndex = 24;
            this.lblDateEnd.Text = "Date end";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateStart.Location = new System.Drawing.Point(7, 128);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(72, 18);
            this.lblDateStart.TabIndex = 23;
            this.lblDateStart.Text = "Date start";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(7, 86);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblID.Location = new System.Drawing.Point(7, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // gvTask
            // 
            this.gvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTask.BackgroundColor = System.Drawing.Color.White;
            this.gvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTask.Location = new System.Drawing.Point(616, 7);
            this.gvTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gvTask.Name = "gvTask";
            this.gvTask.RowHeadersWidth = 51;
            this.gvTask.RowTemplate.Height = 29;
            this.gvTask.Size = new System.Drawing.Size(890, 558);
            this.gvTask.TabIndex = 29;
            this.gvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTask_CellClick);
            // 
            // FTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 572);
            this.Controls.Add(this.gvTask);
            this.Controls.Add(this.grbTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FTask";
            this.Text = "FTask";
            this.Load += new System.EventHandler(this.FTask_Load);
            this.grbTask.ResumeLayout(false);
            this.grbTask.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbTask;
        private DateTimePicker dtDateEnd;
        private DateTimePicker dtDateStart;
        private TextBox txtName;
        private TextBox txtID;
        private RichTextBox rtxtContent;
        private Label lblStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btUpdate;
        private Button btInsert;
        private Button btDelete;
        private Label lblContent;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblName;
        private Label lblID;
        private DataGridView gvTask;
        private Label lblID_Project;
        private ComboBox cbbStatus;
        private TextBox txtID_Project;
    }
}