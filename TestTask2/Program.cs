using System.Net;
using System.Text.Json;
using RestSharp;

namespace TestTask2;

internal class Program
{
    public static async Task Main()
    {
        var client = new RestClient("https://reqres.in/api/");
        var request = new RestRequest("users");
        request.AddParameter("page", "2");
        var response = await client.GetAsync(request);

        if (response.StatusCode == HttpStatusCode.OK && response.Content != null)
        {
            // Настройки для (де)сериализации JSON ответа в SnakeCaseLower
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
            };

            var getPageOfUsersResponse =
                JsonSerializer.Deserialize<GetPageOfUsersResponse>(response.Content, serializeOptions);

            if (getPageOfUsersResponse != null)
            {
                foreach (var user in getPageOfUsersResponse.Data)
                {
                    if (user.FirstName == "George" && user.LastName == "Edwards")
                    {
                        Console.WriteLine(user.Email);
                    }
                }
            }
        }
    }
}