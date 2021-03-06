using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.IpMessaging.V1 
{

    /// <summary>
    /// ServiceResource
    /// </summary>
    public class ServiceResource : Resource 
    {
        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v1/Services",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v1/Services",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ServiceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="defaultServiceRoleSid"> The default_service_role_sid </param>
        /// <param name="defaultChannelRoleSid"> The default_channel_role_sid </param>
        /// <param name="defaultChannelCreatorRoleSid"> The default_channel_creator_role_sid </param>
        /// <param name="readStatusEnabled"> The read_status_enabled </param>
        /// <param name="reachabilityEnabled"> The reachability_enabled </param>
        /// <param name="typingIndicatorTimeout"> The typing_indicator_timeout </param>
        /// <param name="consumptionReportInterval"> The consumption_report_interval </param>
        /// <param name="notificationsNewMessageEnabled"> The notifications.new_message.enabled </param>
        /// <param name="notificationsNewMessageTemplate"> The notifications.new_message.template </param>
        /// <param name="notificationsAddedToChannelEnabled"> The notifications.added_to_channel.enabled </param>
        /// <param name="notificationsAddedToChannelTemplate"> The notifications.added_to_channel.template </param>
        /// <param name="notificationsRemovedFromChannelEnabled"> The notifications.removed_from_channel.enabled </param>
        /// <param name="notificationsRemovedFromChannelTemplate"> The notifications.removed_from_channel.template </param>
        /// <param name="notificationsInvitedToChannelEnabled"> The notifications.invited_to_channel.enabled </param>
        /// <param name="notificationsInvitedToChannelTemplate"> The notifications.invited_to_channel.template </param>
        /// <param name="preWebhookUrl"> The pre_webhook_url </param>
        /// <param name="postWebhookUrl"> The post_webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="webhookFilters"> The webhook_filters </param>
        /// <param name="webhooksOnMessageSendUrl"> The webhooks.on_message_send.url </param>
        /// <param name="webhooksOnMessageSendMethod"> The webhooks.on_message_send.method </param>
        /// <param name="webhooksOnMessageSendFormat"> The webhooks.on_message_send.format </param>
        /// <param name="webhooksOnMessageUpdateUrl"> The webhooks.on_message_update.url </param>
        /// <param name="webhooksOnMessageUpdateMethod"> The webhooks.on_message_update.method </param>
        /// <param name="webhooksOnMessageUpdateFormat"> The webhooks.on_message_update.format </param>
        /// <param name="webhooksOnMessageRemoveUrl"> The webhooks.on_message_remove.url </param>
        /// <param name="webhooksOnMessageRemoveMethod"> The webhooks.on_message_remove.method </param>
        /// <param name="webhooksOnMessageRemoveFormat"> The webhooks.on_message_remove.format </param>
        /// <param name="webhooksOnChannelAddUrl"> The webhooks.on_channel_add.url </param>
        /// <param name="webhooksOnChannelAddMethod"> The webhooks.on_channel_add.method </param>
        /// <param name="webhooksOnChannelAddFormat"> The webhooks.on_channel_add.format </param>
        /// <param name="webhooksOnChannelDestroyUrl"> The webhooks.on_channel_destroy.url </param>
        /// <param name="webhooksOnChannelDestroyMethod"> The webhooks.on_channel_destroy.method </param>
        /// <param name="webhooksOnChannelDestroyFormat"> The webhooks.on_channel_destroy.format </param>
        /// <param name="webhooksOnChannelUpdateUrl"> The webhooks.on_channel_update.url </param>
        /// <param name="webhooksOnChannelUpdateMethod"> The webhooks.on_channel_update.method </param>
        /// <param name="webhooksOnChannelUpdateFormat"> The webhooks.on_channel_update.format </param>
        /// <param name="webhooksOnMemberAddUrl"> The webhooks.on_member_add.url </param>
        /// <param name="webhooksOnMemberAddMethod"> The webhooks.on_member_add.method </param>
        /// <param name="webhooksOnMemberAddFormat"> The webhooks.on_member_add.format </param>
        /// <param name="webhooksOnMemberRemoveUrl"> The webhooks.on_member_remove.url </param>
        /// <param name="webhooksOnMemberRemoveMethod"> The webhooks.on_member_remove.method </param>
        /// <param name="webhooksOnMemberRemoveFormat"> The webhooks.on_member_remove.format </param>
        /// <param name="webhooksOnMessageSentUrl"> The webhooks.on_message_sent.url </param>
        /// <param name="webhooksOnMessageSentMethod"> The webhooks.on_message_sent.method </param>
        /// <param name="webhooksOnMessageSentFormat"> The webhooks.on_message_sent.format </param>
        /// <param name="webhooksOnMessageUpdatedUrl"> The webhooks.on_message_updated.url </param>
        /// <param name="webhooksOnMessageUpdatedMethod"> The webhooks.on_message_updated.method </param>
        /// <param name="webhooksOnMessageUpdatedFormat"> The webhooks.on_message_updated.format </param>
        /// <param name="webhooksOnMessageRemovedUrl"> The webhooks.on_message_removed.url </param>
        /// <param name="webhooksOnMessageRemovedMethod"> The webhooks.on_message_removed.method </param>
        /// <param name="webhooksOnMessageRemovedFormat"> The webhooks.on_message_removed.format </param>
        /// <param name="webhooksOnChannelAddedUrl"> The webhooks.on_channel_added.url </param>
        /// <param name="webhooksOnChannelAddedMethod"> The webhooks.on_channel_added.method </param>
        /// <param name="webhooksOnChannelAddedFormat"> The webhooks.on_channel_added.format </param>
        /// <param name="webhooksOnChannelDestroyedUrl"> The webhooks.on_channel_destroyed.url </param>
        /// <param name="webhooksOnChannelDestroyedMethod"> The webhooks.on_channel_destroyed.method </param>
        /// <param name="webhooksOnChannelDestroyedFormat"> The webhooks.on_channel_destroyed.format </param>
        /// <param name="webhooksOnChannelUpdatedUrl"> The webhooks.on_channel_updated.url </param>
        /// <param name="webhooksOnChannelUpdatedMethod"> The webhooks.on_channel_updated.method </param>
        /// <param name="webhooksOnChannelUpdatedFormat"> The webhooks.on_channel_updated.format </param>
        /// <param name="webhooksOnMemberAddedUrl"> The webhooks.on_member_added.url </param>
        /// <param name="webhooksOnMemberAddedMethod"> The webhooks.on_member_added.method </param>
        /// <param name="webhooksOnMemberAddedFormat"> The webhooks.on_member_added.format </param>
        /// <param name="webhooksOnMemberRemovedUrl"> The webhooks.on_member_removed.url </param>
        /// <param name="webhooksOnMemberRemovedMethod"> The webhooks.on_member_removed.method </param>
        /// <param name="webhooksOnMemberRemovedFormat"> The webhooks.on_member_removed.format </param>
        /// <param name="limitsChannelMembers"> The limits.channel_members </param>
        /// <param name="limitsUserChannels"> The limits.user_channels </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(string pathSid, string friendlyName = null, string defaultServiceRoleSid = null, string defaultChannelRoleSid = null, string defaultChannelCreatorRoleSid = null, bool? readStatusEnabled = null, bool? reachabilityEnabled = null, int? typingIndicatorTimeout = null, int? consumptionReportInterval = null, bool? notificationsNewMessageEnabled = null, string notificationsNewMessageTemplate = null, bool? notificationsAddedToChannelEnabled = null, string notificationsAddedToChannelTemplate = null, bool? notificationsRemovedFromChannelEnabled = null, string notificationsRemovedFromChannelTemplate = null, bool? notificationsInvitedToChannelEnabled = null, string notificationsInvitedToChannelTemplate = null, Uri preWebhookUrl = null, Uri postWebhookUrl = null, Twilio.Http.HttpMethod webhookMethod = null, List<string> webhookFilters = null, Uri webhooksOnMessageSendUrl = null, Twilio.Http.HttpMethod webhooksOnMessageSendMethod = null, string webhooksOnMessageSendFormat = null, Uri webhooksOnMessageUpdateUrl = null, Twilio.Http.HttpMethod webhooksOnMessageUpdateMethod = null, string webhooksOnMessageUpdateFormat = null, Uri webhooksOnMessageRemoveUrl = null, Twilio.Http.HttpMethod webhooksOnMessageRemoveMethod = null, string webhooksOnMessageRemoveFormat = null, Uri webhooksOnChannelAddUrl = null, Twilio.Http.HttpMethod webhooksOnChannelAddMethod = null, string webhooksOnChannelAddFormat = null, Uri webhooksOnChannelDestroyUrl = null, Twilio.Http.HttpMethod webhooksOnChannelDestroyMethod = null, string webhooksOnChannelDestroyFormat = null, Uri webhooksOnChannelUpdateUrl = null, Twilio.Http.HttpMethod webhooksOnChannelUpdateMethod = null, string webhooksOnChannelUpdateFormat = null, Uri webhooksOnMemberAddUrl = null, Twilio.Http.HttpMethod webhooksOnMemberAddMethod = null, string webhooksOnMemberAddFormat = null, Uri webhooksOnMemberRemoveUrl = null, Twilio.Http.HttpMethod webhooksOnMemberRemoveMethod = null, string webhooksOnMemberRemoveFormat = null, Uri webhooksOnMessageSentUrl = null, Twilio.Http.HttpMethod webhooksOnMessageSentMethod = null, string webhooksOnMessageSentFormat = null, Uri webhooksOnMessageUpdatedUrl = null, Twilio.Http.HttpMethod webhooksOnMessageUpdatedMethod = null, string webhooksOnMessageUpdatedFormat = null, Uri webhooksOnMessageRemovedUrl = null, Twilio.Http.HttpMethod webhooksOnMessageRemovedMethod = null, string webhooksOnMessageRemovedFormat = null, Uri webhooksOnChannelAddedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelAddedMethod = null, string webhooksOnChannelAddedFormat = null, Uri webhooksOnChannelDestroyedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelDestroyedMethod = null, string webhooksOnChannelDestroyedFormat = null, Uri webhooksOnChannelUpdatedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelUpdatedMethod = null, string webhooksOnChannelUpdatedFormat = null, Uri webhooksOnMemberAddedUrl = null, Twilio.Http.HttpMethod webhooksOnMemberAddedMethod = null, string webhooksOnMemberAddedFormat = null, Uri webhooksOnMemberRemovedUrl = null, Twilio.Http.HttpMethod webhooksOnMemberRemovedMethod = null, string webhooksOnMemberRemovedFormat = null, int? limitsChannelMembers = null, int? limitsUserChannels = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, WebhooksOnMessageSendUrl = webhooksOnMessageSendUrl, WebhooksOnMessageSendMethod = webhooksOnMessageSendMethod, WebhooksOnMessageSendFormat = webhooksOnMessageSendFormat, WebhooksOnMessageUpdateUrl = webhooksOnMessageUpdateUrl, WebhooksOnMessageUpdateMethod = webhooksOnMessageUpdateMethod, WebhooksOnMessageUpdateFormat = webhooksOnMessageUpdateFormat, WebhooksOnMessageRemoveUrl = webhooksOnMessageRemoveUrl, WebhooksOnMessageRemoveMethod = webhooksOnMessageRemoveMethod, WebhooksOnMessageRemoveFormat = webhooksOnMessageRemoveFormat, WebhooksOnChannelAddUrl = webhooksOnChannelAddUrl, WebhooksOnChannelAddMethod = webhooksOnChannelAddMethod, WebhooksOnChannelAddFormat = webhooksOnChannelAddFormat, WebhooksOnChannelDestroyUrl = webhooksOnChannelDestroyUrl, WebhooksOnChannelDestroyMethod = webhooksOnChannelDestroyMethod, WebhooksOnChannelDestroyFormat = webhooksOnChannelDestroyFormat, WebhooksOnChannelUpdateUrl = webhooksOnChannelUpdateUrl, WebhooksOnChannelUpdateMethod = webhooksOnChannelUpdateMethod, WebhooksOnChannelUpdateFormat = webhooksOnChannelUpdateFormat, WebhooksOnMemberAddUrl = webhooksOnMemberAddUrl, WebhooksOnMemberAddMethod = webhooksOnMemberAddMethod, WebhooksOnMemberAddFormat = webhooksOnMemberAddFormat, WebhooksOnMemberRemoveUrl = webhooksOnMemberRemoveUrl, WebhooksOnMemberRemoveMethod = webhooksOnMemberRemoveMethod, WebhooksOnMemberRemoveFormat = webhooksOnMemberRemoveFormat, WebhooksOnMessageSentUrl = webhooksOnMessageSentUrl, WebhooksOnMessageSentMethod = webhooksOnMessageSentMethod, WebhooksOnMessageSentFormat = webhooksOnMessageSentFormat, WebhooksOnMessageUpdatedUrl = webhooksOnMessageUpdatedUrl, WebhooksOnMessageUpdatedMethod = webhooksOnMessageUpdatedMethod, WebhooksOnMessageUpdatedFormat = webhooksOnMessageUpdatedFormat, WebhooksOnMessageRemovedUrl = webhooksOnMessageRemovedUrl, WebhooksOnMessageRemovedMethod = webhooksOnMessageRemovedMethod, WebhooksOnMessageRemovedFormat = webhooksOnMessageRemovedFormat, WebhooksOnChannelAddedUrl = webhooksOnChannelAddedUrl, WebhooksOnChannelAddedMethod = webhooksOnChannelAddedMethod, WebhooksOnChannelAddedFormat = webhooksOnChannelAddedFormat, WebhooksOnChannelDestroyedUrl = webhooksOnChannelDestroyedUrl, WebhooksOnChannelDestroyedMethod = webhooksOnChannelDestroyedMethod, WebhooksOnChannelDestroyedFormat = webhooksOnChannelDestroyedFormat, WebhooksOnChannelUpdatedUrl = webhooksOnChannelUpdatedUrl, WebhooksOnChannelUpdatedMethod = webhooksOnChannelUpdatedMethod, WebhooksOnChannelUpdatedFormat = webhooksOnChannelUpdatedFormat, WebhooksOnMemberAddedUrl = webhooksOnMemberAddedUrl, WebhooksOnMemberAddedMethod = webhooksOnMemberAddedMethod, WebhooksOnMemberAddedFormat = webhooksOnMemberAddedFormat, WebhooksOnMemberRemovedUrl = webhooksOnMemberRemovedUrl, WebhooksOnMemberRemovedMethod = webhooksOnMemberRemovedMethod, WebhooksOnMemberRemovedFormat = webhooksOnMemberRemovedFormat, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="defaultServiceRoleSid"> The default_service_role_sid </param>
        /// <param name="defaultChannelRoleSid"> The default_channel_role_sid </param>
        /// <param name="defaultChannelCreatorRoleSid"> The default_channel_creator_role_sid </param>
        /// <param name="readStatusEnabled"> The read_status_enabled </param>
        /// <param name="reachabilityEnabled"> The reachability_enabled </param>
        /// <param name="typingIndicatorTimeout"> The typing_indicator_timeout </param>
        /// <param name="consumptionReportInterval"> The consumption_report_interval </param>
        /// <param name="notificationsNewMessageEnabled"> The notifications.new_message.enabled </param>
        /// <param name="notificationsNewMessageTemplate"> The notifications.new_message.template </param>
        /// <param name="notificationsAddedToChannelEnabled"> The notifications.added_to_channel.enabled </param>
        /// <param name="notificationsAddedToChannelTemplate"> The notifications.added_to_channel.template </param>
        /// <param name="notificationsRemovedFromChannelEnabled"> The notifications.removed_from_channel.enabled </param>
        /// <param name="notificationsRemovedFromChannelTemplate"> The notifications.removed_from_channel.template </param>
        /// <param name="notificationsInvitedToChannelEnabled"> The notifications.invited_to_channel.enabled </param>
        /// <param name="notificationsInvitedToChannelTemplate"> The notifications.invited_to_channel.template </param>
        /// <param name="preWebhookUrl"> The pre_webhook_url </param>
        /// <param name="postWebhookUrl"> The post_webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="webhookFilters"> The webhook_filters </param>
        /// <param name="webhooksOnMessageSendUrl"> The webhooks.on_message_send.url </param>
        /// <param name="webhooksOnMessageSendMethod"> The webhooks.on_message_send.method </param>
        /// <param name="webhooksOnMessageSendFormat"> The webhooks.on_message_send.format </param>
        /// <param name="webhooksOnMessageUpdateUrl"> The webhooks.on_message_update.url </param>
        /// <param name="webhooksOnMessageUpdateMethod"> The webhooks.on_message_update.method </param>
        /// <param name="webhooksOnMessageUpdateFormat"> The webhooks.on_message_update.format </param>
        /// <param name="webhooksOnMessageRemoveUrl"> The webhooks.on_message_remove.url </param>
        /// <param name="webhooksOnMessageRemoveMethod"> The webhooks.on_message_remove.method </param>
        /// <param name="webhooksOnMessageRemoveFormat"> The webhooks.on_message_remove.format </param>
        /// <param name="webhooksOnChannelAddUrl"> The webhooks.on_channel_add.url </param>
        /// <param name="webhooksOnChannelAddMethod"> The webhooks.on_channel_add.method </param>
        /// <param name="webhooksOnChannelAddFormat"> The webhooks.on_channel_add.format </param>
        /// <param name="webhooksOnChannelDestroyUrl"> The webhooks.on_channel_destroy.url </param>
        /// <param name="webhooksOnChannelDestroyMethod"> The webhooks.on_channel_destroy.method </param>
        /// <param name="webhooksOnChannelDestroyFormat"> The webhooks.on_channel_destroy.format </param>
        /// <param name="webhooksOnChannelUpdateUrl"> The webhooks.on_channel_update.url </param>
        /// <param name="webhooksOnChannelUpdateMethod"> The webhooks.on_channel_update.method </param>
        /// <param name="webhooksOnChannelUpdateFormat"> The webhooks.on_channel_update.format </param>
        /// <param name="webhooksOnMemberAddUrl"> The webhooks.on_member_add.url </param>
        /// <param name="webhooksOnMemberAddMethod"> The webhooks.on_member_add.method </param>
        /// <param name="webhooksOnMemberAddFormat"> The webhooks.on_member_add.format </param>
        /// <param name="webhooksOnMemberRemoveUrl"> The webhooks.on_member_remove.url </param>
        /// <param name="webhooksOnMemberRemoveMethod"> The webhooks.on_member_remove.method </param>
        /// <param name="webhooksOnMemberRemoveFormat"> The webhooks.on_member_remove.format </param>
        /// <param name="webhooksOnMessageSentUrl"> The webhooks.on_message_sent.url </param>
        /// <param name="webhooksOnMessageSentMethod"> The webhooks.on_message_sent.method </param>
        /// <param name="webhooksOnMessageSentFormat"> The webhooks.on_message_sent.format </param>
        /// <param name="webhooksOnMessageUpdatedUrl"> The webhooks.on_message_updated.url </param>
        /// <param name="webhooksOnMessageUpdatedMethod"> The webhooks.on_message_updated.method </param>
        /// <param name="webhooksOnMessageUpdatedFormat"> The webhooks.on_message_updated.format </param>
        /// <param name="webhooksOnMessageRemovedUrl"> The webhooks.on_message_removed.url </param>
        /// <param name="webhooksOnMessageRemovedMethod"> The webhooks.on_message_removed.method </param>
        /// <param name="webhooksOnMessageRemovedFormat"> The webhooks.on_message_removed.format </param>
        /// <param name="webhooksOnChannelAddedUrl"> The webhooks.on_channel_added.url </param>
        /// <param name="webhooksOnChannelAddedMethod"> The webhooks.on_channel_added.method </param>
        /// <param name="webhooksOnChannelAddedFormat"> The webhooks.on_channel_added.format </param>
        /// <param name="webhooksOnChannelDestroyedUrl"> The webhooks.on_channel_destroyed.url </param>
        /// <param name="webhooksOnChannelDestroyedMethod"> The webhooks.on_channel_destroyed.method </param>
        /// <param name="webhooksOnChannelDestroyedFormat"> The webhooks.on_channel_destroyed.format </param>
        /// <param name="webhooksOnChannelUpdatedUrl"> The webhooks.on_channel_updated.url </param>
        /// <param name="webhooksOnChannelUpdatedMethod"> The webhooks.on_channel_updated.method </param>
        /// <param name="webhooksOnChannelUpdatedFormat"> The webhooks.on_channel_updated.format </param>
        /// <param name="webhooksOnMemberAddedUrl"> The webhooks.on_member_added.url </param>
        /// <param name="webhooksOnMemberAddedMethod"> The webhooks.on_member_added.method </param>
        /// <param name="webhooksOnMemberAddedFormat"> The webhooks.on_member_added.format </param>
        /// <param name="webhooksOnMemberRemovedUrl"> The webhooks.on_member_removed.url </param>
        /// <param name="webhooksOnMemberRemovedMethod"> The webhooks.on_member_removed.method </param>
        /// <param name="webhooksOnMemberRemovedFormat"> The webhooks.on_member_removed.format </param>
        /// <param name="limitsChannelMembers"> The limits.channel_members </param>
        /// <param name="limitsUserChannels"> The limits.user_channels </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(string pathSid, string friendlyName = null, string defaultServiceRoleSid = null, string defaultChannelRoleSid = null, string defaultChannelCreatorRoleSid = null, bool? readStatusEnabled = null, bool? reachabilityEnabled = null, int? typingIndicatorTimeout = null, int? consumptionReportInterval = null, bool? notificationsNewMessageEnabled = null, string notificationsNewMessageTemplate = null, bool? notificationsAddedToChannelEnabled = null, string notificationsAddedToChannelTemplate = null, bool? notificationsRemovedFromChannelEnabled = null, string notificationsRemovedFromChannelTemplate = null, bool? notificationsInvitedToChannelEnabled = null, string notificationsInvitedToChannelTemplate = null, Uri preWebhookUrl = null, Uri postWebhookUrl = null, Twilio.Http.HttpMethod webhookMethod = null, List<string> webhookFilters = null, Uri webhooksOnMessageSendUrl = null, Twilio.Http.HttpMethod webhooksOnMessageSendMethod = null, string webhooksOnMessageSendFormat = null, Uri webhooksOnMessageUpdateUrl = null, Twilio.Http.HttpMethod webhooksOnMessageUpdateMethod = null, string webhooksOnMessageUpdateFormat = null, Uri webhooksOnMessageRemoveUrl = null, Twilio.Http.HttpMethod webhooksOnMessageRemoveMethod = null, string webhooksOnMessageRemoveFormat = null, Uri webhooksOnChannelAddUrl = null, Twilio.Http.HttpMethod webhooksOnChannelAddMethod = null, string webhooksOnChannelAddFormat = null, Uri webhooksOnChannelDestroyUrl = null, Twilio.Http.HttpMethod webhooksOnChannelDestroyMethod = null, string webhooksOnChannelDestroyFormat = null, Uri webhooksOnChannelUpdateUrl = null, Twilio.Http.HttpMethod webhooksOnChannelUpdateMethod = null, string webhooksOnChannelUpdateFormat = null, Uri webhooksOnMemberAddUrl = null, Twilio.Http.HttpMethod webhooksOnMemberAddMethod = null, string webhooksOnMemberAddFormat = null, Uri webhooksOnMemberRemoveUrl = null, Twilio.Http.HttpMethod webhooksOnMemberRemoveMethod = null, string webhooksOnMemberRemoveFormat = null, Uri webhooksOnMessageSentUrl = null, Twilio.Http.HttpMethod webhooksOnMessageSentMethod = null, string webhooksOnMessageSentFormat = null, Uri webhooksOnMessageUpdatedUrl = null, Twilio.Http.HttpMethod webhooksOnMessageUpdatedMethod = null, string webhooksOnMessageUpdatedFormat = null, Uri webhooksOnMessageRemovedUrl = null, Twilio.Http.HttpMethod webhooksOnMessageRemovedMethod = null, string webhooksOnMessageRemovedFormat = null, Uri webhooksOnChannelAddedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelAddedMethod = null, string webhooksOnChannelAddedFormat = null, Uri webhooksOnChannelDestroyedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelDestroyedMethod = null, string webhooksOnChannelDestroyedFormat = null, Uri webhooksOnChannelUpdatedUrl = null, Twilio.Http.HttpMethod webhooksOnChannelUpdatedMethod = null, string webhooksOnChannelUpdatedFormat = null, Uri webhooksOnMemberAddedUrl = null, Twilio.Http.HttpMethod webhooksOnMemberAddedMethod = null, string webhooksOnMemberAddedFormat = null, Uri webhooksOnMemberRemovedUrl = null, Twilio.Http.HttpMethod webhooksOnMemberRemovedMethod = null, string webhooksOnMemberRemovedFormat = null, int? limitsChannelMembers = null, int? limitsUserChannels = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, WebhooksOnMessageSendUrl = webhooksOnMessageSendUrl, WebhooksOnMessageSendMethod = webhooksOnMessageSendMethod, WebhooksOnMessageSendFormat = webhooksOnMessageSendFormat, WebhooksOnMessageUpdateUrl = webhooksOnMessageUpdateUrl, WebhooksOnMessageUpdateMethod = webhooksOnMessageUpdateMethod, WebhooksOnMessageUpdateFormat = webhooksOnMessageUpdateFormat, WebhooksOnMessageRemoveUrl = webhooksOnMessageRemoveUrl, WebhooksOnMessageRemoveMethod = webhooksOnMessageRemoveMethod, WebhooksOnMessageRemoveFormat = webhooksOnMessageRemoveFormat, WebhooksOnChannelAddUrl = webhooksOnChannelAddUrl, WebhooksOnChannelAddMethod = webhooksOnChannelAddMethod, WebhooksOnChannelAddFormat = webhooksOnChannelAddFormat, WebhooksOnChannelDestroyUrl = webhooksOnChannelDestroyUrl, WebhooksOnChannelDestroyMethod = webhooksOnChannelDestroyMethod, WebhooksOnChannelDestroyFormat = webhooksOnChannelDestroyFormat, WebhooksOnChannelUpdateUrl = webhooksOnChannelUpdateUrl, WebhooksOnChannelUpdateMethod = webhooksOnChannelUpdateMethod, WebhooksOnChannelUpdateFormat = webhooksOnChannelUpdateFormat, WebhooksOnMemberAddUrl = webhooksOnMemberAddUrl, WebhooksOnMemberAddMethod = webhooksOnMemberAddMethod, WebhooksOnMemberAddFormat = webhooksOnMemberAddFormat, WebhooksOnMemberRemoveUrl = webhooksOnMemberRemoveUrl, WebhooksOnMemberRemoveMethod = webhooksOnMemberRemoveMethod, WebhooksOnMemberRemoveFormat = webhooksOnMemberRemoveFormat, WebhooksOnMessageSentUrl = webhooksOnMessageSentUrl, WebhooksOnMessageSentMethod = webhooksOnMessageSentMethod, WebhooksOnMessageSentFormat = webhooksOnMessageSentFormat, WebhooksOnMessageUpdatedUrl = webhooksOnMessageUpdatedUrl, WebhooksOnMessageUpdatedMethod = webhooksOnMessageUpdatedMethod, WebhooksOnMessageUpdatedFormat = webhooksOnMessageUpdatedFormat, WebhooksOnMessageRemovedUrl = webhooksOnMessageRemovedUrl, WebhooksOnMessageRemovedMethod = webhooksOnMessageRemovedMethod, WebhooksOnMessageRemovedFormat = webhooksOnMessageRemovedFormat, WebhooksOnChannelAddedUrl = webhooksOnChannelAddedUrl, WebhooksOnChannelAddedMethod = webhooksOnChannelAddedMethod, WebhooksOnChannelAddedFormat = webhooksOnChannelAddedFormat, WebhooksOnChannelDestroyedUrl = webhooksOnChannelDestroyedUrl, WebhooksOnChannelDestroyedMethod = webhooksOnChannelDestroyedMethod, WebhooksOnChannelDestroyedFormat = webhooksOnChannelDestroyedFormat, WebhooksOnChannelUpdatedUrl = webhooksOnChannelUpdatedUrl, WebhooksOnChannelUpdatedMethod = webhooksOnChannelUpdatedMethod, WebhooksOnChannelUpdatedFormat = webhooksOnChannelUpdatedFormat, WebhooksOnMemberAddedUrl = webhooksOnMemberAddedUrl, WebhooksOnMemberAddedMethod = webhooksOnMemberAddedMethod, WebhooksOnMemberAddedFormat = webhooksOnMemberAddedFormat, WebhooksOnMemberRemovedUrl = webhooksOnMemberRemovedUrl, WebhooksOnMemberRemovedMethod = webhooksOnMemberRemovedMethod, WebhooksOnMemberRemovedFormat = webhooksOnMemberRemovedFormat, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns> 
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The default_service_role_sid
        /// </summary>
        [JsonProperty("default_service_role_sid")]
        public string DefaultServiceRoleSid { get; private set; }
        /// <summary>
        /// The default_channel_role_sid
        /// </summary>
        [JsonProperty("default_channel_role_sid")]
        public string DefaultChannelRoleSid { get; private set; }
        /// <summary>
        /// The default_channel_creator_role_sid
        /// </summary>
        [JsonProperty("default_channel_creator_role_sid")]
        public string DefaultChannelCreatorRoleSid { get; private set; }
        /// <summary>
        /// The read_status_enabled
        /// </summary>
        [JsonProperty("read_status_enabled")]
        public bool? ReadStatusEnabled { get; private set; }
        /// <summary>
        /// The reachability_enabled
        /// </summary>
        [JsonProperty("reachability_enabled")]
        public bool? ReachabilityEnabled { get; private set; }
        /// <summary>
        /// The typing_indicator_timeout
        /// </summary>
        [JsonProperty("typing_indicator_timeout")]
        public int? TypingIndicatorTimeout { get; private set; }
        /// <summary>
        /// The consumption_report_interval
        /// </summary>
        [JsonProperty("consumption_report_interval")]
        public int? ConsumptionReportInterval { get; private set; }
        /// <summary>
        /// The limits
        /// </summary>
        [JsonProperty("limits")]
        public object Limits { get; private set; }
        /// <summary>
        /// The webhooks
        /// </summary>
        [JsonProperty("webhooks")]
        public object Webhooks { get; private set; }
        /// <summary>
        /// The pre_webhook_url
        /// </summary>
        [JsonProperty("pre_webhook_url")]
        public string PreWebhookUrl { get; private set; }
        /// <summary>
        /// The post_webhook_url
        /// </summary>
        [JsonProperty("post_webhook_url")]
        public string PostWebhookUrl { get; private set; }
        /// <summary>
        /// The webhook_method
        /// </summary>
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }
        /// <summary>
        /// The webhook_filters
        /// </summary>
        [JsonProperty("webhook_filters")]
        public List<string> WebhookFilters { get; private set; }
        /// <summary>
        /// The notifications
        /// </summary>
        [JsonProperty("notifications")]
        public object Notifications { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ServiceResource()
        {

        }
    }

}