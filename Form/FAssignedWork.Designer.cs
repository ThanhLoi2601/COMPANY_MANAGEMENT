namespace COMPANY_MANAGEMENT
{
    partial class FAssignedWork
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
            this.dataCVPC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCVPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCVPC
            // 
            this.dataCVPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCVPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCVPC.Location = new System.Drawing.Point(0, 0);
            this.dataCVPC.Name = "dataCVPC";
            this.dataCVPC.RowHeadersWidth = 51;
            this.dataCVPC.RowTemplate.Height = 24;
            this.dataCVPC.Size = new System.Drawing.Size(506, 296);
            this.dataCVPC.TabIndex = 0;
            // 
            // FAssignedWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 296);
            this.Controls.Add(this.dataCVPC);
            this.Name = "FAssignedWork";
            this.Text = "Assigned Work";
            this.Load += new System.EventHandler(this.FAssignedWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCVPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCVPC;
    }
}