using DiziSinema.Entity.Concrete.JunctionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Entity.Concrete.Entitys
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public List<SerialTvGenre> SerialTvGenres { get; set; }
    }
}
