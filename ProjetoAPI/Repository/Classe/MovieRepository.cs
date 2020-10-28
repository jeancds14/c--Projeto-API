using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.Models;
using ProjetoAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Repository.Classe
{
    public class MovieRepository : IMovieRepository
    {
        private ApplicationContext db;
        public MovieRepository(ApplicationContext ctx)
        {
            db = ctx;
        }

        public async Task<Movie> Add(Movie movie)
        {
            db.Movies.Add(movie);
            await db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> Find(int id)
        {
            var result = await db.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var result = await db.Movies.ToListAsync();
            return result;
        }

        public async Task Delete(int id)
        {
            var result = await db.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            db.Movies.Remove(result);
            await db.SaveChangesAsync();
        }
    }
}
