using DiziSinema.Entity.Absratct;
using DiziSinema.Entity.Concrete.JunctionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Entity.Concrete.Entitys
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Language { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
    }
}
