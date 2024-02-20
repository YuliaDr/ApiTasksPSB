namespace TestTask2;

/// <summary>
/// Модель ответа, содержащая информацию о странице с пользователями.
/// </summary>
/// <param name="Page">Номер страницы.</param>
/// <param name="PerPage">Количество пользователей на одной странице.</param>
/// <param name="Total">Общее количество пользователей.</param>
/// <param name="TotalPages">Общее количество страниц.</param>
/// <param name="Data">Массив пользователей.</param>
/// <param name="Support">Массив информации о поддержке.</param>
public record GetPageOfUsersResponse(
    int Page,
    int PerPage,
    int Total,
    int TotalPages,
    User[] Data,
    Support Support
);