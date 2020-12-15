using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogFilms.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
    }
}
