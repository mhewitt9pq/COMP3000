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
        public Aes()
        {
            cryptProvider = new AesCryptoServiceProvider();

            cryptProvider.BlockSize = 128;
            cryptProvider.KeySize = 256;
            cryptProvider.GenerateIV();
            cryptProvider.GenerateKey();
            cryptProvider.Mode = CipherMode.CBC;
            cryptProvider.Padding = PaddingMode.PKCS7;
        }
        public String encrypt(String plainTxt)
        {
            ICryptoTransform transform = cryptProvider.CreateEncryptor();

            byte[] encryptedBytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plainTxt), 0, plainTxt.Length);

            string Str = Convert.ToBase64String(encryptedBytes);



            return Str;
        }
    }
}
