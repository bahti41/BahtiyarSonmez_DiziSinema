using AutoMapper;
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
    public class SerialTvManager : ISerialTvSevice
    {
        private readonly IMapper mapper;
        public Task<Response<SerialTvDTO>> CreateAsync(AddSerialTvDTO addSerialTvDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<SerialTvDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<SerialTvDTO>> GetByIdAsync(int id)
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

        public Task<Response<SerialTvDTO>> Update(EditSerialTvDTO editSerialTvDTO)
        {
            throw new NotImplementedException();
        }
    }
}
