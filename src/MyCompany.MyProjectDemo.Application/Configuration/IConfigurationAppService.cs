using System.Threading.Tasks;
using MyCompany.MyProjectDemo.Configuration.Dto;

namespace MyCompany.MyProjectDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
