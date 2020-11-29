using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FilmLab2._2.Models
{
    public class FilmActor
    {
        public int FilmActorID { get; set; }
        public int ActorID { get; set; }
        public int FilmID { get; set; }

        public Actor Actor { get; set; }
        public Film Film { get; set; }
    }
}
