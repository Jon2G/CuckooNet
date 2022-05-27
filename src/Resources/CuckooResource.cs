using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;

namespace Cuckoo.Net.Resources
{
    internal class CuckooResource : CuckooResourceBase, ICuckooAPI
    {
        public CuckooResource(CuckooWebClient client) : base(client)
        {

        }
        public async Task<Response> Exit()
        {
            return await Client.Get("/exit");
        }

        public async Task<Response<CuckooStatus>> Status()
        {
            ResponseResult result = await this.Client.Get("/cuckoo/status");
            return result;
        }
    }
}
