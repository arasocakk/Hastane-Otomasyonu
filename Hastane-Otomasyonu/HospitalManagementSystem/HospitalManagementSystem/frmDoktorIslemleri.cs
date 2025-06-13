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
    public partial class frmDoktorIslemleri : Form
    {
        public frmDoktorIslemleri()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        private void frmDoktorIslemleri_Load(object sender, EventArgs e)
        {
            btnTaniEkle.FlatStyle = FlatStyle.Flat;
            btnTaniEkle.FlatAppearance.BorderSize = 0;
            btnTaniEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnTaniEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnTaniEkle.BackColor = Color.Transparent; btnTaniEkle.FlatStyle = FlatStyle.Flat;

            btnTaniGuncelle.FlatStyle = FlatStyle.Flat;
            btnTaniGuncelle.FlatAppearance.BorderSize = 0;
            btnTaniGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnTaniGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnTaniGuncelle.BackColor = Color.Transparent; btnTaniGuncelle.FlatStyle = FlatStyle.Flat;

            btnTaniSil.FlatStyle = FlatStyle.Flat;
            btnTaniSil.FlatAppearance.BorderSize = 0;
            btnTaniSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnTaniSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnTaniSil.BackColor = Color.Transparent; btnTaniSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            btnIlacSil.FlatStyle = FlatStyle.Flat;
            btnIlacSil.FlatAppearance.BorderSize = 0;
            btnIlacSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnIlacSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnIlacSil.BackColor = Color.Transparent; btnIlacSil.FlatStyle = FlatStyle.Flat;

            btnIlacEkle.FlatStyle = FlatStyle.Flat;
            btnIlacEkle.FlatAppearance.BorderSize = 0;
            btnIlacEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnIlacEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnIlacEkle.BackColor = Color.Transparent; btnIlacEkle.FlatStyle = FlatStyle.Flat;

            btnIlacGuncelle.FlatStyle = FlatStyle.Flat;
            btnIlacGuncelle.FlatAppearance.BorderSize = 0;
            btnIlacGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnIlacGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnIlacGuncelle.BackColor = Color.Transparent; btnIlacGuncelle.FlatStyle = FlatStyle.Flat;

            List();
            DiagnosisList();
            PrescriptionList();
            PatientList();
            ListPatient();
            DoctorList();
            ListDoctor();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           frmLogin frmLogin = new frmLogin();
           frmLogin.Show();
            this.Close();
        }

        public void PatientList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM PatientTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbHasta.DataSource = dt;
                cmbHasta.ValueMember = "PatientID";
                cmbHasta.DisplayMember = "PatientName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        public void ListPatient()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM PatientTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbHastaTani.DataSource = dt;
                cmbHastaTani.ValueMember = "PatientID";
                cmbHastaTani.DisplayMember = "PatientName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        public void DoctorList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM DoctorTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbDoktor.DataSource = dt;
                cmbDoktor.ValueMember = "DoctorID";
                cmbDoktor.DisplayMember = "DoctorName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        public void ListDoctor()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM DoctorTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbDoktorTani.DataSource = dt;
                cmbDoktorTani.ValueMember = "DoctorID";
                cmbDoktorTani.DisplayMember = "DoctorName";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
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
                gridHasta.Columns["PatientName"].HeaderText = "Hasta Adı";
                gridHasta.Columns["PatientSurname"].HeaderText = "Hasta Soyad";
                gridHasta.Columns["PatientBirthday"].HeaderText = "Hasta Doğum T.";
                gridHasta.Columns["GenderName"].HeaderText = "Cinsiyet";
                gridHasta.Columns["PatientPhone"].HeaderText = "Hasta Tel";
                gridHasta.Columns["SecretaryName"].HeaderText = "Sekreter";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        public void DiagnosisList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT diag.DiagnosisID, diag.DiagnosisInfo ,diag.DiagnosisDate, pat.PatientName, doc.DoctorName FROM DiagnosisTBL as diag \r\nINNER JOIN PatientTBL as pat ON pat.PatientID = diag.PatientID\r\nINNER JOIN DoctorTBL as doc ON doc.DoctorID = diag.DoctorID";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridTani.DataSource = dt;
                gridTani.Columns["DiagnosisID"].HeaderText = "Tanı ID";
                gridTani.Columns["DiagnosisInfo"].HeaderText = "Tanı Bilgi";
                gridTani.Columns["DiagnosisDate"].HeaderText = "Tanı Tarih";
                gridTani.Columns["PatientName"].HeaderText = "Hasta Adı";
                gridTani.Columns["DoctorName"].HeaderText = "Doktor Adı";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }

            
        }

        public void PrescriptionList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pres.PrescriptionID, pres.MedicineName, doc.DoctorName,pat.PatientName FROM PrescriptionTBL as pres \r\nINNER JOIN PatientTBL as pat ON pat.PatientID = pres.PatientID\r\nINNER JOIN DoctorTBL as doc ON doc.DoctorID = pres.DoctorID\r\n                ";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridIlac.DataSource = dt;
                gridIlac.Columns["PrescriptionID"].HeaderText = "İlaç ID";
                gridIlac.Columns["MedicineName"].HeaderText = "İlaç Adı";
                gridIlac.Columns["DoctorName"].HeaderText = "Doktor Adı";
                gridIlac.Columns["PatientName"].HeaderText = "Hasta Adı";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void btnTaniEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO DiagnosisTBL VALUES (@diagnosisInfo,@diagnosisDate,@patientID,@doctorID)";


                command = new SqlCommand(commandLine, connection);
                command.Parameters.AddWithValue("@diagnosisInfo", txtTaniBilgi.Text);
                command.Parameters.AddWithValue("@diagnosisDate", dtpTarih.Value);
                command.Parameters.AddWithValue("@patientID", cmbHasta.SelectedValue.ToString());
                command.Parameters.AddWithValue("@doctorID", cmbDoktor.SelectedValue.ToString());
                

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı");

                DiagnosisList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }


        }

        private void btnTaniGuncelle_Click(object sender, EventArgs e)
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
                    commandLine = "UPDATE DiagnosisTBL SET DiagnosisInfo = @diagnosisInfo, DiagnosisDate = @diagnosisDate,PatientID = @patientID, DoctorID = @doctorID  WHERE DiagnosisID = @diagnosisID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@diagnosisID", gridTani.CurrentRow.Cells["DiagnosisID"].Value.ToString());
                    command.Parameters.AddWithValue("@diagnosisInfo", txtTaniBilgi.Text);
                    command.Parameters.AddWithValue("@diagnosisDate", dtpTarih.Value);
                    command.Parameters.AddWithValue("@patientID", cmbHastaTani.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@doctorID", cmbDoktorTani.SelectedValue.ToString());
                    

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
                DiagnosisList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");
            }
        }

        private void btnTaniSil_Click(object sender, EventArgs e)
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
                    commandLine = "DELETE FROM DiagnosisTBL WHERE DiagnosisID = @diagnosisID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@diagnosisID", gridTani.CurrentRow.Cells["DiagnosisID"].Value.ToString());
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

            DiagnosisList();
        }

        private void gridTani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbHastaTani.Text = gridTani.CurrentRow.Cells["PatientName"].Value.ToString();
                cmbDoktorTani.Text = gridTani.CurrentRow.Cells["DoctorName"].Value.ToString();
                dtpTarih.Text = gridTani.CurrentRow.Cells["DiagnosisDate"].Value.ToString();
                txtTaniBilgi.Text = gridTani.CurrentRow.Cells["DiagnosisInfo"].Value.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void gridHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridIlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIlacAd.Text = gridIlac.CurrentRow.Cells["MedicineName"].Value.ToString();
                cmbDoktor.Text = gridIlac.CurrentRow.Cells["DoctorName"].Value.ToString();
                cmbHasta.Text = gridIlac.CurrentRow.Cells["PatientName"].Value.ToString();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO PrescriptionTBL VALUES (@medicineName,@doctorID,@patientID)";


                command = new SqlCommand(commandLine, connection);
                command.Parameters.AddWithValue("@medicineName", txtIlacAd.Text);
                command.Parameters.AddWithValue("@doctorID", cmbDoktor.SelectedValue.ToString());
                command.Parameters.AddWithValue("@patientID", cmbHasta.SelectedValue.ToString());


                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı");

                PrescriptionList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void btnIlacSil_Click(object sender, EventArgs e)
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
                    commandLine = "DELETE FROM PrescriptionTBL WHERE PrescriptionID = @prescriptionID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@prescriptionID", gridIlac.CurrentRow.Cells["PrescriptionID"].Value.ToString());
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
            PrescriptionList();
        }

        private void btnIlacGuncelle_Click(object sender, EventArgs e)
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
                    commandLine = "UPDATE PrescriptionTBL SET MedicineName = @medicineName, DoctorID = @doctorID, PatientID = @patientID WHERE PrescriptionID = @prescriptionID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@prescriptionID", gridIlac.CurrentRow.Cells["PrescriptionID"].Value.ToString());
                    command.Parameters.AddWithValue("@medicineName", txtIlacAd.Text);  
                    command.Parameters.AddWithValue("@doctorID", cmbDoktor.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@patientID", cmbHasta.SelectedValue.ToString());


                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
                PrescriptionList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");
            }
        }

        private void msktxtHastaTCAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID WHERE pat.PatientTC LIKE '%" + msktxtHastaTCAra.Text + "%'";
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
