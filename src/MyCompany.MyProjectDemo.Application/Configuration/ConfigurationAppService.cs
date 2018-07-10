using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCompany.MyProjectDemo.Configuration.Dto;

namespace MyCompany.MyProjectDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
