using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject
{
    class DBValue
    {
        private static List<string> names = new List<string>();
        private static List<string> provs = new List<string>();
        private static List<string> conns = new List<string>();

        public static string[] GetConnectionInfo(string name)
        {
            string[] values = new string[2];

            if (name == "")
            {
                name = ConfigurationManager.AppSettings["DEFAULT"];
            }
            if (names.Contains(name))
            {
                int idx = names.IndexOf(name);
                values[0] = provs[idx];
                values[1] = conns[idx];
            }
            else
            {
                string encrypt = ConfigurationManager.AppSettings["ENCRYPT"];
                string prov = ConfigurationManager.ConnectionStrings[name].ProviderName;
                string conn = ConfigurationManager.ConnectionStrings[name].ConnectionString;

                if (encrypt == "Y")
                {
                    conn = AESDecrypt128(conn, "IBS");
                }

                names.Add(name);
                provs.Add(prov);
                conns.Add(conn);

                values[0] = prov;
                values[1] = conn;
            }
            return values;
        }

        private static string AESDecrypt128(string Input, string key)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(Input);
            byte[] Salt = Encoding.ASCII.GetBytes(key.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream(EncryptedData);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            byte[] PlainText = new byte[EncryptedData.Length];

            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;
        }
    }
}
