using Abp.Runtime.Validation;
using MyCompany.MyProjectDemo.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.MyProjectDemo.PhoneBooks.Dtos
{
    public class GetPersonInput : PageAndSortInputDto, IShouldNormalize
    {
        //dto=>model
        public string FilterText { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting)) {
                Sorting = "Id";
            }
        }
    }
}
