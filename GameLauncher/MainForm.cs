using GameLauncher.Side.Log;
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
        }

        private void GameListButton_Click(object sender, EventArgs e)
        {
            Hide_Panel();
            GameList_Panel.Show();
        }
        private void HomeButton_Click(Object sender, EventArgs e)
        {
            Hide_Panel();
            Home_Panel.Show();
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
    }
}
