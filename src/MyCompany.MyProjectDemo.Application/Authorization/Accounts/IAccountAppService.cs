using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.MyProjectDemo.Authorization.Accounts.Dto;

namespace MyCompany.MyProjectDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
