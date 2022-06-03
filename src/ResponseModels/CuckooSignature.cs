using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CuckooSignature
    {
        [JsonProperty("families")]
        public List<object> Families { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("ttp")]
        public Ttp Ttp { get; set; }

        [JsonProperty("markcount")]
        public int Markcount { get; set; }

        [JsonProperty("references")]
        public List<object> References { get; set; }

        [JsonProperty("marks")]
        public List<Mark> Marks { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
