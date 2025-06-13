using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using HospitalManagementSystem.Properties;

namespace HospitalManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.FlatAppearance.BorderSize = 0;
            btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnAdminLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnAdminLogin.BackColor = Color.Transparent;btnAdminLogin.FlatStyle = FlatStyle.Flat;

            btnDoctorLogin.FlatStyle = FlatStyle.Flat;
            btnDoctorLogin.FlatAppearance.BorderSize = 0;
            btnDoctorLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnDoctorLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnDoctorLogin.BackColor = Color.Transparent;

            btnSecreteryLogin.FlatStyle = FlatStyle.Flat;
            btnSecreteryLogin.FlatAppearance.BorderSize = 0;
            btnSecreteryLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnSecreteryLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnSecreteryLogin.BackColor = Color.Transparent;

            btnPowerOff.FlatStyle = FlatStyle.Flat;
            btnPowerOff.FlatAppearance.BorderSize = 0;
            btnPowerOff.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnPowerOff.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnPowerOff.BackColor = Color.Transparent;

        }



        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            frmAdminLogin frmAdminLogin = new frmAdminLogin();
            frmAdminLogin.Show();
            this.Hide();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
             

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                
            }
            else
            {

            }
            

        }

       

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            frmDoctorLogin frmDoctorLogin = new frmDoctorLogin();   
            frmDoctorLogin.Show();
            this.Hide();
        }

        private void btnSecreteryLogin_Click(object sender, EventArgs e)
        {
            frmSecreteryLogin frmSecreteryLogin = new frmSecreteryLogin();
            frmSecreteryLogin.Show();
            this.Hide();
        }
    }
}
