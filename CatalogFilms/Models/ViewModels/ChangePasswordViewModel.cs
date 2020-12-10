using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogFilms.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }

        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введите корректный адрес электронной почты")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string ConfirmNewPassword { get; set; }
    }
}
