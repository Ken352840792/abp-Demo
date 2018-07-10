using System.Collections.Generic;

namespace MyCompany.MyProjectDemo.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
