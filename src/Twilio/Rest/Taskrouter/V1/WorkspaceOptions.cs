using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1 
{

    /// <summary>
    /// FetchWorkspaceOptions
    /// </summary>
    public class FetchWorkspaceOptions : IOptions<WorkspaceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchWorkspaceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchWorkspaceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateWorkspaceOptions
    /// </summary>
    public class UpdateWorkspaceOptions : IOptions<WorkspaceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The default_activity_sid
        /// </summary>
        public string DefaultActivitySid { get; set; }
        /// <summary>
        /// The event_callback_url
        /// </summary>
        public Uri EventCallbackUrl { get; set; }
        /// <summary>
        /// The events_filter
        /// </summary>
        public string EventsFilter { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The multi_task_enabled
        /// </summary>
        public bool? MultiTaskEnabled { get; set; }
        /// <summary>
        /// The timeout_activity_sid
        /// </summary>
        public string TimeoutActivitySid { get; set; }
        /// <summary>
        /// The prioritize_queue_order
        /// </summary>
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; set; }

        /// <summary>
        /// Construct a new UpdateWorkspaceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateWorkspaceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DefaultActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultActivitySid", DefaultActivitySid.ToString()));
            }

            if (EventCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("EventCallbackUrl", EventCallbackUrl.AbsoluteUri));
            }

            if (EventsFilter != null)
            {
                p.Add(new KeyValuePair<string, string>("EventsFilter", EventsFilter));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (MultiTaskEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MultiTaskEnabled", MultiTaskEnabled.Value.ToString()));
            }

            if (TimeoutActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("TimeoutActivitySid", TimeoutActivitySid.ToString()));
            }

            if (PrioritizeQueueOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("PrioritizeQueueOrder", PrioritizeQueueOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadWorkspaceOptions
    /// </summary>
    public class ReadWorkspaceOptions : ReadOptions<WorkspaceResource> 
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateWorkspaceOptions
    /// </summary>
    public class CreateWorkspaceOptions : IOptions<WorkspaceResource> 
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The event_callback_url
        /// </summary>
        public Uri EventCallbackUrl { get; set; }
        /// <summary>
        /// The events_filter
        /// </summary>
        public string EventsFilter { get; set; }
        /// <summary>
        /// The multi_task_enabled
        /// </summary>
        public bool? MultiTaskEnabled { get; set; }
        /// <summary>
        /// The template
        /// </summary>
        public string Template { get; set; }
        /// <summary>
        /// The prioritize_queue_order
        /// </summary>
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; set; }

        /// <summary>
        /// Construct a new CreateWorkspaceOptions
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        public CreateWorkspaceOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (EventCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("EventCallbackUrl", EventCallbackUrl.AbsoluteUri));
            }

            if (EventsFilter != null)
            {
                p.Add(new KeyValuePair<string, string>("EventsFilter", EventsFilter));
            }

            if (MultiTaskEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MultiTaskEnabled", MultiTaskEnabled.Value.ToString()));
            }

            if (Template != null)
            {
                p.Add(new KeyValuePair<string, string>("Template", Template));
            }

            if (PrioritizeQueueOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("PrioritizeQueueOrder", PrioritizeQueueOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteWorkspaceOptions
    /// </summary>
    public class DeleteWorkspaceOptions : IOptions<WorkspaceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteWorkspaceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeleteWorkspaceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}