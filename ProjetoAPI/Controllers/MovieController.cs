using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Models;
using ProjetoAPI.Services.Interface;

namespace ProjetoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;
        public MovieController(IMovieService MovieService)
        {
            movieService = MovieService;
        }

        [HttpGet]
        public async Task<object> GetAllMovie()
        {
            var result = await movieService.GetAllMovie();

            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{Id}")]
        public async Task<object> GetMovie(int Id)
        {
            var result = await movieService.GetMovieById(Id);

            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<object> CreateMovie([FromBody] Movie movie)
        {
            var result = await movieService.CreateMovie(movie);

            if(result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{Id}")]
        public async Task<object> DeleteMovie(int Id)
        {
            var result = await movieService.DeleteMovie(Id);

            if (result)
            {
                return new
                {
                    success = true
                };
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
