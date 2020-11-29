﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FilmLab2._2.Models
{
    public class FilmGenre
    {
        public int FilmGenreID { get; set; }
        public int GenreID { get; set; }
        public int FilmID { get; set; }

        public Genre Genre { get; set; }
        public Film Film { get; set; }
    }
}
