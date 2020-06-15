using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace SaleGameAPP
{
    class DataProvider
    {
        private readonly string connectionString =
            "Data Source=Desktop-3KCQBD3\\SQLEXPRESS; Database=SaleGame; Trusted_Connection=True";
        public void HashPass(string username, string pass)
        {
            string queryString = @"Update TaiKhoan
                                   Set MatKhauHash=@pass, Salt=@salt
                                   Where TenTaiKhoan=@username";
            PasswordHash hash = new PasswordHash(pass);
            byte[] hashBytes = hash.ToArray();
            //string hashPass = PasswordHash.OutputHash(hashBytes);
            //string salt = PasswordHash.OutputSalt(hash.Salt);
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.Add("@pass", SqlDbType.Binary);
                command.Parameters["@pass"].Value = hashBytes;
                command.Parameters.Add("@salt", SqlDbType.Binary);
                command.Parameters["@salt"].Value = hash.Salt;
                //command.Parameters.AddWithValue("@username", username);
                //command.Parameters.AddWithValue("@pass", hashPass);
                //command.Parameters.AddWithValue("@salt", salt);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public byte[] DeHashPass(string username)
        {
            string queryString = @"Select MatKhauHash
                                   From TaiKhoan
                                   Where TenTaiKhoan=@username";
            byte[] result = new byte[0];
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string hashPass = reader[0].ToString();
                        result = System.Text.Encoding.Unicode.GetBytes(hashPass);
                        //PasswordHash hash1 = new PasswordHash(hashBytes);
                        //result = PasswordHash.OutputHash(hash1.ToArray());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        public byte[] SaltPass(string username)
        {
            string queryString = @"Select Salt
                                   From TaiKhoan
                                   Where TenTaiKhoan=@username";
            byte[] salt = new byte[0];
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string r1 = reader[0].ToString();
                        salt = System.Text.Encoding.Unicode.GetBytes(r1);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return salt;
        }
        public string CheckUserNameExist(string username)
        {
            string queryString = @"Select TenTaiKhoan
                                   From TaiKhoan
                                   Where TenTaiKhoan =@username";
            string result = "";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        public string CheckIDUsed(string ID)
        {
            string queryString = @"Select MSNV
                                   From TaiKhoan
                                   Where MSNV =@ID";
            string result = "";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        public string CheckIDExist(string ID)
        {
            string queryString = @"Select MSNV
                                   From NhanVien
                                   Where MSNV =@ID";
            string result = "";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        public int CheckUserNameAndIDUsed(string ID, string username)
        {
            string queryString = @"Select count(TenTaiKhoan)
                                   From TaiKhoan
                                   Where MSNV =@ID";
            int result = 0;
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
        public void InsertAccount(string ID, string username, string password)
        {

            string queryString = @"Insert into TaiKhoan
                                   Values(@ID, @username, null, null)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            HashPass(username, password);
        }
        public List<Model.Game> TableGame()
        {
            List<Model.Game> dsThucUong = new List<Model.Game>();
            string queryString = @"SELECT MSHH, TenGame, Gia, TinhTrang From Game";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Model.Game mGame = new Model.Game();
                        mGame.MSHH = reader[0].ToString();
                        mGame.TenGame = reader[1].ToString();
                        mGame.Gia = int.Parse(reader[2].ToString());
                        mGame.TinhTrang = bool.Parse(reader[3].ToString());
                        dsThucUong.Add(mGame);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return dsThucUong;
            }
        }
        public void AddGame(string MSHH, string TenGame, string HinhAnh, int Gia, bool TinhTrang)
        {
            string queryString =
                @"Insert into Game 
                  Values(@MSHH, @TenGame, @HinhAnh, @Gia, @TinhTrang)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", MSHH);
                command.Parameters.AddWithValue("@TenGame", TenGame);
                command.Parameters.AddWithValue("@Gia", Gia);
                command.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                byte[] img = null;
                FileStream fs = new FileStream(HinhAnh, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.Parameters.Add(new SqlParameter("@HinhAnh", img));
                int x = command.ExecuteNonQuery();
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void UpdateGame(string oldMSHH, string newMSHH, string TenGame, string HinhAnh, int Gia, bool TinhTrang)
        {
            string queryString =
                @"Update THUCUONG 
                  Set MSHH=@newMSHH, TenGame=@TenGame, HinhAnh=@HinhAnh, Gia=@Gia, TinhTrang=@TinhTrang
                  Where MSHH=@oldMSHH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@oldMSHH", oldMSHH);
                command.Parameters.AddWithValue("@newMSHH", newMSHH);
                command.Parameters.AddWithValue("@TenGame", TenGame);
                command.Parameters.AddWithValue("@Gia", Gia);
                command.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                byte[] img = null;
                FileStream fs = new FileStream(HinhAnh, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command.Parameters.Add(new SqlParameter("@HinhAnh", img));
                int x = command.ExecuteNonQuery();
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void RemoveTHUCUONG(string MSHH)
        {
            string queryString =
                "Delete from THUCUONG Where MSHH=@MSHH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", MSHH);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
