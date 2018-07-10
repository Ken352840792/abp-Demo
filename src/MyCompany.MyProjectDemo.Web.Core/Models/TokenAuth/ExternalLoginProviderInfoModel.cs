using Abp.AutoMapper;
using MyCompany.MyProjectDemo.Authentication.External;

namespace MyCompany.MyProjectDemo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
