using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Side.Secure
{
    public class Encryptions
    {
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
