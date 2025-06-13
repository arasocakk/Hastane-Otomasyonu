namespace HospitalManagementSystem
{
    partial class frmDoktorIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorIslemleri));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridHasta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtHastaTCAra = new System.Windows.Forms.MaskedTextBox();
            this.gridTani = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDoktorTani = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHastaTani = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaniBilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaniSil = new System.Windows.Forms.Button();
            this.btnTaniGuncelle = new System.Windows.Forms.Button();
            this.btnTaniEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridIlac = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlacAd = new System.Windows.Forms.TextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIlacGuncelle = new System.Windows.Forms.Button();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.btnIlacSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTani)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIlac)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.msktxtHastaTCAra);
            this.groupBox2.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(756, 314);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgisi";
            // 
            // gridHasta
            // 
            this.gridHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHasta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridHasta.Location = new System.Drawing.Point(7, 90);
            this.gridHasta.Margin = new System.Windows.Forms.Padding(4);
            this.gridHasta.Name = "gridHasta";
            this.gridHasta.RowHeadersVisible = false;
            this.gridHasta.RowHeadersWidth = 51;
            this.gridHasta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHasta.Size = new System.Drawing.Size(743, 218);
            this.gridHasta.TabIndex = 64;
            this.gridHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHasta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hasta TC Ara:";
            // 
            // msktxtHastaTCAra
            // 
            this.msktxtHastaTCAra.Location = new System.Drawing.Point(223, 47);
            this.msktxtHastaTCAra.Margin = new System.Windows.Forms.Padding(4);
            this.msktxtHastaTCAra.Mask = "00000000000";
            this.msktxtHastaTCAra.Name = "msktxtHastaTCAra";
            this.msktxtHastaTCAra.Size = new System.Drawing.Size(179, 24);
            this.msktxtHastaTCAra.TabIndex = 62;
            this.msktxtHastaTCAra.ValidatingType = typeof(int);
            this.msktxtHastaTCAra.TextChanged += new System.EventHandler(this.msktxtHastaTCAra_TextChanged);
            // 
            // gridTani
            // 
            this.gridTani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTani.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTani.Location = new System.Drawing.Point(7, 22);
            this.gridTani.Margin = new System.Windows.Forms.Padding(4);
            this.gridTani.Name = "gridTani";
            this.gridTani.RowHeadersVisible = false;
            this.gridTani.RowHeadersWidth = 51;
            this.gridTani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTani.Size = new System.Drawing.Size(887, 286);
            this.gridTani.TabIndex = 64;
            this.gridTani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTani_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridTani);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(776, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(900, 314);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDoktorTani);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbHastaTani);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTaniBilgi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpTarih);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnTaniSil);
            this.groupBox3.Controls.Add(this.btnTaniGuncelle);
            this.groupBox3.Controls.Add(this.btnTaniEkle);
            this.groupBox3.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(1059, 455);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(575, 268);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TANI İŞLEMLERİ";
            // 
            // cmbDoktorTani
            // 
            this.cmbDoktorTani.FormattingEnabled = true;
            this.cmbDoktorTani.Location = new System.Drawing.Point(176, 79);
            this.cmbDoktorTani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoktorTani.Name = "cmbDoktorTani";
            this.cmbDoktorTani.Size = new System.Drawing.Size(200, 25);
            this.cmbDoktorTani.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 74;
            this.label7.Text = "Doktor:";
            // 
            // cmbHastaTani
            // 
            this.cmbHastaTani.FormattingEnabled = true;
            this.cmbHastaTani.Location = new System.Drawing.Point(176, 38);
            this.cmbHastaTani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHastaTani.Name = "cmbHastaTani";
            this.cmbHastaTani.Size = new System.Drawing.Size(200, 25);
            this.cmbHastaTani.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tanı Bilgi :";
            // 
            // txtTaniBilgi
            // 
            this.txtTaniBilgi.Location = new System.Drawing.Point(176, 167);
            this.txtTaniBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaniBilgi.Multiline = true;
            this.txtTaniBilgi.Name = "txtTaniBilgi";
            this.txtTaniBilgi.Size = new System.Drawing.Size(223, 75);
            this.txtTaniBilgi.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tarih :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(176, 123);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(160, 24);
            this.dtpTarih.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 64;
            this.label3.Text = "Hasta Adı :";
            // 
            // btnTaniSil
            // 
            this.btnTaniSil.BackColor = System.Drawing.Color.Transparent;
            this.btnTaniSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaniSil.Location = new System.Drawing.Point(436, 167);
            this.btnTaniSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaniSil.Name = "btnTaniSil";
            this.btnTaniSil.Size = new System.Drawing.Size(100, 39);
            this.btnTaniSil.TabIndex = 60;
            this.btnTaniSil.Text = "SİL";
            this.btnTaniSil.UseVisualStyleBackColor = false;
            this.btnTaniSil.Click += new System.EventHandler(this.btnTaniSil_Click);
            // 
            // btnTaniGuncelle
            // 
            this.btnTaniGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnTaniGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaniGuncelle.Location = new System.Drawing.Point(415, 116);
            this.btnTaniGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaniGuncelle.Name = "btnTaniGuncelle";
            this.btnTaniGuncelle.Size = new System.Drawing.Size(141, 41);
            this.btnTaniGuncelle.TabIndex = 59;
            this.btnTaniGuncelle.Text = "GÜNCELLE";
            this.btnTaniGuncelle.UseVisualStyleBackColor = false;
            this.btnTaniGuncelle.Click += new System.EventHandler(this.btnTaniGuncelle_Click);
            // 
            // btnTaniEkle
            // 
            this.btnTaniEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnTaniEkle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaniEkle.Location = new System.Drawing.Point(405, 59);
            this.btnTaniEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaniEkle.Name = "btnTaniEkle";
            this.btnTaniEkle.Size = new System.Drawing.Size(151, 46);
            this.btnTaniEkle.TabIndex = 58;
            this.btnTaniEkle.Text = "TANI EKLE";
            this.btnTaniEkle.UseVisualStyleBackColor = false;
            this.btnTaniEkle.Click += new System.EventHandler(this.btnTaniEkle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridIlac);
            this.groupBox4.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(15, 455);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(583, 266);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İlaç";
            // 
            // gridIlac
            // 
            this.gridIlac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIlac.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridIlac.Location = new System.Drawing.Point(7, 22);
            this.gridIlac.Margin = new System.Windows.Forms.Padding(4);
            this.gridIlac.Name = "gridIlac";
            this.gridIlac.RowHeadersVisible = false;
            this.gridIlac.RowHeadersWidth = 51;
            this.gridIlac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIlac.Size = new System.Drawing.Size(567, 230);
            this.gridIlac.TabIndex = 64;
            this.gridIlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIlac_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbHasta);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtIlacAd);
            this.groupBox5.Controls.Add(this.cmbDoktor);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnIlacGuncelle);
            this.groupBox5.Controls.Add(this.btnIlacEkle);
            this.groupBox5.Controls.Add(this.btnIlacSil);
            this.groupBox5.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(617, 455);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(411, 281);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İLAÇ İŞLEMLERİ";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(157, 128);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 25);
            this.cmbHasta.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 71;
            this.label6.Text = "İlaç Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 72;
            this.label5.Text = "Hasta Adı:";
            // 
            // txtIlacAd
            // 
            this.txtIlacAd.Location = new System.Drawing.Point(145, 33);
            this.txtIlacAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtIlacAd.Name = "txtIlacAd";
            this.txtIlacAd.Size = new System.Drawing.Size(223, 24);
            this.txtIlacAd.TabIndex = 70;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(153, 79);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(207, 25);
            this.cmbDoktor.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Righteous", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 29);
            this.label10.TabIndex = 70;
            this.label10.Text = "Doktor:";
            // 
            // btnIlacGuncelle
            // 
            this.btnIlacGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnIlacGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacGuncelle.Location = new System.Drawing.Point(191, 224);
            this.btnIlacGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlacGuncelle.Name = "btnIlacGuncelle";
            this.btnIlacGuncelle.Size = new System.Drawing.Size(141, 41);
            this.btnIlacGuncelle.TabIndex = 59;
            this.btnIlacGuncelle.Text = "GÜNCELLE";
            this.btnIlacGuncelle.UseVisualStyleBackColor = false;
            this.btnIlacGuncelle.Click += new System.EventHandler(this.btnIlacGuncelle_Click);
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnIlacEkle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacEkle.Location = new System.Drawing.Point(133, 174);
            this.btnIlacEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(151, 46);
            this.btnIlacEkle.TabIndex = 58;
            this.btnIlacEkle.Text = "İLAÇ EKLE";
            this.btnIlacEkle.UseVisualStyleBackColor = false;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // btnIlacSil
            // 
            this.btnIlacSil.BackColor = System.Drawing.Color.Transparent;
            this.btnIlacSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacSil.Location = new System.Drawing.Point(85, 224);
            this.btnIlacSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlacSil.Name = "btnIlacSil";
            this.btnIlacSil.Size = new System.Drawing.Size(100, 39);
            this.btnIlacSil.TabIndex = 60;
            this.btnIlacSil.Text = "SİL";
            this.btnIlacSil.UseVisualStyleBackColor = false;
            this.btnIlacSil.Click += new System.EventHandler(this.btnIlacSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Righteous", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(615, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(479, 76);
            this.label11.TabIndex = 73;
            this.label11.Text = "Doktor İşlemleri";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(7, 6);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 74;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.doctorNew5850;
            this.pictureBox1.Location = new System.Drawing.Point(1599, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoktorIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1684, 804);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoktorIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.frmDoktorIslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTani)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIlac)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtHastaTCAra;
        private System.Windows.Forms.DataGridView gridHasta;
        private System.Windows.Forms.DataGridView gridTani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaniSil;
        private System.Windows.Forms.Button btnTaniGuncelle;
        private System.Windows.Forms.Button btnTaniEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaniBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridIlac;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIlacAd;
        private System.Windows.Forms.Button btnIlacSil;
        private System.Windows.Forms.Button btnIlacGuncelle;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbHastaTani;
        private System.Windows.Forms.ComboBox cmbDoktorTani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}