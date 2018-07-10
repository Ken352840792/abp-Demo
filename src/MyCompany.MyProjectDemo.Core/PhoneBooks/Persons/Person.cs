using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyCompany.MyProjectDemo.PhoneBooks.Persons
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person : FullAuditedEntity
    {

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
