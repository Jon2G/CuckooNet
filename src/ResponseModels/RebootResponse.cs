using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class RebootResponse
    {
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
        [JsonProperty("reboot_id")]
        public int RebootId { get; set; }

        public RebootResponse()
        {

        }
    }
}
