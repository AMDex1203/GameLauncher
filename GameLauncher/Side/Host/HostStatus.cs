using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Side.Host
{
    public enum HostStatus
    {
        Online,
        OnlineAllert,
        Offline,
        OfflineAllert,
        Maintenance,
        MaintenanceAllert,
        Unknown
    }
}
