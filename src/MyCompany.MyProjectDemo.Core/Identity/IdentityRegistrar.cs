using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyCompany.MyProjectDemo.Authorization;
using MyCompany.MyProjectDemo.Authorization.Roles;
using MyCompany.MyProjectDemo.Authorization.Users;
using MyCompany.MyProjectDemo.Editions;
using MyCompany.MyProjectDemo.MultiTenancy;

namespace MyCompany.MyProjectDemo.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();
           
            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
