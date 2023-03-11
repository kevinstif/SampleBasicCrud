using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Geor.Authorization.Roles;
using Geor.Authorization.Users;
using Geor.MultiTenancy;
using Geor.Application;

namespace Geor.EntityFrameworkCore
{
    public class GeorDbContext : AbpZeroDbContext<Tenant, Role, User, GeorDbContext>
    {
        public DbSet<Country> Countries { get; set; }
        
        public GeorDbContext(DbContextOptions<GeorDbContext> options)
            : base(options)
        {
        }
    }
}
