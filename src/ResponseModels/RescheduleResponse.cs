using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class RescheduleResponse
    {
        public string Status { get; set; }
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}
