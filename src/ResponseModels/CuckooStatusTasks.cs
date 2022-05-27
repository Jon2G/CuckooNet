namespace Cuckoo.Net.ResponseModels
{
    public partial class CuckooStatus
    {
        public class CuckooStatusTasks
        {
            public int Reported { get; set; }
            public int Running { get; set; }
            public int Total { get; set; }
            public int Completed { get; set; }
            public int Pending { get; set; }
        }
    }
}
