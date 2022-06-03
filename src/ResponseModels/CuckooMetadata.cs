using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CuckooMetadata
    {
        [JsonProperty("output")]
        public CuckooOutput Output { get; set; }
    }
}
