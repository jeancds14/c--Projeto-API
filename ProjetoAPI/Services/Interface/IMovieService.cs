using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Services.Interface
{
    public interface IMovieService
    {
        Task<Movie> CreateMovie(Movie movie);
        Task<IEnumerable<Movie>> GetAllMovie();
        Task<Movie> GetMovieById(int id);
        Task<bool> DeleteMovie(int id);
    }
}
