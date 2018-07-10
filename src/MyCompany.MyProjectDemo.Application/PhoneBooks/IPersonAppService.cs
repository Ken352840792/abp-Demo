using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompany.MyProjectDemo.PhoneBooks.Dtos;

namespace MyCompany.MyProjectDemo.PhoneBooks
{
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 分页获取用户的相关信息
        /// </summary>
        /// <param name="getPersonInput"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput getPersonInput);


        /// <summary>
        /// 根据ID获取用户的相关信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(long Id);

        /// <summary>
        /// 新增或者修改联系人信息
        /// </summary>
        /// <returns></returns>
        Task InsertOrEditPersonAsync();

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}
