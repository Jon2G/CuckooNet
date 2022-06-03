using Cuckoo.Net.Interfaces.Json;
using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class Machine
    {
        public int Id { get; set; }
        public string Interface { get; set; }
        public string Ip { get; set; }
        [JsonProperty("manager")]
        public string Manager { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        public bool Locked { get; set; }
        [JsonProperty("locked_changed_on")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? LockedChangedOn { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        public string[] Options { get; set; }
        public string Platform { get; set; }
        public dynamic RCParams { get; set; }
        [JsonProperty("resultserver_ip")]
        public string ResultServerIp { get; set; }
        [JsonProperty("resultserver_port")]
        public int ResultServerPort { get; set; }
        public string Snapshot { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("status_changed_on")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? StatusChangedOn { get; set; }
        [JsonProperty("shutdown_on")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? ShutdownOn { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        public Machine()
        {

        }
    }
}
