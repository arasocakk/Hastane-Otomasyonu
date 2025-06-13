namespace HospitalManagementSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnSecreteryLogin = new System.Windows.Forms.Button();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(258, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(455, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(184, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 61);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hoşgeldiniz!";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPowerOff.Image = global::HospitalManagementSystem.Properties.Resources.newpowerswitchPNG;
            this.btnPowerOff.Location = new System.Drawing.Point(12, 12);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(44, 38);
            this.btnPowerOff.TabIndex = 12;
            this.btnPowerOff.UseVisualStyleBackColor = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnSecreteryLogin
            // 
            this.btnSecreteryLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnSecreteryLogin.Image = global::HospitalManagementSystem.Properties.Resources.medicalsecretary150140;
            this.btnSecreteryLogin.Location = new System.Drawing.Point(450, 137);
            this.btnSecreteryLogin.Name = "btnSecreteryLogin";
            this.btnSecreteryLogin.Size = new System.Drawing.Size(150, 140);
            this.btnSecreteryLogin.TabIndex = 8;
            this.btnSecreteryLogin.UseVisualStyleBackColor = false;
            this.btnSecreteryLogin.Click += new System.EventHandler(this.btnSecreteryLogin_Click);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctorLogin.Image = global::HospitalManagementSystem.Properties.Resources.doctorNew150140;
            this.btnDoctorLogin.Location = new System.Drawing.Point(244, 137);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(150, 140);
            this.btnDoctorLogin.TabIndex = 7;
            this.btnDoctorLogin.UseVisualStyleBackColor = false;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.Image = global::HospitalManagementSystem.Properties.Resources.adminPNG;
            this.btnAdminLogin.Location = new System.Drawing.Point(36, 137);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(150, 140);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(663, 390);
            this.Controls.Add(this.btnPowerOff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSecreteryLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.Button btnSecreteryLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPowerOff;
    }
}

