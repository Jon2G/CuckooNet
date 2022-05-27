using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Resources
{
    internal class PcapResource : CuckooResourceBase, IPcapAPI
    {
        public PcapResource(CuckooWebClient client) : base(client)
        {
        }

        public async Task<Response> Get(int idTask)
        {
            return await Client.Get($"/pcap/get/{idTask}");
        }
    }
}
