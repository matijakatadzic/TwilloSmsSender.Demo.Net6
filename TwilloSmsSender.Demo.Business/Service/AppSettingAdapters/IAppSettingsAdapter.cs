using TwilloSmsSender.Demo.Models.Settings;

namespace TwilloSmsSender.Demo.Business.Service.AppSettingAdapters
{
    public interface IAppSettingsAdapter
    {
        AppSettings AppSettings { get; }
    }
}