using Cuckoo.Net.Enums;
using Cuckoo.Net.Interfaces;
using Cuckoo.Net.Internal;
using Cuckoo.Net.RequestsModel;
using Cuckoo.Net.ResponseModels;
using Cuckoo.Net.ResponseModels.Reports;

namespace Cuckoo.Net.Resources
{
    internal class TasksResource : CuckooResourceBase, ITasksAPI
    {
        public TasksResource(CuckooWebClient client) : base(client)
        {
        }

        public async Task<Response<CreateFileResponse>> CreateFile(CreateFileRequest request)
        {
            return await Client.Post("/tasks/create/file", request.GetContent());
        }
        public Task<Response<CreateSubmitResponse>> CreateSubmit(params FileInfo[] files) =>
            CreateSubmit(new SubmitFilesRequest(files));

        public Task<Response<CreateFileResponse>> CreateFile(FileInfo file) => CreateFile(new CreateFileRequest(file));

        public async Task<Response<CreateSubmitResponse>> CreateSubmit(SubmitUrlsRequest request)
        {
            return await Client.Post("/tasks/create/submit", request.GetContent());
        }

        public Task<Response<CreateSubmitResponse>> CreateSubmit(params Uri[] urls) =>
            CreateSubmit(new SubmitUrlsRequest(url: urls));

        public async Task<Response<CreateSubmitResponse>> CreateSubmit(SubmitFilesRequest request)
        {
            return await Client.Post("/tasks/create/submit", request.GetContent());
        }

        public Task<Response<CreateSubmitResponse>> CreateUrl(Uri url)
            => CreateSubmit(new SubmitUrlsRequest(url: url));

        public async Task<Response<DeleteResponse>> Delete(int taskId)
        {
            return await Client.Get($"/tasks/delete/{taskId}");
        }

        public async Task<Response<RescheduleResponse>> Reschedule(int taskId, Priority? priority = null)
        {
            if (priority is { })
                return await Client.Get($"/tasks/reschedule/{taskId}/{(int)priority}");
            return await Client.Get($"/tasks/reschedule/{taskId}");
        }

        public async Task<Response<TaskListResponse>> List(int? limit = null, int? offset = null)
        {
            if (offset is { })
            {
                if (limit is null)
                    throw new ArgumentNullException(nameof(limit), "Limit must be provided if using offset");
                return await Client.Get($"/tasks/list/{limit}/{offset}");
            }
            if (limit is { })
                return await Client.Get($"/tasks/list/{limit}");
            return await Client.Get($"/tasks/list");
        }

        public async Task<Response<RebootResponse>> Reboot(int taskId)
        {
            return await Client.Get($"/tasks/reboot/{taskId}");
        }

        public async Task<Response<CuckooReport>> Report(int taskId, ReportFormat format = ReportFormat.JSON)
        {
            Response response = await Client.Get($"/tasks/report/{taskId}/{format.GetString()}");
            switch (format)
            {
                case ReportFormat.ALL:
                case ReportFormat.DROPPED:
                    return new Response<CuckooReport>(response.HttpStatusCode, "Ok", new TarBz2Report(response.Message, format));
                case ReportFormat.JSON:
                    return new Response<CuckooReport>(response.HttpStatusCode, "Ok", new JsonReport(response.Message));
                case ReportFormat.HTML:
                    return new Response<CuckooReport>(response.HttpStatusCode, "Ok", new HtmlReport(response.Message));
                case ReportFormat.PACKAGE_FILES:
                    return new Response<CuckooReport>(response.HttpStatusCode, "Ok", new PackageFilesReport(response.Message));
                default:
                    throw new ArgumentOutOfRangeException(nameof(format));
            }
        }

        public async Task<Response> ReReport(int taskId)
        {
            return await Client.Get($"/tasks/rereport/{taskId}");
        }

        public async Task<Response<TaskListResponse>> Sample(int sampleId)
        {
            return await Client.Get($"/tasks/sample/{sampleId}");
        }

        public async Task<Response> ScreenShots(int taskId, int? screenshot = null)
        {
            if (screenshot is { })
                return await Client.Get($"/tasks/report/{taskId}/{screenshot:D4}");
            return await Client.Get($"/tasks/report/{taskId}");
        }

        public async Task<Response> Summary(int taskId)
        {
            return await Client.Get($"/tasks/summary/{taskId}");
        }

        public async Task<Response<TaskResponse>> View(int taskId)
        {
            return await Client.Get($"/tasks/view/{taskId}");
        }
    }
}
