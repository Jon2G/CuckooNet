using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class PackageFilesReport : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.PACKAGE_FILES;
        public PackageFilesReport(string value) : base(value)
        {
        }
        public override void Save(string path, string name)
        {
            throw new NotImplementedException();
        }
    }
}
