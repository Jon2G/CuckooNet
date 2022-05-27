using System.Net;

namespace TestProject
{
    public class MachinesAPITest : TestBase//,IMachinesAPI
    {
        [Test]
        public async Task List()
        {
            var response = await API.Machines.List();
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Is.Not.Null);
            Assert.That(response.Content.Machines.Any);
        }

        [Test]
        public async Task View()
        {
            var response = await API.Machines.View("cuckoo1");
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Is.Not.Null);
        }
    }
}
