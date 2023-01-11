using OneOf;

namespace CalcApi.Core;

using Result = OneOf<int, Error>;

/// <summary>
/// Represents a simple calculator over the <see cref="Int32"/> type,
/// accounting for integer overflow and division-by-zero errors.
/// </summary>
public interface ICalculator
{
    Result Add(int x, int y);
    Result Subtract(int x, int y);
    Result Multiply(int x, int y);
    Result Divide(int x, int y);
}

public class Calculator : ICalculator
{
    public Result Add(int x, int y)
    {
        throw new NotImplementedException();
    }

    public Result Subtract(int x, int y)
    {
        throw new NotImplementedException();
    }

    public Result Multiply(int x, int y)
    {
        throw new NotImplementedException();
    }

    public Result Divide(int x, int y)
    {
        if (y is 0)
        {
            return new Error { Message = "Division by zero is undefined." };
        }

        return x / y;
    }
}