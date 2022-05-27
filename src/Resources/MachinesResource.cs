using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;

namespace Cuckoo.Net.Resources
{
    internal class MachinesResource : CuckooResourceBase, IMachinesAPI
    {
        public MachinesResource(CuckooWebClient client) : base(client)
        {
        }

        public async Task<Response<MachinesResponse>> List()
        {
            return await Client.Get("/machines/list");
        }

        public async Task<Response<MachineResponse>> View(string machineName)
        {
            return await Client.Get($"/machines/view/{machineName}");
        }
    }
}
