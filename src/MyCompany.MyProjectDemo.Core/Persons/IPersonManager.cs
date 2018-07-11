using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;


namespace MyCompany.MyProjectDemo.Persons.DomainServices
{
    public interface IPersonManager : IDomainService
    {
        
        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitPerson();


		
		//// custom codes 
		
        //// custom codes end

    }
}
