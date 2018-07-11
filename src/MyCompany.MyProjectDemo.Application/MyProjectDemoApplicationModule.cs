using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProjectDemo.Authorization;
using MyCompany.MyProjectDemo.Persons.Authorization;

namespace MyCompany.MyProjectDemo
{
    [DependsOn(
        typeof(MyProjectDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProjectDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyProjectDemoAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<PersonAppAuthorizationProvider>();
            
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyProjectDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
