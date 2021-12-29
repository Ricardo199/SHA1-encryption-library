using System;
using System.Text;
using System.Security.Cryptography;

namespace ClassLibrary1{
    public class Encrypt
    {
        public string sha1(string var)
        {
            byte[] temp;
            SHA1 sha = new SHA1CryptoServiceProvider();
            temp = sha.ComputeHash(Encoding.UTF8.GetBytes(var));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}