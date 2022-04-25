using System.Text;

namespace FloatingPointConverter.Helpers;

internal static class StringExtensions
{
    public static string RemoveNonNumericalChars(this string input)
    {
        StringBuilder stringBuilder = new StringBuilder(input.Length);

        foreach (char c in input)
            if (char.IsDigit(c) || c == '.' || c == ',')
                stringBuilder.Append(c);

        return stringBuilder.ToString();
    }
}
