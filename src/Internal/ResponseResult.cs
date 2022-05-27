using System.Net;

namespace Cuckoo.Net.Internal
{
    public class ResponseResult
    {
        public HttpStatusCode HttpStatusCode;
        public readonly string Response;
        public bool Ok => HttpStatusCode == HttpStatusCode.OK;
        public ResponseResult(HttpStatusCode httpStatusCode, string response)
        {
            HttpStatusCode = httpStatusCode;
            Response = response;
        }
    }
}
