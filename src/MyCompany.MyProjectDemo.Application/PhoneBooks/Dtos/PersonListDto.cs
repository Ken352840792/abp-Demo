using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompany.MyProjectDemo.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string EmailAddress { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
