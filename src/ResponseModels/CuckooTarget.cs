using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CuckooTarget
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("file")]
        public CuckooFile File { get; set; }
    }
}
