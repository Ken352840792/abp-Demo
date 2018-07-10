using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompany.MyProjectDemo.Authorization.Roles;
using MyCompany.MyProjectDemo.Authorization.Users;
using MyCompany.MyProjectDemo.MultiTenancy;

namespace MyCompany.MyProjectDemo.EntityFrameworkCore
{
    public class MyProjectDemoDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectDemoDbContext(DbContextOptions<MyProjectDemoDbContext> options)
            : base(options)
        {
        }
    }
}
