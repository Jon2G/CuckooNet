using Cuckoo.Net.Enums;
using Cuckoo.Net.Interfaces.Json;
using Newtonsoft.Json;
namespace Cuckoo.Net.ResponseModels
{
    public class CuckooTask
    {
        [JsonConverter(typeof(JsonDateTimeConverter))]
        [JsonProperty("added_on")]
        public DateTime? AddedOn { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? Clock { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? CompletedOn { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? StartedOn { get; set; }
        public int Duration { get; set; }
        public string Processing { get; set; }
        public string Route { get; set; }
        public Sample Sample { get; set; }
        [JsonProperty("sample_id")]
        public int? SampleId { get; set; }
        [JsonProperty("submit_id")]
        public int? SubmitId { get; set; }
        public Category Category { get; set; }
        public string Machine { get; set; }
        public string[] Errors { get; set; }
        public string Target { get; set; }
        public string Package { get; set; }
        public Guest Guest { get; set; }
        public string Custom { get; set; }
        public string Owner { get; set; }
        public Priority Priority { get; set; }
        public string Platform { get; set; }
        public dynamic Options { get; set; }
        public Status Status { get; set; }
        public bool EnforceTimeOut { get; set; }
        public int TimeOut { get; set; }
        public bool Memory { get; set; }
        public string[] Tags { get; set; }
        public int Id { get; set; }

        public CuckooTask()
        {

        }
    }
}
