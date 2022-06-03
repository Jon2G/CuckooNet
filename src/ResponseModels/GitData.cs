using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class GitData
    {
        [JsonProperty("head")]
        public string Head { get; set; }

        [JsonProperty("fetch_head")]
        public string FetchHead { get; set; }
    }
}
