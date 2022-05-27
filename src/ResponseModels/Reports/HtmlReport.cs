using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class HtmlReport : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.HTML;
        private readonly string HTML;
        public HtmlReport(string value) : base(value)
        {
            HTML = value;
        }
        public override void Save(string path, string name)
        {
            throw new NotImplementedException();
        }
    }
}
