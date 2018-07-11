using Abp.Domain.Services;

namespace MyCompany.MyProjectDemo
{
    public abstract class MyProjectDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */
        /*在领域服务中添加你的自定义公共方法*/
		
		//// custom codes 
		
        //// custom codes end

        protected MyProjectDemoDomainServiceBase()
        {
            LocalizationSourceName = MyProjectDemoConsts.LocalizationSourceName;
        }
    }
}
