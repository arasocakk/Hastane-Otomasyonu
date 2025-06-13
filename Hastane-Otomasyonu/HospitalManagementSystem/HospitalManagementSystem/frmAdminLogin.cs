using HospitalManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
           
            InitializeComponent();
        }
        
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            btnGirisAdm.FlatStyle = FlatStyle.Flat;
            btnGirisAdm.FlatAppearance.BorderSize = 0;
            btnGirisAdm.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnGirisAdm.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnGirisAdm.BackColor = Color.Transparent; btnGirisAdm.FlatStyle = FlatStyle.Flat;

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

        private void btnGirisAdm_Click(object sender, EventArgs e)
        {

           
            try
            {
               

                connection = dbTransactions.connection();
                if (connection.State != ConnectionState.Open) 
                {
                    connection.Open();
                }

                commandLine = "SELECT * FROM AdminTBL WHERE AdminUsername='" + txtAdminName.Text + "'AND AdminPassword='" + txtAdminSifre.Text + "'";
                command = new SqlCommand(commandLine,connection);
                
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Merhaba " + txtAdminName.Text,"Giriş Başarılı");
                    frmSekreterEkleAdmin frmSekreterEkleAdmin = new frmSekreterEkleAdmin();
                    frmSekreterEkleAdmin.Show();
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

                MessageBox.Show(ex.Message,"Hata Oluştu!");
            }

           
        }

        private void chbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreGoster.Checked)
            {
                txtAdminSifre.UseSystemPasswordChar = false ;
            }
            else
            {
                txtAdminSifre.UseSystemPasswordChar = true;
            }
           
        }
    }
}
