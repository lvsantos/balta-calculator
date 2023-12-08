using Calculator2 = Balta.Calculator.Application.Calculator;

namespace Balta.Calculator.Tests;

public class CalculatorTests
{
    [Theory(DisplayName = "Must add two numbers")]
    [InlineData(2, 3, 5)]
    [InlineData(1.5, 2.5, 4)]
    public void Should_Add_TwoNumbers(double number1, double number2, double sum)
    {
        // Arrange & Act
        double result = Calculator2.Add(number1, number2);

        // Assert
        Assert.Equal(sum, result);
    }
}

