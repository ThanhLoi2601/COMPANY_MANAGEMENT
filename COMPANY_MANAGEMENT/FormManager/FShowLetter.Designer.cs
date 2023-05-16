namespace COMPANY_MANAGEMENT
{
    partial class FShowLetter
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
            this.dGVStaffLetter = new System.Windows.Forms.DataGridView();
            this.btMin = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaffLetter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVStaffLetter
            // 
            this.dGVStaffLetter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStaffLetter.BackgroundColor = System.Drawing.Color.White;
            this.dGVStaffLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStaffLetter.Location = new System.Drawing.Point(4, 48);
            this.dGVStaffLetter.Margin = new System.Windows.Forms.Padding(4);
            this.dGVStaffLetter.Name = "dGVStaffLetter";
            this.dGVStaffLetter.RowHeadersWidth = 51;
            this.dGVStaffLetter.RowTemplate.Height = 24;
            this.dGVStaffLetter.Size = new System.Drawing.Size(978, 538);
            this.dGVStaffLetter.TabIndex = 0;
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Image = global::COMPANY_MANAGEMENT.Properties.Resources.minimize_window_30px;
            this.btMin.Location = new System.Drawing.Point(780, 12);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(79, 29);
            this.btMin.TabIndex = 7;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::COMPANY_MANAGEMENT.Properties.Resources.close_window_30px;
            this.btClose.Location = new System.Drawing.Point(881, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(79, 29);
            this.btClose.TabIndex = 5;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 49);
            this.panel1.TabIndex = 8;
            // 
            // FShowLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVStaffLetter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FShowLetter";
            this.Text = "Show Staff Letter";
            this.Load += new System.EventHandler(this.FShowLetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaffLetter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStaffLetter;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
    }
}