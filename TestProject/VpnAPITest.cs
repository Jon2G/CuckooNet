using System.Net;

namespace TestProject
{
    public class VpnAPITest : TestBase
    {
        [Test]
        public async Task Status()
        {
            Cuckoo.Net.Internal.Response? response = await API.VPN.Status();
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.InternalServerError));
        }
    }
}
