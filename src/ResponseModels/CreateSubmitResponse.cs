using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CreateSubmitResponse
    {
        public string[] Errors { get; set; }
        [JsonProperty("submit_id")]
        public int SubmitId { get; set; }
        [JsonProperty("task_ids")]
        public int[] TaskIds { get; set; }

        public CreateSubmitResponse()
        {

        }
    }
}
