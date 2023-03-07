using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Reflection;
using static SampleCA.Models.Movie;

namespace SampleCA.Models
{
    public enum Genres
    {
        action, adventure, animation, comedy, crime, drama, fantasy, family, horror, sci_fi, thriller
    };

    public enum Certification
    {
        universal, twelve, fifthteen, eighteen
    };

    public class Movie
    {
        public string? MovieId { get; set; }

        public string? Title { get; set; }

        public Genres Genre { get; set; }

        public Certification Cert { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double AverageRating { get; set; }


        // to string
        public override string ToString()
        {
            return "Movie Id: " + MovieId + "\nFilm Title:  " + Title ;
        }
    }
}