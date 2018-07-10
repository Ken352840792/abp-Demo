using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.MyProjectDemo.EntityFrameworkCore
{
    public static class MyProjectDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
