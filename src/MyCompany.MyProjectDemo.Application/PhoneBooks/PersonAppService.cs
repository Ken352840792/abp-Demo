using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MyCompany.MyProjectDemo.PhoneBooks.Dtos;

namespace MyCompany.MyProjectDemo.PhoneBooks
{
    public class PersonAppService : MyProjectDemoAppServiceBase, IPersonAppService
    {

        public Task DeletePersonAsync(EntityDto input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput getPersonInput)
        {
            throw new NotImplementedException();
        }

        public Task<PersonListDto> GetPersonByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task InsertOrEditPersonAsync()
        {
            throw new NotImplementedException();
        }
    }
}
