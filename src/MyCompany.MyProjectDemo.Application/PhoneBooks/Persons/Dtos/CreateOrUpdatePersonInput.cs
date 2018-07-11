using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;

namespace MyCompany.MyProjectDemo.PhoneBooks.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}