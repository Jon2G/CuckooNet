using System.Net;

namespace TestProject
{
    public class FilesAPITest : TestBase
    {
        [Test]
        public async Task Get()
        {
            var response = await API.Files.Get("c7be1ed902fb8dd4d48997c6452f5d7e509fbcdbe2808b16bcf4edce4c07d14e");
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task View()
        {
            var response = await API.Files.View(sha256: "c7be1ed902fb8dd4d48997c6452f5d7e509fbcdbe2808b16bcf4edce4c07d14e");
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Is.Not.Null);
        }
    }
}
