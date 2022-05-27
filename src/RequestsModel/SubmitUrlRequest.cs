using Cuckoo.Net.Enums;
using System.Net.Http.Headers;

namespace Cuckoo.Net.RequestsModel
{
    public class SubmitUrlRequest : SubimtRequest<Uri>
    {
        /// <summary>
        /// Adds a file to the list of pending tasks. Returns the ID of the newly created task.
        /// </summary>
        /// <param name="url">Sample file (multipart encoded file content)</param>
        /// <param name="package">analysis package to be used for the analysis</param>
        /// <param name="timeOut">analysis timeout (in seconds)</param>
        /// <param name="priority"> priority to assign to the task (1-3)</param>
        /// <param name="options">options to pass to the analysis package</param>
        /// <param name="machine">label of the analysis machine to use for the analysis</param>
        /// <param name="platform">name of the platform to select the analysis machine from (e.g. “windows”)</param>
        /// <param name="tags"> define machine to start by tags. Platform must be set to use that. Tags are comma separated</param>
        /// <param name="custom">custom string to pass over the analysis and the processing/reporting modules</param>
        /// <param name="owner">task owner in case multiple users can submit files to the same cuckoo instance</param>
        /// <param name="clock">set virtual machine clock (format %m-%d-%Y %H:%M:%S)</param>
        /// <param name="memory"> enable the creation of a full memory dump of the analysis machine</param>
        /// <param name="unique">only submit samples that have not been analyzed before</param>
        /// <param name="enforceTimeout"> enable to enforce the execution for the full timeout value</param>
        public SubmitUrlRequest(Uri url,
            string? package = null, int? timeOut = null, Priority? priority = null,
            string? options = null, string? machine = null, string? platform = null,
            string[]? tags = null, string? custom = null, string? owner = null,
            string? clock = null, bool? memory = null, bool? unique = null,
            bool? enforceTimeout = null)
        : base(url, package, timeOut, priority, options, machine, platform, tags, custom, owner, clock, memory, unique, enforceTimeout)
        {

        }
        public override MultipartFormDataContent GetContent()
        {
            MultipartFormDataContent multi = new MultipartFormDataContent();
            string url = Sample.AbsoluteUri;

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(url);
            writer.Flush();
            stream.Position = 0;

            StreamContent fileContent = new StreamContent(stream);
            ContentDispositionHeaderValue disposition = new ContentDispositionHeaderValue("form-data");
            disposition.Name = "\"url\"";
            disposition.FileName = "\"\"";
            fileContent.Headers.ContentDisposition = disposition;
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");



            multi.Add(fileContent);
            return AddParameters(multi);
        }
    }
}
