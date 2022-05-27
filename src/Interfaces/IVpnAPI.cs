using Cuckoo.Net.Internal;

namespace Cuckoo.Net.Interfaces
{
    public interface IVpnAPI
    {
        /// <summary>
        /// /vpn/status
        /// Returns VPN status.
        /// </summary>
        /// <returns></returns>
        public Task<Response> Status();
    }
}
