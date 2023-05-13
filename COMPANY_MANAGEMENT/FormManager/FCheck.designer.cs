namespace COMPANY_MANAGEMENT
{
    partial class FCheck
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
            this.dtCheckinout = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCheckinout)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCheckinout
            // 
            this.dtCheckinout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCheckinout.BackgroundColor = System.Drawing.Color.White;
            this.dtCheckinout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCheckinout.Location = new System.Drawing.Point(4, 1);
            this.dtCheckinout.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheckinout.Name = "dtCheckinout";
            this.dtCheckinout.RowHeadersWidth = 51;
            this.dtCheckinout.RowTemplate.Height = 24;
            this.dtCheckinout.Size = new System.Drawing.Size(1192, 728);
            this.dtCheckinout.TabIndex = 0;
            // 
            // FCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 733);
            this.Controls.Add(this.dtCheckinout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCheck";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.FCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCheckinout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtCheckinout;
    }
}