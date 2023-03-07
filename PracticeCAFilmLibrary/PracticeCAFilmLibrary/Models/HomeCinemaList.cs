using Microsoft.Extensions.FileSystemGlobbing;

namespace PracticeCAFilmLibrary.Models
{
    public class HomeCinemaList
    {
        // list of films
       public static List<Film>HomeCinema = new List<Film>();

        public static void init()
        {
            // populate list
            Film f1 = new Film() { FilmID = "1980150001", FilmName = "Star Wars: Episode V - The Empire Strikes Back", FilmGenre = Genre.science_fiction, FilmLocation = Location.DisneyPlus, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(1980, 12, 02), IMBDRating = 8.7, HomeRating = 7 };
            HomeCinema.Add(f1);

            Film f2 = new Film() { FilmID = "1998000002", FilmName = "My Neighbor Totoro", FilmGenre = Genre.family, FilmLocation = Location.CrunchyRoll, FilmOriginalLanguage = OriginalLanguage.Japanese, ReleaseDate = new DateTime(1988, 10, 12), IMBDRating = 8.1, HomeRating = 10 };
            HomeCinema.Add (f2);

            Film f3 = new Film() { FilmID = "1962970003", FilmName = "Lawrence of Arabia", FilmGenre = Genre.historical, FilmLocation = Location.GoogleMovies, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(1962, 12, 02), IMBDRating = 8.3, HomeRating = 10 };
            HomeCinema.Add(f3);

            Film f4 = new Film() { FilmID = "2006000004", FilmName = "Pan's Labyrinth", FilmGenre = Genre.fantasty, FilmLocation = Location.Prime, FilmOriginalLanguage = OriginalLanguage.Spanish, ReleaseDate = new DateTime(2006, 12, 02), IMBDRating = 8.2, HomeRating = 8 };
            HomeCinema.Add(f4);

            Film f5 = new Film() { FilmID = "1991220005", FilmName = "The Silence of the Lambs", FilmGenre = Genre.thriller, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(1991, 12, 02), IMBDRating = 8.6, HomeRating = 8 };
            HomeCinema.Add(f5);

            Film f6 = new Film() { FilmID = "2000190006", FilmName = "American Psycho", FilmGenre = Genre.horror, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(2000, 12, 02), IMBDRating = 7.6, HomeRating = 8 };
            HomeCinema.Add(f6);

            Film f7 = new Film() { FilmID = "1979370007", FilmName = "Alien", FilmGenre = Genre.horror, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(1979, 12, 02), IMBDRating = 8.5, HomeRating = 8.5 };
            HomeCinema.Add(f7);

            Film f8 = new Film() { FilmID = "2001310008", FilmName = "Spirited Away", FilmGenre = Genre.family, FilmLocation = Location.CrunchyRoll, FilmOriginalLanguage = OriginalLanguage.Japanese, ReleaseDate = new DateTime(2001, 12, 02), IMBDRating = 8.6, HomeRating = 9.5 };
            HomeCinema.Add(f8);

            Film f9 = new Film() { FilmID = "2022080009", FilmName = "The Banshees of Inisherin", FilmGenre = Genre.comedy, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.English, ReleaseDate = new DateTime(2022, 12, 02), IMBDRating = 7.8, HomeRating = 9 };
            HomeCinema.Add(f9);

            Film f10 = new Film() { FilmID = "2009110010", FilmName = "The Secret of Kells", FilmGenre = Genre.family, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.Irish, ReleaseDate = new DateTime(2009, 12, 02), IMBDRating = 7.6, HomeRating = 6 };
            HomeCinema.Add(f10);

            Film f11 = new Film() { FilmID = "1966100011", FilmName = "The Good, the Bad and the Ugly", FilmGenre = Genre.western, FilmLocation = Location.Netflix, FilmOriginalLanguage = OriginalLanguage.Irish, ReleaseDate = new DateTime(1966, 12, 02), IMBDRating = 8.8, HomeRating = 4 };
            HomeCinema.Add(f11);
        }
    };
}
