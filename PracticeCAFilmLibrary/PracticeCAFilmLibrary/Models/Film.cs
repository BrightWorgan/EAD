using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace PracticeCAFilmLibrary.Models
{
    // Enums:
    public enum Genre { horror, action, fantasty, drama, adventure, historical, crime, mystery, comedy, thriller, science_fiction, family, western }
    public enum Location { Netflix, DisneyPlus, Prime, NowTV, CrunchyRoll, GoogleMovies}
    public enum OriginalLanguage { English, Irish, Japanese, French, Spanish}
    public class Film
    {
        // attrributes
        public string FilmID { get; set; }
        public string FilmName { get; set; }
        public Genre FilmGenre { get; set; }
        public Location FilmLocation { get; set; }
        public OriginalLanguage FilmOriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double IMBDRating { get; set; }
        public double HomeRating { get; set; }

        // ToString()
        public override string ToString()
        {
            return String.Format("\tFil Details: \n\tFilm ID: {0}\n\t Title {1}\n\tFilmGenre: {2}\n\tFilmLocation: {3}\n\tFilmOriginalLanguage: {4}\n\tReleaseDate: {5}\n\tIMBDRating: {6}\n\t HomeRating {7}", FilmID, FilmName, FilmGenre, FilmLocation, FilmOriginalLanguage, ReleaseDate, IMBDRating, HomeRating);
        }
    }
}
