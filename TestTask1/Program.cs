using System.Net;
using System.Text.Json;
using RestSharp;

namespace TestTask1;

internal class Program
{
    public static async Task Main()
    {
        var client = new RestClient("https://swapi.dev/api/");
        var request = new RestRequest("people/1");
        var response = await client.GetAsync(request);

        if (response.StatusCode == HttpStatusCode.OK && response.Content != null)
        {
            // Настройки для (де)сериализации JSON ответа в SnakeCaseLower
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
            };

            var getPersonByIdResponse =
                JsonSerializer.Deserialize<GetPersonByIdResponse>(response.Content, serializeOptions);

            if (getPersonByIdResponse?.Films != null)
            {
                foreach (var film in getPersonByIdResponse.Films)
                {
                    Console.WriteLine(film);
                }
            }
        }
    }
}