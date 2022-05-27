using Cuckoo.Net.Enums;

namespace Cuckoo.Net.RequestsModel
{
    public abstract class SubimtRequest<T> where T : class
    {
        /// <summary>
        ///  sample (multipart encoded file content)
        /// </summary>
        public readonly T Sample;
        /// <summary>
        /// analysis package to be used for the analysis
        /// </summary>
        public string? Package { get; set; }
        /// <summary>
        /// analysis timeout (in seconds)
        /// </summary>
        public int? TimeOut { get; set; }
        /// <summary>
        /// priority to assign to the task (1-3)
        /// </summary>
        public Priority? Priority { get; set; }
        /// <summary>
        /// options to pass to the analysis package
        /// </summary>
        public string? Options { get; set; }
        /// <summary>
        ///  label of the analysis machine to use for the analysis
        /// </summary>
        public string? Machine { get; set; }
        /// <summary>
        /// name of the platform to select the analysis machine from (e.g. “windows”)
        /// </summary>
        public string? Platform { get; set; }
        /// <summary>
        /// define machine to start by tags. Platform must be set to use that. Tags are comma separated
        /// </summary>
        public string[]? Tags { get; set; }
        /// <summary>
        /// custom string to pass over the analysis and the processing/reporting modules
        /// </summary>
        public string? Custom { get; set; }
        /// <summary>
        /// task owner in case multiple users can submit files to the same cuckoo instance
        /// </summary>
        public string? Owner { get; set; }
        /// <summary>
        /// set virtual machine clock (format %m-%d-%Y %H:%M:%S)
        /// </summary>
        public string? Clock { get; set; }
        /// <summary>
        ///  enable the creation of a full memory dump of the analysis machine
        /// </summary>
        public bool? Memory { get; set; }
        /// <summary>
        ///  only submit samples that have not been analyzed before
        /// </summary>
        public bool? Unique { get; set; }
        /// <summary>
        /// enable to enforce the execution for the full timeout value
        /// </summary>
        public bool? EnforceTimeout { get; set; }

        /// <summary>
        /// Adds a file to the list of pending tasks. Returns the ID of the newly created task.
        /// </summary>
        /// <param name="file">Sample file (multipart encoded file content)</param>
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
        protected SubimtRequest(T sample,
            string? package = null, int? timeOut = null, Priority? priority = null,
            string? options = null, string? machine = null, string? platform = null,
            string[]? tags = null, string? custom = null, string? owner = null,
            string? clock = null, bool? memory = null, bool? unique = null,
            bool? enforceTimeout = null)
        {
            Sample = sample;
            Package = package;
            TimeOut = timeOut;
            Priority = priority;
            Options = options;
            Machine = machine;
            Platform = platform;
            Tags = tags;
            Custom = custom;
            Owner = owner;
            Clock = clock;
            Memory = memory;
            Unique = unique;
            EnforceTimeout = enforceTimeout;
        }
        protected SubimtRequest() { }
        public abstract MultipartFormDataContent GetContent();

        protected MultipartFormDataContent AddParameters(MultipartFormDataContent multi)
        {
            var parameters = new Dictionary<string, string>();
            if (Package is not null)
            {
                parameters.Add("package", Package);
            }

            if (TimeOut is not null)
            {
                parameters.Add("timeout", TimeOut.Value.ToString());
            }

            if (Priority is not null)
            {
                parameters.Add("priority", ((int)Priority.Value).ToString());
            }

            if (Options is not null)
            {
                parameters.Add("options", Options);
            }

            if (Machine is not null)
            {
                parameters.Add("machine", Machine);
            }

            if (Platform is not null)
            {
                parameters.Add("platform", Platform);
            }

            if (Tags is not null)
            {
                parameters.Add("tags", string.Join(",", Tags));
            }

            if (Custom is not null)
            {
                parameters.Add("custom", Custom);
            }

            if (Owner is not null)
            {
                parameters.Add("owner", Owner);
            }

            if (Clock is not null)
            {
                parameters.Add("clock", Clock);
            }

            if (Memory is not null)
            {
                parameters.Add("memory", Memory.Value ? "true" : "false");
            }

            if (Unique is not null)
            {
                parameters.Add("unique", Unique.Value ? "true" : "false");
            }

            if (EnforceTimeout is not null)
            {
                parameters.Add("enforce_timeout", EnforceTimeout.Value ? "true" : "false");
            }

            if (parameters.Any())
                multi.Add(new FormUrlEncodedContent(parameters));
            return multi;
        }
    }
}
