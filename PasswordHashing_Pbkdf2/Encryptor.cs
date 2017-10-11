using System;
using System.Security.Cryptography; //nuget:  System.Security.Cryptography.X509Certificates
using Microsoft.AspNetCore.Cryptography.KeyDerivation; //nuget: Microsoft.AspNetCore.Cryptography.KeyDerivation
using System.Diagnostics;
using System.Text;
using System.Security;
using PasswordHashing_Pbkdf2.Console;

//from: 
// https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/consumer-apis/password-hashing
// https://www.codeproject.com/Articles/844722/Hashing-Passwords-using-ASP-NETs-Crypto-Class

namespace PasswordHashing_Pbkdf2
{
    public class Encryptor
    {
        //todo: show password in MemoryDump
        public string GetPasswordHash(string password, int iterationcnt = 10000)
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            Salt = salt;

            Debug.WriteLine($"Salt: {Convert.ToBase64String(salt)}");


            // derive a 256-bit subkey (use HMACSHA512 with 10,000 iterations)
            string hashed = Encoding.UTF8.GetString(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: iterationcnt,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        public byte[] Salt { get; private set; }
    }
}
