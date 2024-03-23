using AutoMapper;
using DiziSinema.Business.Absract;
using DiziSinema.Data.Abstract;
using DiziSinema.Entity.Concrete.Entitys;
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

        public MovieManager(IMapper mapper, IMovieRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<MovieDTO>> CreateAsync(AddMovieDTO addMovieDTO)
        {
            var movie = _mapper.Map<Movie>(addMovieDTO);
            var addMovie = await _repository.CreateAsync(movie);
            if(addMovie == null)
            {
                return Response<MovieDTO>.Fail("Film Oluşturulamadı", 301);
            }
            var addMovieDto = _mapper.Map<MovieDTO>(addMovie);
            return Response<MovieDTO>.Success(addMovieDto, 200);
        }

        public async Task<Response<List<MovieDTO>>> GetAllAsync()
        {
            var movietList = await _repository.GetAllAsync();
            if (movietList == null)
            {
                return Response<List<MovieDTO>>.Fail("Hiç film bulunamadı", 301);
            }
            var movieDtoList = _mapper.Map<List<MovieDTO>>(movietList);
            return Response<List<MovieDTO>>.Success(movieDtoList, 200);
        }

        public async Task<Response<MovieDTO>> GetByIdAsync(int id)
        {
            var movie = await _repository.GetByIdAsync(m=>m.Id == id);
            if (movie == null)
            {
                return Response<MovieDTO>.Fail("ilgili Film bulunamadı.", 404);
            }
            var movieDto = _mapper.Map<MovieDTO>(movie);
            return Response<MovieDTO>.Success(movieDto, 200);
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var movie = await _repository.GetByIdAsync(c=>c.Id == id);
            if (movie == null)
            {
                return Response<NoContent>.Fail("ilgili Film bulunamadı.", 404);
            }
            await _repository.HardDeleteAsync(movie);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var deletedMovie = await _repository.GetByIdAsync(c=>c.Id==id);
            if (deletedMovie == null)
            {
                return Response<NoContent>.Fail("ilgili Film Bulunamadı.", 404);
            }
            if (deletedMovie.IsDeleted)
            {
                return Response<NoContent>.Fail("Bu Film Zaten Silinmiş.", 404);
            }
            deletedMovie.IsDeleted=true;
            deletedMovie.IsActive=false;
            deletedMovie.ModifiedDate=DateTime.Now;
            await _repository.UpdateAsync(deletedMovie);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<MovieDTO>> UpdateAsync(EditMovieDTO editMovieDTO)
        {
            var editedMovie = _mapper.Map<Movie>(editMovieDTO);
            if (editedMovie == null)
            {
                return Response<MovieDTO>.Fail("Böyle Bir film Bulunamadı", 404);
            }
            editedMovie.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(editedMovie);
            var editedMovieDto = _mapper.Map<MovieDTO>(editedMovie);
            return Response<MovieDTO>.Success(editedMovieDto, 200);
        }
    }
}
