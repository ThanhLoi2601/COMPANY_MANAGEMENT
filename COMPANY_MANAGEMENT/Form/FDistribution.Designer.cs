namespace COMPANY_MANAGEMENT
{
    partial class FDistribution
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.txtIDJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.dGVJob = new System.Windows.Forms.DataGridView();
            this.dGVStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "JOB LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "STAFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Staff :";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(729, 386);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(183, 22);
            this.txtIDStaff.TabIndex = 6;
            // 
            // txtIDJob
            // 
            this.txtIDJob.Location = new System.Drawing.Point(243, 384);
            this.txtIDJob.Name = "txtIDJob";
            this.txtIDJob.Size = new System.Drawing.Size(182, 22);
            this.txtIDJob.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Job :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "assigned to";
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(987, 373);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(153, 58);
            this.btConfirm.TabIndex = 10;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // dGVJob
            // 
            this.dGVJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJob.Location = new System.Drawing.Point(12, 64);
            this.dGVJob.Name = "dGVJob";
            this.dGVJob.RowHeadersWidth = 51;
            this.dGVJob.RowTemplate.Height = 24;
            this.dGVJob.Size = new System.Drawing.Size(524, 275);
            this.dGVJob.TabIndex = 3;
            this.dGVJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJob_CellClick);
            // 
            // dGVStaff
            // 
            this.dGVStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStaff.Location = new System.Drawing.Point(579, 64);
            this.dGVStaff.Name = "dGVStaff";
            this.dGVStaff.RowHeadersWidth = 51;
            this.dGVStaff.RowTemplate.Height = 24;
            this.dGVStaff.Size = new System.Drawing.Size(561, 275);
            this.dGVStaff.TabIndex = 0;
            this.dGVStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVStaff_CellClick);
            // 
            // FDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVJob);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.dGVStaff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDistribution";
            this.Text = "DISTRIBUTION";
            this.Load += new System.EventHandler(this.FDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.TextBox txtIDJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.DataGridView dGVJob;
        private System.Windows.Forms.DataGridView dGVStaff;
    }
}