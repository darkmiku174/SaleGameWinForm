using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SaleGameAPP.View.Service
{
    public partial class FormGame : Form
    {
        private readonly string connectionString =
            "Data Source=Desktop-3KCQBD3\\SQLEXPRESS; Database=SaleGame; Trusted_Connection=True";
        string oldMSHH = "";
        string imgLoc = "";
        public FormGame()
        {
            InitializeComponent();   
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void ShowImg(string MSHH)
        {
            string queryString = @"SELECT HinhAnh From Game where MSHH=@MSHH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@MSHH", MSHH);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader[0];
                        if (img != null)
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureImgGame.Image = Image.FromStream(ms);
                        }
                        else
                            pictureImgGame.Image = null;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void ShowDataGridView()
        {
            string queryString = @"SELECT MSHH, TenGame, Gia, TinhTrang From Game";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    DataTable dttb = new DataTable();
                    sqlDa.Fill(dttb);
                    dgvGame.DataSource = dttb;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void dgvGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGame.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvGame.CurrentRow.Selected = true;
                tbMSHH.Text = dgvGame.Rows[e.RowIndex].Cells["MSHH"].Value.ToString();
                tbTenGame.Text = dgvGame.Rows[e.RowIndex].Cells["TenGame"].Value.ToString();
                ShowImg(tbMSHH.Text);
                tbGia.Text = dgvGame.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                rdExist.Checked = bool.Parse(dgvGame.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString());
                rdNotExist.Checked = !rdExist.Checked;
                oldMSHH = tbMSHH.Text;
            }
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|All File (*.*)|*.*";
                dlg.Title = "Select Game's Picture Which You Want To Add";
                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureImgGame.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int gia = Int32.Parse(tbGia.Text);
            dp.AddGame(tbMSHH.Text, tbTenGame.Text, imgLoc, gia, rdExist.Checked);
            ShowDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int gia = Int32.Parse(tbGia.Text);
            try
            {
                dp.UpdateGame(oldMSHH, tbMSHH.Text, tbTenGame.Text, imgLoc, gia, rdExist.Checked);
                ShowDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

       
    }
}
