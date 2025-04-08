using System.Net.NetworkInformation;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Launcher_Core.Support
{
    public class Core
    {
        public static string Conf(string line, string conf)
        {
            return line.Substring(conf.Length + 1);
        }
        public static string FileMD5(string file)
        {
            HashAlgorithm hashAlgorithm = (HashAlgorithm)new MD5CryptoServiceProvider();
            string empty = string.Empty;
            using (FileStream inputStream = File.OpenRead(file))
                return BitConverter.ToString(hashAlgorithm.ComputeHash((Stream)inputStream)).ToLower().Replace("-", "");
        }
        public static string FileChecksum(string file, HashAlgorithm algorithm)
        {
            string empty = string.Empty;
            using (FileStream inputStream = File.OpenRead(file))
                return BitConverter.ToString(algorithm.ComputeHash((Stream)inputStream)).ToLower().Replace("-", "");
        }
        public static string EnderecoMAC1()
        {
            try
            {
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                string empty = string.Empty;
                foreach (NetworkInterface networkInterface in networkInterfaces)
                {
                    if (empty == string.Empty)
                    {
                        networkInterface.GetIPProperties();
                        empty = networkInterface.GetPhysicalAddress().ToString();
                    }
                }
                return empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static PhysicalAddress EnderecoMAC2()
        {
            try
            {
                foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)
                        return networkInterface.GetPhysicalAddress();
                }
                return (PhysicalAddress)null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
