using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportTestDEvexpress.Configuration;
using ReportTestDEvexpress.EntityFrameworkCore;
using ReportTestDEvexpress.Migrator.DependencyInjection;

namespace ReportTestDEvexpress.Migrator
{
    [DependsOn(typeof(ReportTestDEvexpressEntityFrameworkModule))]
    public class ReportTestDEvexpressMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ReportTestDEvexpressMigratorModule(ReportTestDEvexpressEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ReportTestDEvexpressMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ReportTestDEvexpressConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportTestDEvexpressMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
