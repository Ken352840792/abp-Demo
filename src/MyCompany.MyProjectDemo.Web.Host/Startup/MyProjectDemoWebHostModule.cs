using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProjectDemo.Configuration;

namespace MyCompany.MyProjectDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(MyProjectDemoWebCoreModule))]
    public class MyProjectDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjectDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectDemoWebHostModule).GetAssembly());
        }
    }
}
