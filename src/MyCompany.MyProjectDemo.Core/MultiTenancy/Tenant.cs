using Abp.MultiTenancy;
using MyCompany.MyProjectDemo.Authorization.Users;

namespace MyCompany.MyProjectDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
