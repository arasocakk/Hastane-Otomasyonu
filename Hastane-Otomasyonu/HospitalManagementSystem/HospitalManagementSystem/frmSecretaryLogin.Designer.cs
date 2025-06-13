namespace HospitalManagementSystem
{
    partial class frmSecreteryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecreteryLogin));
            this.btnGirisSekr = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSekreterSifre = new System.Windows.Forms.TextBox();
            this.txtSekreterTc = new System.Windows.Forms.TextBox();
            this.lblAdminLog = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbSifreGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisSekr
            // 
            this.btnGirisSekr.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisSekr.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisSekr.Location = new System.Drawing.Point(142, 159);
            this.btnGirisSekr.Name = "btnGirisSekr";
            this.btnGirisSekr.Size = new System.Drawing.Size(117, 31);
            this.btnGirisSekr.TabIndex = 12;
            this.btnGirisSekr.Text = "GİRİŞ";
            this.btnGirisSekr.UseVisualStyleBackColor = false;
            this.btnGirisSekr.Click += new System.EventHandler(this.btnGirisSekr_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Righteous", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(88, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 26);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC:";
            // 
            // txtSekreterSifre
            // 
            this.txtSekreterSifre.Location = new System.Drawing.Point(161, 122);
            this.txtSekreterSifre.Name = "txtSekreterSifre";
            this.txtSekreterSifre.Size = new System.Drawing.Size(132, 20);
            this.txtSekreterSifre.TabIndex = 9;
            // 
            // txtSekreterTc
            // 
            this.txtSekreterTc.Location = new System.Drawing.Point(161, 73);
            this.txtSekreterTc.Name = "txtSekreterTc";
            this.txtSekreterTc.Size = new System.Drawing.Size(132, 20);
            this.txtSekreterTc.TabIndex = 8;
            // 
            // lblAdminLog
            // 
            this.lblAdminLog.AutoSize = true;
            this.lblAdminLog.Font = new System.Drawing.Font("Righteous", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminLog.Location = new System.Drawing.Point(70, 9);
            this.lblAdminLog.Name = "lblAdminLog";
            this.lblAdminLog.Size = new System.Drawing.Size(260, 44);
            this.lblAdminLog.TabIndex = 7;
            this.lblAdminLog.Text = "Sekreter Girişi";
            this.lblAdminLog.Click += new System.EventHandler(this.lblAdminLog_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(352, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 35);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.medical_secretary_5850;
            this.pictureBox1.Location = new System.Drawing.Point(12, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chbSifreGoster
            // 
            this.chbSifreGoster.AutoSize = true;
            this.chbSifreGoster.Location = new System.Drawing.Point(299, 125);
            this.chbSifreGoster.Name = "chbSifreGoster";
            this.chbSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.chbSifreGoster.TabIndex = 16;
            this.chbSifreGoster.Text = "Şifreyi Göster";
            this.chbSifreGoster.UseVisualStyleBackColor = true;
            this.chbSifreGoster.CheckedChanged += new System.EventHandler(this.chbSifreGoster_CheckedChanged);
            // 
            // frmSecreteryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(394, 205);
            this.Controls.Add(this.chbSifreGoster);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGirisSekr);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSekreterSifre);
            this.Controls.Add(this.txtSekreterTc);
            this.Controls.Add(this.lblAdminLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecreteryLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Girişi";
            this.Load += new System.EventHandler(this.frmSecreteryLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisSekr;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSekreterSifre;
        private System.Windows.Forms.TextBox txtSekreterTc;
        private System.Windows.Forms.Label lblAdminLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox chbSifreGoster;
    }
}