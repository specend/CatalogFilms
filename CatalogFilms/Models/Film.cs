using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogFilms.Models
{
    public class Film
    {
        [Key]
        public int Id_Film { get; set; }

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

        [Required(ErrorMessage = "Загрузите постер фильма")]
        [Display(Name = "Постер")]
        public byte[] Poster { get; set; }
        public int? Id_User { get; set; }

        [ForeignKey("Id_User")]
        public User User { get; set; }
    }
}
