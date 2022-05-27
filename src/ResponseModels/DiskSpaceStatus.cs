
namespace Cuckoo.Net.ResponseModels
{
    public class DiskSpaceStatus
    {
        public DiskSpace Analyses { get; set; }
        public DiskSpace Binaries { get; set; }
        public DiskSpace Temporary { get; set; }
    }
}
