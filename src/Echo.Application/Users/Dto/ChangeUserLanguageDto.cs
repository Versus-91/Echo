using System.ComponentModel.DataAnnotations;

namespace Echo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}