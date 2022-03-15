using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace secPass
{
    class secController
    {
        /// <summary>
        /// AES encryption/decryption handler
        /// </summary>
        public secController()
        {
        }

        /// <summary>
        /// Encrypting using AES256 and master password
        /// </summary>
        /// <param name="plainTxt"></param>
        /// <returns></returns>
        public string encrypt(string mastPass, string plainTxt)
        {
            string encData = null;
            byte[][] keys = getHashKeys(mastPass);

            try
            {
                encData = encryptPlainToBytes(plainTxt, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return encData;
        }

        /// <summary>
        /// Decryption using AES256 and master password 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cryptText"></param>
        /// <returns></returns>
        public string decrypt(string key, string cryptText)
        {
            string decData = null;
            byte[][] keys = getHashKeys(key);

            try
            {
                decData = encryptCryptToBytes(cryptText, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return decData;
        }

        /// <summary>
        /// Calculates hash value of entered master password
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[][] getHashKeys(string key)
        {
            byte[][] hashedKey = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(key);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            hashedKey[0] = hashKey;
            hashedKey[1] = hashIV;

            return hashedKey;
        }

        /// <summary>
        /// Hashes single string value
        /// </summary>
        /// <param name="plnTxt"></param>
        /// <returns></returns>
        public string hash(string plnTxt)
        {
            SHA256 h = new SHA256CryptoServiceProvider();
            Encoding enc = Encoding.UTF8;

            byte[] bytes = h.ComputeHash(enc.GetBytes(plnTxt));

            var stringB = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringB.Append(bytes[i].ToString());
            }

            return stringB.ToString();
        }

        /// <summary>
        /// Encrypts plaintext using AES256 and masterkey hash values
        /// </summary>
        /// <param name="pTxt"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        private string encryptPlainToBytes(string pTxt, byte[] Key, byte[] IV)
        {
            byte[] encryptedText;
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt =
                            new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(pTxt);
                        }
                        encryptedText = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedText);
        }

        /// <summary>
        /// Decrypts excrypted data using AES256 and masterkey hash values
        /// </summary>
        /// <param name="cipherTextString"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static string encryptCryptToBytes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;            
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}