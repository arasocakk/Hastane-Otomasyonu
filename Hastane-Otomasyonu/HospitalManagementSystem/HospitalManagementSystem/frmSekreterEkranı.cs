using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmSekreterEkranı : Form
    {
        public frmSekreterEkranı()
        {
            InitializeComponent();
        }

        private void frmSekreterEkranı_Load(object sender, EventArgs e)
        {
            btnDoktorDetay.FlatStyle = FlatStyle.Flat;
            btnDoktorDetay.FlatAppearance.BorderSize = 0;
            btnDoktorDetay.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnDoktorDetay.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnDoktorDetay.BackColor = Color.Transparent; btnDoktorDetay.FlatStyle = FlatStyle.Flat;

            btnRandevu.FlatStyle = FlatStyle.Flat;
            btnRandevu.FlatAppearance.BorderSize = 0;
            btnRandevu.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnRandevu.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnRandevu.BackColor = Color.Transparent; btnRandevu.FlatStyle = FlatStyle.Flat;

            btnBransEkle.FlatStyle = FlatStyle.Flat;
            btnBransEkle.FlatAppearance.BorderSize = 0;
            btnBransEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnBransEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnBransEkle.BackColor = Color.Transparent; btnBransEkle.FlatStyle = FlatStyle.Flat;

            btnHastaEkle.FlatStyle = FlatStyle.Flat;
            btnHastaEkle.FlatAppearance.BorderSize = 0;
            btnHastaEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnHastaEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnHastaEkle.BackColor = Color.Transparent; btnHastaEkle.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSecreteryLogin frmSecreteryLogin = new frmSecreteryLogin();
            frmSecreteryLogin.Show();
            this.Close();   
        }

        private void btnDoktorDetay_Click(object sender, EventArgs e)
        {
            frmDoktorDetay frmDoktorDetay = new frmDoktorDetay();
            frmDoktorDetay.Show();
            this.Close();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            frmHastaEkle frmHastaEkle = new frmHastaEkle();
            frmHastaEkle.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            frmBransEkle frmBransEkle = new frmBransEkle();
            frmBransEkle.Show();
            this.Close();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            frmRandevuOlustur frmRandevuOlustur = new frmRandevuOlustur();
            frmRandevuOlustur.Show();
            this.Close();
        }
    }
}
