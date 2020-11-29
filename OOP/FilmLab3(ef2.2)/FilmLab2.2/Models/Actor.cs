using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FilmLab2._2.Models
{
    public class Actor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Уведіть ім'я актора")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Уведіть рік народження актора")]
        [Range(0, 2019, ErrorMessage = "Некоректний рік")]
        public int Birth { get; set; }

        [Range(0, 2019, ErrorMessage = "Некоректний рік")]
        public int? Death { get; set; }

        public ICollection<FilmActor> FilmsActors { get; set; }
    }
}
