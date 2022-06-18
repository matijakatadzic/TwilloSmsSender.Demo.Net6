using Microsoft.AspNetCore.Mvc;
using TwilloSmsSender.Demo.Business.Service.SmsSenderService;
using TwilloSmsSender.Demo.Models.Models.Request;

namespace TwilloSmsSender.Demo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmsController : ControllerBase
    {
        private readonly ILogger<SmsController> _logger;
        private readonly ISmsSenderService _smsService;

        public SmsController(ILogger<SmsController> logger, ISmsSenderService smsService)
        {
            _logger = logger;
            _smsService = smsService;
        }

        /// <summary>
        /// SendSMS
        /// </summary>
        /// <param name="sendSmsRQ"></param>
        /// <returns></returns>
        [HttpPost(Name = "SendSMS")]
        public async Task<IActionResult> SendSMS(SendSmsRQ sendSmsRQ)
        {
            return  Ok(await _smsService.SendSmsAsync(sendSmsRQ));
        }
    }
}