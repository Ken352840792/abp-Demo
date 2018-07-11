using AutoMapper;
using MyCompany.MyProjectDemo.Persons;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;

namespace MyCompany.MyProjectDemo.PhoneBooks.Persons.Dtos
{

	/// <summary>
	/// 配置Person的AutoMapper
	/// </summary>
	internal static class CustomerPersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Person, PersonListDto>();
            configuration.CreateMap <PersonEditDto, Person>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}