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
    public interface IGenreService
    {
        #region Generic
        Task<Response<GenreDTO>> GetByIdAsync(int id);
        Task<Response<List<GenreDTO>>> GetAllAsync();
        Task<Response<GenreDTO>> CreateAsync(AddGenreDTO addGenreDTO);
        Task<Response<GenreDTO>> Update(EditGenreDTO editGenreDTO);
        Task<Response<NoContent>> HardDelete(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        #endregion

        #region Genre

        #endregion
    }
}
