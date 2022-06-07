using System.Net;
using System.Text;

namespace Cuckoo.Net.Internal
{
    public class Response<T> : Response where T : class
    {
        public T? Content { get; set; }
        public Response(HttpStatusCode httpStatusCode, string message, T? content = default(T))
            : base(httpStatusCode, message)
        {
            this.Content = content;
        }
        public static implicit operator Response<T>(ResponseResult r)
        {
            if (r.Ok)
            {
                T? content = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(r.Response);
                return new Response<T>(r.HttpStatusCode, r.Response, content);
            }
            else
            {
                Console.WriteLine("failed");
                switch (r.HttpStatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new UnauthorizedAccessException("Unauthorized,api key may be wrong");
                }
            }
            return new Response<T>(r.HttpStatusCode, r.Response);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HttpStatusCode).Append(" - ").Append(Content);
            return sb.ToString();
        }
    }
    public class Response
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public Stream Stream { get; set; }
        public bool Ok => HttpStatusCode.OK == HttpStatusCode;
        public Response(HttpStatusCode httpStatusCode, string message, Stream stream = null)
        {
            this.HttpStatusCode = httpStatusCode;
            this.Message = message;
            this.Stream = stream;
        }
        public static implicit operator Response(ResponseResult r)
        {
            return new Response(r.HttpStatusCode, r.Response, r.Stream);
        }
    }
}
