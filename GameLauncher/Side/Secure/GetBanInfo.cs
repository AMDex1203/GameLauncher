using GameLauncher.Side.Data;
using GameLauncher.Side.Host;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Side.Secure
{
    internal class GetBanInfo
    {
        public static async Task ValidateDevice()
        {
            string connectionString = Database.HostDatabase.DatabaseConfig;
            string query = "SELECT reason, date_end FROM get_banned_device WHERE ip_address = @ip AND mac_address = @mac_address";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ip", GetPublicIpAddress.GetPublicIpv4());
                    cmd.Parameters.AddWithValue("@mac_address", GetPublicIpAddress.GetPublicIpv6());
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            string reason = reader["reason"].ToString();
                            DateTime dateEnd = Convert.ToDateTime(reader["date_end"]);

                            if (dateEnd < DateTime.Now)
                            {
                                // Hak Akses Kembali Ketika Tanggal Sudah Terlewati
                                return;
                            }
                            else
                            {
                                MessageBox.Show($"Komputer Anda Telah Di Banned.\n\nAlasan : {reason}\nBanned End : {dateEnd.ToString("dd MMMM yyyy")}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            // IP tidak ditemukan, izinkan akses
                            return;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Kesalahan database: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan umum: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
