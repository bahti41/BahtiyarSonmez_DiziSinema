﻿using AutoMapper;
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
    public class SerialTvManager : ISerialTvSevice
    {
        private readonly IMapper _mapper;
        private readonly ISerialTvRepository _repository;

        public SerialTvManager(IMapper mapper, ISerialTvRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<Response<SerialTvDTO>> CreateAsync(AddSerialTvDTO addSerialTvDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<SerialTvDTO>>> GetAllAsync()
        {
            var serialTvList = await _repository.GetAllAsync();
            if (serialTvList == null)
            {
                return Response<List<SerialTvDTO>>.Fail("Hiç ürün bulunamadı", 301);
            }
            var serialTvListDtoList = _mapper.Map<List<SerialTvDTO>>(serialTvList);
            return Response<List<SerialTvDTO>>.Success(serialTvListDtoList, 200);
        }

        public Task<Response<SerialTvDTO>> GetByIdAsync(int id)
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

        public Task<Response<SerialTvDTO>> UpdateAsync(EditSerialTvDTO editSerialTvDTO)
        {
            throw new NotImplementedException();
        }
    }
}