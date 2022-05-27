using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Resources
{
    internal class VpnResource : CuckooResourceBase, IVpnAPI
    {
        public VpnResource(CuckooWebClient client) : base(client)
        {
        }

        public async Task<Response> Status()
        {
            return await Client.Get("/vpn/status");
        }
    }
}
