using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FilmLab2._2.Models
{
    public class Film
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Уведіть назву фільму")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Уведіть рік фільму")]
        [Range(0, 2019, ErrorMessage = "Некоректний рік")]
        public int Year { get; set; }
        public int ProducerID { get; set; }

        public Producer Producer { get; set; }
        public ICollection<FilmGenre> FilmsGenres { get; set; }
        public ICollection<FilmActor> FilmsActors { get; set; }
    }
}
