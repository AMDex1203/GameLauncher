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
                await Task.Delay(5);
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_LOADING;
                await Task.Delay(1000);
                GetBanInfo.ValidateDevice();
                Status(await Connections.GetHostInfo());
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
        private async void Status(HostStatus p)
        {
            if (p != HostStatus.Unknown || p == HostStatus.Unknown)
            {

                Logger.Log("[LAUNCHER_CHECKING_STATUS] ->> Prepare To Connect Server...");
                switch (p)
                {
                    case HostStatus.Maintenance:
                        Logger.Log("[<<] [SERVER_MESSAGE_ALLERT] ->> Maintenance");
                        MessageBox.Show(InternalLauncher.InternalSTRING.STR_MAINTENANCE, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;
                    case HostStatus.MaintenanceAllert:
                        if (string.IsNullOrEmpty(Connections.MessageAllert))
                            goto case HostStatus.Maintenance;
                        Logger.Log("[<<] [SERVER_MESSAGE_ALLERT] ->> " + Connections.MessageAllert);
                        MessageBox.Show(Connections.MessageAllert, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        Close();
                        break;
                    case HostStatus.Online:
                    case HostStatus.OnlineAllert:
                        //Userlist_check();
                        break;
                    case HostStatus.Offline:
                        Logger.Log("[<<] [SERVER_CONNECT_INTERUPT] ->> Unknown Host Server");
                        MessageBox.Show(InternalLauncher.InternalSTRING.STR_CONNECTION_BROKEN, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;
                    default:
                        Logger.Log("[<<] [SERVER_CONNECT_INFO] ->> Server Not Responding Code 404");
                        MessageBox.Show(InternalLauncher.InternalSTRING.STR_NULL_CONNECTION, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;

                }
            }
        }
    }
}
