namespace TestTask1;

/// <summary>
/// Модель ответа, содержащая информацию о герое Звездных воинов.
/// </summary>
/// <param name="Name">Имя героя.</param>
/// <param name="Height">Рост героя.</param>
/// <param name="Mass">Вес героя.</param>
/// <param name="HairColor">Цвет волос героя.</param>
/// <param name="SkinColor">Цвет кожи героя.</param>
/// <param name="EyeColor">Цвет глаз героя.</param>
/// <param name="BirthYear">Год рождения героя.</param>
/// <param name="Gender">Пол героя.</param>
/// <param name="Homeworld">Родной мир героя.</param>
/// <param name="Films">Ссылки на фильмы с героем.</param>
/// <param name="Species">Расы героя.</param>
/// <param name="Vehicles">Ссылки на транспортные средства героя.</param>
/// <param name="Starships">Ссылки на звездолеты героя.</param>
/// <param name="Created">Дата создания героя.</param>
/// <param name="Edited">Дата изменения героя.</param>
/// <param name="Url">Ссылка героя.</param>
public record GetPersonByIdResponse(
    string Name,
    string Height,
    string Mass,
    string HairColor,
    string SkinColor,
    string EyeColor,
    string BirthYear,
    string Gender,
    string Homeworld,
    string[] Films,
    string[] Species,
    string[] Vehicles,
    string[] Starships,
    DateTime Created,
    DateTime Edited,
    string Url
);