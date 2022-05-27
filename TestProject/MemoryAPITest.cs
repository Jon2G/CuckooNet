using System.Net;

namespace TestProject
{
    public class MemoryAPITest : TestBase//,IMachinesAPI
    {
        [Test]
        public async Task List()
        {
            var response = await API.Memory.List(1);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            //Assert.That(response.Content, Is.Not.Null);
            //Assert.That(response.Content.Machines.Any);
        }

        [Test]
        public async Task Get()
        {
            var response = await API.Memory.Get(1, 1908);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            //Assert.That(response.Content, Is.Not.Null);
        }
    }
}
