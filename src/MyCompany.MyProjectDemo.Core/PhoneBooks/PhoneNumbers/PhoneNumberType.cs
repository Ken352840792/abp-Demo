using MyCompany.MyProjectDemo.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompany.MyProjectDemo.PhoneBooks.PhoneNumbers
{
    /// <summary>
    /// 电话号码类型
    /// </summary>
    public enum PhoneNumberType
    {
        /// <summary>
        /// 移动电话
        /// </summary>
        [Description("移动电话")]
        Mobile = 1,
        /// <summary>
        /// 家庭
        /// </summary>
        [Description("家庭")]

        Home = 2,
        /// <summary>
        /// 公司
        /// </summary>
        [Description("公司")]

        Company = 3,
        /// <summary>
        /// 商务
        /// </summary>
        [Description("商务")]

        Business = 4
    }
}
