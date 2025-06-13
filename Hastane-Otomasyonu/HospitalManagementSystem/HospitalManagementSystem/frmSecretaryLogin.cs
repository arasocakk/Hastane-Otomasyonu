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
    public partial class frmSecreteryLogin : Form
    {
        public frmSecreteryLogin()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        private void frmSecreteryLogin_Load(object sender, EventArgs e)
        {
            btnGirisSekr.FlatStyle = FlatStyle.Flat;
            btnGirisSekr.FlatAppearance.BorderSize = 0;
            btnGirisSekr.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnGirisSekr.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnGirisSekr.BackColor = Color.Transparent; btnGirisSekr.FlatStyle = FlatStyle.Flat;


            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;
        }

        private void lblAdminLog_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();

        }

        private void btnGirisSekr_Click(object sender, EventArgs e)
        {
            try
            {


                connection = dbTransactions.connection();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "SELECT * FROM SecretaryTBL WHERE SecretaryTC='" + txtSekreterTc.Text + "'AND SecretaryPassword='" + txtSekreterSifre.Text + "'";
                command = new SqlCommand(commandLine, connection);

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Hoşgeldiniz","Giriş Başarılı!");
                    frmSekreterEkranı frmSekreterEkranı = new frmSekreterEkranı();
                    frmSekreterEkranı.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                }

                connection.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreGoster.Checked)
            {
                txtSekreterSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSekreterSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
