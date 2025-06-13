using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmHastaEkle : Form
    {
        public frmHastaEkle()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        private void frmHastaEkle_Load(object sender, EventArgs e)
        {
            btnEkleHasta.FlatStyle = FlatStyle.Flat;
            btnEkleHasta.FlatAppearance.BorderSize = 0;
            btnEkleHasta.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnEkleHasta.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnEkleHasta.BackColor = Color.Transparent; btnEkleHasta.FlatStyle = FlatStyle.Flat;

            btnHastaGuncelle.FlatStyle = FlatStyle.Flat;
            btnHastaGuncelle.FlatAppearance.BorderSize = 0;
            btnHastaGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnHastaGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnHastaGuncelle.BackColor = Color.Transparent; btnHastaGuncelle.FlatStyle = FlatStyle.Flat;

            btnHastaSil.FlatStyle = FlatStyle.Flat;
            btnHastaSil.FlatAppearance.BorderSize = 0;
            btnHastaSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnHastaSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnHastaSil.BackColor = Color.Transparent; btnHastaSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            List();
            SecretaryList();
            GenderList();
        }

        public void List()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID\r\n\r\n";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridHasta.DataSource = dt;
                gridHasta.Columns["PatientID"].HeaderText = "Hasta ID";
                gridHasta.Columns["PatientTC"].HeaderText = "Hasta TC";
                gridHasta.Columns["PatientName"].HeaderText = "Hasta Ad";
                gridHasta.Columns["PatientSurname"].HeaderText = "Hasta Soyad";
                gridHasta.Columns["PatientBirthday"].HeaderText = "Hasta Doğum T.";
                gridHasta.Columns["GenderName"].HeaderText = "Cinsiyeti";
                gridHasta.Columns["PatientPhone"].HeaderText = "Hasta Telefon";
                gridHasta.Columns["SecretaryName"].HeaderText = "Sekreter Adı";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }
        private void SecretaryList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM SecretaryTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSekreter.DataSource = dt;
                cmbSekreter.ValueMember = "SecretaryID";
                cmbSekreter.DisplayMember = "SecretaryName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void GenderList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM GenderTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCinsiyet.DataSource = dt;
                cmbCinsiyet.ValueMember = "GenderID";
                cmbCinsiyet.DisplayMember = "GenderName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }


        private void btnEkleHasta_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO PatientTBL VALUES (@patientTC,@patientName,@patientSurname,@patientBirthday,@genderid,@patientPhone,@secretaryID)";


                command = new SqlCommand(commandLine, connection);
                command.Parameters.AddWithValue("@patientTC", maskTxtTC.Text);
                command.Parameters.AddWithValue("@patientName", txtAd.Text);
                command.Parameters.AddWithValue("@patientSurname", txtSoyad.Text);
                command.Parameters.AddWithValue("@patientBirthday", dtpDogum.Value);
                command.Parameters.AddWithValue("@genderid", cmbCinsiyet.SelectedValue.ToString());
                command.Parameters.AddWithValue("@patientPhone", txtPhone.Text);
                command.Parameters.AddWithValue("@secretaryID", cmbSekreter.SelectedValue.ToString());

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı");

                List();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSekreterEkranı frmSekreterEkranı = new frmSekreterEkranı();
            frmSekreterEkranı.Show();
            this.Close();
        }

        private void gridHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maskTxtTC.Text = gridHasta.CurrentRow.Cells["PatientTC"].Value.ToString();
                txtAd.Text = gridHasta.CurrentRow.Cells["PatientName"].Value.ToString();
                txtSoyad.Text = gridHasta.CurrentRow.Cells["PatientSurname"].Value.ToString();
                txtPhone.Text = gridHasta.CurrentRow.Cells["PatientPhone"].Value.ToString();
                dtpDogum.Value = Convert.ToDateTime(gridHasta.CurrentRow.Cells["PatientBirthday"].Value.ToString());
                cmbCinsiyet.Text = gridHasta.CurrentRow.Cells["GenderName"].Value.ToString();
                cmbSekreter.Text = gridHasta.CurrentRow.Cells["SecretaryName"].Value.ToString();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    commandLine = "DELETE FROM PatientTBL WHERE PatientID = @patientID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@patientID", gridHasta.CurrentRow.Cells["PatientID"].Value.ToString());
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");
            }

            List();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                DialogResult result = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    commandLine = "UPDATE PatientTBL SET PatientTC = @pattc, PatientName = @patname,PatientSurname = @patsurname,PatientPhone = @patphone, PatientBirthday = @patbirth, GenderID = @genid, SecretaryID = @secid  WHERE PatientID = @patid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@patid", gridHasta.CurrentRow.Cells["PatientID"].Value.ToString());
                    command.Parameters.AddWithValue("@pattc", maskTxtTC.Text);
                    command.Parameters.AddWithValue("@patname", txtAd.Text);
                    command.Parameters.AddWithValue("@patsurname", txtSoyad.Text);
                    command.Parameters.AddWithValue("@patphone", txtPhone.Text);
                    command.Parameters.AddWithValue("@patbirth", dtpDogum.Value);
                    command.Parameters.AddWithValue("@genid", int.Parse(cmbCinsiyet.SelectedValue.ToString()));
                    command.Parameters.AddWithValue("@secid", int.Parse(cmbSekreter.SelectedValue.ToString()));
                    
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
                List();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");
            }
        }

        private void maskDoktorTCAra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        private void maskAraTel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID WHERE pat.PatientPhone LIKE '%" + maskAraTel.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridHasta.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void maskHastaTCAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID WHERE pat.PatientTC LIKE '%" + maskTxtTC.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridHasta.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }
    }
}
