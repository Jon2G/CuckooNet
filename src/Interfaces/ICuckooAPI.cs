using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;
namespace Cuckoo.Net.Interfaces
{
    public interface ICuckooAPI
    {
        /// <summary>
        /// /cuckoo/status
        /// (This feature is only available under Unix!)
        /// Returns status of the cuckoo server. 
        /// In version 1.3 the diskspace entry was added. 
        /// The diskspace entry shows the used, free, and total diskspace at the disk where the respective directories can be found. 
        /// The diskspace entry allows monitoring of a Cuckoo node through the Cuckoo API. 
        /// Note that each directory is checked separately as one may create a symlink for $CUCKOO/storage/analyses to a separate harddisk, but keep $CUCKOO/storage/binaries as-is. 
        /// In version 1.3 the cpuload entry was also added - the cpuload entry shows the CPU load for the past minute, the past 5 minutes, and the past 15 minutes, respectively. (This feature is only available under Unix!)
        /// </summary>
        /// <returns></returns>
        public Task<Response<CuckooStatus>> Status();

        /// <summary>
        /// Shuts down the server if in debug mode and using the werkzeug server.
        /// </summary>
        /// <returns></returns>
        public Task<Response> Exit();
    }
}
