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
        public Response(HttpStatusCode httpStatusCode, string message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.Message = message;
        }
        public static implicit operator Response(ResponseResult r)
        {
            return new Response(r.HttpStatusCode, r.Response);
        }
    }
}
