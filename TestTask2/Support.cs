namespace TestTask2;

/// <summary>
/// Модель информации о поддержке.
/// </summary>
/// <param name="Url">Ссылка для поддержки.</param>
/// <param name="Text">Комментарий.</param>
public record Support(
    string Url,
    string Text
);