using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HospitalManagementSystem
{
    public partial class frmRandevuOlustur : Form
    {
        public frmRandevuOlustur()
        {
            InitializeComponent();
        }

        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;

        private void frmRandevuOlustur_Load(object sender, EventArgs e)
        {
            btnEkleRandevu.FlatStyle = FlatStyle.Flat;
            btnEkleRandevu.FlatAppearance.BorderSize = 0;
            btnEkleRandevu.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnEkleRandevu.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnEkleRandevu.BackColor = Color.Transparent; btnEkleRandevu.FlatStyle = FlatStyle.Flat;

            btnRandevuGuncelle.FlatStyle = FlatStyle.Flat;
            btnRandevuGuncelle.FlatAppearance.BorderSize = 0;
            btnRandevuGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnRandevuGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnRandevuGuncelle.BackColor = Color.Transparent; btnRandevuGuncelle.FlatStyle = FlatStyle.Flat;

            btnRandevuSil.FlatStyle = FlatStyle.Flat;
            btnRandevuSil.FlatAppearance.BorderSize = 0;
            btnRandevuSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnRandevuSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnRandevuSil.BackColor = Color.Transparent; btnRandevuSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            ListAppointment();
            ListPatient();
            BranchList();
            DoctorList();
            SecretaryList();
            PatientList();
        }

        public void ListAppointment()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT appo.AppointmentID,appo.AppointmentDate,appo.AppointmentClock, doc.DoctorName, pat.PatientName,sec.SecretaryName,bra.BranchName FROM AppointmentTBL as appo\r\nINNER JOIN DoctorTBL as doc ON doc.DoctorID = appo.DoctorID\r\nINNER JOIN PatientTBL as pat ON pat.PatientID = appo.PatientID\r\nINNER JOIN SecretaryTBL as sec ON sec.SecretaryID = appo.SecretaryID\r\nINNER JOIN BranchTBL as bra ON bra.BranchID = appo.BranchID\r\n";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridRandevu.DataSource = dt;
                gridRandevu.Columns["AppointmentID"].HeaderText = "Randevu ID";
                gridRandevu.Columns["AppointmentDate"].HeaderText = "Randevu Tarih";
                gridRandevu.Columns["AppointmentClock"].HeaderText = "Randevu Saat";
                gridRandevu.Columns["DoctorName"].HeaderText = "Doktor Adı";
                gridRandevu.Columns["PatientName"].HeaderText = "Hasta Adı";
                gridRandevu.Columns["SecretaryName"].HeaderText = "Sekreter Adı";
                gridRandevu.Columns["BranchName"].HeaderText = "Branşı";



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
        public void SecretaryList()
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




        public void BranchList()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM BranchTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrans.DataSource = dt;
                cmbBrans.ValueMember = "BranchID";
                cmbBrans.DisplayMember = "BranchName";


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
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID";
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

 

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSekreterEkranı frmSekreterEkranı = new frmSekreterEkranı();
            frmSekreterEkranı.Show();
            this.Close();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
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
                    commandLine = "DELETE FROM AppointmentTBL WHERE AppointmentID = @appointmentID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@appointmentID", gridRandevu.CurrentRow.Cells["AppointmentID"].Value.ToString());
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

            ListAppointment();
        }

        private void btnEkleRandevu_Click(object sender, EventArgs e)
        {

            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO AppointmentTBL (AppointmentDate,AppointmentClock,DoctorID,PatientID,SecretaryID,BranchID) VALUES (@appointmentDate,@appointmentClock,@doctorID,@patientID,@secretaryID,@branchID)";

                DialogResult result = MessageBox.Show("Eklemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@appointmentDate", dtpRandevuTarihi.Value);
                    command.Parameters.AddWithValue("@appointmentClock", msktxtClock.Text );     
                    command.Parameters.AddWithValue("@doctorID", cmbDoktor.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@patientID", cmbHasta.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@secretaryID", cmbSekreter.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@branchID", cmbBrans.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                }
                else
                {

                }


                ListAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }

        }

        private void txtHastaIDAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID WHERE pat.PatientID LIKE '%" + txtHastaIDAra.Text+"%'";
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

        private void txtAraTC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT pat.PatientID, pat.PatientTC ,pat.PatientName, pat.PatientSurname, pat.PatientBirthday, gen.GenderName, pat.PatientPhone, sec.SecretaryName FROM PatientTBL as pat\r\nINNER JOIN GenderTBL as gen ON pat.GenderID = gen.GenderID\r\nINNER JOIN SecretaryTBL as sec ON pat.SecretaryID = sec.SecretaryID WHERE pat.PatientTC LIKE '%" + txtAraTC.Text + "%'";
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

        private void txtRandevuIDAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT appo.AppointmentID,appo.AppointmentDate,appo.AppointmentClock, doc.DoctorName, pat.PatientName,sec.SecretaryName,bra.BranchName FROM AppointmentTBL as appo\r\nINNER JOIN DoctorTBL as doc ON doc.DoctorID = appo.DoctorID\r\nINNER JOIN PatientTBL as pat ON pat.PatientID = appo.PatientID\r\nINNER JOIN SecretaryTBL as sec ON sec.SecretaryID = appo.SecretaryID\r\nINNER JOIN BranchTBL as bra ON bra.BranchID = appo.BranchID\r\n WHERE appo.AppointmentID LIKE '%" + txtRandevuIDAra.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridRandevu.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void gridRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtpRandevuTarihi.Text = gridRandevu.CurrentRow.Cells["AppointmentDate"].Value.ToString();
                msktxtClock.Text = gridRandevu.CurrentRow.Cells["AppointmentClock"].Value.ToString();
                cmbHasta.Text = gridRandevu.CurrentRow.Cells["PatientName"].Value.ToString();
                cmbDoktor.Text = gridRandevu.CurrentRow.Cells["DoctorName"].Value.ToString();
                cmbSekreter.Text = gridRandevu.CurrentRow.Cells["SecretaryName"].Value.ToString();
                cmbBrans.Text = gridRandevu.CurrentRow.Cells["BranchName"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
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
                    commandLine = "UPDATE AppointmentTBL SET AppointmentDate = @appointmentDate, AppointmentClock = @appointmentClock,DoctorID = @doctorID, PatientID = @patientID ,SecretaryID = @secretaryID,BranchID = @branchID WHERE appointmentID = @appointmentID";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@appointmentID", gridRandevu.CurrentRow.Cells["AppointmentID"].Value.ToString());
                    command.Parameters.AddWithValue("@appointmentDate", dtpRandevuTarihi.Value);
                    command.Parameters.AddWithValue("@appointmentClock", msktxtClock.Text);
                    command.Parameters.AddWithValue("@doctorID", cmbDoktor.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@patientID", cmbHasta.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@secretaryID", cmbSekreter.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@branchID", cmbBrans.SelectedValue.ToString());

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
                ListAppointment();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");
            }
        }

        private void gridHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

