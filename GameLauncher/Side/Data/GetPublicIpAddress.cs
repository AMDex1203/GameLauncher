using GameLauncher.Side.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Side.Data
{
    public class GetPublicIpAddress
    {
        public static string GetPublicIpv4()
        {
            try
            {
                string url = "https://api.ipify.org";
                using (var client = new WebClient())
                {
                    var responseString = client.DownloadString(url);
                    Logger.Log("[UPDATER_STATE_PRE_UPDATER_VERSION_ACK]-> [UPDATER_STATE_PATCH_END] try state change");
                    return responseString;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error getting public IP address: " + ex.ToString());
                return "";
            }
        }
        public static string GetPublicIpv6()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var nic in nics)
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }

            return "";
        }
    }
}
