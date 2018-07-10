using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompany.MyProjectDemo.MultiTenancy.Dto;

namespace MyCompany.MyProjectDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
