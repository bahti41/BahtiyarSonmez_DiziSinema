﻿using DiziSinema.Business.Absract;
using DiziSinema.Shared.DTOs;
using DiziSinema.Shared.ReponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        public Task<Response<MovieDTO>> CreateAsync(AddMovieDTO addMovieDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<MovieDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<MovieDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<MovieDTO>> Update(EditMovieDTO editMovieDTO)
        {
            throw new NotImplementedException();
        }
    }
}
