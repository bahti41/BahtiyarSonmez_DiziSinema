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
    public class SerialTvRepository : GenericRepository<SerialTv>, ISerialTvRepository
    {
        public SerialTvRepository(DiziSinemaDbContext _context) : base(_context)
        {
            
        }
        private DiziSinemaDbContext DiziSinemaDbContext 
        {
            get { return _dbContext as DiziSinemaDbContext; }
        }
        public Task<List<SerialTv>> GetAllSerialTvWithGenreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SerialTv> GetSerialTvWithGenreAsync()
        {
            throw new NotImplementedException();
        }
    }
}
