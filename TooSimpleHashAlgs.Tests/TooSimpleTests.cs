using Xunit;
using Xunit.Abstractions;

namespace TooSimpleHashAlgs.Tests
{
    public class TooSimpleTests
    {
        private readonly ITestOutputHelper _output;

        public TooSimpleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        //http://www.md5decrypt.org/

        [Fact]
        public void CheckHashCodes()
        {
            var pw = "MyPassword";

            //MD5
            var md5 = TooSimple.GetMd5(pw);
            _output.WriteLine($"MD5 Hash: {md5}");
            Assert.NotEqual(pw, md5);

            _output.WriteLine("#################################");

            //SHA1
            var sha1 = TooSimple.GetSha1(pw);
            _output.WriteLine($"Sha1: {sha1}");
            Assert.NotEqual(pw, sha1);
        }
    }
}
