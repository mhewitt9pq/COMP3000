using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace secPass
{
    class Aes
    {
        AesCryptoServiceProvider cryptProvider;

        /// <summary>
        /// AES encryption/decryption handler
        /// </summary>
        public Aes()
        {
            //Allow this conf to be custom - Settings tab for user to conf

            //How to store key securely so cn decrypt when application is restarted
            //Hashing masterkey to create const key

            cryptProvider = new AesCryptoServiceProvider();
            cryptProvider.BlockSize = 128;
            cryptProvider.KeySize = 256;

            cryptProvider.GenerateIV();
            cryptProvider.GenerateKey();

            cryptProvider.Mode = CipherMode.CBC;
            cryptProvider.Padding = PaddingMode.PKCS7;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainTxt"></param>
        /// <returns></returns>

        public String encrypt(String plainTxt)
        {
            ICryptoTransform transform = cryptProvider.CreateEncryptor();

            byte[] encryptedBytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plainTxt), 0, plainTxt.Length);

            string encrypted =  Convert.ToBase64String(encryptedBytes);

            return encrypted;
        }
        /// <summary>
        /// Decrypt using AES256
        /// </summary>
        /// <param name="encryptedText">Ciphertext</param>
        /// <returns></returns>
        public String decrypt(String encryptedText)
        {
            ICryptoTransform transform = cryptProvider.CreateDecryptor();

            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            byte[] decryptedBytes = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            string decrypted = ASCIIEncoding.ASCII.GetString(decryptedBytes);

            return decrypted;
        }
    }
}