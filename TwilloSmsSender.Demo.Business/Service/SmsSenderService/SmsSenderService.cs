using Twilio;
using Twilio.Rest.Api.V2010.Account;
using TwilloSmsSender.Demo.Business.Service.AppSettingAdapters;
using TwilloSmsSender.Demo.Models.Models.Request;

namespace TwilloSmsSender.Demo.Business.Service.SmsSenderService
{
    public class SmsSenderService : ISmsSenderService
    {
        private readonly IAppSettingsAdapter _configuration;

        public SmsSenderService(IAppSettingsAdapter configuration)
        {
            _configuration = configuration;
        }

        public async Task<MessageResource> SendSmsAsync(SendSmsRQ sendSmsRQ)
        {
            TwilioClient.Init(_configuration.AppSettings.AccountSid, _configuration.AppSettings.AuthToken);
            var message = await MessageResource.CreateAsync(
                                                    body: sendSmsRQ.Text,
                                                    from: new Twilio.Types.PhoneNumber(_configuration.AppSettings.TwilioSenderNumber),
                                                    to: new Twilio.Types.PhoneNumber(sendSmsRQ.Number)
                                                );
            return message;
        }
    }
}
