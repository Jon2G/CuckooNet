using Cuckoo.Net.Enums;
using Cuckoo.Net.ResponseModels;
using Newtonsoft.Json;
using System.Net;

namespace TestProject
{
    public class TasksAPITest : TestBase
    {
        [Test]
        public void Deserialization()
        {
            string json = @"{
      ""added_on"": ""2022-05-24 14:43:33"", 
      ""clock"": ""2022-05-24 14:43:33"", 
      ""completed_on"": null, 
      ""duration"": -1, 
      ""processing"": null, 
      ""route"": null, 
      ""sample"": {
        ""crc32"": ""C07A9F32"", 
        ""file_size"": 14, 
        ""file_type"": ""ASCII text, with no line terminators"", 
        ""id"": 1, 
        ""md5"": ""ce114e4501d2f4e2dcea3e17b546f339"", 
        ""sha1"": ""a54d88e06612d820bc3be72877c74f257b561b19"", 
        ""sha256"": ""c7be1ed902fb8dd4d48997c6452f5d7e509fbcdbe2808b16bcf4edce4c07d14e"", 
        ""sha512"": ""a028d4f74b602ba45eb0a93c9a4677240dcf281a1a9322f183bd32f0bed82ec72de9c3957b2f4c9a1ccf7ed14f85d73498df38017e703d47ebb9f0b3bf116f69"", 
        ""ssdeep"": ""3:hMCEpn:hup""
      }, 
      ""sample_id"": 1, 
      ""started_on"": null, 
      ""submit_id"": null
    }";
            var task = JsonConvert.DeserializeObject<CuckooTask>(json);
        }
        [Test]
        public async Task CreateFile()
        {
            var response = await API.Tasks.CreateFile(new FileInfo($"{Environment.CurrentDirectory}/TestSample.txt"));
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task CreateSubmitFiles()
        {
            var response = await API.Tasks.CreateSubmit(new FileInfo($"{Environment.CurrentDirectory}/TestSample.txt"), new FileInfo($"{Environment.CurrentDirectory}/TestSample2.txt"));
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task CreateSubmitUrls()
        {
            var response = await API.Tasks.CreateSubmit(new Uri("https://www.google.com"), new Uri("https://www.youtube.com"));
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task CreateUrl()
        {
            var response = await API.Tasks.CreateUrl(new Uri("https://www.facebook.com"));
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Delete()
        {
            var response = await API.Tasks.Delete(9);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Reschedule()
        {
            var response = await API.Tasks.Reschedule(2);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task List()
        {
            var response = await API.Tasks.List();
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Reboot()
        {
            var response = await API.Tasks.Reboot(2);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Report()
        {
            var response = await API.Tasks.Report(2, ReportFormat.HTML);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task ReReport()
        {
            var response = await API.Tasks.ReReport(1);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Sample()
        {
            var response = await API.Tasks.Sample(1);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task ScreenShots()
        {
            var response = await API.Tasks.ScreenShots(1);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Summary()
        {
            var response = await API.Tasks.Summary(2);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task View()
        {
            var response = await API.Tasks.View(2);
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Is.Not.Null);
        }
    }
}
