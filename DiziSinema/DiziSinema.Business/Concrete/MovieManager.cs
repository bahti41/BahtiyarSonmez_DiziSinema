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
    public class MovieManager : IMovieService
    {
        private readonly IMapper _mapper;
        private readonly IMovieRepository _repository;

        public MovieManager(IMapper mapper, IMovieRepository movieRepository)
        {
            _mapper = mapper;
            _repository = movieRepository;
        }

        public Task<Response<MovieDTO>> CreateAsync(AddMovieDTO addMovieDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<MovieDTO>>> GetAllAsync()
        {
            var movietList = await _repository.GetAllAsync();
            if (movietList == null)
            {
                return Response<List<MovieDTO>>.Fail("Hiç ürün bulunamadı", 301);
            }
            var movieDtoList = _mapper.Map<List<MovieDTO>>(movietList);
            return Response<List<MovieDTO>>.Success(movieDtoList, 200);
        }

        public Task<Response<MovieDTO>> GetByIdAsync(int id)
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

        public Task<Response<MovieDTO>> UpdateAsync(EditMovieDTO editMovieDTO)
        {
            throw new NotImplementedException();
        }
    }
}
