using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCAFilmLibrary.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace PracticeCAFilmLibrary.Controllers
{
    [Route("api/DisplayAllMoviesController")]
    [ApiController]
    public class DisplayAllMoviesController : ControllerBase
    {
        [HttpGet (Name = "DisplayAllMoviesController")]
        public List<Film> Get()
        {
            // returns all of the films in HomeCinema List in descending order
            return HomeCinemaList.HomeCinema.OrderByDescending(x => x.ReleaseDate).ToList();

            //List<Film> temp = Catalogue.Film.OrderByDescending(x => x.ReleaseDate).ToList();
            //return temp;
        }
    }
}
