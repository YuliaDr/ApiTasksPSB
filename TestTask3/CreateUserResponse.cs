namespace TestTask3;

/// <summary>
/// Модель ответа, содержащая информацию о созданном пользователе.
/// </summary>
/// <param name="Id">Id пользователя.</param>
/// <param name="Name">Имя пользователя.</param>
/// <param name="Job">Работа пользователя.</param>
/// <param name="CreatedAt">Дата создания пользователя.</param>
public record CreateUserResponse(
    string Id,
    string Name,
    string Job,
    DateTime CreatedAt
);