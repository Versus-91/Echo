using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Echo.EntityFrameworkCore
{
    public static class EchoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EchoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EchoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
