using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieDB DB = new MovieDB();

        [Route("ListAllMovies")]
        public Movie[] ListAllMovies()
        {
           return DB.movies.ToArray();
        }
        [Route("ListCategory")]
        public Movie[] ListCategory(string category)
        {
            List<Movie> moviesOfCategory = new List<Movie>();
            foreach(var currMovie in DB.movies)
            {
                if(currMovie.Category.Equals(category, StringComparison.CurrentCultureIgnoreCase))
                {
                    moviesOfCategory.Add(currMovie);
                }
            }
            return moviesOfCategory.ToArray();
        }
        [Route("GetRandomMovie")]
        public Movie GetRandomMovie()
        {
            var random = new Random();
            int index = random.Next(DB.movies.Count);
            return DB.movies[index];
        }
        [Route("GetRandomMovieOfCategory")]
        public Movie GetRandomMovieOfCategory(string category)
        {
            var listCategory = ListCategory(category);
            var random = new Random();
            int index = random.Next(listCategory.Length);
            return listCategory[index];
        }
        [Route("ListCategories")]
        public string[] ListCategories()
        {
            return DB.movies.Select(x => x.Category).ToArray();
        }
        [Route("GetMovieInfo")]
        public string GetMovieInfo(string title)
        {
            Movie thatMovie = null;
            foreach(var currMovie in DB.movies)
            {
                if(currMovie.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase))
                {
                    thatMovie = currMovie;
                }
            }
            return $"{thatMovie.ID}.) {thatMovie.Title} is a {thatMovie.Category} movie";
        }
    }
}
