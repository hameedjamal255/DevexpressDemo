using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ReportTestDEvexpress.EntityFrameworkCore
{
    public static class ReportTestDEvexpressDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReportTestDEvexpressDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReportTestDEvexpressDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
