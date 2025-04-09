using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Side.Data
{
    public class GetInfoClient
    {
        public static string GetHwid()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    string processorId = obj["ProcessorId"].ToString();
                    return processorId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil Data Comouter: " + ex.Message);
            }

            return string.Empty;
        }
    }
}
