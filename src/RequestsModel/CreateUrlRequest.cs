using Newtonsoft.Json;

namespace Cuckoo.Net.RequestsModel
{
    internal class CreateUrlRequest
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
