using System.Net;

namespace TestProject
{
    public class PcapAPITest : TestBase//,IMachinesAPI
    {
        [Test]
        public async Task Get()
        {
            var response = await API.PCAP.Get(1);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            //Assert.That(response.Content, Is.Not.Null);
        }
    }
}
