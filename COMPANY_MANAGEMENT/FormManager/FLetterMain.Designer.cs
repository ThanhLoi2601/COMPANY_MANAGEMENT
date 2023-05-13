namespace COMPANY_MANAGEMENT
{
    partial class FLetterMain
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
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.rbSeeStaff = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.btConfirm);
            this.gbOption.Controls.Add(this.rbSeeStaff);
            this.gbOption.Controls.Add(this.rbCreate);
            this.gbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOption.Location = new System.Drawing.Point(15, 15);
            this.gbOption.Margin = new System.Windows.Forms.Padding(4);
            this.gbOption.Name = "gbOption";
            this.gbOption.Padding = new System.Windows.Forms.Padding(4);
            this.gbOption.Size = new System.Drawing.Size(520, 224);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "OPTION";
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(342, 164);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(170, 52);
            this.btConfirm.TabIndex = 11;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // rbSeeStaff
            // 
            this.rbSeeStaff.AutoSize = true;
            this.rbSeeStaff.Location = new System.Drawing.Point(272, 61);
            this.rbSeeStaff.Margin = new System.Windows.Forms.Padding(4);
            this.rbSeeStaff.Name = "rbSeeStaff";
            this.rbSeeStaff.Size = new System.Drawing.Size(152, 29);
            this.rbSeeStaff.TabIndex = 1;
            this.rbSeeStaff.TabStop = true;
            this.rbSeeStaff.Text = "SEE STAFF";
            this.rbSeeStaff.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(19, 61);
            this.rbCreate.Margin = new System.Windows.Forms.Padding(4);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(120, 29);
            this.rbCreate.TabIndex = 0;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "CREATE";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // FLetterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 254);
            this.Controls.Add(this.gbOption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLetterMain";
            this.Text = "ABSENCE LETTER";
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbSeeStaff;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.Button btConfirm;
    }
}