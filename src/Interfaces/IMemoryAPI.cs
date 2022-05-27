using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Interfaces
{
    public interface IMemoryAPI
    {
        /// <summary>
        /// /memory/list
        /// Returns a list of memory dump files or one memory dump file associated with the specified task ID.
        /// </summary>
        /// <param name="idTask">ID of the task to get the report for.  (required)</param>
        /// <returns></returns>
        public Task<Response> List(int idTask);
        /// <summary>
        /// /memory/get
        /// Returns one memory dump file associated with the specified task ID.
        /// </summary>
        /// <param name="idTask">ID of the task to get the report for.  (required)</param>
        /// <param name="pid">Numerical identifier (pid) of a single memory dump file (e.g. 205, 1908).  (required)</param>
        /// <returns></returns>
        public Task<Response> Get(int idTask, int pid);
    }
}
