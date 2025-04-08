using GameLauncher.Side.Log;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Side.Data
{
    public class Location
    {
        public string country_name { get; set; }
        public string region { get; set; }
        public string City { get; set; }
    }
    public class GetRegionClient
    {
        public static string GetCityFromIPAddress()
        {
            try
            {
                string url = $"https://ipapi.co/city/";
                using (var client = new WebClient())
                {
                    string city = client.DownloadString(url);
                    return city;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error getting city from IP address: " + ex.ToString());
                return "";
            }
        }
        public static string GetRegionData()
        {
            string ipAddress = GetPublicIpAddress.GetPublicIpv4();
            try
            {
                string url = $"https://freegeoip.app/json/{ipAddress}";
                using (var client = new WebClient())
                {
                    string response = client.DownloadString(url);
                    Location location = JsonConvert.DeserializeObject<Location>(response);
                    return location.country_name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting location from IP address: " + ex.ToString());
                return "Gagal mendapatkan lokasi";
            }
        }
    }
}
