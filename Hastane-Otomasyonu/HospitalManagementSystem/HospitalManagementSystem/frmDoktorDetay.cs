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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            

            btnEkleDoktor.FlatStyle = FlatStyle.Flat;
            btnEkleDoktor.FlatAppearance.BorderSize = 0;
            btnEkleDoktor.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnEkleDoktor.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnEkleDoktor.BackColor = Color.Transparent; btnEkleDoktor.FlatStyle = FlatStyle.Flat;

            btnDoktorGuncelle.FlatStyle = FlatStyle.Flat;
            btnDoktorGuncelle.FlatAppearance.BorderSize = 0;
            btnDoktorGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnDoktorGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnDoktorGuncelle.BackColor = Color.Transparent; btnDoktorGuncelle.FlatStyle = FlatStyle.Flat;

            btnDoktorSil.FlatStyle = FlatStyle.Flat;
            btnDoktorSil.FlatAppearance.BorderSize = 0;
            btnDoktorSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnDoktorSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnDoktorSil.BackColor = Color.Transparent; btnDoktorSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            List();
            BranchList();
            SecretaryList();

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

        public void List()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT doc.DoctorID, doc.DoctorTC,doc.DoctorName,DoctorSurname,doc.DoctorPassword,bra.BranchName,sec.SecretaryName FROM DoctorTBL as doc\r\nINNER JOIN BranchTBL as bra ON doc.BranchID = bra.BranchID\r\nINNER JOIN SecretaryTBL as sec ON doc.SecretaryID = sec.SecretaryID\r\n";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridDoktor.DataSource = dt;

                gridDoktor.Columns["DoctorID"].HeaderText = "Doktor ID";
                gridDoktor.Columns["DoctorTC"].HeaderText = "Doktor TC";
                gridDoktor.Columns["DoctorName"].HeaderText = "Doktor Adı";
                gridDoktor.Columns["DoctorSurname"].HeaderText = "Doktor Soyadı";
                gridDoktor.Columns["DoctorPassword"].HeaderText = "Doktor Şifre";
                gridDoktor.Columns["BranchName"].HeaderText = "Branşı";
                gridDoktor.Columns["SecretaryName"].HeaderText = "Sekreter Adı";
                

               
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }


        }



        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskDoktorTCAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDoktorAdiAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

       

        private void btnEkleDoktor_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO DoctorTBL VALUES (@doctorTC,@doctorName,@doctorSurname,@doctorPassword,@branchID,@secretaryid)";


                command = new SqlCommand(commandLine, connection);
                command.Parameters.AddWithValue("@doctorTC", maskTxtTC.Text);
                command.Parameters.AddWithValue("@doctorName", txtAd.Text);
                command.Parameters.AddWithValue("@doctorSurname", txtSoyad.Text);
                command.Parameters.AddWithValue("@doctorPassword", txtPassword.Text);
                command.Parameters.AddWithValue("@branchID", cmbBrans.SelectedValue.ToString());
                command.Parameters.AddWithValue("@secretaryid", cmbSekreter.SelectedValue.ToString());
                
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

        private void maskDoktorTCAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT doc.DoctorID, doc.DoctorTC,doc.DoctorName,DoctorSurname,doc.DoctorPassword,bra.BranchName,sec.SecretaryName FROM DoctorTBL as doc\r\nINNER JOIN BranchTBL as bra ON doc.BranchID = bra.BranchID\r\nINNER JOIN SecretaryTBL as sec ON doc.SecretaryID = sec.SecretaryID WHERE doc.DoctorTC LIKE '%"+maskDoktorTCAra.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridDoktor.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
                
            }
            
        }

        private void txtDoktorAdiAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT doc.DoctorID, doc.DoctorTC,doc.DoctorName,DoctorSurname,doc.DoctorPassword,bra.BranchName,sec.SecretaryName FROM DoctorTBL as doc\r\nINNER JOIN BranchTBL as bra ON doc.BranchID = bra.BranchID\r\nINNER JOIN SecretaryTBL as sec ON doc.SecretaryID = sec.SecretaryID WHERE doc.DoctorName LIKE '%" + txtDoktorAdiAra.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridDoktor.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
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
                    commandLine = "DELETE FROM DoctorTBL WHERE DoctorID = @doctorid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@doctorid", gridDoktor.CurrentRow.Cells["DoctorID"].Value.ToString());
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

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
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
                    commandLine = "UPDATE DoctorTBL SET DoctorTC = @doctc, DoctorName = @docname,DoctorSurname = @docsurname, DoctorPassword = @docpass ,BranchID = @branchid ,SecretaryID = @secid  WHERE DoctorID = @docid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@docid", gridDoktor.CurrentRow.Cells["DoctorID"].Value.ToString());
                    command.Parameters.AddWithValue("@doctc", maskTxtTC.Text);
                    command.Parameters.AddWithValue("@docname", txtAd.Text);
                    command.Parameters.AddWithValue("@docsurname", txtSoyad.Text);
                    command.Parameters.AddWithValue("@docpass", txtPassword.Text);
                    command.Parameters.AddWithValue("@branchid", int.Parse(cmbBrans.SelectedValue.ToString()));
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSekreterEkranı frmSekreterEkranı = new frmSekreterEkranı();
            frmSekreterEkranı.Show();
            this.Close();
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

        private void gridDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maskTxtTC.Text = gridDoktor.CurrentRow.Cells["DoctorTC"].Value.ToString();
                txtAd.Text = gridDoktor.CurrentRow.Cells["DoctorName"].Value.ToString();
                txtSoyad.Text = gridDoktor.CurrentRow.Cells["DoctorSurname"].Value.ToString();
                txtPassword.Text = gridDoktor.CurrentRow.Cells["DoctorPassword"].Value.ToString();
                cmbBrans.Text = gridDoktor.CurrentRow.Cells["BranchName"].Value.ToString();
                cmbSekreter.Text = gridDoktor.CurrentRow.Cells["SecretaryName"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void gridDoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
