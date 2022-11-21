using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ReportTestDEvexpress.Authorization.Users;
using ReportTestDEvexpress.Editions;

namespace ReportTestDEvexpress.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
