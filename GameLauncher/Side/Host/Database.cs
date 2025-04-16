using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Side.Host
{
    public class Database
    {
        public static class HostDatabase
        {
            public static string DatabaseConfig = "Host=localhost;Database=postgres;Username=postgres;Password=spacegrid2025;";
            public static string DatabaseGamePanel1 = "Host=localhost;Database=officialdb;Username=postgres;Password=spacegrid2025;";
        }
    }
}
