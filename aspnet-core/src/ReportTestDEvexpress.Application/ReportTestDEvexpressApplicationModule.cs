using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportTestDEvexpress.Authorization;

namespace ReportTestDEvexpress
{
    [DependsOn(
        typeof(ReportTestDEvexpressCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReportTestDEvexpressApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReportTestDEvexpressAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReportTestDEvexpressApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
