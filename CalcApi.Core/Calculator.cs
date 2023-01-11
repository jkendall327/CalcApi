using OneOf;

namespace CalcApi.Core;

public interface ICalculator
{
    OneOf<int, Error> Add(int x, int y);
    OneOf<int, Error> Subtract(int x, int y);
    OneOf<int, Error> Multiply(int x, int y);
    OneOf<int, Error> Divide(int x, int y);
}

public class Calculator : ICalculator
{
    public OneOf<int, Error> Add(int x, int y)
    {
        throw new NotImplementedException();
    }

    public OneOf<int, Error> Subtract(int x, int y)
    {
        throw new NotImplementedException();
    }

    public OneOf<int, Error> Multiply(int x, int y)
    {
        throw new NotImplementedException();
    }

    public OneOf<int, Error> Divide(int x, int y)
    {
        throw new NotImplementedException();
    }
}