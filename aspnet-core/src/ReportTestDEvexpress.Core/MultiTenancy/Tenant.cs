using Abp.MultiTenancy;
using ReportTestDEvexpress.Authorization.Users;

namespace ReportTestDEvexpress.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
