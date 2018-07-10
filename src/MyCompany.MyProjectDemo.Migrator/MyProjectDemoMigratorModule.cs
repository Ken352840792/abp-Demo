using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProjectDemo.Configuration;
using MyCompany.MyProjectDemo.EntityFrameworkCore;
using MyCompany.MyProjectDemo.Migrator.DependencyInjection;

namespace MyCompany.MyProjectDemo.Migrator
{
    [DependsOn(typeof(MyProjectDemoEntityFrameworkModule))]
    public class MyProjectDemoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjectDemoMigratorModule(MyProjectDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MyProjectDemoMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MyProjectDemoConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectDemoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
