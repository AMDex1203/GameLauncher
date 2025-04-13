using GameLauncher.Side.Host;
using GameLauncher.Side.Log;
using Guna.UI2.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
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
                                        GN_Panel1.Text = game_name;
                                        STR_VERSION_GAME_PG1.Text = game_version;
                                        Game_Panel1.Show();
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
