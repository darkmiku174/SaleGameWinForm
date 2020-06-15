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
using System.Text.RegularExpressions;

namespace SaleGameAPP.View.Service
{
    public partial class FormGame : Form
    {
        private readonly string connectionString =
            "Data Source=Desktop-3KCQBD3\\SQLEXPRESS; Database=SaleGame; Trusted_Connection=True";
        string oldMSHH = "";
        string imgLoc = "";
        AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
        private event EventHandler search;
        public FormGame()
        {
            InitializeComponent();   
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            rdExist.Checked = true;
            ShowDataGridView();
            AutoCompleteSearch();
        }
        private void Clear()
        {
            tbMSHH.Text = "";
            tbTenGame.Text = "";
            tbGia.Text = "";
            rdExist.Checked = true;
            tbSearch.Text = "";
            pictureImgGame.Image = null;
        }
        private bool CheckInput()
        {
            if (tbMSHH.Text == "" || tbTenGame.Text == "" || tbGia.Text == "" || pictureImgGame.Image == null)
            {
                MessageBox.Show("Please type full information!!!");
                return false;
            }
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!regex.IsMatch(tbGia.Text))
            {
                MessageBox.Show("Please type number at Gia!!!");
                return false;
            }
            return true;
        }
        private void AutoCompleteSearch()
        {
            DataProvider dp = new DataProvider();
            List<string> autocomplete = dp.CreateAutoCompelteSearch();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < autocomplete.Count; i++)
                myCollection.Add(autocomplete[i]);
            tbSearch.AutoCompleteCustomSource = myCollection;
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
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectMenuGame();
            dgvGame.DataSource = dttb; 
        }

        private void dgvGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dgvGame.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
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
            if(!CheckInput())
            {
                return;
            }
            DataProvider dp = new DataProvider();
            if (!dp.CheckExistGame(tbMSHH.Text))
            {
                MessageBox.Show("MSHH is exist");
                return;
            }
            int gia = Int32.Parse(tbGia.Text);
            dp.AddGame(tbMSHH.Text, tbTenGame.Text, imgLoc, gia, rdExist.Checked);
            ShowDataGridView();
            myCollection.Add(tbTenGame.Text);
            tbSearch.AutoCompleteCustomSource = myCollection;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            DataProvider dp = new DataProvider();
            if (!dp.CheckExistGame(tbMSHH.Text))
            {
                MessageBox.Show("MSHH is exist");
                return;
            }
            int gia = Int32.Parse(tbGia.Text);
            dp.UpdateGame(oldMSHH, tbMSHH.Text, tbTenGame.Text, imgLoc, gia, rdExist.Checked);
            ShowDataGridView();
            myCollection.Add(tbTenGame.Text);
            tbSearch.AutoCompleteCustomSource = myCollection;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            dp.DeleteGame(tbMSHH.Text);
            ShowDataGridView();
            myCollection.Remove(tbTenGame.Text);
            tbSearch.AutoCompleteCustomSource = myCollection;
            Clear();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "" || tbSearch.Text == null)
                ShowDataGridView();
            else
            {
                DataProvider dp = new DataProvider();
                DataTable dttb = dp.SearchGame(tbSearch.Text);
                dgvGame.DataSource = dttb;
            }
            

        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvGame.Rows[0].Selected = true;
        }
    }
}
