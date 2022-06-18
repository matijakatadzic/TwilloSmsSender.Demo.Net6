using Twilio.Rest.Api.V2010.Account;
using TwilloSmsSender.Demo.Models.Models.Request;

namespace TwilloSmsSender.Demo.Business.Service.SmsSenderService
{
    public interface ISmsSenderService
    {
        Task<MessageResource> SendSmsAsync(SendSmsRQ sendSmsRQ);
    }
}