using Microsoft.Extensions.DependencyInjection;
using TwilloSmsSender.Demo.Business.Service.AppSettingAdapters;
using TwilloSmsSender.Demo.Business.Service.SmsSenderService;

namespace TwilloSmsSender.Demo.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddSingleton<IAppSettingsAdapter, AppSettingsAdapter>();
            services.AddScoped<ISmsSenderService, SmsSenderService>();
        }
    }
}