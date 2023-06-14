using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Dependencias.Model;

namespace Dependencias.PasswordHandling
{
    public class HashCreator
    {
        private string stringtoHash;
        private byte[] tmpStore;
        private byte[] hash;
        private string finalHash;

        public string StringtoHash { set => finalHash = value; }

        public string FinalHash { get => finalHash; set => finalHash = value; }

        public void EncryptPassword()
        {
            tmpStore = ASCIIEncoding.ASCII.GetBytes(stringtoHash);
            hash = new MD5CryptoServiceProvider().ComputeHash(tmpStore);
            int i;
            StringBuilder sOutput = new StringBuilder(hash.Length);
            for (i = 0; i < hash.Length; i++)
            {
                sOutput.Append(hash[i].ToString("X2"));
            }
            FinalHash = sOutput.ToString();
        }

        public bool CompareHash(string hash1, string hash2)
        {
            if (hash1.Equals(hash2))
            {
                return true;
            }
           return false;
        }

    }
}
