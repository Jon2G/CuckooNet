using Cuckoo.Net.Enums;
using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class JsonReport : CuckooReport
    {
        public override ReportFormat Format => ReportFormat.JSON;
        [JsonProperty("info")]
        public CuckooInfo Info { get; set; }

        [JsonProperty("signatures")]
        public List<CuckooSignature> Signatures { get; set; }

        [JsonProperty("target")]
        public CuckooTarget Target { get; set; }

        [JsonProperty("debug")]
        public DebugData Debug { get; set; }

        [JsonProperty("metadata")]
        public CuckooMetadata Metadata { get; set; }

        [JsonProperty("strings")]
        public List<string> Strings { get; set; }

        [JsonProperty("network")]
        public NetworkData Network { get; set; }

        public JsonReport()
        {

        }
        public override async Task Save(string path, string name)
        {
            using (FileStream file = new FileStream(Path.Combine(path, $"{name}.json"), FileMode.OpenOrCreate))
            {
                using (StreamWriter writter = new StreamWriter(file))
                {
                    await writter.WriteAsync(TextData);
                }
            }
        }
    }
}
