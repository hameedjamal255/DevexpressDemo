using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReportTestDEvexpress.Authorization.Roles;
using ReportTestDEvexpress.Authorization.Users;
using ReportTestDEvexpress.MultiTenancy;

namespace ReportTestDEvexpress.EntityFrameworkCore
{
    public class ReportTestDEvexpressDbContext : AbpZeroDbContext<Tenant, Role, User, ReportTestDEvexpressDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReportTestDEvexpressDbContext(DbContextOptions<ReportTestDEvexpressDbContext> options)
            : base(options)
        {
        }
    }
}
