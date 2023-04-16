namespace COMPANY_MANAGEMENT
{
    partial class FContact
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVContact = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDSent = new System.Windows.Forms.TextBox();
            this.txtNameSent = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.cbBoxIDRe = new System.Windows.Forms.ComboBox();
            this.btSent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVContact)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSent);
            this.groupBox1.Controls.Add(this.cbBoxIDRe);
            this.groupBox1.Controls.Add(this.rTxtContent);
            this.groupBox1.Controls.Add(this.txtSub);
            this.groupBox1.Controls.Add(this.txtNameSent);
            this.groupBox1.Controls.Add(this.txtIDSent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // dtGVContact
            // 
            this.dtGVContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVContact.Location = new System.Drawing.Point(578, 12);
            this.dtGVContact.Name = "dtGVContact";
            this.dtGVContact.RowHeadersWidth = 51;
            this.dtGVContact.RowTemplate.Height = 29;
            this.dtGVContact.Size = new System.Drawing.Size(638, 637);
            this.dtGVContact.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Sent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Receive";
            // 
            // txtIDSent
            // 
            this.txtIDSent.Location = new System.Drawing.Point(142, 45);
            this.txtIDSent.Name = "txtIDSent";
            this.txtIDSent.Size = new System.Drawing.Size(253, 27);
            this.txtIDSent.TabIndex = 5;
            // 
            // txtNameSent
            // 
            this.txtNameSent.Location = new System.Drawing.Point(142, 116);
            this.txtNameSent.Name = "txtNameSent";
            this.txtNameSent.Size = new System.Drawing.Size(253, 27);
            this.txtNameSent.TabIndex = 6;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(142, 193);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(387, 27);
            this.txtSub.TabIndex = 7;
            // 
            // rTxtContent
            // 
            this.rTxtContent.Location = new System.Drawing.Point(17, 298);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(512, 243);
            this.rTxtContent.TabIndex = 8;
            this.rTxtContent.Text = "";
            // 
            // cbBoxIDRe
            // 
            this.cbBoxIDRe.FormattingEnabled = true;
            this.cbBoxIDRe.Items.AddRange(new object[] {
            "All Staff",
            "All Manager",
            "All"});
            this.cbBoxIDRe.Location = new System.Drawing.Point(142, 547);
            this.cbBoxIDRe.Name = "cbBoxIDRe";
            this.cbBoxIDRe.Size = new System.Drawing.Size(253, 28);
            this.cbBoxIDRe.TabIndex = 9;
            // 
            // btSent
            // 
            this.btSent.Location = new System.Drawing.Point(373, 596);
            this.btSent.Name = "btSent";
            this.btSent.Size = new System.Drawing.Size(156, 46);
            this.btSent.TabIndex = 10;
            this.btSent.Text = "SENT";
            this.btSent.UseVisualStyleBackColor = true;
            // 
            // FContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 653);
            this.Controls.Add(this.dtGVContact);
            this.Controls.Add(this.groupBox1);
            this.Name = "FContact";
            this.Text = "FContact";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btSent;
        private ComboBox cbBoxIDRe;
        private RichTextBox rTxtContent;
        private TextBox txtSub;
        private TextBox txtNameSent;
        private TextBox txtIDSent;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtGVContact;
    }
}