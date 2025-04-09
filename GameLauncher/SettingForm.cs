using GameLauncher.Side.Host;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MessageBox.Show("Settings saved successfully!");
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
