using System;
using System.Security;

namespace PasswordHashing_Pbkdf2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please insert your password for hash:");
            //var inserted = System.Console.ReadLine();

            //CallPwHash
            //CallPwHash(System.Console.ReadLine();

            //StringCaller
            new AnyProcessCaller().RunProcessAndShowPassword(System.Console.ReadLine());

            //SecureStringCaller
            //using (SecureString secureString = new SecureStringBuilder().ConvertToSecureString(System.Console.ReadLine()))
            //    new AnyProcessCaller().RunProcessAndShowSecurePasswort(secureString);

            System.Console.WriteLine("press enter for exit.");
            System.Console.ReadLine();
        }
        

        private static void CallPwHash(string password)
        {
            var encryptor = new Encryptor();
            var pwHash = encryptor.GetPasswordHash(password);

            System.Console.WriteLine($"Hash for password is {pwHash} {Environment.NewLine}");
        }
    }
}
