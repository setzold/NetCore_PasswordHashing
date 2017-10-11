using System.Security.Cryptography;
using System.Text;

namespace TooSimpleHashAlgs
{
    public class TooSimple
    {
        public static string GetMd5(string input)
        {
            using (var md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder stringBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                    stringBuilder.Append(data[i].ToString("x2"));

                // Return the hexadecimal string.
                return stringBuilder.ToString();
            }
        }

        public static string GetSha1(string input)
        {
            using (var sha1 = SHA1.Create())
            {
                byte[] data = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder stringBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                    stringBuilder.Append(data[i].ToString("x2"));

                // Return the hexadecimal string.
                return stringBuilder.ToString();
            }
        }

        public static string GetSha256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder stringBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                    stringBuilder.Append(data[i].ToString("x2"));

                // Return the hexadecimal string.
                return stringBuilder.ToString();
            }
        }
    }
}
