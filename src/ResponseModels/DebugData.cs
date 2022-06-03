using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class DebugData
    {
        [JsonProperty("action")]
        public List<string> Action { get; set; }

        [JsonProperty("dbgview")]
        public List<object> Dbgview { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("log")]
        public List<object> Log { get; set; }

        [JsonProperty("cuckoo")]
        public List<string> Cuckoo { get; set; }
    }
}
