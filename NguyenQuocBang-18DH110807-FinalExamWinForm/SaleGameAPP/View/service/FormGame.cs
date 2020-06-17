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
using System.Text.RegularExpressions;

namespace SaleGameAPP.View.Service
{
    public partial class FormGame : Form
    {
        private string oldMSHH = "";
        private string imgLoc = "";
        private AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
        public FormGame()
        {
            InitializeComponent();   
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            rdExist.Checked = true;
            ShowDataGridView();
            AutoCompleteSearch();
            ShowInfo();
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
            if (Int32.Parse(tbGia.Text) <= 0)
            {
                MessageBox.Show("Please type number bigger than 0");
                return false;
            }
            return true;
        }
        private void AutoCompleteSearch()
        {
            DataProvider dp = new DataProvider();
            List<string> autocomplete = dp.CreateAutoCompleteSearch();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
            for (int i = 0; i < autocomplete.Count; i++)
                myCollection.Add(autocomplete[i]);
            tbSearch.AutoCompleteCustomSource = myCollection;
        }
        private void ShowImg(string MSHH)
        {
            DataProvider dp = new DataProvider();
            byte[] img = dp.ImageGame(MSHH);
            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pictureImgGame.Image = Image.FromStream(ms);
            }
            else
                pictureImgGame.Image = null;
        }
        private void ShowInfo()
        {
            tbMSHH.Text = dgvGame.Rows[0].Cells["MSHH"].Value.ToString();
            tbTenGame.Text = dgvGame.Rows[0].Cells["TenGame"].Value.ToString();
            ShowImg(tbMSHH.Text);
            tbGia.Text = dgvGame.Rows[0].Cells["Gia"].Value.ToString();
            rdExist.Checked = bool.Parse(dgvGame.Rows[0].Cells["TinhTrang"].Value.ToString());
            rdNotExist.Checked = !rdExist.Checked;
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
                return;
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
            Clear();
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
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete game?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
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

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || e.KeyCode==Keys.Right)
                if (dgvGame.Rows[0].Cells[0].Value != null)
                    ShowInfo();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool notExist = rdNotExist.Checked;
            if(notExist)
            {
                MessageBox.Show("Out of stock");
                return;
            }
            string MSHH = dgvGame.CurrentRow.Cells["MSHH"].Value.ToString();
            SaleGameAPP.View.Service.FormCreateBill formBill = new View.Service.FormCreateBill(MSHH);
            formBill.Show();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            dp.CreateBill(SaleGameAPP.View.Home.FormHome.MSNV, DateTime.Now);
            MessageBox.Show("You created new bill");
        }
    }
}
