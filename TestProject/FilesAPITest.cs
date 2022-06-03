using System.Net;

namespace TestProject
{
    public class FilesAPITest : TestBase
    {
        [Test]
        public async Task Get()
        {
            var response = await API.Files.Get("09ffaa1523fbdceb7c0e6fa2be7221c161b5499dd45fc5dd4c210425fb333427");
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task View()
        {
            var response = await API.Files.View(sha256: "09ffaa1523fbdceb7c0e6fa2be7221c161b5499dd45fc5dd4c210425fb333427");
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Is.Not.Null);
        }
    }
}
