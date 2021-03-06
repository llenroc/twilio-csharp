using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Message 
{

    /// <summary>
    /// Delete media from your account. Once delete, you will no longer be billed
    /// </summary>
    public class DeleteMediaOptions : IOptions<MediaResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The message_sid
        /// </summary>
        public string PathMessageSid { get; }
        /// <summary>
        /// Delete by unique media Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMediaOptions
        /// </summary>
        ///
        /// <param name="pathMessageSid"> The message_sid </param>
        /// <param name="pathSid"> Delete by unique media Sid </param>
        public DeleteMediaOptions(string pathMessageSid, string pathSid)
        {
            PathMessageSid = pathMessageSid;
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
    /// Fetch a single media instance belonging to the account used to make the request
    /// </summary>
    public class FetchMediaOptions : IOptions<MediaResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The message_sid
        /// </summary>
        public string PathMessageSid { get; }
        /// <summary>
        /// Fetch by unique media Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMediaOptions
        /// </summary>
        ///
        /// <param name="pathMessageSid"> The message_sid </param>
        /// <param name="pathSid"> Fetch by unique media Sid </param>
        public FetchMediaOptions(string pathMessageSid, string pathSid)
        {
            PathMessageSid = pathMessageSid;
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
    /// Retrieve a list of medias belonging to the account used to make the request
    /// </summary>
    public class ReadMediaOptions : ReadOptions<MediaResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The message_sid
        /// </summary>
        public string PathMessageSid { get; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }

        /// <summary>
        /// Construct a new ReadMediaOptions
        /// </summary>
        ///
        /// <param name="pathMessageSid"> The message_sid </param>
        public ReadMediaOptions(string pathMessageSid)
        {
            PathMessageSid = pathMessageSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", Serializers.DateTimeIso8601(DateCreatedBefore)));
                }

                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", Serializers.DateTimeIso8601(DateCreatedAfter)));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}