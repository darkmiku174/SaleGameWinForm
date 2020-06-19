﻿using System;
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
            string queryString = null;
            if (HinhAnh !="")
            {
                queryString =
                @"Update Game 
                  Set MSHH=@newMSHH, TenGame=@TenGame, HinhAnh=@HinhAnh, Gia=@Gia, TinhTrang=@TinhTrang
                  Where MSHH=@oldMSHH";
            }
            else
            {
                queryString =
               @"Update Game 
                  Set MSHH=@newMSHH, TenGame=@TenGame, Gia=@Gia, TinhTrang=@TinhTrang
                  Where MSHH=@oldMSHH";
            }
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@oldMSHH", oldMSHH);
                command.Parameters.AddWithValue("@newMSHH", newMSHH);
                command.Parameters.AddWithValue("@TenGame", TenGame);
                command.Parameters.AddWithValue("@Gia", Gia);
                command.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                if(HinhAnh != "")
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(HinhAnh, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    command.Parameters.Add(new SqlParameter("@HinhAnh", img));
                    int x = command.ExecuteNonQuery();
                }
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
        public void DeleteGame(string MSHH)
        {
            string queryString =
                @"Delete from Game Where MSHH=@MSHH";
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
        public DataTable SearchGame(string TenGameSearch)
        {
            DataTable dttb = new DataTable();
            string queryString = @"SELECT MSHH, TenGame, Gia, TinhTrang From Game Where TenGame like @TenGameSearch";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@TenGameSearch", "%" + TenGameSearch + "%");
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public byte[] ImageGame(string MSHH)
        {
            string queryString = @"SELECT HinhAnh From Game where MSHH=@MSHH";
            byte[] img = null;
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
                        img = (byte[])reader[0];       
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return img;
        }
        public DataTable SelectMenuGame()
        {
            DataTable dttb = new DataTable();
            string queryString = @"SELECT MSHH, TenGame, Gia, TinhTrang From Game";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public List<string> CreateAutoCompleteSearch()
        {
            List<string> myCollection = new List<string>();
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select TenGame Game From Game", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        myCollection.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return myCollection;
        }
        public bool CheckExistGame(string MSHH)
        {
            string queryString =
                "SELECT MSHH From Game Where MSHH=@MSHH";
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
                        if (reader[0].ToString() == "")
                            return true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }
        private string CreateAutoNewMSDH()
        {
            string queryString =
                @"Select top 1 MSDH From HoaDon Order By MSDH Desc";
            string lastMSDH = "";
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
                       lastMSDH = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            string tempMSDH = "";
            for (int i = 2; i < lastMSDH.Length; i++)
                tempMSDH += lastMSDH[i];
            string newMSDH = "HD" + (Int32.Parse(tempMSDH) + 1).ToString();
            return newMSDH;
        }
        public string CurrentMSDH()
        {
            string queryString =
                @"Select top 1 MSDH From HoaDon Order By MSDH Desc";
            string lastMSDH = "";
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
                        lastMSDH = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lastMSDH;
        }
        public void CreateBill(string MSNV, DateTime NgayDat)
        {
            string MSDH = CreateAutoNewMSDH();
            string queryString =
                @"Insert into HoaDon 
                  Values(@MSDH, @MSNV, @NgayDat)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
                command.Parameters.AddWithValue("@MSNV", MSNV);
                command.Parameters.AddWithValue("@NgayDat", NgayDat);
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
        public void AddCart(string MSDH, string MSHH, int SoLuong, int TiLeGiam )
        {
            string queryString =
                @"Insert into DonHang 
                  Values(@MSDH, @MSHH, @SoLuong, @TiLeGiam)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
                command.Parameters.AddWithValue("@MSHH", MSHH);
                command.Parameters.AddWithValue("@SoLuong", SoLuong);
                command.Parameters.AddWithValue("@TiLeGiam", TiLeGiam);
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
        public DataTable SelectCart(string MSDH)
        {
            DataTable dttb = new DataTable();
            string queryString = 
                @"Select DonHang.MSHH, TenGame, Gia, SoLuong, TiLeGiam, Gia*SoLuong*(100-TiLeGiam)/100 As ThanhTien 
                  From DonHang, Game 
                  Where DonHang.MSHH=Game.MSHH 
	                and MSDH=@MSDH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@MSDH", MSDH);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public void DeleteGameInCart(string MSDH, string MSHH)
        {
            string queryString =
                @"Delete from DonHang Where MSDH=@MSDH And MSHH=@MSHH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
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
        public void DeleteCart(string MSDH)
        {
            DeleteDonHang(MSDH);
            DeleteHoaDon(MSDH);
        }
        private void DeleteDonHang(string MSDH)
        {
            string queryString =
                @"Delete from DonHang Where MSDH=@MSDH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
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
        private void DeleteHoaDon(string MSDH)
        {
            string queryString =
                @"Delete from HoaDon Where MSDH=@MSDH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
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
        public DataTable SelectBill()
        {
            DataTable dttb = new DataTable();
            string queryString =
                @"Select MSDH, TenNV, NgayDat 
                  From HoaDon, NhanVien 
                  Where HoaDon.MSNV=NhanVien.MSNV
                  Order By MSDH Desc";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public List<string> SelectNameNV()
        {
            List<string> lstName = new List<string>();
            string queryString =
                    @"Select TenNV From NhanVien";
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
                        lstName.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lstName;
        }
        public DataTable SearchBillOneDay(string ngayDat)
        {
            DataTable dttb = new DataTable();
            string queryString =
                @"Select MSDH, TenNV, NgayDat 
                  From HoaDon, NhanVien 
                  Where HoaDon.MSNV=NhanVien.MSNV
                        And "+ "NgayDat between " + "'"+ngayDat+"'" +" and "+ "'"+ngayDat + " 23:59:59'";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public DataTable SearchBillStartEnd(string start, string end)
        {
            DataTable dttb = new DataTable();
            string queryString =
                @"Select MSDH, TenNV, NgayDat 
                  From HoaDon, NhanVien 
                  Where HoaDon.MSNV=NhanVien.MSNV
                        And " + "NgayDat between " + "'" + start + "'" + " and " + "'" + end + " 23:59:59'";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
        public DataTable SelectWorker()
        {
            DataTable dttb = new DataTable();
            string queryString =
                @"select MSNV, TenNV,
                  case	
	                  When GioiTinh=1 then N'Nữ'
	                  else 'Nam' end as GioiTinh,
                  case	
	                  When Loai=1 then N'Nhân viên'
	                  else N'Chủ' end as Loai 
                  from NhanVien";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
                    sqlDa.Fill(dttb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dttb;
        }
    }
}
