using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Repository.Interface
{
    public interface IMovieRepository
    {
        Task<Movie> Add(Movie movie);
        Task<Movie> Find(int id);
        Task<IEnumerable<Movie>> GetAll();
        Task Delete(int id);
    }
}
