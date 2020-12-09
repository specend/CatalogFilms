using System.ComponentModel.DataAnnotations;

namespace CatalogFilms.Models
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введите корректный адрес электронной почты")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

    }
}
