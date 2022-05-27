using System.Net;

namespace TestProject
{
    public class CuckooAPITest : TestBase
    {
        [Test]
        public async Task Exit()
        {
            Cuckoo.Net.Internal.Response? response = await API.Cuckoo.Exit();
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.Forbidden));
        }

        [Test]
        public async Task Status()
        {
            Cuckoo.Net.Internal.Response? response = await API.Cuckoo.Status();
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
