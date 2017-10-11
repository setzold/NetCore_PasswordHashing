using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace PasswordHashing_Argon2.Tests
{
    public class EncryptTests
    {
        private readonly ITestOutputHelper _output;

        public EncryptTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void HashPasswordWithArgon2()
        {
            string pw = "MeinePasswort";
            var encryptor = new Encryptor();
            Stopwatch stopwatch = new Stopwatch();
            var testresult = encryptor.GetPasswordHash(pw);
            
            stopwatch.Stop();

            _output.WriteLine($"Password: {testresult}");
            Assert.NotEqual(pw, testresult);
        }
    }
}
