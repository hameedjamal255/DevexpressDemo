using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportTestDEvexpress.Configuration;

namespace ReportTestDEvexpress.Web.Startup
{
    [DependsOn(typeof(ReportTestDEvexpressWebCoreModule))]
    public class ReportTestDEvexpressWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReportTestDEvexpressWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ReportTestDEvexpressNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportTestDEvexpressWebMvcModule).GetAssembly());
        }
    }
}
