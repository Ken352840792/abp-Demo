using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompany.MyProjectDemo.PhoneBooks.Dtos
{
   public class PersonEditDto
    {
        public int? Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Required]
        public int Age { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [EmailAddress]
        public string EmailAddress { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
