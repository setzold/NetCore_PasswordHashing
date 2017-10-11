using Isopoh.Cryptography.Argon2; //nuget

namespace PasswordHashing_Argon2
{
    public class Encryptor
    {
        public string GetPasswordHash(string password)
        {
            return Argon2.Hash(password);
        }
    }
}
