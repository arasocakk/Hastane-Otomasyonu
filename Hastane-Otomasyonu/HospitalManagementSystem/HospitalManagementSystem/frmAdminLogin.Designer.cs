namespace HospitalManagementSystem
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            this.lblAdminLog = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGirisAdm = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbSifreGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminLog
            // 
            this.lblAdminLog.AutoSize = true;
            this.lblAdminLog.Font = new System.Drawing.Font("Lobster", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminLog.Location = new System.Drawing.Point(95, 18);
            this.lblAdminLog.Name = "lblAdminLog";
            this.lblAdminLog.Size = new System.Drawing.Size(203, 52);
            this.lblAdminLog.TabIndex = 0;
            this.lblAdminLog.Text = "Admin Girişi";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(164, 86);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(166, 20);
            this.txtAdminName.TabIndex = 1;
            this.txtAdminName.Text = "admin";
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(164, 130);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(166, 20);
            this.txtAdminSifre.TabIndex = 2;
            this.txtAdminSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Righteous", 15F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(95, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 26);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifre:";
            // 
            // btnGirisAdm
            // 
            this.btnGirisAdm.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisAdm.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisAdm.Location = new System.Drawing.Point(164, 168);
            this.btnGirisAdm.Name = "btnGirisAdm";
            this.btnGirisAdm.Size = new System.Drawing.Size(117, 31);
            this.btnGirisAdm.TabIndex = 6;
            this.btnGirisAdm.Text = "GİRİŞ";
            this.btnGirisAdm.UseVisualStyleBackColor = false;
            this.btnGirisAdm.Click += new System.EventHandler(this.btnGirisAdm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(384, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 35);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.adminPNG5850;
            this.pictureBox1.Location = new System.Drawing.Point(12, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // chbSifreGoster
            // 
            this.chbSifreGoster.AutoSize = true;
            this.chbSifreGoster.Location = new System.Drawing.Point(336, 132);
            this.chbSifreGoster.Name = "chbSifreGoster";
            this.chbSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.chbSifreGoster.TabIndex = 14;
            this.chbSifreGoster.Text = "Şifreyi Göster";
            this.chbSifreGoster.UseVisualStyleBackColor = true;
            this.chbSifreGoster.CheckedChanged += new System.EventHandler(this.chbSifreGoster_CheckedChanged);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(427, 211);
            this.Controls.Add(this.chbSifreGoster);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGirisAdm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblAdminLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Girişi";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminLog;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGirisAdm;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox chbSifreGoster;
    }
}