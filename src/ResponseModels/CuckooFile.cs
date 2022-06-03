using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class CuckooFile
    {
        [JsonProperty("yara")]
        public List<object> Yara { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("urls")]
        public List<object> Urls { get; set; }

        [JsonProperty("crc32")]
        public string Crc32 { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("ssdeep")]
        public object Ssdeep { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sha512")]
        public string Sha512 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }
    }
}
