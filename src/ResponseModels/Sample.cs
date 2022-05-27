using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public class Sample
    {
        [JsonProperty("crc32")]
        public string Crc32 { get; set; }
        [JsonProperty("file_size")]
        public ulong FileSize { get; set; }
        [JsonProperty("file_type")]
        public string FileType { get; set; }
        public int Id { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public string SHA256 { get; set; }
        public string SHA512 { get; set; }
        public string SSDeep { get; set; }
    }
}
