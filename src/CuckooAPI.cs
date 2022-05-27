using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;
using Cuckoo.Net.Resources;

namespace Cuckoo.Net
{
    public class CuckooAPI
    {
        private readonly Lazy<ICuckooAPI> _Cuckoo;
        public ICuckooAPI Cuckoo => _Cuckoo.Value;
        private readonly Lazy<IMachinesAPI> _Machines;
        public IMachinesAPI Machines => _Machines.Value;
        private readonly Lazy<IMemoryAPI> _Memory;
        public IMemoryAPI Memory => _Memory.Value;
        private readonly Lazy<IPcapAPI> _PCAP;
        public IPcapAPI PCAP => _PCAP.Value;
        private readonly Lazy<IVpnAPI> _VPN;
        public IVpnAPI VPN => _VPN.Value;
        private readonly Lazy<IFilesAPI> _Files;
        public IFilesAPI Files => _Files.Value;
        private readonly Lazy<ITasksAPI> _Tasks;
        public ITasksAPI Tasks => _Tasks.Value;

        private readonly CuckooWebClient WebClient;

        public CuckooAPI(string url, string token) :
            this(new Uri(url), token)
        {

        }
        public CuckooAPI(Uri url, string token)
        {
            this.WebClient = new CuckooWebClient(url, token);
            this._Cuckoo = new Lazy<ICuckooAPI>(() => new CuckooResource(this.WebClient));
            this._Machines = new Lazy<IMachinesAPI>(() => new MachinesResource(this.WebClient));
            this._Memory = new Lazy<IMemoryAPI>(() => new MemoryResource(this.WebClient));
            this._PCAP = new Lazy<IPcapAPI>(() => new PcapResource(this.WebClient));
            this._VPN = new Lazy<IVpnAPI>(() => new VpnResource(this.WebClient));
            this._Files = new Lazy<IFilesAPI>(() => new FilesResource(this.WebClient));
            this._Tasks = new Lazy<ITasksAPI>(() => new TasksResource(this.WebClient));
        }
    }
}
