namespace HospitalManagementSystem
{
    partial class frmDoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorLogin));
            this.btnGirisDoktr = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorSifre = new System.Windows.Forms.TextBox();
            this.txtDoctorTc = new System.Windows.Forms.TextBox();
            this.lblAdminLog = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbSifreGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisDoktr
            // 
            this.btnGirisDoktr.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisDoktr.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisDoktr.Location = new System.Drawing.Point(200, 196);
            this.btnGirisDoktr.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisDoktr.Name = "btnGirisDoktr";
            this.btnGirisDoktr.Size = new System.Drawing.Size(156, 38);
            this.btnGirisDoktr.TabIndex = 12;
            this.btnGirisDoktr.Text = "GİRİŞ";
            this.btnGirisDoktr.UseVisualStyleBackColor = false;
            this.btnGirisDoktr.Click += new System.EventHandler(this.btnGirisDoktr_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Righteous", 15F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(124, 144);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 32);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC:";
            // 
            // txtDoctorSifre
            // 
            this.txtDoctorSifre.Location = new System.Drawing.Point(213, 150);
            this.txtDoctorSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorSifre.Name = "txtDoctorSifre";
            this.txtDoctorSifre.Size = new System.Drawing.Size(175, 22);
            this.txtDoctorSifre.TabIndex = 9;
            this.txtDoctorSifre.UseSystemPasswordChar = true;
            // 
            // txtDoctorTc
            // 
            this.txtDoctorTc.Location = new System.Drawing.Point(212, 96);
            this.txtDoctorTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorTc.Name = "txtDoctorTc";
            this.txtDoctorTc.Size = new System.Drawing.Size(175, 22);
            this.txtDoctorTc.TabIndex = 8;
            // 
            // lblAdminLog
            // 
            this.lblAdminLog.AutoSize = true;
            this.lblAdminLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminLog.Location = new System.Drawing.Point(121, 23);
            this.lblAdminLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminLog.Name = "lblAdminLog";
            this.lblAdminLog.Size = new System.Drawing.Size(277, 52);
            this.lblAdminLog.TabIndex = 7;
            this.lblAdminLog.Text = "Doktor Girişi";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(468, 4);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.doctorNew5850;
            this.pictureBox1.Location = new System.Drawing.Point(16, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chbSifreGoster
            // 
            this.chbSifreGoster.AutoSize = true;
            this.chbSifreGoster.Location = new System.Drawing.Point(397, 153);
            this.chbSifreGoster.Margin = new System.Windows.Forms.Padding(4);
            this.chbSifreGoster.Name = "chbSifreGoster";
            this.chbSifreGoster.Size = new System.Drawing.Size(109, 20);
            this.chbSifreGoster.TabIndex = 15;
            this.chbSifreGoster.Text = "Şifreyi Göster";
            this.chbSifreGoster.UseVisualStyleBackColor = true;
            this.chbSifreGoster.CheckedChanged += new System.EventHandler(this.chbSifreGoster_CheckedChanged);
            // 
            // frmDoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(525, 260);
            this.Controls.Add(this.chbSifreGoster);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGirisDoktr);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoctorSifre);
            this.Controls.Add(this.txtDoctorTc);
            this.Controls.Add(this.lblAdminLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoctorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Girişi";
            this.Load += new System.EventHandler(this.frmDoctorLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisDoktr;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorSifre;
        private System.Windows.Forms.TextBox txtDoctorTc;
        private System.Windows.Forms.Label lblAdminLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox chbSifreGoster;
    }
}