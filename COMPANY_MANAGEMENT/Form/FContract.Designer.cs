using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    partial class FContract
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.gvContract = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSigningDate = new System.Windows.Forms.Label();
            this.lbEffectiveDate = new System.Windows.Forms.Label();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtSigningDate = new System.Windows.Forms.DateTimePicker();
            this.dtEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btInsert);
            this.flowLayoutPanel1.Controls.Add(this.btDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 462);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 57);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdate.Location = new System.Drawing.Point(3, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(125, 48);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInsert.Location = new System.Drawing.Point(134, 3);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(125, 48);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDelete.Location = new System.Drawing.Point(265, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(125, 48);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // gvContract
            // 
            this.gvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContract.Location = new System.Drawing.Point(488, 3);
            this.gvContract.Name = "gvContract";
            this.gvContract.RowHeadersWidth = 51;
            this.gvContract.RowTemplate.Height = 29;
            this.gvContract.Size = new System.Drawing.Size(593, 516);
            this.gvContract.TabIndex = 20;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 28);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 20);
            this.lbID.TabIndex = 21;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 64);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(106, 20);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Contract name";
            // 
            // lbSigningDate
            // 
            this.lbSigningDate.AutoSize = true;
            this.lbSigningDate.Location = new System.Drawing.Point(12, 99);
            this.lbSigningDate.Name = "lbSigningDate";
            this.lbSigningDate.Size = new System.Drawing.Size(93, 20);
            this.lbSigningDate.TabIndex = 23;
            this.lbSigningDate.Text = "Signing date";
            // 
            // lbEffectiveDate
            // 
            this.lbEffectiveDate.AutoSize = true;
            this.lbEffectiveDate.Location = new System.Drawing.Point(12, 132);
            this.lbEffectiveDate.Name = "lbEffectiveDate";
            this.lbEffectiveDate.Size = new System.Drawing.Size(100, 20);
            this.lbEffectiveDate.TabIndex = 24;
            this.lbEffectiveDate.Text = "Effective date";
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(12, 165);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(68, 20);
            this.lbDateEnd.TabIndex = 25;
            this.lbDateEnd.Text = "End date";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(12, 204);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 26;
            this.lbPrice.Text = "Price";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(12, 237);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(61, 20);
            this.lbContent.TabIndex = 27;
            this.lbContent.Text = "Content";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(12, 398);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(94, 20);
            this.lbEmployeeID.TabIndex = 28;
            this.lbEmployeeID.Text = "Employee ID";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(12, 432);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(91, 20);
            this.lbCustomerID.TabIndex = 29;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(130, 237);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(340, 152);
            this.rtxtContent.TabIndex = 30;
            this.rtxtContent.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(340, 27);
            this.txtID.TabIndex = 31;
            // 
            // txtContractName
            // 
            this.txtContractName.Location = new System.Drawing.Point(130, 61);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(340, 27);
            this.txtContractName.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 27);
            this.textBox3.TabIndex = 33;
            // 
            // dtSigningDate
            // 
            this.dtSigningDate.Location = new System.Drawing.Point(132, 94);
            this.dtSigningDate.Name = "dtSigningDate";
            this.dtSigningDate.Size = new System.Drawing.Size(338, 27);
            this.dtSigningDate.TabIndex = 34;
            // 
            // dtEffectiveDate
            // 
            this.dtEffectiveDate.Location = new System.Drawing.Point(132, 127);
            this.dtEffectiveDate.Name = "dtEffectiveDate";
            this.dtEffectiveDate.Size = new System.Drawing.Size(338, 27);
            this.dtEffectiveDate.TabIndex = 35;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(132, 160);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(338, 27);
            this.dateTimePicker3.TabIndex = 36;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(130, 395);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(340, 27);
            this.txtEmployeeID.TabIndex = 37;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(130, 429);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(340, 27);
            this.txtCustomerID.TabIndex = 38;
            // 
            // FContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 523);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dtEffectiveDate);
            this.Controls.Add(this.dtSigningDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtContractName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDateEnd);
            this.Controls.Add(this.lbEffectiveDate);
            this.Controls.Add(this.lbSigningDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.gvContract);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FContract";
            this.Text = "FContract";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btUpdate;
        private Button btInsert;
        private Button btDelete;
        private DataGridView gvContract;
        private Label lbID;
        private Label lbName;
        private Label lbSigningDate;
        private Label lbEffectiveDate;
        private Label lbDateEnd;
        private Label lbPrice;
        private Label lbContent;
        private Label lbEmployeeID;
        private Label lbCustomerID;
        private RichTextBox rtxtContent;
        private TextBox txtID;
        private TextBox txtContractName;
        private TextBox textBox3;
        private DateTimePicker dtSigningDate;
        private DateTimePicker dtEffectiveDate;
        private DateTimePicker dateTimePicker3;
        private TextBox txtEmployeeID;
        private TextBox txtCustomerID;
    }
}