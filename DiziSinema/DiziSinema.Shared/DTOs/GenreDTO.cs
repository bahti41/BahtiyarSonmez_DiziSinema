﻿using DiziSinema.Shared.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Shared.DTOs
{
    public class GenreDTO
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<InSerialTvDTO> SerialTvList { get; set; }
        public List<InMovieDTO> MovieList { get; set; }
    }
}
