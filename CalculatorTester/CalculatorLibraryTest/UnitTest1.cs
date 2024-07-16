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

    [TestMethod]
    public void TestPositiveMultiply()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.Multiply(4, 3);

        Assert.AreEqual(12, resultPositive);
    }

    [TestMethod]
    public void TestNegativeMultiply()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Multiply(-1, 3);

        Assert.AreEqual(-3, resultNegative);
    }

    [TestMethod]
    public void TestDoubleNegativeMultiply()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.Multiply(-1, -3);

        Assert.AreEqual(3, resultDoubleNegative);
    }

    [TestMethod]
    public void TestPositiveDivide()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.Divide(6, 3);

        Assert.AreEqual(2, resultPositive);
    }

    [TestMethod]
    public void TestNegativeDivide()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Divide(-4, 3);

        Assert.AreEqual(-1, resultNegative);
    }

    [TestMethod]
    public void TestDoubleNegativeDivide()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.Divide(-6, -3);

        Assert.AreEqual(2, resultDoubleNegative);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    "2nd number can't be 0!!!")]
    public void TestDivideZero()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.Divide(-6, 0);
    }

    [TestMethod]
    public void TestPositivePower()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Power(2, 2);

        Assert.AreEqual(4, resultNegative);
    }

    [TestMethod]
    public void TestNegativeExponenetPower()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.Power(2, -2);

        Assert.AreEqual(0, resultDoubleNegative);
    }

    [TestMethod]
    public void TestNegativeBasePower()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.Power(-2, 2);

        Assert.AreEqual(4, resultDoubleNegative);
    }

    [TestMethod]
    public void TestNegativeBaseNegativeAnswerPower()
    {
        var calculator = new Calculator();

        int resultNegativeBaseNegativeAnswer = calculator.Power(-2, 3);

        Assert.AreEqual(-8, resultNegativeBaseNegativeAnswer);
    }

    [TestMethod]
    public void TestPositiveModulo()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.Modulo(3, 3);

        Assert.AreEqual(0, resultPositive);
    }

    [TestMethod]
    public void TestNegativeModulo()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.Modulo(-1, 3);

        Assert.AreEqual(2, resultNegative);
    }

    [TestMethod]
    public void TestZeroModulo()
    {
        var calculator = new Calculator();

        int resultZero = calculator.Modulo(3, 3);

        Assert.AreEqual(0, resultZero);
    }

    // END OF COMMON CORE STATE STANDARD MATHEMATICS


}


// Handful documentation:
// https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0
// 

// Notes:
//      types of math:
//          - common core
//          - Reverse polish notation like "34+" = "7"

