using static SampleCA.Models.Movie;

namespace SampleCA.Models
{
    public class Catalogue
    {
        // List of Movies / Catalogue
        public static List<Movie> Movies = new List<Movie>();

        public static void init()
        {
            Movie m1 = new Movie() { MovieId = "101010", Title = "WordyTitle", Genre = Genres.horror, Cert = Certification.universal, ReleaseDate = new DateTime(1930, 10, 12), AverageRating = 3.5 };
            Movies.Add(m1);
            Movie m2 = new Movie() { MovieId = "100002", Title = "Call of Chtuliou", Genre = Genres.horror, Cert = Certification.universal, ReleaseDate = new DateTime(2002, 10, 12), AverageRating = 4.1 };
            Movies.Add(m2);
            Movie m3 = new Movie() { MovieId = "100003", Title = "An American Werewolf in London", Genre = Genres.horror, Cert = Certification.universal, ReleaseDate = new DateTime(1982, 10, 12), AverageRating = 3.5 };
            Movies.Add(m3);
            Movie m4 = new Movie() { MovieId = "100004", Title = "Star Trek", Genre = Genres.sci_fi, Cert = Certification.universal, ReleaseDate = new DateTime(2019, 10, 12), AverageRating = 4.5 };
            Movies.Add(m4);
        }

    }
}
