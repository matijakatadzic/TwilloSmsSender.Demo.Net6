using Microsoft.Extensions.Options;
using System;
using TwilloSmsSender.Demo.Models.Settings;

namespace TwilloSmsSender.Demo.Business.Service.AppSettingAdapters
{
    public class AppSettingsAdapter : IAppSettingsAdapter
    {
        private readonly IOptions<AppSettings> _options;

        public AppSettings AppSettings => _options.Value;

        public AppSettingsAdapter(IOptions<AppSettings> options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options), "Options cannot be null. Please check your appsettings.json.");
        }
    }
}