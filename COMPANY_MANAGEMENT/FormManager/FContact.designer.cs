﻿using System;
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
            this.dtGVSent = new System.Windows.Forms.DataGridView();
            this.dtGVReceive = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            this.btSent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(495, 728);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // cbBoxIDRe
            // 
            this.cbBoxIDRe.FormattingEnabled = true;
            this.cbBoxIDRe.Items.AddRange(new object[] {
            "All Staff"});
            this.cbBoxIDRe.Location = new System.Drawing.Point(160, 613);
            this.cbBoxIDRe.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbBoxIDRe.Name = "cbBoxIDRe";
            this.cbBoxIDRe.Size = new System.Drawing.Size(201, 33);
            this.cbBoxIDRe.TabIndex = 9;
            // 
            // rTxtContent
            // 
            this.rTxtContent.Location = new System.Drawing.Point(7, 365);
            this.rTxtContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(455, 219);
            this.rTxtContent.TabIndex = 8;
            this.rTxtContent.Text = "";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(148, 236);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(314, 30);
            this.txtSub.TabIndex = 7;
            // 
            // txtNameSent
            // 
            this.txtNameSent.Location = new System.Drawing.Point(148, 140);
            this.txtNameSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNameSent.Name = "txtNameSent";
            this.txtNameSent.Size = new System.Drawing.Size(198, 30);
            this.txtNameSent.TabIndex = 6;
            // 
            // txtIDSent
            // 
            this.txtIDSent.Location = new System.Drawing.Point(148, 62);
            this.txtIDSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDSent.Name = "txtIDSent";
            this.txtIDSent.Size = new System.Drawing.Size(198, 30);
            this.txtIDSent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 622);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Receive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Sent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sent";
            // 
            // dtGVSent
            // 
            this.dtGVSent.BackgroundColor = System.Drawing.Color.White;
            this.dtGVSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVSent.Location = new System.Drawing.Point(635, 1);
            this.dtGVSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtGVSent.Name = "dtGVSent";
            this.dtGVSent.RowHeadersWidth = 51;
            this.dtGVSent.RowTemplate.Height = 29;
            this.dtGVSent.Size = new System.Drawing.Size(563, 364);
            this.dtGVSent.TabIndex = 1;
            this.dtGVSent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVSent_CellClick);
            // 
            // dtGVReceive
            // 
            this.dtGVReceive.BackgroundColor = System.Drawing.Color.White;
            this.dtGVReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVReceive.Location = new System.Drawing.Point(517, 366);
            this.dtGVReceive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtGVReceive.Name = "dtGVReceive";
            this.dtGVReceive.RowHeadersWidth = 51;
            this.dtGVReceive.RowTemplate.Height = 29;
            this.dtGVReceive.Size = new System.Drawing.Size(536, 363);
            this.dtGVReceive.TabIndex = 2;
            this.dtGVReceive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVReceive_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "SENT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1054, 542);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "RECEIVE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::COMPANY_MANAGEMENT.Properties.Resources._22f71249fb2e25707c3f;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(1096, 585);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 63);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COMPANY_MANAGEMENT.Properties.Resources.commercial_64px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(550, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 63);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(22, 650);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(146, 71);
            this.btLoadHightLight.TabIndex = 11;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // btSent
            // 
            this.btSent.FlatAppearance.BorderSize = 0;
            this.btSent.Image = global::COMPANY_MANAGEMENT.Properties.Resources.c5cfbe450622d87c81331;
            this.btSent.Location = new System.Drawing.Point(327, 650);
            this.btSent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btSent.Name = "btSent";
            this.btSent.Size = new System.Drawing.Size(146, 71);
            this.btSent.TabIndex = 10;
            this.btSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSent.UseVisualStyleBackColor = true;
            this.btSent.Click += new System.EventHandler(this.btSent_Click);
            // 
            // FContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtGVReceive);
            this.Controls.Add(this.dtGVSent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FContact";
            this.Text = "FContact";
            this.Load += new System.EventHandler(this.FContact_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView dtGVSent;
        private DataGridView dtGVReceive;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btLoadHightLight;
    }
}