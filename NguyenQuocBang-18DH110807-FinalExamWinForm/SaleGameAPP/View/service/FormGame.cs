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
        public FormGame()
        {
            InitializeComponent();
            ShowDataGridView();
            ShowInfo("G021");
        }
        private void ShowInfo(string MSHH)
        {
            string queryString = @"SELECT * From Game where MSHH=@MSHH";
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
                        tbMSHH.Text = reader[0].ToString();
                        tbTenGame.Text = reader[1].ToString();
                        byte[] img = (byte[])reader[2];
                        if (img != null)
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureImgGame.Image = Image.FromStream(ms);
                        }
                        else
                            pictureImgGame.Image = null;
                        tbGia.Text = reader[3].ToString();
                        rdExist.Checked = bool.Parse(reader[4].ToString());
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

    }
}
