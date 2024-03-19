using DiziSinema.Shared.DTOs;
using DiziSinema.Shared.ReponseDTOs;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Business.Absract
{
    public interface IMovieService
    {
        #region Generic
        Task<Response<MovieDTO>> GetByIdAsync(int id);
        Task<Response<List<MovieDTO>>> GetAllAsync();
        Task<Response<MovieDTO>> CreateAsync(AddMovieDTO addMovieDTO);
        Task<Response<MovieDTO>> Update(EditMovieDTO editMovieDTO);
        Task<Response<NoContent>> HardDelete(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        #endregion

        #region Movie
        //Task<Response<List<MovieDTO>>> GetMovieByGenreIdAsync(int GenreId);
        #endregion
    }
}
