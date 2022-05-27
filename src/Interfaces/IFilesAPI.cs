using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;

namespace Cuckoo.Net.Interfaces
{
    public interface IFilesAPI
    {
        /// <summary>
        /// /files/view
        /// Returns details on the file matching either the specified MD5 hash, SHA256 hash or ID.
        /// </summary>
        /// <param name="id">ID of the file to lookup. (optional)</param>
        /// <param name="sha256">SHA256 hash of the file to lookup. (optional)</param>
        /// <param name="md5">MD5 hash of the file to lookup. (optional)</param>
        /// <returns></returns>
        public Task<Response<SampleResponse>> View(int? id = null, string? sha256 = "", string? md5 = "");

        /// <summary>
        /// /files/get/
        /// Returns the binary content of the file matching the specified SHA256 hash.
        /// </summary>
        /// <param name="sha256"></param>
        /// <returns></returns>
        public Task<Response> Get(string sha256);

    }
}
