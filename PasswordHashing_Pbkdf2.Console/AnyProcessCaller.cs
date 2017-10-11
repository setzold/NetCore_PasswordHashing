using System.Security;

namespace PasswordHashing_Pbkdf2.Console
{
    class AnyProcessCaller
    {
        public void RunProcessAndShowPassword(string password)
        {
            System.Console.WriteLine($"Sie haben folgendes Passwort angefordert {password}.");
        }

        public void RunProcessAndShowSecurePasswort(SecureString password)
        {
            System.Console.WriteLine($"Sie haben folgendes (SecureString) Passwort angefordert {password}.");
        }
    }
}
