using Newtonsoft.Json;

namespace Cuckoo.Net.ResponseModels
{
    public partial class CuckooStatus
    {
        [JsonProperty("cpu_count")]
        public int CpuCount { get; set; }
        [JsonProperty("cpuload")]
        public double[] CpuLoad { get; set; }
        [JsonProperty("diskspace")]
        public DiskSpaceStatus DiskSpace { get; set; }
        [JsonProperty("hostName")]
        public string HostName { get; set; }
        [JsonProperty("machines")]
        public MachinesStatus Machines { get; set; }
        [JsonProperty("memavail")]
        public ulong AvaibleMemory { get; set; }
        [JsonProperty("memory")]
        public double Memory { get; set; }
        [JsonProperty("memtotal")]
        public ulong TotalMemory { get; set; }
        [JsonProperty("processes")]
        public dynamic Processes { get; set; }
        [JsonProperty("tasks")]
        public CuckooStatusTasks Tasks { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("protocol_version")]
        public int ProtocolVersion { get; set; }
    }
}
