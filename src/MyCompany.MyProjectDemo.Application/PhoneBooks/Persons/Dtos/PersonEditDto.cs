using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyCompany.MyProjectDemo.PhoneBooks.Persons;
using MyCompany.MyProjectDemo.PhoneBooks.PhoneNumbers;

namespace  MyCompany.MyProjectDemo.PhoneBooks.Persons.Dtos
{
    public class PersonEditDto
    {
		/// <summary>
/// Id
/// </summary>
public int? Id { get; set; }


/// <summary>
/// Name
/// </summary>
[MaxLength(2147483647, ErrorMessage="Name超出最大长度")]
[Required(ErrorMessage="Name不能为空")]
public string Name { get; set; }


/// <summary>
/// EmailAddress
/// </summary>
[MaxLength(2147483647, ErrorMessage="EmailAddress超出最大长度")]
[Required(ErrorMessage="EmailAddress不能为空")]
public string EmailAddress { get; set; }


/// <summary>
/// Address
/// </summary>
[MaxLength(2147483647, ErrorMessage="Address超出最大长度")]
public string Address { get; set; }


/// <summary>
/// PhoneNumbers
/// </summary>
public ICollection<PhoneNumber> PhoneNumbers { get; set; }



		
		
		
		//// custom codes 
		
        //// custom codes end
    }
}