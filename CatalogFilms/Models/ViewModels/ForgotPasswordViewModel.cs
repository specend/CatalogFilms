using System.ComponentModel.DataAnnotations;

namespace CatalogFilms.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}