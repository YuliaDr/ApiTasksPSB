namespace TestTask2;

/// <summary>
/// Модель пользователя.
/// </summary>
/// <param name="Id">Id пользователя.</param>
/// <param name="Email">Email пользователя.</param>
/// <param name="FirstName">Имя пользователя.</param>
/// <param name="LastName">Фамилия пользователя.</param>
/// <param name="Avatar">Аватар пользователя.</param>
public record User(
    int Id,
    string Email,
    string FirstName,
    string LastName,
    string Avatar
);