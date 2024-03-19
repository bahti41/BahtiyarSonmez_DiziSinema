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
    public interface ISerialTvSevice
    {
        #region Generic
        Task<Response<SerialTvDTO>> GetByIdAsync(int id);
        Task<Response<List<SerialTvDTO>>> GetAllAsync();
        Task<Response<SerialTvDTO>> CreateAsync(AddSerialTvDTO addSerialTvDTO);
        Task<Response<SerialTvDTO>> Update(EditSerialTvDTO editSerialTvDTO);
        Task<Response<NoContent>> HardDelete(int id);
        Task<Response<NoContent>> SoftDeleteAsync(int id);
        #endregion

        #region SerialTv
        //Task<Response<List<SerialTvDTO>>> GetSerialTvByGenreIdAsync(int GenreId);
        #endregion
    }
}
