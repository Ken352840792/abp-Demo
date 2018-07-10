using System.ComponentModel.DataAnnotations;

namespace MyCompany.MyProjectDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}