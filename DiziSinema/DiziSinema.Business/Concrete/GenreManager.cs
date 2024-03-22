using AutoMapper;
using DiziSinema.Business.Absract;
using DiziSinema.Data.Abstract;
using DiziSinema.Shared.DTOs;
using DiziSinema.Shared.DTOs.Core.Add;
using DiziSinema.Shared.DTOs.Core.Edit;
using DiziSinema.Shared.DTOs.In;
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
        private readonly IMapper _mapper;
        private readonly IGenreRepository _repository;

        public GenreManager(IMapper mapper, IGenreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

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

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<GenreDTO>> UpdateAsync(EditGenreDTO editGenreDTO)
        {
            throw new NotImplementedException();
        }
    }
}
