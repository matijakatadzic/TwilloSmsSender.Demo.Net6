using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilloSmsSender.Demo.Models.Settings
{
    public class AppSettings
    {
        public string AccountSid { get; set; }
        public string AuthToken { get; set; }
        public string TwilioSenderNumber { get; set; }
    }
}
