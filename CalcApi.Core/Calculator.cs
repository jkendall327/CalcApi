namespace CalcApi.Core;

public interface ICalculator
{
    int Add(int x, int y);
    int Subtract(int x, int y);
    int Multiply(int x, int y);
    int? Divide(int x, int y);
}

public class Calculator : ICalculator
{
    public int Add(int x, int y)
    {
        throw new NotImplementedException();
    }

    public int Subtract(int x, int y)
    {
        throw new NotImplementedException();
    }

    public int Multiply(int x, int y)
    {
        throw new NotImplementedException();
    }

    public int? Divide(int x, int y)
    {
        throw new NotImplementedException();
    }
}