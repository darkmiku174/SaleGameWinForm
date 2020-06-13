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
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SaleGameAPP
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString =
            "Data Source=Desktop-3KCQBD3\\SQLEXPRESS; Database=SaleGame; Trusted_Connection=True";
        public FormLogin()
        {
            InitializeComponent();
        }

        void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
                    UpdatePass(encrypted, aes.Key, aes.IV);
                    Output(encrypted);
                    Output(aes.Key);
                    Output(aes.IV);
                    // Print encrypted string    
                    //MessageBox.Show($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");

                    // Decrypt the bytes to a string. 
                    //string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
                    // Print decrypted string. It should be same as raw data    
                    //MessageBox.Show($"Decrypted data: {decrypted}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;
        }

        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                   
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        void UpdatePass(byte[] pass, byte[] key, byte[] IV)
        {
            string queryString = @"Update TaiKhoan
                                   Set MatKhau=@pass, ChiaKhoa=@Key, IV=@IV
                                   Where TenTaiKhoan=@username";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", "admin");
                command.Parameters.AddWithValue("@pass", pass);
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

        void SelectPass()
        {
            string queryString = @"Select MatKhau, ChiaKhoa, IV
                                   From TaiKhoan
                                   Where TenTaiKhoan=@username";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", "admin");
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tempPass = reader[0].ToString();
                        string tempKey = reader[1].ToString();
                        string tempIV = reader[2].ToString();
                        byte[] pass = System.Text.Encoding.Unicode.GetBytes(tempPass);
                        //Output(pass);
                        byte[] key = System.Text.Encoding.Unicode.GetBytes(tempKey);
                        //Output(key);
                        byte[] IV = System.Text.Encoding.Unicode.GetBytes(tempIV);
                        //Output(IV);
                        string decrypted = Decrypt(pass, key, IV);
                        MessageBox.Show($"Decrypted data: {decrypted}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void Output(byte[] x)
        {
            string result = "";
            for (int i = 0; i < x.Length; i++)
                result += x[i].ToString();
            MessageBox.Show(result);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string raw = tbPass.Text;
            EncryptAesManaged(raw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectPass();
        }
    }
}
