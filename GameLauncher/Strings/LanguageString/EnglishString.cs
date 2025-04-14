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
        public string STR_MSG_MAINTENANCE { get; set; } = "Server is currently under Maintenance\nPlease try again later";
        public string STR_SAVE_SETTING { get; set; } = "Settings Have Been Saved\nChanges Will Take Effect When You Reload the Program";
        public string STR_MINIMIZE_CHECK { get; set; } = "Minimize When Game Start";
        public string STR_LOGIN_NAME { get; set; } = "Login Area";
        public string STR_REGISTER_NAME { get; set; } = "Register Area";
        public string STR_REGISTER_TEXT { get; set; } = "Register Here";
        public string STR_FORGOT_PASS { get; set; } = "Forgot Password?";

        //=============== String Main Form =============

        public string STR_ABOUT_BUTTON { get; set; } = "ABOUT PROJECT";
        public string STR_GAMELIST_BUTTON { get; set; } = "GAME LIST";
        public string STR_ITEM_SHOP { get; set; } = "ITEM SHOP";
        public string STR_TOPUP_CENTER { get; set; } = "TOPUP CENTER";
        public string STR_ACCOUNT_CENTER { get; set; } = "MY ACCOUNT";
        public string STR_SETTING_BUTTON { get; set; } = "SETTING'S";

        //=============== End String Main =============

        //=============== String Login Form =============

        public string STR_ID_OR_PASS { get; set; } = "Username or Password Must Fill";
        public string STR_WRONG_ID_OR_PASS { get; set; } = "Username or Password Wrong";
        public string STR_UPDATE_FIRST { get; set; } = "Please Update First";

        //=============== End String Login =============

        //=============== String Register Form =============

        public string STR_DATA_MUST_FILL { get; set; } = "All Data must be filled!";
        public string STR_ID_OR_PASS_LESS_4_WORD { get; set; } = "Username or Password must be at least 4 characters";
        public string STR_PASS_LESS_4_WORD { get; set; } = "Password must be at least 4 characters and a maximum of 16 characters!";
        public string STR_EMAIL_INSERT { get; set; } = "Email must be @gmail.com or @yahoo.com!";
        public string STR_REGISTER_PASS_NOT_SAME { get; set; } = "Password & Re Password not Same!";
        public string STR_HUMAN_VERIFICATION { get; set; } = "Human Code is not valid, please fill it in correctly !!";
        public string STR_USERNAME_ALREADY_EXIST { get; set; } = "Username has been used by other users!";
        public string STR_EMAIL_ALREADY_EXIST { get; set; } = "Email has been used by other users!";
        public string STR_REGISTER_SUCCESS { get; set; } = "Register Success!";

        //=============== End String Register =============
    }
}
