using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
namespace MyCompany.MyProjectDemo.Dto
{
    public class PageAndSortInputDto : IPagedAndSortedResultRequest
    {
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
        [Range(1,500)]
        public int MaxResultCount { get; set; }
        public string Sorting { get; set; }
    }
}
