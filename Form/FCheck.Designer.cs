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
            this.components = new System.ComponentModel.Container();
            this.dateTimeCheck = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkOUT = new System.Windows.Forms.CheckBox();
            this.checkIN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btConfirm = new System.Windows.Forms.Button();
            this.cbDsCV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTienDo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeCheck
            // 
            this.dateTimeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheck.Location = new System.Drawing.Point(160, 14);
            this.dateTimeCheck.Name = "dateTimeCheck";
            this.dateTimeCheck.Size = new System.Drawing.Size(278, 27);
            this.dateTimeCheck.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkOUT);
            this.groupBox1.Controls.Add(this.checkIN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTION";
            // 
            // checkOUT
            // 
            this.checkOUT.AutoSize = true;
            this.checkOUT.Location = new System.Drawing.Point(15, 70);
            this.checkOUT.Name = "checkOUT";
            this.checkOUT.Size = new System.Drawing.Size(113, 24);
            this.checkOUT.TabIndex = 9;
            this.checkOUT.Text = "CheckOut";
            this.checkOUT.UseVisualStyleBackColor = true;
            // 
            // checkIN
            // 
            this.checkIN.AutoSize = true;
            this.checkIN.Location = new System.Drawing.Point(15, 26);
            this.checkIN.Name = "checkIN";
            this.checkIN.Size = new System.Drawing.Size(98, 24);
            this.checkIN.TabIndex = 8;
            this.checkIN.Text = "CheckIn";
            this.checkIN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(542, 222);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(125, 46);
            this.btConfirm.TabIndex = 24;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // cbDsCV
            // 
            this.cbDsCV.FormattingEnabled = true;
            this.cbDsCV.Location = new System.Drawing.Point(275, 199);
            this.cbDsCV.Name = "cbDsCV";
            this.cbDsCV.Size = new System.Drawing.Size(186, 24);
            this.cbDsCV.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Danh sách công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tiến độ công việc";
            // 
            // textTienDo
            // 
            this.textTienDo.Location = new System.Drawing.Point(275, 248);
            this.textTienDo.Name = "textTienDo";
            this.textTienDo.Size = new System.Drawing.Size(186, 22);
            this.textTienDo.TabIndex = 29;
            // 
            // FCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 277);
            this.Controls.Add(this.textTienDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDsCV);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeCheck);
            this.Name = "FCheck";
            this.Text = "Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCheck_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCheck_FormClosed);
            this.Load += new System.EventHandler(this.FCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.CheckBox checkOUT;
        private System.Windows.Forms.CheckBox checkIN;
        private System.Windows.Forms.ComboBox cbDsCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTienDo;
    }
}