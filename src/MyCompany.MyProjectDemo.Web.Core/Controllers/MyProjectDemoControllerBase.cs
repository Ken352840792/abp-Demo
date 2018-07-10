using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCompany.MyProjectDemo.Controllers
{
    public abstract class MyProjectDemoControllerBase: AbpController
    {
        protected MyProjectDemoControllerBase()
        {
            LocalizationSourceName = MyProjectDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
