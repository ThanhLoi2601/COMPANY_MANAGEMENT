namespace COMPANY_MANAGEMENT
{
    partial class FShowStaffLetter
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
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaffLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVStaffLetter
            // 
            this.dGVStaffLetter.BackgroundColor = System.Drawing.Color.White;
            this.dGVStaffLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStaffLetter.Location = new System.Drawing.Point(3, 2);
            this.dGVStaffLetter.Name = "dGVStaffLetter";
            this.dGVStaffLetter.RowHeadersWidth = 51;
            this.dGVStaffLetter.RowTemplate.Height = 24;
            this.dGVStaffLetter.Size = new System.Drawing.Size(778, 467);
            this.dGVStaffLetter.TabIndex = 0;
            // 
            // FShowStaffLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 470);
            this.Controls.Add(this.dGVStaffLetter);
            this.Name = "FShowStaffLetter";
            this.Text = "Show Staff Letter";
            this.Load += new System.EventHandler(this.FShowStaffLetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaffLetter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStaffLetter;
    }
}