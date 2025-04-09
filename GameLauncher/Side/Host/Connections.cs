using GameLauncher.Side.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace GameLauncher.Side.Host
{
    public static class Connections
    {
        private static readonly string HostUTAMA = "http://localhost/new_launcher/config_launcher.base";
        public static string ProgramNAME = "Spinnet+";
        public static string StringLanguageFileName = "Language.set";


        public static HostStatus access = HostStatus.Online;
        public static string LauncherVersion, MessageAllert;
        public static int ClientVersion, LauncherStatus;


        public static async Task<HostStatus> GetHostInfo()
        {
            await Task.Delay(100);
            try
            {
                using (WebClient wc = new WebClient() { Encoding = Encoding.UTF8 })
                using (var sr = new StringReader(wc.DownloadString(HostUTAMA)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("="))
                        {
                            string id = line.Split('=')[0];
                            switch (id)
                            {
                                case "launcherversion":
                                    LauncherVersion = Config.Conf(line, id);
                                    break;
                                case "launcherstatus":
                                    LauncherStatus = int.Parse(Config.Conf(line, id));
                                    break;
                                case "messagallert":
                                    MessageAllert = Config.Conf(line, id);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"GetHostInfo -> {ex.Message}");
                access = HostStatus.Unknown;
            }
            return access;
        }
        public static async Task<long> GetVersionUP()
        {
            await Task.Delay(5);
            try
            {
                using (WebClient wc = new WebClient() { Encoding = Encoding.UTF8 })
                using (var sr = new StringReader(wc.DownloadString(HostUTAMA)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("="))
                        {
                            string id = line.Split('=')[0];
                            switch (id)
                            {
                                case "clientversion":
                                    ClientVersion = int.Parse(Config.Conf(line, id));
                                    return ClientVersion;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"GetVersionUP -> {ex.Message}");
                ClientVersion = -1;
            }
            return ClientVersion;
        }
    }
}
