using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CreateFileResponse
    {
        [JsonProperty("task_id")]
        public int Id { get; set; }
    }
}
