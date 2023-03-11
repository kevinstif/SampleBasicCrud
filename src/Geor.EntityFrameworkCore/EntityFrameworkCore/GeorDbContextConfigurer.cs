using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Geor.EntityFrameworkCore
{
    public static class GeorDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GeorDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public static void Configure(DbContextOptionsBuilder<GeorDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection,ServerVersion.AutoDetect(connection.ConnectionString));
        }
    }
}
