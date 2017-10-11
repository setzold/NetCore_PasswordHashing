using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace PasswordHashing_Pbkdf2.Tests
{
    public class EncryptTests
    {
        private readonly ITestOutputHelper _output;

        public EncryptTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void HashPasswordWithMultipleIterations()
        {
            string pw = "MeinePasswort";
            var encryptor = new Encryptor();

            string previousSalt = string.Empty;

            Stopwatch stopwatch = new Stopwatch();

            //200 its
            CreatePasswordHashForNIteratiosn(pw, 200, encryptor, stopwatch);

            //2500 its
            CreatePasswordHashForNIteratiosn(pw, 2500, encryptor, stopwatch);

            //10000 its
            CreatePasswordHashForNIteratiosn(pw, 10000, encryptor, stopwatch);

            //10000 its - der wzeite durchlauf ist beabsichtigt wegen Salt
            CreatePasswordHashForNIteratiosn(pw, 10000, encryptor, stopwatch);

            stopwatch.Stop();
        }

        private string CreatePasswordHashForNIteratiosn(string pw, int iterations, Encryptor encrypt, Stopwatch stopwatch)
        {
            stopwatch.Restart();
            var testresult = encrypt.GetPasswordHash(pw, iterations);
            stopwatch.Stop();

            _output.WriteLine($"Password hashing for {iterations} iterations runs {stopwatch.ElapsedMilliseconds} ms.");
            _output.WriteLine($"Used salt is {Encoding.UTF8.GetString(encrypt.Salt)}.");
            _output.WriteLine($"Password: {testresult}");
            _output.WriteLine($"############################################");

            Assert.NotEqual(pw, testresult);
            return testresult;
        }
    }
}
