namespace CalculatorLibraryTest;
// THis is MSTest cases 
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestPositiveAdd()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.Add(4, 3);

        Assert.AreEqual(7, resultPositive);
    }

    [TestMethod]
    public void TestNegativeAdd()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Add(-4, -3);

        Assert.AreEqual(-7, resultNegative);
    }

    [TestMethod]
    public void TestPositiveSubtract()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.Subtract(4, 3);

        Assert.AreEqual(1, resultPositive);
    }

    [TestMethod]
    public void TestNegativeSubtract()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Subtract(1, 3);

        Assert.AreEqual(-2, resultNegative);
    }
}

// Handful documentation:
// https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0