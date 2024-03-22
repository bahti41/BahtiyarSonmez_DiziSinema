﻿using DiziSinema.Business.Absract;
using DiziSinema.Shared.DTOs.Core.Add;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieManager;

        public MoviesController(IMovieService movieManager)
        {
            _movieManager = movieManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _movieManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _movieManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(AddMovieDTO addMovieDTO)
        {
            var respponse = await _movieManager.CreateAsync(addMovieDTO);
            var jsonResponse = JsonSerializer.Serialize(respponse);
            return Ok(jsonResponse);
        }

        [HttpGet("HardDeleted/{id}")]
        public async Task<IActionResult> HardDeleted(int id)
        {
            var response = await _movieManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
