namespace LibraryApi.Helpers;

public class StringHelper
{
    public bool IsEmpty(string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }

    public int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        var words = text.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    public string Capitalize(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }

    public bool Contains(string text, string? substring)
    {
        return substring != null && text.Contains(substring, StringComparison.OrdinalIgnoreCase);
    }
}