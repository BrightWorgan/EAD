using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SampleCA.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace SampleCA.Controllers
{
    [Route("api/return-all-movies")]
    [ApiController]
    // Return data about all movies in the catalogue, sorted in release date order(most recent to oldest).
    public class ReturnAllMovies: ControllerBase
    {
        [HttpGet(Name = "ReturnAllMovies") ]
        public List<Movie> Get()
        {
            

            List<Movie> temp =  Catalogue.Movies.OrderByDescending(x => x.ReleaseDate).ToList();
            return temp;


            
            
        }


//3.	Return a list of movie IDs and titles for movies that contain a specified keyword as a whole word in their title.

    }
}
