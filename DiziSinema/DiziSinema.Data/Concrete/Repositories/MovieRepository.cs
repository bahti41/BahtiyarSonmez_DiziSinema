using DiziSinema.Data.Abstract;
using DiziSinema.Data.Concrete.Context;
using DiziSinema.Entity.Concrete.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Concrete.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(DiziSinemaDbContext _context ) : base (_context)
        {
            
        }
        private DiziSinemaDbContext DiziSinemaDbContext
        {
            get { return _dbContext as DiziSinemaDbContext; }
        }
        public Task<List<Movie>> GetAllMovieWithGenreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovieWithGenreAsync()
        {
            throw new NotImplementedException();
        }
    }
}
