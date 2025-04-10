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
        private async Task<string> GetHashedPassword(string password)
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
                    string query = "SELECT password FROM accounts WHERE login = @login";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);

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
    }
}
