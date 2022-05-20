using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepegaCoin
{
    class Encryption
    {
        public static void generateKeyPair()
        {
            CspParameters cspParams = new CspParameters();// { KeyContainerName = "pepegacoin" };
            var rsa = new RSACryptoServiceProvider(2048, cspParams);

            byte[] privateKey = rsa.ExportRSAPrivateKey();
            byte[] publicKey = rsa.ExportRSAPublicKey();
            Clipboard.SetText(Utility.ByteArrayToString(publicKey));
            byte[] hellobytes = Encoding.ASCII.GetBytes("Hello World Shit");
            MessageBox.Show("key copy to clipboard");
            byte[] encryptedmessage = rsa.Encrypt(hellobytes, true);
            Clipboard.SetText(Utility.ByteArrayToString(encryptedmessage));
            MessageBox.Show("encrypted text to clipboard");

            rsa.PersistKeyInCsp = false;
            rsa.Clear();


        }

    }
}
