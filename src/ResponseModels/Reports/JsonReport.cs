using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class JsonReport : CuckooReport
    {
        public string Json { get; set; }
        public override ReportFormat Format => ReportFormat.JSON;
        public JsonReport(string value) : base(value)
        {
            Json = value;
        }
        public override void Save(string path, string name)
        {
            throw new NotImplementedException();
        }
    }
}
