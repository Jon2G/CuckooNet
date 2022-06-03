using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CuckooInfo
    {
        [JsonProperty("added")]
        public double Added { get; set; }

        [JsonProperty("started")]
        public double Started { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("ended")]
        public double Ended { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("git")]
        public GitData Git { get; set; }

        [JsonProperty("monitor")]
        public string Monitor { get; set; }

        [JsonProperty("package")]
        public string Package { get; set; }

        [JsonProperty("route")]
        public object Route { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }

        [JsonProperty("machine")]
        public Machine Machine { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }
    }
}
