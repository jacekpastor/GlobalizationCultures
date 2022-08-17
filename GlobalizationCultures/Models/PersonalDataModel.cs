using System.ComponentModel.DataAnnotations;

namespace GlobalizationCultures.Models
{
    public class PersonalDataModel
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i nazwisko.")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }
    }
}
