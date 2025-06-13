namespace HospitalManagementSystem
{
    partial class frmBransEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBransEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridBrans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBransAra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBransSil = new System.Windows.Forms.Button();
            this.btnBransGuncelle = new System.Windows.Forms.Button();
            this.txtBransEkle = new System.Windows.Forms.TextBox();
            this.btnEkleBrans = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrans)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridBrans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBransAra);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(460, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(459, 210);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş Arama";
            // 
            // gridBrans
            // 
            this.gridBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBrans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBrans.Location = new System.Drawing.Point(5, 79);
            this.gridBrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridBrans.Name = "gridBrans";
            this.gridBrans.RowHeadersVisible = false;
            this.gridBrans.RowHeadersWidth = 51;
            this.gridBrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBrans.Size = new System.Drawing.Size(447, 127);
            this.gridBrans.TabIndex = 48;
            this.gridBrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBrans_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "Branş Adı Ara:";
            // 
            // txtBransAra
            // 
            this.txtBransAra.Location = new System.Drawing.Point(252, 33);
            this.txtBransAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBransAra.Name = "txtBransAra";
            this.txtBransAra.Size = new System.Drawing.Size(185, 26);
            this.txtBransAra.TabIndex = 34;
            this.txtBransAra.TextChanged += new System.EventHandler(this.txtBransAra_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnBransSil);
            this.groupBox3.Controls.Add(this.btnBransGuncelle);
            this.groupBox3.Controls.Add(this.txtBransEkle);
            this.groupBox3.Controls.Add(this.btnEkleBrans);
            this.groupBox3.Font = new System.Drawing.Font("Righteous", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(31, 110);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(393, 222);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branş Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 34);
            this.label2.TabIndex = 31;
            this.label2.Text = "Branş Adı:";
            // 
            // btnBransSil
            // 
            this.btnBransSil.BackColor = System.Drawing.Color.Transparent;
            this.btnBransSil.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransSil.Location = new System.Drawing.Point(71, 158);
            this.btnBransSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBransSil.Name = "btnBransSil";
            this.btnBransSil.Size = new System.Drawing.Size(100, 39);
            this.btnBransSil.TabIndex = 41;
            this.btnBransSil.Text = "SİL";
            this.btnBransSil.UseVisualStyleBackColor = false;
            this.btnBransSil.Click += new System.EventHandler(this.btnBransSil_Click);
            // 
            // btnBransGuncelle
            // 
            this.btnBransGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnBransGuncelle.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransGuncelle.Location = new System.Drawing.Point(177, 158);
            this.btnBransGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBransGuncelle.Name = "btnBransGuncelle";
            this.btnBransGuncelle.Size = new System.Drawing.Size(141, 41);
            this.btnBransGuncelle.TabIndex = 40;
            this.btnBransGuncelle.Text = "GÜNCELLE";
            this.btnBransGuncelle.UseVisualStyleBackColor = false;
            this.btnBransGuncelle.Click += new System.EventHandler(this.btnBransGuncelle_Click);
            // 
            // txtBransEkle
            // 
            this.txtBransEkle.Location = new System.Drawing.Point(191, 46);
            this.txtBransEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBransEkle.Name = "txtBransEkle";
            this.txtBransEkle.Size = new System.Drawing.Size(185, 26);
            this.txtBransEkle.TabIndex = 34;
            this.txtBransEkle.TextChanged += new System.EventHandler(this.txtBransEkle_TextChanged);
            // 
            // btnEkleBrans
            // 
            this.btnEkleBrans.BackColor = System.Drawing.Color.Transparent;
            this.btnEkleBrans.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleBrans.Location = new System.Drawing.Point(119, 106);
            this.btnEkleBrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkleBrans.Name = "btnEkleBrans";
            this.btnEkleBrans.Size = new System.Drawing.Size(151, 46);
            this.btnEkleBrans.TabIndex = 39;
            this.btnEkleBrans.Text = "EKLE";
            this.btnEkleBrans.UseVisualStyleBackColor = false;
            this.btnEkleBrans.Click += new System.EventHandler(this.btnEkleBrans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 76);
            this.label3.TabIndex = 49;
            this.label3.Text = "Branş Ekle";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturn.Image = global::HospitalManagementSystem.Properties.Resources.returnPNG4035;
            this.btnReturn.Location = new System.Drawing.Point(891, 4);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 43);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmBransEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(947, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBransEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Ekle";
            this.Load += new System.EventHandler(this.frmBransEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrans)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBransAra;
        private System.Windows.Forms.DataGridView gridBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBransSil;
        private System.Windows.Forms.Button btnBransGuncelle;
        private System.Windows.Forms.TextBox txtBransEkle;
        private System.Windows.Forms.Button btnEkleBrans;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
    }
}