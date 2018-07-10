using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCompany.MyProjectDemo.Configuration;
using MyCompany.MyProjectDemo.Web;

namespace MyCompany.MyProjectDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyProjectDemoDbContextFactory : IDesignTimeDbContextFactory<MyProjectDemoDbContext>
    {
        public MyProjectDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProjectDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyProjectDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyProjectDemoConsts.ConnectionStringName));

            return new MyProjectDemoDbContext(builder.Options);
        }
    }
}
