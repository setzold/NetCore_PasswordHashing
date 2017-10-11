using System;

namespace PasswordHashing_Pbkdf2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please insert your password for hash:");
            var inserted = System.Console.ReadLine();

            var encryptor = new Encryptor();
            var pwHash = encryptor.GetPasswordHash(inserted);

            System.Console.WriteLine($"Hash for password is {pwHash} {Environment.NewLine}");

            System.Console.WriteLine("press enter for exit.");
            System.Console.ReadLine();
        }
    }
}
