using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CreateUrlResponse
    {
        [JsonProperty("task_id")]
        public int? Id { get; set; }
    }
}
