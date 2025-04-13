using GameLauncher.Properties;
using GameLauncher.Side.Host;
using GameLauncher.Side.Secure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            GetStringInfoVersion();
            STRINGView();
            AutoSetLanguage();
        }
        private void STRINGView()
        {
            MinimizeStatus.Text = InternalLauncher.InternalSTRING.STR_MINIMIZE_CHECK;
        }
        string password = "your_password"; // Ganti dengan password yang Anda inginkan
        private void GetLanguageSetting()
        {
            if (File.Exists(Connections.StringLanguageFileName))
            {
                string encryptedText = File.ReadAllText(Connections.StringLanguageFileName).Trim();
                string decryptedText = Encryptions.ChipperEncryption.Decrypt(encryptedText, password);

                if (LanguageSelect.SelectedIndex == 0)
                {
                    string encryptedEnText = Encryptions.ChipperEncryption.Encrypt("language=en", password);
                    File.WriteAllText(Connections.StringLanguageFileName, encryptedEnText);
                }
                else if (LanguageSelect.SelectedIndex == 1)
                {
                    string encryptedIdText = Encryptions.ChipperEncryption.Encrypt("language=id", password);
                    File.WriteAllText(Connections.StringLanguageFileName, encryptedIdText);
                }
            }
        }
        private void AutoSetLanguage()
        {
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(Connections.StringLanguageFileName))
            {
                string encryptedText = File.ReadAllText(Connections.StringLanguageFileName).Trim();
                string decryptedText = Encryptions.ChipperEncryption.Decrypt(encryptedText, password);

                if (decryptedText == "language=id")
                {
                    LanguageSelect.SelectedIndex = 1; // Bahasa Indonesia
                }
                else if (decryptedText == "language=en")
                {
                    LanguageSelect.SelectedIndex = 0; // Bahasa Inggris
                }
            }
            else
            {
                string encryptedText = Encryptions.ChipperEncryption.Decrypt("language=id", password);
                File.WriteAllText(Connections.StringLanguageFileName, encryptedText);
            }
        }
        private void GetStringInfoVersion()
        {
            if (Connections.LauncherVersion == null)
            {
                STR_VERSION_LAUNCHER.Text = "Error 404";
            }
            else
            {
                STR_VERSION_LAUNCHER.Text = Connections.LauncherVersion;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetLanguageSetting();
            MessageBox.Show(InternalLauncher.InternalSTRING.STR_SAVE_SETTING);
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
