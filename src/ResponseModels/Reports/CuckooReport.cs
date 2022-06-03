using Cuckoo.Net.Enums;
using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels.Reports
{
    public abstract class CuckooReport
    {
        public abstract ReportFormat Format { get; }
        public abstract Task Save(string path, string name);
        public Task Save(string name) => Save(Environment.CurrentDirectory, name);
        public string TextData { get; set; }
        protected CuckooReport() { }

        public static T Get<T>(string data) where T : CuckooReport
        {
            T report = JsonConvert.DeserializeObject<T>(data);
            report.TextData = data;
            return report;
        }
    }
}
