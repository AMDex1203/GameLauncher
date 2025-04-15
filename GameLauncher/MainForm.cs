using GameLauncher.Side.Host;
using GameLauncher.Side.Log;
using Guna.UI2.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            STRINGView();
            FadeInMainForm.Start();

            Hide_Panel();

            Home_Panel.Show();
        }
        private void STRINGView()
        {
            HomeButton.Text = InternalLauncher.InternalSTRING.STR_ABOUT_BUTTON;
            ListGameButton.Text = InternalLauncher.InternalSTRING.STR_GAMELIST_BUTTON;
            ItemShopButton.Text = InternalLauncher.InternalSTRING.STR_ITEM_SHOP;
            TOPUPButton.Text = InternalLauncher.InternalSTRING.STR_TOPUP_CENTER;
            AccountCenterButton.Text = InternalLauncher.InternalSTRING.STR_ACCOUNT_CENTER;
            SettingButton.Text = InternalLauncher.InternalSTRING.STR_SETTING_BUTTON;
        }
        private void Hide_Panel()
        {
            Home_Panel.Hide();
            GameList_Panel.Hide();
            TopUpCenter_Panel.Hide();


            HideAutoScroll();
        }
        private void HideAutoScroll()
        {
            TopUpCenter_Panel.AutoScroll = false;
        }

        private void GameListButton_Click(object sender, EventArgs e)
        {
            Hide_Panel();
            GameList_Panel.Show();

            Game_Panel1.Hide();
            Game_Panel2.Hide();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Database.HostDatabase.DatabaseConfig))
                {
                    conn.Open();
                    string query = "SELECT id, game_name, version, udp_version, update_link, client_link, visible FROM data_game_list";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string game_id = reader["id"].ToString();
                                string game_name = reader["game_name"].ToString();
                                string game_version = reader["version"].ToString();
                                string game_udp_version = reader["udp_version"].ToString();
                                string game_update_link = reader["update_link"].ToString();
                                string game_client_link = reader["client_link"].ToString();
                                string game_visible = reader["visible"].ToString();

                                if (game_id == "1")
                                {
                                    if (game_visible.ToLower() == "true")
                                    {
                                        STR_DOWNLOAD_CP1.Visible = false;
                                        STR_Pencent_GP1.Visible = false;
                                        STR_TOTALSIZE_GP1.Visible = false;
                                        DownloadBarP1.Visible = false;


                                        GN_Panel1.Text = game_name;
                                        STR_VERSION_GAME_PG1.Text = game_version;
                                        Game_Panel1.Show();
                                        GamePanel1Start();
                                    }
                                    else
                                    {
                                        Game_Panel1.Hide();
                                    }
                                }
                                else if (game_id == "2")
                                {
                                    if (game_visible.ToLower() == "true")
                                    {
                                        GN_Panel2.Text = game_name;
                                        STR_VERSION_GAME_PG2.Text = game_version;
                                        Game_Panel2.Show();
                                        GamePanel2Start();
                                    }
                                    else
                                    {
                                        Game_Panel2.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, show a message box, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void GamePanel1Start()
        {
            string pbFolderPath = @"C:\Spinnet+\Games\PBID";
            string pbExePath = Path.Combine(pbFolderPath, "PointBlank.exe");

            if (File.Exists(pbExePath))
            {
                RunGameP1_Click.Show();
            }
            else
            {
                RunGameP1_Click.Hide();
            }
        }
        private void GamePanel2Start()
        {
            string pbFolderPath = @"C:\Spinnet+\Games\PBEvo";

            if (Directory.Exists(pbFolderPath))
            {
                RunGameP2_Click.Show();
            }
            else
            {
                RunGameP2_Click.Hide();
            }
        }
        private void GamePanel_2()
        {
            Game_Panel2.Show();
        }
        private async void InstalGP1_Click(object sender, EventArgs e)
        {
            STR_DOWNLOAD_CP1.Visible = true;
            STR_Pencent_GP1.Visible = true;
            STR_TOTALSIZE_GP1.Visible = true;
            DownloadBarP1.Visible = true;

            RunGameP1_Click.Hide();
            UpdateGameP1_Click.Hide();
            InstallGameP1_Click.Hide();

            string url = Connections.GamePanel1Client;
            string extractPath = @"C:\Spinnet+\Games\PBID";

            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            try
            {
                await DownloadFileAsync(url, extractPath);
                await ExtractFileAsync(extractPath);
                //MessageBox.Show("Download dan ekstraksi selesai!");
                RunGameP1_Click.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DownloadBarP1.Visible = false;
                STR_Pencent_GP1.Visible = false;
                STR_TOTALSIZE_GP1.Visible = false;
                STR_DOWNLOAD_CP1.Visible = false;
            }
        }
        private async Task DownloadFileAsync(string url, string extractPath)
        {
            using (var httpClient = new HttpClient { Timeout = TimeSpan.FromDays(1) })
            {
                long totalSize = 0;
                for (int i = 1; i <= 23; i++)
                {
                    string file = $"PBID.z{i:00}";
                    string fileUrl = url + file;
                    var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, fileUrl));
                    response.EnsureSuccessStatusCode();
                    totalSize += response.Content.Headers.ContentLength ?? 0;
                }

                string zipFile = "PBID.zip";
                string zipFileUrl = url + zipFile;
                var zipResponse = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, zipFileUrl));
                zipResponse.EnsureSuccessStatusCode();
                totalSize += zipResponse.Content.Headers.ContentLength ?? 0;

                STR_TOTALSIZE_GP1.Invoke((MethodInvoker)(() => STR_TOTALSIZE_GP1.Text = $"Total Size: {FormatSize(totalSize)}"));

                for (int i = 1; i <= 23; i++)
                {
                    string file = $"PBID.z{i:00}";
                    string filePath = Path.Combine(extractPath, file);
                    string fileUrl = url + file;
                    await DownloadFile(httpClient, fileUrl, filePath, file, totalSize);
                }

                string zipFilePath = Path.Combine(extractPath, zipFile);
                await DownloadFile(httpClient, zipFileUrl, zipFilePath, zipFile, totalSize);
            }
        }

        private async Task DownloadFile(HttpClient httpClient, string url, string filePath, string fileName, long totalSize)
        {
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
            {
                var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var fileSize = response.Content.Headers.ContentLength ?? 0;
                var downloadedBytes = 0;

                using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    var buffer = new byte[1024 * 1024]; // 1MB buffer size
                    int bytesRead;
                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false)) > 0)
                    {
                        await fs.WriteAsync(buffer, 0, bytesRead).ConfigureAwait(false);
                        downloadedBytes += bytesRead;
                        var progress = (int)((double)(downloadedBytes + GetDownloadedBytes()) / totalSize * 100);
                        DownloadBarP1.Invoke((MethodInvoker)(() => DownloadBarP1.Value = progress));
                        STR_Pencent_GP1.Invoke((MethodInvoker)(() => STR_Pencent_GP1.Text = progress + "%"));
                        STR_DOWNLOAD_CP1.Invoke((MethodInvoker)(() => STR_DOWNLOAD_CP1.Text = $"Downloading {fileName} ({FormatSize(downloadedBytes + GetDownloadedBytes())} / {FormatSize(totalSize)})"));
                    }
                }
                SetDownloadedBytes(GetDownloadedBytes() + fileSize);
            }
        }

        private long downloadedBytes = 0;
        private long GetDownloadedBytes()
        {
            return downloadedBytes;
        }

        private void SetDownloadedBytes(long value)
        {
            downloadedBytes = value;
        }

        private string FormatSize(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return string.Format("{0:0.##} {1}", size, sizes[order]);
        }
        private async Task ExtractFileAsync(string extractPath)
        {
            string zipFile = "PBID.zip";
            string zipFilePath = Path.Combine(extractPath, zipFile);

            STR_DOWNLOAD_CP1.Invoke((MethodInvoker)(() => STR_DOWNLOAD_CP1.Text = "Extracting..."));

            using (var process = new Process())
            {
                process.StartInfo.FileName = @"C:\Program Files\7-Zip\7z.exe";
                process.StartInfo.Arguments = $"x \"{zipFilePath}\" -o\"{extractPath}\" -y";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.OutputDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                    {
                        string[] lines = e.Data.Split('\r');
                        foreach (string line in lines)
                        {
                            if (line.Contains("%"))
                            {
                                string percentage = line.Split('%')[0].Trim();
                                if (int.TryParse(percentage, out int percent))
                                {
                                    if (DownloadBarP1.InvokeRequired)
                                    {
                                        DownloadBarP1.Invoke((MethodInvoker)(() =>
                                        {
                                            DownloadBarP1.Value = percent;
                                            STR_Pencent_GP1.Text = percent + "%";
                                        }));
                                    }
                                    else
                                    {
                                        DownloadBarP1.Value = percent;
                                        STR_Pencent_GP1.Text = percent + "%";
                                    }
                                }
                            }
                        }
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                await Task.Run(() => process.WaitForExit());
            }

            // Hapus file z
            for (int i = 1; i <= 23; i++)
            {
                string file = $"PBID.z{i:00}";
                string filePath = Path.Combine(extractPath, file);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }

            // Hapus file zip
            if (File.Exists(zipFilePath))
            {
                File.Delete(zipFilePath);
            }
        }
        private void HomeButton_Click(Object sender, EventArgs e)
        {
            Hide_Panel();
            Home_Panel.Show();
        }
        private void ItemShopButton_Click(object sender, EventArgs e)
        {
            Hide_Panel();
            //ItemShop_Panel.Show();
        }
        private void TOPUPButton_Click(object sender, EventArgs e)
        {
            Hide_Panel();
            TopUpCenter_Panel.AutoScroll = true;
            TopUpCenter_Panel.Show();
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
        private void FadeinMainForm(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private int imagecount = 1;
        private void ImageChangerSetting()
        {
            if (imagecount == 10)
            {
                imagecount = 1;
            }
            ImageChange_Box.ImageLocation = string.Format(@"Images\{0}.bmp", imagecount);
            imagecount++;
        }

        private void ImageChager_Timer(object sender, EventArgs e)
        {
            ImageChangerSetting();
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
