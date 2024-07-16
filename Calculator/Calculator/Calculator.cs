using System.Collections;
public class Calculator 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int CommonAdd(int x, int y)
    {
        return x + y;
    }

    public int CommonSubtract(int x, int y)
    {
        return x - y;
    }

    public int CommonMultiply(int x, int y)
    {
        return x * y;
    }
    
    public int CommonDivide(int x, int y)
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

    public int CommonPower(int x, int y)
    {
        return (int) Math.Pow(x, y);
    }

    public int CommonModulo(int x, int y)
    {
        return (x % y + y) % y;
    }

    // End of common standard notation

    // Start of reverse polish

    public int PolishNotationOperations(char[] calculation)
    {
        Stack<char> currStack = new Stack<char>();
        foreach (char x in calculation)
        {
            currStack.Push(x);
        }
        if (currStack.Count() == 0)
        {
            throw new InvalidOperationException("the Stack is empty! Please put in order two numbers and an operation");
        }
        char currChar = currStack.Peek();
        if (!Char.IsNumber(currStack.Peek()))
        {
            char currOperation = currStack.Pop();
            if (currStack.Count() < 2)
            {
                throw new InvalidOperationException(@"Please enter the correct number of numbers for the operation, 
                two numbers in the array that come before the operation sign");
            }

            // tried using a try and catch here but the first if statement makes it so I do not have to
            char firstNumber = currStack.Pop();
            char secondNumber = currStack.Pop();
            if (!Char.IsNumber(firstNumber) && !Char.IsNumber(secondNumber))
            {
               throw new InvalidOperationException("Please make sure the first two entries in the array are numbers!"); 
            }
            else
            {
                if (currOperation == '/')
                {

                }
                else if (currOperation == '*')
                {

                }
                else if (currOperation == '-')
                {

                }
                else if (currOperation == '+')
                {
                    
                }
                else if (currOperation == '^')
                {
                    
                }
                else if (currOperation == '%')
                {

                }
            }
            return -1;
        }

    }

    // https://stackify.com/unit-testing-basics-best-practices/
}
