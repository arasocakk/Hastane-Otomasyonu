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
    public partial class frmDoctorLogin : Form
    {
        public frmDoctorLogin()
        {
            InitializeComponent();
        }
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        private void frmDoctorLogin_Load(object sender, EventArgs e)
        {
            btnGirisDoktr.FlatStyle = FlatStyle.Flat;
            btnGirisDoktr.FlatAppearance.BorderSize = 0;
            btnGirisDoktr.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnGirisDoktr.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnGirisDoktr.BackColor = Color.Transparent; btnGirisDoktr.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnGirisDoktr_Click(object sender, EventArgs e)
        {
            try
            {


                connection = dbTransactions.connection();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "SELECT * FROM DoctorTBL WHERE DoctorTC='" + txtDoctorTc.Text + "'AND DoctorPassword='" + txtDoctorSifre.Text + "'";
                command = new SqlCommand(commandLine, connection);

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Hoşgeldiniz","Giriş Başarılı!");
                    frmDoktorIslemleri frmDoktorIslemleri = new frmDoktorIslemleri();
                    frmDoktorIslemleri.Show();
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
                txtDoctorSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtDoctorSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
