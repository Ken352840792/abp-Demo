﻿using Abp.Domain.Entities.Auditing;
using MyCompany.MyProjectDemo.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompany.MyProjectDemo.PhoneBooks.Persons
{
    public class Person : FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(PhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }


        /// <summary>
        /// 电话号码的导航属性
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
