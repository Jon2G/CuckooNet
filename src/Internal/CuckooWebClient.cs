using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Cuckoo.Net.Internal
{
    internal class CuckooWebClient
    {
        private readonly HttpClient HttpClient;
        private readonly string Token;
        public CuckooWebClient(Uri url, string token)
        {
            Token = token;
            this.HttpClient = new HttpClient();
            this.HttpClient.BaseAddress = url;
            this.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public async Task<ResponseResult> Post<T>(string method, T obj)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.PostAsync(method, JsonContent.Create(obj, typeof(T)));
                string json = await response.Content.ReadAsStringAsync();
                return new ResponseResult(response.StatusCode, json);
            }
            catch (HttpRequestException httpError)
            {
                return new ResponseResult(httpError.StatusCode ?? System.Net.HttpStatusCode.Unused, httpError.Message);

            }
            catch (Exception ex)
            {
                return new ResponseResult(System.Net.HttpStatusCode.Unused, ex.Message);
            }
        }
        public async Task<ResponseResult> Post(string method, MultipartFormDataContent multi)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, method)
                {
                    Content = multi
                });
                string json = await response.Content.ReadAsStringAsync();
                return new ResponseResult(response.StatusCode, json);
            }
            catch (HttpRequestException httpError)
            {
                return new ResponseResult(httpError.StatusCode ?? System.Net.HttpStatusCode.Unused, httpError.Message);

            }
            catch (Exception ex)
            {
                return new ResponseResult(System.Net.HttpStatusCode.Unused, ex.Message);
            }
        }
        internal static HttpContent CreateFileContent(Stream stream, string fileName)
        {
            StreamContent fileContent = new StreamContent(stream);
            ContentDispositionHeaderValue disposition = new ContentDispositionHeaderValue("form-data");
            disposition.Name = "\"file\"";
            disposition.FileName = "\"" + fileName + "\"";
            fileContent.Headers.ContentDisposition = disposition;
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return fileContent;
        }
        internal static HttpContent CreatePlainTextContent(string text)
        {
            StringContent textContent = new StringContent(text);
            ContentDispositionHeaderValue disposition = new ContentDispositionHeaderValue("form-data");
            disposition.Name = "\"strings\"";
            textContent.Headers.ContentDisposition = disposition;
            textContent.Headers.ContentType = new MediaTypeHeaderValue("plain/text");
            return textContent;
        }
        //
        public async Task<ResponseResult> Get(string method)
        {
            try
            {
                HttpResponseMessage response = await this.HttpClient.GetAsync(method);
                switch (response.Content?.Headers?.ContentType?.MediaType)
                {
                    case "text/html":
                    case "application/json":
                        string json = await response.Content.ReadAsStringAsync();
                        return new ResponseResult(response.StatusCode, json);
                    default:
                        Stream stream = await response.Content.ReadAsStreamAsync();
                        stream.Position = 0;
                        return new ResponseResult(response.StatusCode, stream);
                }
            }
            catch (HttpRequestException httpError)
            {
                return new ResponseResult(httpError.StatusCode ?? System.Net.HttpStatusCode.Unused, httpError.Message);

            }
            catch (Exception ex)
            {
                return new ResponseResult(System.Net.HttpStatusCode.Unused, ex.Message);
            }
        }
    }
}
