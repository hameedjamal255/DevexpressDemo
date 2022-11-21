using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportTestDEvexpress.EntityFrameworkCore;
using ReportTestDEvexpress.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ReportTestDEvexpress.Web.Tests
{
    [DependsOn(
        typeof(ReportTestDEvexpressWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ReportTestDEvexpressWebTestModule : AbpModule
    {
        public ReportTestDEvexpressWebTestModule(ReportTestDEvexpressEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportTestDEvexpressWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ReportTestDEvexpressWebMvcModule).Assembly);
        }
    }
}