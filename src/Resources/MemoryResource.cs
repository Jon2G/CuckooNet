using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Resources
{
    internal class MemoryResource : CuckooResourceBase, IMemoryAPI
    {
        public MemoryResource(CuckooWebClient client) : base(client)
        {

        }
        public async Task<Response> Get(int idTask, int pid)
        {
            return await Client.Get($"/memory/get/{idTask}/{pid}");
        }

        public async Task<Response> List(int idTask)
        {
            return await Client.Get($"/memory/list/{idTask}");
        }
    }
}
