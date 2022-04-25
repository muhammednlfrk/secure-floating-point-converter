using System.Globalization;
using FloatingPointConverter.Helpers;

namespace FloatingPointConverter;

public class SecureConverter
{
    private static string getCleanString(object value)
    {
        if (value == null || value.GetType() == typeof(string) && ((string)value).Trim() == string.Empty)
            throw new ArgumentNullException(nameof(value), $"{nameof(value)} can not to be null.");

        string valueStr = value?.ToString() ?? throw new ArgumentNullException(nameof(value), $"{nameof(value)} can not to be null.");


        valueStr = valueStr.RemoveNonNumericalChars();
        if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
        {
            if (valueStr.Contains('.') && valueStr.Contains(','))
            {
                int separatorIndex = valueStr.IndexOf('.');

                if (separatorIndex != -1)
                    valueStr = valueStr[..separatorIndex] + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + valueStr[(separatorIndex + 1)..];
            }
            else
                valueStr = valueStr.Replace(',', '.');
        }
        else
        {
            if (valueStr.Contains(',') && valueStr.Contains('.'))
            {
                int separatorIndex = valueStr.IndexOf(',');

                if (separatorIndex != -1)
                    valueStr = valueStr[..separatorIndex] + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + valueStr[(separatorIndex + 1)..];
            }
            else
                valueStr = valueStr.Replace('.', ',');
        }

        return valueStr;
    }

    public static double ToDouble(object value)
    {
        if (double.TryParse(getCleanString(value), out double result))
            return result;

        throw new FormatException("This value is not a double.");
    }

    public static float ToFloat(object value)
    {
        if (float.TryParse(getCleanString(value), out float result))
            return result;

        throw new FormatException("This value is not a float.");
    }

    public static decimal ToDecimal(object value)
    {
        if (decimal.TryParse(getCleanString(value), out decimal result))
            return result;

        throw new FormatException("This value is not a decimal.");
    }
}
