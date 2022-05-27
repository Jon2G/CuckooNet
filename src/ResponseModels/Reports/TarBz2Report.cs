using Cuckoo.Net.Enums;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public class TarBz2Report : CuckooReport
    {
        private readonly ReportFormat _format;
        public override ReportFormat Format => _format;
        public TarBz2Report(string value, ReportFormat format) : base(value)
        {
            format = _format;
        }

        public override void Save(string path, string name)
        {
            throw new NotImplementedException();
        }
    }
}
