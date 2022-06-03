using Cuckoo.Net.Enums;
using Cuckoo.Net.Internal;
using Cuckoo.Net.RequestsModel;
using Cuckoo.Net.ResponseModels;
using Cuckoo.Net.ResponseModels.Reports;

namespace Cuckoo.Net.Interfaces
{
    public interface ITasksAPI
    {

        /// <summary>
        /// /tasks/create/file
        /// Adds a file to the list of pending tasks. Returns the ID of the newly created task.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Response<CreateFileResponse>> CreateFile(CreateFileRequest request);

        /// <summary>
        /// /tasks/create/file
        /// Adds a file to the list of pending tasks. Returns the ID of the newly created task.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public Task<Response<CreateFileResponse>> CreateFile(FileInfo file);

        /// <summary>
        /// /tasks/create/url
        /// Adds a file to the list of pending tasks. Returns the ID of the newly created task.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<Response<CreateSubmitResponse>> CreateUrl(Uri url);


        /// <summary>
        /// /tasks/create/submit
        /// Adds one or more files and/or files embedded in archives or a newline separated list of URLs/hashes to the list of pending tasks. 
        /// Returns the submit ID as well as the task IDs of the newly created task(s).
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<Response<CreateSubmitResponse>> CreateSubmit(params Uri[] urls);

        /// <summary>
        /// /tasks/create/submit
        /// Adds one or more files and/or files embedded in archives or a newline separated list of URLs/hashes to the list of pending tasks. 
        /// Returns the submit ID as well as the task IDs of the newly created task(s).
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<Response<CreateSubmitResponse>> CreateSubmit(SubmitUrlsRequest request);

        /// <summary>
        /// /tasks/create/submit
        /// Adds one or more files and/or files embedded in archives or a newline separated list of URLs/hashes to the list of pending tasks. 
        /// Returns the submit ID as well as the task IDs of the newly created task(s).
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public Task<Response<CreateSubmitResponse>> CreateSubmit(SubmitFilesRequest request);

        /// <summary>
        /// /tasks/create/submit
        /// Adds one or more files and/or files embedded in archives or a newline separated list of URLs/hashes to the list of pending tasks. 
        /// Returns the submit ID as well as the task IDs of the newly created task(s).
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public Task<Response<CreateSubmitResponse>> CreateSubmit(params FileInfo[] files);

        /// <summary>
        /// /tasks/list
        /// Returns list of tasks.
        /// </summary>
        /// <returns></returns>
        public Task<Response<TaskListResponse>> List(int? limit = null, int? offset = null);

        /// <summary>
        /// /tasks/sample
        /// Returns list of tasks for sample.
        /// </summary>
        /// <param name="sampleId"></param>
        /// <returns></returns>
        public Task<Response<TaskListResponse>> Sample(int sampleId);

        /// <summary>
        /// /tasks/view
        /// Returns details on the task associated with the specified ID.
        /// </summary>
        /// <param name="taskId">ID of the task to lookup. (required)</param>
        /// <returns>Task associated with the specified ID</returns>
        public Task<Response<TaskResponse>> View(int taskId);
        /// <summary>
        /// /tasks/reschedule
        /// Reschedule a task with the specified ID and priority (default priority is 1).
        /// </summary>
        /// <param name="taskId">ID of the task to reschedule. (required)</param>
        /// <param name="priority">Task priority. (optional)</param>
        /// <returns></returns>
        public Task<Response<RescheduleResponse>> Reschedule(int taskId, Priority? priority = null);

        /// <summary>
        /// /tasks/delete
        /// Removes the given task from the database and deletes the results.
        /// </summary>
        /// <param name="taskId">ID of the task to delete (required)</param>
        /// <returns></returns>
        public Task<Response<DeleteResponse>> Delete(int taskId);

        /// <summary>.
        /// /tasks/report
        /// Returns the report associated with the specified task ID.
        /// </summary>
        /// <param name="taskId">ID of the task to delete. (required)</param>
        /// <returns></returns>
        public Task<Response<CuckooReport>> Report(int taskId, ReportFormat format = ReportFormat.JSON);

        /// <summary>
        /// /tasks/summary
        /// Returns a condensed report associated with the specified task ID in JSON format.
        /// </summary>
        /// <param name="taskId">ID of the task to get the report for. (required)</param>
        /// <returns></returns>
        public Task<Response> Summary(int taskId);

        /// <summary>
        /// /tasks/screenshots
        /// Returns one or all screenshots associated with the specified task ID.
        /// </summary>
        /// <param name="taskId">ID of the task to get the report for. (required)</param>
        /// <param name="screenshot">Numerical identifier of a single screenshot (e.g. 0001, 0002). (optional)</param>
        public Task<Response<ZipResponse>> ScreenShots(int taskId, int? screenshot = null);

        /// <summary>
        /// /tasks/rereport
        /// Re-run reporting for task associated with the specified task ID.
        /// </summary>
        /// <param name="taskId">ID of the task to re-run report.  (required)</param>
        /// <returns></returns>
        public Task<Response> ReReport(int taskId);

        /// <summary>
        /// /tasks/reboot
        /// Add a reboot task to database from an existing analysis ID.
        /// </summary>
        /// <param name="taskId">ID of the task  (required)</param>
        /// <returns></returns>
        public Task<Response<RebootResponse>> Reboot(int taskId);
    }
}
