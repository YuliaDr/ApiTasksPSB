using System.Net;
using System.Text.Json;
using RestSharp;

namespace TestTask3;

public class UnitTest1
{
    [Fact]
    public async void CreateUser_ValidData_ReturnsUserId()
    {
        // Arrange
        var createUserRequest = new CreateUserRequest(
            Name: "morpheus",
            Job: "leader"
        );
        
        // Настройки для (де)сериализации JSON ответа в SnakeCaseLower
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        };

        var client = new RestClient("https://reqres.in/api/");
        var request = new RestRequest("users");
        request.AddJsonBody(createUserRequest);

        // Act
        var response = await client.PostAsync(request);
        var createUserResponse = JsonSerializer.Deserialize<CreateUserResponse>(response.Content!, serializeOptions);

        // Assert
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        Assert.NotNull(createUserResponse?.Id);
    }
}