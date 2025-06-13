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
    public partial class frmBransEkle : Form
    {
        DatabaseTransactions dbTransactions = new DatabaseTransactions();
        SqlConnection connection;
        SqlDataReader dataReader;
        SqlCommand command;
        string commandLine;
        public frmBransEkle()
        {
            InitializeComponent();
        }
        public void List()
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT * FROM BranchTBL";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridBrans.DataSource = dt;
                gridBrans.Columns["BranchID"].HeaderText = "Branş ID";
                gridBrans.Columns["BranchName"].HeaderText = "Branş Adı";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }
        private void btnEkleBrans_Click(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                commandLine = "INSERT INTO BranchTBL VALUES (@branchname)";

                DialogResult result = MessageBox.Show("Eklemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if(result == DialogResult.Yes)
                {
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@branchname", txtBransEkle.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                }
                else
                {
                    
                }


               List();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
        }

        private void btnBransSil_Click(object sender, EventArgs e)
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
                    commandLine = "DELETE FROM BranchTBL WHERE BranchID = @branchid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@branchid", gridBrans.CurrentRow.Cells["BranchID"].Value.ToString());
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

        private void btnBransGuncelle_Click(object sender, EventArgs e)
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
                    
                    commandLine = "UPDATE BranchTBL SET BranchName = @branchname WHERE BranchID = @branchid";
                    command = new SqlCommand(commandLine, connection);
                    command.Parameters.AddWithValue("@branchid", gridBrans.CurrentRow.Cells["BranchID"].Value.ToString());
                    command.Parameters.AddWithValue("@branchname", txtBransEkle.Text);
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

        private void frmBransEkle_Load(object sender, EventArgs e)
        {
            btnEkleBrans.FlatStyle = FlatStyle.Flat;
            btnEkleBrans.FlatAppearance.BorderSize = 0;
            btnEkleBrans.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnEkleBrans.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnEkleBrans.BackColor = Color.Transparent; btnEkleBrans.FlatStyle = FlatStyle.Flat;

            btnBransGuncelle.FlatStyle = FlatStyle.Flat;
            btnBransGuncelle.FlatAppearance.BorderSize = 0;
            btnBransGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnBransGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnBransGuncelle.BackColor = Color.Transparent; btnBransGuncelle.FlatStyle = FlatStyle.Flat;

            btnBransSil.FlatStyle = FlatStyle.Flat;
            btnBransSil.FlatAppearance.BorderSize = 0;
            btnBransSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnBransSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnBransSil.BackColor = Color.Transparent; btnBransSil.FlatStyle = FlatStyle.Flat;

            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, Color.Gray);
            btnReturn.BackColor = Color.Transparent; btnReturn.FlatStyle = FlatStyle.Flat;

            List();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSekreterEkranı frmSekreterEkranı = new frmSekreterEkranı();
            frmSekreterEkranı.Show();
            this.Close();

        }

        private void gridBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtBransEkle.Text = gridBrans.CurrentRow.Cells["BranchName"].Value.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }

        private void txtBransAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection = dbTransactions.connection();
                commandLine = "SELECT BranchName FROM BranchTBL WHERE BranchName LIKE '%" + txtBransAra.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(commandLine, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridBrans.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void txtBransEkle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
