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
            using (SHA256 hash = SHA256.Create())
            {
                var passBytes = Encoding.UTF8.GetBytes($"{plaintext}{salt}");
                return Convert.ToString(hash.ComputeHash(passBytes));
            }
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
                    des.Padding = PaddingMode.PKCS7;
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
