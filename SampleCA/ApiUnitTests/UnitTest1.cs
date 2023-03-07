using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCA.Controllers;
using SampleCA.Models;

namespace ApiUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void init(TestContext context)
        { // This function HAS to be written like this
            Catalogue.init();
        }

        [TestMethod]
        public void RetrunAllMoviesTest()
        {
            ReturnAllMovies controller = new ReturnAllMovies();

            var allMovies = controller.Get();

            Assert.AreEqual(4, allMovies.Count);
        }

        [TestMethod]
        public void SearchByKeyWord()
        {
            SearchMoviesByKeyword controller = new SearchMoviesByKeyword();

            List<Movie> searched = controller.Get("Werewolf");
            Assert.AreEqual(searched.Count(), 1);
        }

    }
}