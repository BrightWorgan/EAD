using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SampleCA.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace SampleCA.Controllers
{
    [Route("api/SearchMoviesByKeyword")]
    [ApiController]
    // Return a list of movie IDs and titles for movies that contain a specified keyword as a whole word in their title.
    public class SearchMoviesByKeyword : ControllerBase
    {
        [HttpGet(Name = "SearchMoviesByKeyword") ]
        public List<Movie> Get(string Keyword)
        {
            List<Movie> NewMovies = new List<Movie>();

            foreach (var Movie in Catalogue.Movies)
            {
                if (Movie.Title.Contains(Keyword))
                {
                    NewMovies.Add(Movie);
                }
            }
            return NewMovies;

        }


    }
}
