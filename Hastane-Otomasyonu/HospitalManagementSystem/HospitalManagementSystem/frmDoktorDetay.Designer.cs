namespace HospitalManagementSystem
{
    partial class frmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.btnEkleDoktor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridDoktor = new System.Windows.Forms.DataGridView();
            this.txtDoktorAdiAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskDoktorTCAra = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSekreter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(541, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doktor Ekle";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 26);
            this.txtPassword.TabIndex = 36;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(148, 139);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(183, 26);
            this.txtSoyad.TabIndex = 35;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(148, 91);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(183, 26);
            this.txtAd.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 34);
            this.label5.TabIndex = 33;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 34);
            this.label4.TabIndex = 32;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 34);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ad:";
            // 
            // maskTxtTC
            // 
            this.maskTxtTC.Location = new System.Drawing.Point(147, 43);
            this.maskTxtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskTxtTC.Mask = "00000000000";
            this.maskTxtTC.Name = "maskTxtTC";
            this.maskTxtTC.Size = new System.Drawing.Size(185, 26);
            this.maskTxtTC.TabIndex = 30;
            this.maskTxtTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 34);
            this.label6.TabIndex = 37;
            this.label6.Text = "Branş:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(148, 231);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(184, 27);
            this.cmbBrans.TabIndex = 38;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorSil.Location = new System.Drawing.Point(31, 398);
            this.btnDoktorSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(133, 49);
            this.btnDoktorSil.TabIndex = 41;
            this.btnDoktorSil.Text = "SİL";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(172, 396);
            this.btnDoktorGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(151, 50);
            this.btnDoktorGuncelle.TabIndex = 40;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = false;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // btnEkleDoktor
            // 
            this.btnEkleDoktor.BackColor = System.Drawing.Color.Transparent;
            this.btnEkleDoktor.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleDoktor.Location = new System.Drawing.Point(73, 334);
            this.btnEkleDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleDoktor.Name = "btnEkleDoktor";
            this.btnEkleDoktor.Size = new System.Drawing.Size(201, 57);
            this.btnEkleDoktor.TabIndex = 39;
            this.btnEkleDoktor.Text = "EKLE";
            this.btnEkleDoktor.UseVisualStyleBackColor = false;
            this.btnEkleDoktor.Click += new System.EventHandler(this.btnEkleDoktor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridDoktor);
            this.groupBox1.Controls.Add(this.txtDoktorAdiAra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskDoktorTCAra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(399, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(948, 331);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Listesi ve Arama";
            // 
            // gridDoktor
            // 
            this.gridDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoktor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDoktor.Location = new System.Drawing.Point(8, 121);
            this.gridDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridDoktor.Name = "gridDoktor";
            this.gridDoktor.RowHeadersWidth = 51;
            this.gridDoktor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoktor.Size = new System.Drawing.Size(932, 172);
            this.gridDoktor.TabIndex = 47;
            this.gridDoktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDoktor_CellClick);
            this.gridDoktor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDoktor_CellContentClick);
            // 
            // txtDoktorAdiAra
            // 
            this.txtDoktorAdiAra.Location = new System.Drawing.Point(309, 81);
            this.txtDoktorAdiAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoktorAdiAra.Name = "txtDoktorAdiAra";
            this.txtDoktorAdiAra.Size = new System.Drawing.Size(203, 26);
            this.txtDoktorAdiAra.TabIndex = 46;
            this.txtDoktorAdiAra.TextChanged += new System.EventHandler(this.txtDoktorAdiAra_TextChanged);
            this.txtDoktorAdiAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoktorAdiAra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "Doktor Adı ile Arama:";
            // 
            // maskDoktorTCAra
            // 
            this.maskDoktorTCAra.Location = new System.Drawing.Point(309, 43);
            this.maskDoktorTCAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskDoktorTCAra.Mask = "0000000000000";
            this.maskDoktorTCAra.Name = "maskDoktorTCAra";
            this.maskDoktorTCAra.Size = new System.Drawing.Size(203, 26);
            this.maskDoktorTCAra.TabIndex = 44;
            this.maskDoktorTCAra.TextChanged += new System.EventHandler(this.maskDoktorTCAra_TextChanged);
            this.maskDoktorTCAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskDoktorTCAra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 31);
            this.label7.TabIndex = 43;
            this.label7.Text = "Doktor TC ile Arama:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.doctorNew5850;
            this.pictureBox1.Location = new System.Drawing.Point(1291, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(7, 4);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 43;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSekreter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maskTxtTC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDoktorSil);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDoktorGuncelle);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.btnEkleDoktor);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(7, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(357, 457);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Bilgi";
            // 
            // cmbSekreter
            // 
            this.cmbSekreter.FormattingEnabled = true;
            this.cmbSekreter.Location = new System.Drawing.Point(152, 276);
            this.cmbSekreter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSekreter.Name = "cmbSekreter";
            this.cmbSekreter.Size = new System.Drawing.Size(184, 27);
            this.cmbSekreter.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(8, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 34);
            this.label9.TabIndex = 42;
            this.label9.Text = "Sekreter:";
            // 
            // frmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1385, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.frmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskTxtTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.Button btnEkleDoktor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskDoktorTCAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoktorAdiAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridDoktor;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSekreter;
        private System.Windows.Forms.Label label9;
    }
}