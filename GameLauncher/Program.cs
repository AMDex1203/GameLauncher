using GameLauncher.Side.Log;
using GameLauncher.Strings;
using GameLauncher.Strings.LanguageString;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string settingFolder = "setting";
            if (!Directory.Exists(settingFolder))
            {
                Directory.CreateDirectory(settingFolder);
            }

            string filePath = Path.Combine(settingFolder, "Language.set");
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(filePath))
            {
                string encryptedText = File.ReadAllText(filePath).Trim();
                string decryptedText = ChipperEncryption.Decrypt(encryptedText, password);
                if (decryptedText == "language=id")
                {
                    InternalLauncher.InternalSTRING = new IndonesiaString();
                }
                else if (decryptedText == "language=en")
                {
                    InternalLauncher.InternalSTRING = new EnglishString();
                }
            }
            else
            {
                string encryptedText = ChipperEncryption.Encrypt("language=en", password);
                File.WriteAllText(filePath, encryptedText);
                InternalLauncher.InternalSTRING = new EnglishString();
            }

            if (!File.Exists(string.Concat(Application.StartupPath, "\\Newtonsoft.Json.dll")))
            {
                Logger.Log("[ERROR] Newtonsoft.Json.dll not found.");
                MessageBox.Show(InternalLauncher.InternalSTRING.STR_DLL_JSON_NULL, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Application.Run(new CheckForm());
            }
        }

        public static class ChipperEncryption
        {
            public static string Encrypt(string plaintext, string password)
            {
                string encryptedText = "";
                int key = 0;

                foreach (char c in plaintext)
                {
                    key = password[key % password.Length];
                    encryptedText += (char)(c + key);
                }

                return encryptedText;
            }

            public static string Decrypt(string ciphertext, string password)
            {
                string decryptedText = "";
                int key = 0;

                foreach (char c in ciphertext)
                {
                    key = password[key % password.Length];
                    decryptedText += (char)(c - key);
                }

                return decryptedText;
            }
        }
    }
}
