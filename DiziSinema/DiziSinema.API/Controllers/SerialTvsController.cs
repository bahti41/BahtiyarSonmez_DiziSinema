﻿using DiziSinema.Business.Absract;
using DiziSinema.Business.Concrete;
using DiziSinema.Shared.DTOs.Core.Add;
using DiziSinema.Shared.DTOs.Core.Edit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SerialTvsController : ControllerBase
    {
        private readonly ISerialTvSevice _serialTvManager;

        public SerialTvsController(ISerialTvSevice serialTvManager)
        {
            _serialTvManager = serialTvManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _serialTvManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _serialTvManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(AddSerialTvDTO addSerialTvDTO)
        {
            var respponse = await _serialTvManager.CreateAsync(addSerialTvDTO);
            var jsonResponse = JsonSerializer.Serialize(respponse);
            return Ok(jsonResponse);
        }

        [HttpDelete("HardDeleted/{id}")]
        public async Task<IActionResult> HardDeleted(int id)
        {
            var response = await _serialTvManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("SoftDeleted/{id}")]
        public async Task<IActionResult> SoftDeleted(int id)
        {
            var response = await _serialTvManager.SoftDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EditSerialTvDTO editSerialTvDTO)
        {
            var response = await _serialTvManager.UpdateAsync(editSerialTvDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("UpdateIsActive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _serialTvManager.UpdateIsActiveAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("ActiveCount")]
        public async Task<IActionResult> GetActiveCount()
        {
            var response = await _serialTvManager.GetActiveSerialTvCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("Count")]
        public async Task<IActionResult> GetCount()
        {
            var response = await _serialTvManager.GetSerialTvCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
