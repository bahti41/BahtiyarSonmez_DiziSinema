using DiziSinema.Business.Absract;
using DiziSinema.Shared.DTOs;
using DiziSinema.Shared.ReponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Business.Concrete
{
    public class GenreManager : IGenreService
    {
        public Task<Response<GenreDTO>> CreateAsync(AddGenreDTO addGenreDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<GenreDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<GenreDTO>> GetByIdAsync(int id)
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

        public Task<Response<GenreDTO>> Update(EditGenreDTO editGenreDTO)
        {
            throw new NotImplementedException();
        }
    }
}
