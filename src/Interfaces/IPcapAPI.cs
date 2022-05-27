using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Interfaces
{
    public interface IPcapAPI
    {
        public Task<Response> Get(int idTask);
    }
}
