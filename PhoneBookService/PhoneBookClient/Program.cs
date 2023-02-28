// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using var client = new HttpClient();

var builder = new UriBuilder("https://localhost:7071/contact-by-name");
builder.Query = "name=Sarah";

var result = await client.GetAsync(builder.ToString());
var body = await result.Content.ReadAsStringAsync();
Console.WriteLine(body);
Console.WriteLine();

// random api to test out other apis (generates a random quoate from an anime :) )
var animeResult = await client.GetAsync("https://animechan.vercel.app/api/random");
var animeBody = await animeResult.Content.ReadAsStringAsync();
Console.WriteLine(animeBody);
Console.ReadLine();