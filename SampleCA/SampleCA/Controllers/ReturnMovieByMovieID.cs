using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SampleCA.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace SampleCA.Controllers
{
    [Route("api/ReturnMovieByMovieID")]
    [ApiController]
    //Return data about a specific movie as specified using a movie ID
    public class ReturnMovieByMovieID : ControllerBase
    {
        [HttpGet(Name = "ReturnMovieByMovieID")]
        public Movie? Get(string MovieId)
        {
            // 
            foreach (var Movie in Catalogue.Movies)
            {
                if (Movie.MovieId == MovieId)
                {
                    return Movie;
                }
            }
            return null;
        }
    
    }
}
