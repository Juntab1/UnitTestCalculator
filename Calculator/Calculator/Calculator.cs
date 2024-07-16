public class Calculator 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }
    
    public int Divide(int x, int y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            throw new InvalidOperationException("2nd number can't be 0!!!");
        }
    }

    public int Power(int x, int y)
    {
        return (int) Math.Pow(x, y);
    }

    public int Modulo(int x, int y)
    {
        return (x % y + y) % y;
    }

    // https://stackify.com/unit-testing-basics-best-practices/
}
