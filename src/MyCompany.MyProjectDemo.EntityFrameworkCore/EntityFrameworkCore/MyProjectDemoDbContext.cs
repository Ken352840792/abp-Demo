using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompany.MyProjectDemo.Authorization.Roles;
using MyCompany.MyProjectDemo.Authorization.Users;
using MyCompany.MyProjectDemo.MultiTenancy;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;
using MyCompany.MyProjectDemo.PhoneBooks.PhoneNums;

namespace MyCompany.MyProjectDemo.EntityFrameworkCore
{
    public class MyProjectDemoDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
       
        public MyProjectDemoDbContext(DbContextOptions<MyProjectDemoDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<PhoneNum> PhoneNum { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person","PB");
            modelBuilder.Entity<PhoneNum>().ToTable("PhoneNum", "PB");
            base.OnModelCreating(modelBuilder);
        }

    }
}
