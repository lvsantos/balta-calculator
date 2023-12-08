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
    [Theory(DisplayName = "Must subtract two numbers")]
    [InlineData(5, 3, 2)]
    [InlineData(2.5, 1.5, 1)]
    public void Should_Subtract_TwoNumbers(double number1, double number2, double subtraction)
    {
        // Arrange & Act
        double result = Calculator2.Subtract(number1, number2);

        // Assert
        Assert.Equal(subtraction, result);
    }
    [Theory(DisplayName = "Must divide two numbers")]
    [InlineData(6, 3, 2)]
    [InlineData(2.5, 1.25, 2)]
    public void Should_Divide_TwoNumbers(double number1, double number2, double division)
    {
        // Arrange & Act
        double result = Calculator2.Divide(number1, number2);

        // Assert
        Assert.Equal(division, result);
    }
}

