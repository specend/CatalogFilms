using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CatalogFilms.Models
{
    public class User : IdentityUser<Guid>
    {

        public string FIO { get; set; }

       // public virtual ICollection<Film> Films { get; set; }

       // public User()
       // {
       //     Films = new List<Film>();
      // }
    }

    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
