using GameLauncher.Side.Host;
using GameLauncher.Side.Log;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Side.Secure
{
    public class Validations
    {
        public static async Task<string> GetHashedPassword(string password)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(Connections.HashDecoderHost, new StringContent("password=" + password, Encoding.UTF8, "application/x-www-form-urlencoded"));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        public static bool ValidasiLoginV1(string login, string hashedPassword)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Database.HostDatabase.DatabaseConfig))
                {
                    conn.Open();
                    string query = "SELECT password FROM accounts_data WHERE username = @username";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", login);

                    string storedHashedPassword = (string)cmd.ExecuteScalar();
                    return storedHashedPassword == hashedPassword;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
                return false;
            }
        }
        public static bool ValidasiLoginV3(string login, string password)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Database.HostDatabase.DatabaseConfig))
                {
                    conn.Open();
                    string query = "SELECT password FROM accounts_data WHERE username = @username";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@username", NpgsqlDbType.Varchar).Value = login;
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string storedPassword = reader["password"].ToString();
                                if (storedPassword == password)
                                {
                                    //Logger.Log("Login berhasil");
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Logger.Log("Kesalahan Server Database: " + ex.Message + " " + ex.InnerException);
                return false;
            }
            catch (Exception ex)
            {
                Logger.Log("Kesalahan: " + ex.Message + " " + ex.InnerException);
                return false;
            }
            return false;
        }
        public static async Task UpdateLastLogin(string username)
        {
            try
            {
                string query = "UPDATE accounts_data SET last_login = @last_login WHERE username = @username";
                using (NpgsqlConnection conn = new NpgsqlConnection(Database.HostDatabase.DatabaseConfig))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@last_login", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@username", username);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Kesalahan update last login: " + ex.Message);
            }
        }
    }
}
