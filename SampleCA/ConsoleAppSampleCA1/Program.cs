// See https://aka.ms/new-console-template for more information
using SampleCA.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");
Console.WriteLine("Test test test!");




using (HttpClient client = new HttpClient())
{
    UriBuilder uriBuilder = new UriBuilder("https://localhost:7153/api/return-all-movies");
    //uriBuilder.Query = "MovieId=101010";

    var res = await client.GetFromJsonAsync<List<Movie>>(uriBuilder.ToString());
    foreach (Movie m in res)
    {
        Console.WriteLine(m.Title);
    }

    UriBuilder getMovieURI = new UriBuilder("https://localhost:7153/api/SearchMoviesByKeyword");
    getMovieURI.Query = "Keyword=American";
    var res2 = await client.GetFromJsonAsync<List<Movie>>(getMovieURI.ToString());
    foreach (Movie m in res2)
    {
        Console.WriteLine(m.Title);
    }

    //
    UriBuilder MovieIDURI = new UriBuilder("https://localhost:7153/api/ReturnMovieByMovieID");

    MovieIDURI.Query = "MovieId=101010";

    var res3 = await client.GetFromJsonAsync<Movie>(MovieIDURI.ToString());

    Console.WriteLine(res3.Title);
}

//    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//HttpResponseMessage response = await client.GetAsync(uriBuilder.ToString());
//if (response.IsSuccessStatusCode)
//{
//var x = await response.Content.ReadFromJsonAsync<List<Movie>>();

//}
//var body = await response.Content.ReadFromJsonAsync

//Console.WriteLine(response);
Console.ReadLine();