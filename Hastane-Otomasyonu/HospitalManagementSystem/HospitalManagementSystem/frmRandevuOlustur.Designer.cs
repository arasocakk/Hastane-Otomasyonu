namespace HospitalManagementSystem
{
    partial class frmRandevuOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevuOlustur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridHasta = new System.Windows.Forms.DataGridView();
            this.txtAraTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaIDAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSekreter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.btnEkleRandevu = new System.Windows.Forms.Button();
            this.msktxtClock = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridRandevu = new System.Windows.Forms.DataGridView();
            this.txtRandevuIDAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHasta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridHasta);
            this.groupBox1.Controls.Add(this.txtAraTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHastaIDAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(19, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1061, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgisi";
            // 
            // gridHasta
            // 
            this.gridHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHasta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridHasta.Location = new System.Drawing.Point(5, 135);
            this.gridHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridHasta.Name = "gridHasta";
            this.gridHasta.RowHeadersVisible = false;
            this.gridHasta.RowHeadersWidth = 51;
            this.gridHasta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHasta.Size = new System.Drawing.Size(1051, 224);
            this.gridHasta.TabIndex = 49;
            this.gridHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHasta_CellClick);
            // 
            // txtAraTC
            // 
            this.txtAraTC.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold);
            this.txtAraTC.Location = new System.Drawing.Point(228, 90);
            this.txtAraTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAraTC.Name = "txtAraTC";
            this.txtAraTC.Size = new System.Drawing.Size(160, 26);
            this.txtAraTC.TabIndex = 35;
            this.txtAraTC.TextChanged += new System.EventHandler(this.txtAraTC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hasta TC Ara:";
            // 
            // txtHastaIDAra
            // 
            this.txtHastaIDAra.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold);
            this.txtHastaIDAra.Location = new System.Drawing.Point(228, 39);
            this.txtHastaIDAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaIDAra.Name = "txtHastaIDAra";
            this.txtHastaIDAra.Size = new System.Drawing.Size(65, 26);
            this.txtHastaIDAra.TabIndex = 33;
            this.txtHastaIDAra.TextChanged += new System.EventHandler(this.txtHastaIDAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hasta ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbHasta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbSekreter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnRandevuSil);
            this.groupBox2.Controls.Add(this.btnRandevuGuncelle);
            this.groupBox2.Controls.Add(this.btnEkleRandevu);
            this.groupBox2.Controls.Add(this.msktxtClock);
            this.groupBox2.Controls.Add(this.cmbDoktor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpRandevuTarihi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1101, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(500, 425);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgi";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(253, 128);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(172, 25);
            this.cmbHasta.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 63;
            this.label10.Text = "Hasta Adı:";
            // 
            // cmbSekreter
            // 
            this.cmbSekreter.FormattingEnabled = true;
            this.cmbSekreter.Location = new System.Drawing.Point(253, 215);
            this.cmbSekreter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSekreter.Name = "cmbSekreter";
            this.cmbSekreter.Size = new System.Drawing.Size(172, 25);
            this.cmbSekreter.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Sekreter:";
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuSil.Location = new System.Drawing.Point(119, 366);
            this.btnRandevuSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(100, 39);
            this.btnRandevuSil.TabIndex = 60;
            this.btnRandevuSil.Text = "SİL";
            this.btnRandevuSil.UseVisualStyleBackColor = false;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(225, 366);
            this.btnRandevuGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(141, 41);
            this.btnRandevuGuncelle.TabIndex = 59;
            this.btnRandevuGuncelle.Text = "GÜNCELLE";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = false;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click);
            // 
            // btnEkleRandevu
            // 
            this.btnEkleRandevu.BackColor = System.Drawing.Color.Transparent;
            this.btnEkleRandevu.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleRandevu.Location = new System.Drawing.Point(169, 314);
            this.btnEkleRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkleRandevu.Name = "btnEkleRandevu";
            this.btnEkleRandevu.Size = new System.Drawing.Size(151, 46);
            this.btnEkleRandevu.TabIndex = 58;
            this.btnEkleRandevu.Text = "EKLE";
            this.btnEkleRandevu.UseVisualStyleBackColor = false;
            this.btnEkleRandevu.Click += new System.EventHandler(this.btnEkleRandevu_Click);
            // 
            // msktxtClock
            // 
            this.msktxtClock.Location = new System.Drawing.Point(253, 80);
            this.msktxtClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtClock.Mask = "00:00";
            this.msktxtClock.Name = "msktxtClock";
            this.msktxtClock.Size = new System.Drawing.Size(172, 24);
            this.msktxtClock.TabIndex = 57;
            this.msktxtClock.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(253, 174);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(172, 25);
            this.cmbDoktor.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Doktor:";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(253, 42);
            this.dtpRandevuTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(172, 24);
            this.dtpRandevuTarihi.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Randevu Saati:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(253, 265);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(172, 25);
            this.cmbBrans.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Randevu Tarihi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridRandevu);
            this.groupBox3.Controls.Add(this.txtRandevuIDAra);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 517);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1201, 214);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // gridRandevu
            // 
            this.gridRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRandevu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridRandevu.Location = new System.Drawing.Point(5, 55);
            this.gridRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRandevu.Name = "gridRandevu";
            this.gridRandevu.RowHeadersVisible = false;
            this.gridRandevu.RowHeadersWidth = 51;
            this.gridRandevu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRandevu.Size = new System.Drawing.Size(1189, 146);
            this.gridRandevu.TabIndex = 50;
            this.gridRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRandevu_CellClick);
            // 
            // txtRandevuIDAra
            // 
            this.txtRandevuIDAra.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRandevuIDAra.Location = new System.Drawing.Point(205, 23);
            this.txtRandevuIDAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRandevuIDAra.Name = "txtRandevuIDAra";
            this.txtRandevuIDAra.Size = new System.Drawing.Size(72, 26);
            this.txtRandevuIDAra.TabIndex = 51;
            this.txtRandevuIDAra.TextChanged += new System.EventHandler(this.txtRandevuIDAra_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 29);
            this.label7.TabIndex = 50;
            this.label7.Text = "Randevu ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(636, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 60);
            this.label8.TabIndex = 52;
            this.label8.Text = "Randevu Oluştur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.appointmentPNG5850;
            this.pictureBox1.Location = new System.Drawing.Point(1577, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmRandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1671, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRandevuOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Oluştur";
            this.Load += new System.EventHandler(this.frmRandevuOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHasta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAraTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaIDAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridHasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktxtClock;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRandevuGuncelle;
        private System.Windows.Forms.Button btnEkleRandevu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRandevuIDAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridRandevu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbSekreter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}