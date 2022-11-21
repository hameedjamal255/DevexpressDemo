using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportTestDEvexpress.Configuration;

namespace ReportTestDEvexpress.Web.Host.Startup
{
    [DependsOn(
       typeof(ReportTestDEvexpressWebCoreModule))]
    public class ReportTestDEvexpressWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReportTestDEvexpressWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportTestDEvexpressWebHostModule).GetAssembly());
        }
    }
}
