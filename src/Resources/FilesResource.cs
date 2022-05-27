using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;

namespace Cuckoo.Net.Resources
{
    internal class FilesResource : CuckooResourceBase, IFilesAPI
    {
        public FilesResource(CuckooWebClient client) : base(client)
        {
        }

        public async Task<Response> Get(string sha256)
        {
            return await Client.Get($"/files/get/{sha256}");
        }

        public async Task<Response<SampleResponse>> View(int? id = null, string sha256 = "", string md5 = "")
        {
            if (id is not null)
                return await Client.Get($"/files/get/{id}");
            if (!string.IsNullOrEmpty(sha256))
                return await Client.Get($"/files/get/{sha256}");
            if (!string.IsNullOrEmpty(md5))
                return await Client.Get($"/files/get/{md5}");
            throw new ArgumentNullException("Id,sha256 or md5 must be provided");
        }
    }
}
