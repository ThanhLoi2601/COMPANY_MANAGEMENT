using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
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
            this.btSent = new System.Windows.Forms.Button();
            this.cbBoxIDRe = new System.Windows.Forms.ComboBox();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtNameSent = new System.Windows.Forms.TextBox();
            this.txtIDSent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGVContact = new System.Windows.Forms.DataGridView();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVContact)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLoadHightLight);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(604, 662);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // btSent
            // 
            this.btSent.BackgroundImage = global::COMPANY_MANAGEMENT.Properties.Resources.c5cfbe450622d87c81331;
            this.btSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSent.FlatAppearance.BorderSize = 0;
            this.btSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSent.Location = new System.Drawing.Point(427, 583);
            this.btSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btSent.Name = "btSent";
            this.btSent.Size = new System.Drawing.Size(158, 75);
            this.btSent.TabIndex = 10;
            this.btSent.UseVisualStyleBackColor = true;
            this.btSent.Click += new System.EventHandler(this.btSent_Click);
            // 
            // cbBoxIDRe
            // 
            this.cbBoxIDRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxIDRe.FormattingEnabled = true;
            this.cbBoxIDRe.Items.AddRange(new object[] {
            "All Staff",
            "All Manager",
            "All"});
            this.cbBoxIDRe.Location = new System.Drawing.Point(160, 549);
            this.cbBoxIDRe.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbBoxIDRe.Name = "cbBoxIDRe";
            this.cbBoxIDRe.Size = new System.Drawing.Size(240, 30);
            this.cbBoxIDRe.TabIndex = 9;
            // 
            // rTxtContent
            // 
            this.rTxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtContent.Location = new System.Drawing.Point(23, 300);
            this.rTxtContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(482, 219);
            this.rTxtContent.TabIndex = 8;
            this.rTxtContent.Text = "";
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(160, 212);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(435, 28);
            this.txtSub.TabIndex = 7;
            // 
            // txtNameSent
            // 
            this.txtNameSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSent.Location = new System.Drawing.Point(160, 133);
            this.txtNameSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNameSent.Name = "txtNameSent";
            this.txtNameSent.ReadOnly = true;
            this.txtNameSent.Size = new System.Drawing.Size(284, 28);
            this.txtNameSent.TabIndex = 6;
            // 
            // txtIDSent
            // 
            this.txtIDSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSent.Location = new System.Drawing.Point(160, 62);
            this.txtIDSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDSent.Name = "txtIDSent";
            this.txtIDSent.ReadOnly = true;
            this.txtIDSent.Size = new System.Drawing.Size(284, 28);
            this.txtIDSent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 558);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Receive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Sent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sent";
            // 
            // dtGVContact
            // 
            this.dtGVContact.BackgroundColor = System.Drawing.Color.White;
            this.dtGVContact.ColumnHeadersHeight = 29;
            this.dtGVContact.Location = new System.Drawing.Point(626, 11);
            this.dtGVContact.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtGVContact.Name = "dtGVContact";
            this.dtGVContact.RowHeadersWidth = 51;
            this.dtGVContact.RowTemplate.Height = 29;
            this.dtGVContact.Size = new System.Drawing.Size(610, 648);
            this.dtGVContact.TabIndex = 0;
            this.dtGVContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVContact_CellClick);
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(254, 583);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(146, 75);
            this.btLoadHightLight.TabIndex = 12;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // FContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 674);
            this.Controls.Add(this.dtGVContact);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FContact";
            this.Text = "FContact";
            this.Load += new System.EventHandler(this.FContact_Load);
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
        private Button btLoadHightLight;
    }
}