namespace TestTask3;

/// <summary>
/// Модель запроса для создания пользователя.
/// </summary>
/// <param name="Name">Имя пользователя.</param>
/// <param name="Job">Работа пользователя.</param>
public record CreateUserRequest(
    string Name,
    string Job
);