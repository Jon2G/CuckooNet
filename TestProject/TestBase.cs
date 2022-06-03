namespace TestProject
{
    public class TestBase
    {
        public Cuckoo.Net.CuckooAPI API { get; set; }
        [SetUp]
        public void Setup()
        {
            API = new Cuckoo.Net.CuckooAPI("http://localhost:8090", "<Your API Key>");
        }
    }
}
