namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FPayroll
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
            this.lbKPI = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataChuyenCan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataCVHT = new System.Windows.Forms.DataGridView();
            this.textBonus = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChuyenCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCVHT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHUYÊN CẦN";
            // 
            // lbKPI
            // 
            this.lbKPI.AutoSize = true;
            this.lbKPI.BackColor = System.Drawing.SystemColors.Info;
            this.lbKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKPI.Location = new System.Drawing.Point(853, 87);
            this.lbKPI.Name = "lbKPI";
            this.lbKPI.Size = new System.Drawing.Size(33, 20);
            this.lbKPI.TabIndex = 13;
            this.lbKPI.Text = "****";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(698, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "KPI: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiền thưởng:";
            // 
            // txtFine
            // 
            this.txtFine.Enabled = false;
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(816, 185);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(100, 27);
            this.txtFine.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tiền phạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiền lương tổng:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.SystemColors.Info;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(853, 235);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(33, 20);
            this.lbSalary.TabIndex = 19;
            this.lbSalary.Text = "****";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.dataChuyenCan);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.dataCVHT);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 438);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // dataChuyenCan
            // 
            this.dataChuyenCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChuyenCan.Location = new System.Drawing.Point(3, 28);
            this.dataChuyenCan.Name = "dataChuyenCan";
            this.dataChuyenCan.RowHeadersWidth = 51;
            this.dataChuyenCan.RowTemplate.Height = 24;
            this.dataChuyenCan.Size = new System.Drawing.Size(628, 203);
            this.dataChuyenCan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "DS CÔNG VIỆC ĐÃ HOÀN THÀNH";
            // 
            // dataCVHT
            // 
            this.dataCVHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCVHT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCVHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCVHT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataCVHT.Location = new System.Drawing.Point(3, 262);
            this.dataCVHT.Name = "dataCVHT";
            this.dataCVHT.RowHeadersWidth = 51;
            this.dataCVHT.RowTemplate.Height = 24;
            this.dataCVHT.Size = new System.Drawing.Size(628, 181);
            this.dataCVHT.TabIndex = 5;
            // 
            // textBonus
            // 
            this.textBonus.Location = new System.Drawing.Point(816, 132);
            this.textBonus.Name = "textBonus";
            this.textBonus.ReadOnly = true;
            this.textBonus.Size = new System.Drawing.Size(100, 22);
            this.textBonus.TabIndex = 21;
            // 
            // FPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 439);
            this.Controls.Add(this.textBonus);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKPI);
            this.Controls.Add(this.label10);
            this.Name = "FPayroll";
            this.Text = "PAYROLL";
            this.Load += new System.EventHandler(this.FPayroll_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChuyenCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCVHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKPI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataChuyenCan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataCVHT;
        private System.Windows.Forms.TextBox textBonus;
    }
}