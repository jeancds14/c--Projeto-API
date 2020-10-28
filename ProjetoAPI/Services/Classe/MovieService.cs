using ProjetoAPI.Models;
using ProjetoAPI.Repository.Interface;
using ProjetoAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Services.Classe
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;
        public MovieService(IMovieRepository MovieRepository)
        {
            movieRepository = MovieRepository;
        }
        public async Task<Movie> CreateMovie(Movie movie)
        {
            try
            {
                var result = await movieRepository.Add(movie);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Movie>> GetAllMovie()
        {
            try
            {
                var result = await movieRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Movie> GetMovieById(int id)
        {
            try
            {
                var result = await movieRepository.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> DeleteMovie(int id)
        {
            try
            {
                await movieRepository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
