using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using ReportTestDEvexpress.EntityFrameworkCore.Seed;

namespace ReportTestDEvexpress.EntityFrameworkCore
{
    [DependsOn(
        typeof(ReportTestDEvexpressCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ReportTestDEvexpressEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ReportTestDEvexpressDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ReportTestDEvexpressDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ReportTestDEvexpressDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportTestDEvexpressEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
