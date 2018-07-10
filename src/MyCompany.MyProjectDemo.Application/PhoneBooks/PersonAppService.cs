using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MyCompany.MyProjectDemo.PhoneBooks.Dtos;
using Abp.Domain.Repositories;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using Abp.AutoMapper;
using Abp.UI;

namespace MyCompany.MyProjectDemo.PhoneBooks
{
    public class PersonAppService : MyProjectDemoAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRespository;
        public PersonAppService(IRepository<Person> PersonRepository)
        {
            _personRespository = PersonRepository;
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRespository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("Id不存在，无法删除");
            }
            await _personRespository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput getPersonInput)
        {
            var query = _personRespository.GetAll();
            var count = await query.CountAsync();
            var persons = query.OrderBy(getPersonInput.Sorting).PageBy(getPersonInput).ToListAsync();
            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(count, dtos);
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto Id)
        {
            var entity = await _personRespository.GetAsync(Id.Id.Value);
            return entity.MapTo<PersonListDto>();
        }

        public async Task InsertOrEditPersonAsync(InsertOrEditPersonAsyncInput insertOrEditPersonAsyncInput)
        {
            if (insertOrEditPersonAsyncInput.editDto.Id.HasValue)
            {
                await UpdatePersonAsync(insertOrEditPersonAsyncInput.editDto);
            }
            else
            {
                await CreatePersonAsync(insertOrEditPersonAsyncInput.editDto);
            }
        }
        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRespository.GetAsync(input.Id.Value);
            await _personRespository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            await _personRespository.InsertAsync(input.MapTo<Person>());
        }
    }
}
