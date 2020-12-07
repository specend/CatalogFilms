using Microsoft.AspNetCore.Identity;

namespace CatalogFilms.Models
{
    public class User : IdentityUser
    {
        public string FIO { get; set; }
    }
}
