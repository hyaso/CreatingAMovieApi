using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreatingAMovieApi.Models;

namespace CreatingAMovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieDB DB = new MovieDB();

        [Route("Movies")]
        public Movie[] GetListOfMovies()
        {
            return DB.Movies.ToArray();
        }

        [Route("category")]
        public Movie[] GetMovieByCategory(string category)
        {
            var categoryList = new List<Movie>();

            foreach (var currMovie in DB.Movies)
            {
                if (currMovie.Category.Equals(category, StringComparison.CurrentCultureIgnoreCase))
                {
                    categoryList.Add(currMovie);
                }
            }

            return categoryList.ToArray();
        }

        [Route("randommovie")]
        public Movie GetRandomMovie()
        {
            var random = new Random();
            int index = random.Next(DB.Movies.Count);
            return DB.Movies[index];
        }

        [Route("randomMovieByCategory")]
        public Movie GetRandomMovieByCategory(string category)
        {
            var list = GetMovieByCategory(category);
            var random = new Random();
            int index = random.Next(list.Length);
            return list[index];
        }

        [Route("randommoviepicks")]
        public Movie[] GetRandomMoviePicks(int count)
        {
            var random = new Random();
            var randomMovies = new List<Movie>();

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(DB.Movies.Count);
                randomMovies.Add(DB.Movies[index]);
            }

            return randomMovies.ToArray();
        }

        [Route("listofcategories")]
        public String[] GetListOfCategories()
        {
            return DB.Movies.Select(x => x.Category).ToArray();
        }

        [Route("infoaboutmovie")]
        public Movie GetInfoAboutMovie(string title)
        {
            Movie movie = null;

            foreach (var currMovie in DB.Movies)
            {
                if (currMovie.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase))
                {
                    movie = currMovie;
                }
            }

            return movie;
        }

        [Route("keyword")]
        public Movie[] GetMovieByKeyword(string keyword)
        {
            var movieList = new List<Movie>();

            foreach (var movie in DB.Movies)
            {
                if (movie.Title.Contains(keyword, StringComparison.CurrentCultureIgnoreCase))
                {
                    movieList.Add(movie);
                }
            }

            return movieList.ToArray();
        }
    }
}
