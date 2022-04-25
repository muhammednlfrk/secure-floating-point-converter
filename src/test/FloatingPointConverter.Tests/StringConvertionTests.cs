using Xunit;

namespace FloatingPointConverter.Tests;

public class StringConvertionTests
{
    [Fact]
    public void String_To_Double_Convertion()
    {
        // Arrange
        string value1 = "1.2342342klnadn";
        string value2 = "1,2342342lsafkn";

        // Act
        double result1 = SecureConverter.ToDouble(value1);
        double result2 = SecureConverter.ToDouble(value2);

        // Assert
        Assert.Equal(1.2342342d, result1);
        Assert.Equal(1.2342342d, result2);
    }

    [Fact]
    public void String_To_Float_Convertion()
    {
        // Arrange
        string value1 = "1.2342342klnadn";
        string value2 = "1,2342342lsafkn";

        // Act
        float result1 = SecureConverter.ToFloat(value1);
        float result2 = SecureConverter.ToFloat(value2);

        // Assert
        Assert.Equal(1.2342342f, result1);
        Assert.Equal(1.2342342f, result2);
    }

    [Fact]
    public void String_To_Decimal_Convertion()
    {
        // Arrange
        string value1 = "1.2342342klnadn";
        string value2 = "1,2342342lsafkn";

        // Act
        decimal result1 = SecureConverter.ToDecimal(value1);
        decimal result2 = SecureConverter.ToDecimal(value2);

        // Assert
        Assert.Equal(1.2342342m, result1);
        Assert.Equal(1.2342342m, result2);
    }
}