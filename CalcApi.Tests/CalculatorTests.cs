using CalcApi.Core;
using FluentAssertions;
using OneOf;

namespace CalcApi.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut = new();
    
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(15, 3, 18)]
    [InlineData(99, 1, 100)]
    public void Addition_Should_ReturnCorrectResult(int first, int second, int expected)
    {
        var actual = _sut.Add(first, second);
        
        RequireSuccesfulCalculation(actual).Should().Be(expected);
    }

    [Theory]
    [InlineData(5, 3)]
    public void Addition_Should_BeCommutative(int first, int second)
    {
        var firstResult = _sut.Add(first, second);
        var secondResult = _sut.Add(second, first);

        firstResult.Should().Be(secondResult);
    }

    [Fact]
    public void Addition_OverMaximumValidInt_ShouldReturnError()
    {
        var max = int.MaxValue;

        var actual = _sut.Add(max, 1);
        
        RequireFailedCalculation(actual);
    }

    [Fact]
    public void Subtraction_BelowMinimumValidInt_ShouldReturnError()
    {
        var min = int.MinValue;

        var actual = _sut.Subtract(min, 1);

        RequireFailedCalculation(actual);
    }

    [Fact]
    public void Subtraction_OfNegativeValue_ShouldReturnPositive()
    {
        var firstOperand = 3;
        
        var actual = _sut.Subtract(firstOperand, -5);

        RequireSuccesfulCalculation(actual).Should().BeGreaterThan(firstOperand);
    }

    [Fact]
    public void DivisionByZero_Should_ReturnNull()
    {
        var actual = _sut.Divide(1, 0);

        RequireFailedCalculation(actual);
    }

    private int RequireSuccesfulCalculation(OneOf<int, Error> monad) => monad.Match(x => x, y => throw new Exception());
    private Error RequireFailedCalculation(OneOf<int, Error> monad) => monad.Match(x => throw new Exception(), y => y);
}