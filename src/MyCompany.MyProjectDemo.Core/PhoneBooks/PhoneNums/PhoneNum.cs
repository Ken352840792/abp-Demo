using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
namespace MyCompany.MyProjectDemo.PhoneBooks.PhoneNums
{
    public class PhoneNum :Entity<long>,IHasCreationTime
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(12)]
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType PhoneType { get; set; }
        public int PersonId { get; set; }
        public Persons.Person Person { get; set; }
        public DateTime CreationTime { get; set; }
 
    }
}
