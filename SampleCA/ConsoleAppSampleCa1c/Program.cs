// See https://aka.ms/new-console-template for more information
using SampleCA.Models;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

using (HttpClient client = new HttpClient())
{
    //
    UriBuilder uriAllMovies = new UriBuilder("https://localhost:7153/api/return-all-movies");

    var res1 = await client.GetFromJsonAsync<List<Movie>>(uriAllMovies.ToString());

    foreach (Movie m in res1)
    {
        Console.WriteLine(m);
    }


    //
    UriBuilder uriMID = new UriBuilder("https://localhost:7153/api/ReturnMovieByMovieID");
    uriMID.Query = "MovieId=101010";
    var res2 = await client.GetFromJsonAsync<Movie>(uriMID.ToString());
    Console.WriteLine(res2);


    //
    UriBuilder uriSearch = new UriBuilder("https://localhost:7153/api/SearchMoviesByKeyword");
    uriSearch.Query = "Keyword=Werewolf";
    var res3 = await client.GetFromJsonAsync<List<Movie>>(uriSearch.ToString());
    
    foreach (Movie m in res3)
    {
        Console.WriteLine(m);
    }

    Console.ReadLine();






    //UriBuilder uriNewFilm = new UriBuilder("https://localhost:7153/api/film");
    ////uriSearch. = "Keyword=Werewolf";
    ////var content = new HttpContent();
    //var dict = new Dictionary<string, string>();
    //dict.Add("id", "my-new-movie");
    //dict.Add("title", "Cool Movie!");
    //dict.Add("releaseDate", "12-23-2023");
    //var content = new FormUrlEncodedContent(dict);

    //var res3 = await client.PostAsync(uriNewFilm.ToString(), content);

    //foreach (Movie m in res3)
    //{
    //    Console.WriteLine(m);
    //}

    //Console.ReadLine();

}
