/*
 * References:
 * https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=netframework-4.7.2
 * https://www.youtube.com/watch?v=LOmgFxPHop0
 * https://stackoverflow.com/questions/17195969/generating-aes-256-bit-key-value
 * 
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace mock_up
{
    class Aes_Encryption
    {
        AesCryptoServiceProvider ServiceProvider;
        public Aes_Encryption()
        {
            ServiceProvider = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 128
            };
            ServiceProvider.GenerateIV();
            ServiceProvider.Mode = CipherMode.CBC;
            ServiceProvider.Padding = PaddingMode.PKCS7;
        }
        public String Encrypt(String plaintext, string password)
        {
            ServiceProvider.Key = CreateKey(password);
            ICryptoTransform transform = ServiceProvider.CreateEncryptor();
            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plaintext), 0, plaintext.Length);
            string str = Convert.ToBase64String(encrypted_bytes);
            return str;

        }
        public String Decrypt(String cipher_text)
        {
            ICryptoTransform transform = ServiceProvider.CreateDecryptor();
            byte[] enc_bytes = Convert.FromBase64String(cipher_text);
            byte[] dec_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);
            string str = ASCIIEncoding.ASCII.GetString(dec_bytes);
            return str;
        }


        //Create AES key based on password
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            Encoding utf8 = Encoding.UTF8;

            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(utf8.GetBytes(password), Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        private static readonly byte[] Salt =
    new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };
    }
}
