using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class T1045
    {
        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }
}
