using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Echo.Authorization.Roles;
using Echo.Authorization.Users;
using Echo.MultiTenancy;

namespace Echo.EntityFrameworkCore
{
    public class EchoDbContext : AbpZeroDbContext<Tenant, Role, User, EchoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EchoDbContext(DbContextOptions<EchoDbContext> options)
            : base(options)
        {
        }
    }
}
