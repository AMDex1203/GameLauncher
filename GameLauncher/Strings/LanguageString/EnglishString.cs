using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Strings.LanguageString
{
    public class EnglishString : GetString
    {
        public string STR_LOADING { get; set; } = "Please Wait...";
        public string STR_DLL_JSON_NULL { get; set; } = "Newtonsoft.Json.dll Not Found";
        public string STR_GET_SUPPORT_FILE { get; set; } = "Checking Required Files";
        public string STR_SUCCESS_CHECK { get; set; } = "Checking Suceessfully...";
        public string STR_ALREADY_GAME { get; set; } = "There are Program that is already running.";
        public string STR_MAINTENANCE { get; set; } = "Server is currently under Maintenance";
        public string STR_CONNECTION_BROKEN { get; set; } = "Failed To Connect Server \nServer Status Broken";
        public string STR_NULL_CONNECTION { get; set; } = "Failed To Connect Server \nServer Now Is Closed";
        public string STR_CHECK_CONNECTION { get; set; } = "Checking Connection...";
    }
}
