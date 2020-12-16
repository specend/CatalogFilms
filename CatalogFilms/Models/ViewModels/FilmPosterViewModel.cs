using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CatalogFilms.Models
{
    public class FilmPosterViewModel
    {
        [Required(ErrorMessage = "Введите название фильма")]
        [Display(Name = "Фильм")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Добавьте описание к фильму")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите год фильма")]
        [Display(Name = "Год выпуска")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Укажите режиссёра фильма")]
        [Display(Name = "Режиссёр")]
        public string Director { get; set; }

        public string NamePoster { get; set; }

        public IFormFile Poster { get; set; }
    }
}
