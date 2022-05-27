using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public abstract class CuckooReport
    {
        public abstract ReportFormat Format { get; }
        public abstract void Save(string path, string name);
        protected CuckooReport(string value)
        {

        }
    }
}
