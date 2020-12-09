using Microsoft.AspNetCore.Identity;
using System;

namespace CatalogFilms.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FIO { get; set; }
    }

    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
