using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using MyCompany.MyProjectDemo.Authorization.Users;
using MyCompany.MyProjectDemo.Editions;

namespace MyCompany.MyProjectDemo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
