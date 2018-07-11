using Abp.Application.Services.Dto;

namespace MyCompany.MyProjectDemo.Dtos
{
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }

		
		//// custom codes 
		
        //// custom codes end

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppLtmConsts.DefaultPageSize;
        }
    }
}