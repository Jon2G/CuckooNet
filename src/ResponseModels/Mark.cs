using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class Mark
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("ioc")]
        public string Ioc { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
