using DiziSinema.Entity.Concrete.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Abstract
{
    public interface IMovieRepository:IGenericRepository<Movie>
    {
        Task<List<Movie>> GetAllMovieWithGenreAsync();
        Task<Movie> GetMovieWithGenreAsync();
    }
}
