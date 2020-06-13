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
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        private readonly string connectionString =
            "Data Source=Desktop-3KCQBD3\\SQLEXPRESS; Database=SaleGame; Trusted_Connection=True";
        public void EncryptPass(string username ,byte[] pass, byte[] key, byte[] IV)
        {
            string queryString = @"Update TaiKhoan
                                   Set MatKhau=@pass, ChiaKhoa=@Key, IV=@IV
                                   Where TenTaiKhoan=@username";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", username);
                SqlParameter param = command.Parameters.Add("@pass", SqlDbType.VarBinary);
                param.Value = pass;
                //command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@key", key);
                command.Parameters.AddWithValue("@IV", IV);
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
        public byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            /*byte[] encrypted;
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;*/
            byte[] encrypted = Encoding.Unicode.GetBytes(plainText);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("admin@123"));
            crypt.IV = IV;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                }

                encrypted = memoryStream.ToArray();
            }
            return encrypted;
        }
        public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            string plaintext = null;
            /*using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;*/
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("admin@123"));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(cipherText))
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[cipherText.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    plaintext = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
            return plaintext;
        }
        public string DecryptPass(string username)
        {
            string queryString = @"Select MatKhau, ChiaKhoa, IV
                                   From TaiKhoan
                                   Where TenTaiKhoan=@username";
            string roundtrip = "";
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
                        string tempEncrypted = reader[0].ToString();
                        string tempKey = reader[1].ToString();
                        string tempIV = reader[2].ToString();
                        byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(tempEncrypted);
                        byte[] key = System.Text.Encoding.Unicode.GetBytes(tempKey);
                        byte[] IV = System.Text.Encoding.Unicode.GetBytes(tempIV);
                        roundtrip = DecryptStringFromBytes_Aes(encrypted, key, IV);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return roundtrip;
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
                                   Values(@ID, @username, null, null, null)";
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
            using (Aes myAes = Aes.Create())
            {
                byte[] encrypted = EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);
                EncryptPass(username, encrypted, myAes.Key, myAes.IV);
            }
        }
    }
}
