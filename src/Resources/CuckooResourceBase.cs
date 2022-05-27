using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Resources
{
    internal abstract class CuckooResourceBase
    {
        protected readonly CuckooWebClient Client;
        public CuckooResourceBase(CuckooWebClient client)
        {
            Client = client;
        }
    }
}
