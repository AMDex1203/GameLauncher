using GameLauncher.Side.Host;
using GameLauncher.Side.Log;
using GameLauncher.Side.Secure;
using GameLauncher.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private async void GetInfoSystem(object sender, EventArgs e)
        {
            if (!CheckStateCount())
                Close();
            else
            {
                DeleteFileLog();
                await Task.Delay(5);
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_LOADING;
                await Task.Delay(1000);
                GetBanInfo.ValidateDevice();
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_CHECK_CONNECTION;
                await Connections.GetHostInfo();
                GetStatusLauncher();
                await Task.Delay(1000);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
        private void DeleteFileLog()
        {
            string filename = "Launcher.log";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
        private bool CheckStateCount()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Logger.Log("[!] There is no Launcher window open.");
                MessageBox.Show(InternalLauncher.InternalSTRING.STR_ALREADY_GAME, Connections.ProgramNAME);
                return false;
            }
            return true;
        }
        private void GetStatusLauncher()
        {
            if (Connections.LauncherStatus == null || Connections.LauncherStatus < 0)
            {
                MessageBox.Show(InternalLauncher.InternalSTRING.STR_NULL_CONNECTION, "INFO");
                Application.Exit();
            }
            else if (Connections.LauncherStatus == 1) //Can Access With Allert
            {
                MessageBox.Show(Connections.MessageAllert, Connections.ProgramNAME);
            }
            else if (Connections.LauncherStatus == 2) //Maintenance
            {
                MessageBox.Show(InternalLauncher.InternalSTRING.STR_MAINTENANCE, Connections.ProgramNAME);
                Application.Exit();
            }
            else if (Connections.LauncherStatus == 3) //Maintenance With Allert
            {
                MessageBox.Show(Connections.MessageAllert, Connections.ProgramNAME);
                Application.Exit();
            }
        }
    }
}
