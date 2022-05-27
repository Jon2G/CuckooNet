namespace TestProject
{
    public class TestBase
    {
        public Cuckoo.Net.CuckooAPI API { get; set; }
        [SetUp]
        public void Setup()
        {
            API = new Cuckoo.Net.CuckooAPI("http://172.25.87.33:8090", "jon2g");
        }
    }
}
