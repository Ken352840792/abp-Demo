using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.MyProjectDemo.Sessions.Dto;

namespace MyCompany.MyProjectDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
