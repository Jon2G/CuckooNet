using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class NetworkData
    {
        [JsonProperty("mitm")]
        public List<object> Mitm { get; set; }
    }
}
