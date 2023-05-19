using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AssetManagement.BC.Helpers
{
    public class StringHelpers : IStringHelpers
    {
        private readonly string _key;
        public StringHelpers(string key)
        {
            _key = key;
        }

        public string HashString(string plaintext, string salt)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                var passBytes = Encoding.UTF8.GetBytes($"{plaintext}{salt}");
                var result = hash.ComputeHash(passBytes);

                foreach (Byte b in result)
                {
                    Sb.Append(b.ToString("x2"));
                }
            }
            return Sb.ToString();
        }


        public string decryptDES(string ciphertextWithIv)
        {
            string ciphertext = ciphertextWithIv.Split(':')[0];
            byte[] ivWords = Encoding.UTF8.GetBytes(ciphertextWithIv.Split(':')[1]);

            byte[] decrypted = new byte[ciphertext.Length];
            decrypted = Convert.FromBase64String(ciphertext);

            using (MemoryStream mStream = new MemoryStream())
            {
                using (DES des = DES.Create())
                {
                    des.Padding = PaddingMode.None;
                    using (ICryptoTransform decryptor = des.CreateDecryptor(Encoding.UTF8.GetBytes(_key), ivWords))
                    using (var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Write))
                    {
                        cStream.Write(decrypted, 0, decrypted.Length);
                    }
                    return Encoding.UTF8.GetString(mStream.ToArray());
                }
            }
        }
    }
}
