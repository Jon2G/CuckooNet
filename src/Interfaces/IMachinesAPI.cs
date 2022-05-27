using Cuckoo.Net.Internal;
using Cuckoo.Net.ResponseModels;

namespace Cuckoo.Net.Interfaces
{
    public interface IMachinesAPI
    {
        /// <summary>
        /// /machines/list
        /// Returns a list with details on the analysis machines available to Cuckoo.
        /// </summary>
        /// <returns></returns>
        public Task<Response<MachinesResponse>> List();

        /// <summary>
        /// /machines/view/
        /// Returns details on the analysis machine associated with the given name.
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns></returns>
        public Task<Response<MachineResponse>> View(string machineName);
    }
}
