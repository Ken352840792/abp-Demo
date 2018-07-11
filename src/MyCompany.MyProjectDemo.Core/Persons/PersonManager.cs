using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;

namespace MyCompany.MyProjectDemo.Persons.DomainServices
{
    /// <summary>
    /// Person领域层的业务管理
    /// </summary>
    public class PersonManager :MyProjectDemoDomainServiceBase, IPersonManager
    {
        private readonly IRepository<Person, int> _personRepository;

        /// <summary>
        /// Person的构造方法
        /// </summary>
        public PersonManager(IRepository<Person, int> personRepository)
        {
            _personRepository = personRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitPerson()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
