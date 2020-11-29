using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FilmLab2._2.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Уведіть назву жанру")]
        public string Name { get; set; }

        public ICollection<FilmGenre> FilmsGenres { get; set; }
    }
}
