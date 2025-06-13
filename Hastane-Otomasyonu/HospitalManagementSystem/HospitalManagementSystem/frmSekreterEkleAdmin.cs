using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmSekreterEkleAdmin : Form
    {
        public frmSekreterEkleAdmin()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlCommand command;
        string commandLine;

        private void frmSekreterEkleAdmin_Load(object sender, EventArgs e)
        {
            btnEkleSekreter.FlatStyle = FlatStyle.Flat;
            btnEkleSekreter.FlatAppearance.BorderSize = 0;
            btnEkleSekreter.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnEkleSekreter.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnEkleSekreter.BackColor = Color.Transparent; btnEkleSekreter.FlatStyle = FlatStyle.Flat;

            btnSekreterGuncelle.FlatStyle = FlatStyle.Flat;
            btnSekreterGuncelle.FlatAppearance.BorderSize = 0;
            btnSekreterGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnSekreterGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnSekreterGuncelle.BackColor = Color.Transparent; btnSekreterGuncelle.FlatStyle = FlatStyle.Flat;

            btnSekreterSil.FlatStyle = FlatStyle.Flat;
            btnSekreterSil.FlatAppearance.BorderSize = 0;
            btnSekreterSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnSekreterSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnSekreterSil.BackColor = Color.Transparent; btnSekreterSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;



            List();


        }
        public void List()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT sec.SecretaryID, sec.SecretaryName,sec.SecretarySurname,sec.SecretaryTC,sec.SecretaryPassword, adm.AdminUsername FROM SecretaryTBL as sec \r\nINNER JOIN AdminTBL as adm ON sec.AdminID = adm.AdminID";
                SqlDataAdapter da = new SqlDataAdapter(commandLine,connection);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                gridSecretary.DataSource = dt;
                gridSecretary.Columns["SecretaryID"].HeaderText = "Sekreter ID";
                gridSecretary.Columns["SecretaryName"].HeaderText = "Sekreter Adı";
                gridSecretary.Columns["SecretarySurname"].HeaderText = "Sekreter Soyadı";
                gridSecretary.Columns["SecretaryTC"].HeaderText = "Sekreter TC";
                gridSecretary.Columns["SecretaryPassword"].HeaderText = "Sekreter Şifre";
                gridSecretary.Columns["AdminUsername"].HeaderText = "Admin Ad";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void btnEkleSekreter_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO SecretaryTBL VALUES (@secretaryName,@secretarySurname,@secretaryTC,@secretaryPassword,@adminID)";


                command = new SqlCommand(commandLine,connection);
                command.Parameters.AddWithValue("@secretaryName",txtAd.Text);
                command.Parameters.AddWithValue("@secretarySurname",txtSoyad.Text);
                command.Parameters.AddWithValue("@secretaryTC",maskTxtTC.Text);
                command.Parameters.AddWithValue("@secretaryPassword",txtPassword.Text);
                command.Parameters.AddWithValue("@adminID",1);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı");

                List();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata Oluştu!");
            }
        }

        private void btnSekreterSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    commandLine = "DELETE FROM SecretaryTBL WHERE SecretaryID = @secretaryid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@secretaryid", gridSecretary.CurrentRow.Cells["SecretaryID"].Value.ToString());
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata Oluştu");
            }

            List();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmAdminLogin frmAdminLogin = new frmAdminLogin();
            frmAdminLogin.Show();
            this.Close();
        }

        private void btnSekreterGuncelle_Click(object sender, EventArgs e)
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
                    commandLine = "UPDATE SecretaryTBL SET SecretaryTC = @sectc, SecretaryName = @secname,SecretarySurname = @secsurname,SecretaryPassword = @secpassw  WHERE SecretaryID = @secretaryid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@secretaryid", gridSecretary.CurrentRow.Cells["SecretaryID"].Value.ToString());
                    command.Parameters.AddWithValue("@sectc",maskTxtTC.Text);
                    command.Parameters.AddWithValue("@secname",txtAd.Text);
                    command.Parameters.AddWithValue("@secsurname",txtSoyad.Text);
                    command.Parameters.AddWithValue("@secpassw",txtPassword.Text);
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

        private void txtSekreterArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "SELECT * FROM SecretaryTBL WHERE SecretaryName LIKE '%" + txtSekreterArama.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridSecretary.DataSource = dt;

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridSecretary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridSecretary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maskTxtTC.Text = gridSecretary.CurrentRow.Cells["SecretaryTC"].Value.ToString();
                txtAd.Text = gridSecretary.CurrentRow.Cells["SecretaryName"].Value.ToString();
                txtSoyad.Text = gridSecretary.CurrentRow.Cells["SecretarySurname"].Value.ToString();
                txtPassword.Text = gridSecretary.CurrentRow.Cells["SecretaryPassword"].Value.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }
    }
}
