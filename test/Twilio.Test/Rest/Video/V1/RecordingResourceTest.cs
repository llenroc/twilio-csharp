using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Video.V1;

namespace Twilio.Tests.Rest.Video.V1 
{

    [TestFixture]
    public class RecordingTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RecordingResource.Fetch("RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"processing\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_sid\": \"MTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"size\": 0,\"url\": \"https://video.twilio.com/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"audio\",\"duration\": 0,\"container_format\": \"mka\",\"codec\": \"OPUS\",\"grouping_sids\": {\"room_sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"links\": {\"media\": \"https://video.twilio.com/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Media\"}}"
                                     ));

            var response = RecordingResource.Fetch("RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Recordings",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RecordingResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"recordings\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://video.twilio.com/v1/Recordings?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://video.twilio.com/v1/Recordings?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"recordings\"}}"
                                     ));

            var response = RecordingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadResultsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"recordings\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"completed\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_sid\": \"MTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"size\": 23,\"type\": \"audio\",\"duration\": 10,\"container_format\": \"mka\",\"codec\": \"OPUS\",\"grouping_sids\": {\"room_sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"participant_sid\": \"PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"url\": \"https://video.twilio.com/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"media\": \"https://video.twilio.com/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Media\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://video.twilio.com/v1/Recordings?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://video.twilio.com/v1/Recordings?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"recordings\"}}"
                                     ));

            var response = RecordingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Video,
                "/v1/Recordings/RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RecordingResource.Delete("RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = RecordingResource.Delete("RTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}