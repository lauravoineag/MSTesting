namespace Exercise;

public interface ICalculator
{
    int Multiply(int a, int b);
    int Add(int a, int b);
}

public class Calculator:ICalculator
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class ListCalculator
{
    private ICalculator _calculator;

    public ListCalculator(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public IEnumerable<int> MultiplyList(IEnumerable<int> listIntegers, int factor)
    {
        foreach (var item in listIntegers)
        {
            yield return _calculator.Multiply(item,factor);
        } 
        /*foreach (var item in listIntegers)
        {
            yield return item * factor;
        }*/
    }

    public IEnumerable<int> AddList(IEnumerable<int> listIntegers, int operand)
    {
        foreach (var item in listIntegers)
        {
            yield return item + operand;
        }
    }

} 