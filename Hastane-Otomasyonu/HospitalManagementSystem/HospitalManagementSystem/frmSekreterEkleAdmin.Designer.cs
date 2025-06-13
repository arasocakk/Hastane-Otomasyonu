namespace HospitalManagementSystem
{
    partial class frmSekreterEkleAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterEkleAdmin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridSecretary = new System.Windows.Forms.DataGridView();
            this.maskTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkleSekreter = new System.Windows.Forms.Button();
            this.btnSekreterGuncelle = new System.Windows.Forms.Button();
            this.btnSekreterSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSekreterArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecretary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(456, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin Sayfası ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridSecretary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(427, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(880, 315);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Listesi";
            // 
            // gridSecretary
            // 
            this.gridSecretary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSecretary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecretary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSecretary.Location = new System.Drawing.Point(9, 25);
            this.gridSecretary.Margin = new System.Windows.Forms.Padding(4);
            this.gridSecretary.Name = "gridSecretary";
            this.gridSecretary.RowHeadersVisible = false;
            this.gridSecretary.RowHeadersWidth = 51;
            this.gridSecretary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSecretary.Size = new System.Drawing.Size(863, 283);
            this.gridSecretary.TabIndex = 65;
            // 
            // maskTxtTC
            // 
            this.maskTxtTC.Font = new System.Drawing.Font("Righteous", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskTxtTC.Location = new System.Drawing.Point(179, 75);
            this.maskTxtTC.Margin = new System.Windows.Forms.Padding(4);
            this.maskTxtTC.Mask = "00000000000";
            this.maskTxtTC.Name = "maskTxtTC";
            this.maskTxtTC.Size = new System.Drawing.Size(185, 25);
            this.maskTxtTC.TabIndex = 16;
            this.maskTxtTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(64, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(49, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "Şifre:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Righteous", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(180, 123);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(183, 25);
            this.txtAd.TabIndex = 23;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Righteous", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(180, 171);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(183, 25);
            this.txtSoyad.TabIndex = 24;
            // 
            // btnEkleSekreter
            // 
            this.btnEkleSekreter.BackColor = System.Drawing.Color.Transparent;
            this.btnEkleSekreter.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleSekreter.Location = new System.Drawing.Point(99, 298);
            this.btnEkleSekreter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkleSekreter.Name = "btnEkleSekreter";
            this.btnEkleSekreter.Size = new System.Drawing.Size(201, 57);
            this.btnEkleSekreter.TabIndex = 25;
            this.btnEkleSekreter.Text = "EKLE";
            this.btnEkleSekreter.UseVisualStyleBackColor = false;
            this.btnEkleSekreter.Click += new System.EventHandler(this.btnEkleSekreter_Click);
            // 
            // btnSekreterGuncelle
            // 
            this.btnSekreterGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnSekreterGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterGuncelle.Location = new System.Drawing.Point(197, 361);
            this.btnSekreterGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSekreterGuncelle.Name = "btnSekreterGuncelle";
            this.btnSekreterGuncelle.Size = new System.Drawing.Size(151, 50);
            this.btnSekreterGuncelle.TabIndex = 26;
            this.btnSekreterGuncelle.Text = "GÜNCELLE";
            this.btnSekreterGuncelle.UseVisualStyleBackColor = false;
            this.btnSekreterGuncelle.Click += new System.EventHandler(this.btnSekreterGuncelle_Click);
            // 
            // btnSekreterSil
            // 
            this.btnSekreterSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSekreterSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterSil.Location = new System.Drawing.Point(56, 362);
            this.btnSekreterSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSekreterSil.Name = "btnSekreterSil";
            this.btnSekreterSil.Size = new System.Drawing.Size(133, 49);
            this.btnSekreterSil.TabIndex = 27;
            this.btnSekreterSil.Text = "SİL";
            this.btnSekreterSil.UseVisualStyleBackColor = false;
            this.btnSekreterSil.Click += new System.EventHandler(this.btnSekreterSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.adminPNG5850;
            this.pictureBox1.Location = new System.Drawing.Point(1229, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Righteous", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(180, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 25);
            this.txtPassword.TabIndex = 28;
            // 
            // txtSekreterArama
            // 
            this.txtSekreterArama.Location = new System.Drawing.Point(960, 71);
            this.txtSekreterArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtSekreterArama.Name = "txtSekreterArama";
            this.txtSekreterArama.Size = new System.Drawing.Size(217, 22);
            this.txtSekreterArama.TabIndex = 31;
            this.txtSekreterArama.TextChanged += new System.EventHandler(this.txtSekreterArama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(728, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adına Göre Arama:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(4, 2);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmSekreterEkleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1323, 433);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSekreterArama);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSekreterSil);
            this.Controls.Add(this.btnSekreterGuncelle);
            this.Controls.Add(this.btnEkleSekreter);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskTxtTC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSekreterEkleAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Sayfası";
            this.Load += new System.EventHandler(this.frmSekreterEkleAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSecretary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskTxtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkleSekreter;
        private System.Windows.Forms.Button btnSekreterGuncelle;
        private System.Windows.Forms.Button btnSekreterSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSekreterArama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView gridSecretary;
    }
}