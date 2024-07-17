namespace CalculatorLibraryTest;
// THis is MSTest cases 
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestPositiveAdd()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonAdd(4, 3);

        Assert.AreEqual(7, resultPositive);
    }

    [TestMethod]
    public void TestPositiveAddAndMinus()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonAdd(4, 3);

        int resultNegative = calculator.CommonSubtract(4, 3);

        Assert.AreEqual(6, resultPositive - resultNegative);
    }

    [TestMethod]
    public void TestNegativeAdd()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonAdd(-4, -3);

        Assert.AreEqual(-7, resultNegative);
    }

    [TestMethod]
    public void TestPositiveSubtract()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonSubtract(4, 3);

        Assert.AreEqual(1, resultPositive);
    }

    [TestMethod]
    public void TestNegativeSubtract()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonSubtract(1, 3);

        Assert.AreEqual(-2, resultNegative);
    }

    [TestMethod]
    public void TestPositiveMultiply()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonMultiply(4, 3);

        Assert.AreEqual(24, calculator.CommonMultiply(resultPositive,2));
    }

    [TestMethod]
    public void TestNegativeMultiply()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonMultiply(-1, 3);

        Assert.AreEqual(-3, resultNegative);
    }

    [TestMethod]
    public void TestDoubleNegativeMultiply()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.CommonMultiply(-1, -3);

        Assert.AreEqual(3, resultDoubleNegative);
    }

    [TestMethod]
    public void TestPositiveDivide()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonDivide(6, 3);

        Assert.AreEqual(2, resultPositive);
    }

    [TestMethod]
    public void TestNegativeDivide()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonDivide(-4, 3);

        Assert.AreEqual(-1, resultNegative);
    }

    [TestMethod]
    public void TestDoubleNegativeDivide()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.CommonDivide(-6, -3);

        Assert.AreEqual(2, resultDoubleNegative);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    "2nd number can't be 0!!!")]
    public void TestDivideZero()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.CommonDivide(-6, 0);
    }

    [TestMethod]
    public void TestPositivePower()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonPower(2, 2);

        Assert.AreEqual(4, resultNegative);
    }

    [TestMethod]
    public void TestNegativeExponenetPower()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.CommonPower(2, -2);

        Assert.AreEqual(0, resultDoubleNegative);
    }

    [TestMethod]
    public void TestNegativeBasePower()
    {
        var calculator = new Calculator();

        int resultDoubleNegative = calculator.CommonPower(-2, 2);

        Assert.AreEqual(4, resultDoubleNegative);
    }

    [TestMethod]
    public void TestNegativeBaseNegativeAnswerPower()
    {
        var calculator = new Calculator();

        int resultNegativeBaseNegativeAnswer = calculator.CommonPower(-2, 3);

        Assert.AreEqual(-8, resultNegativeBaseNegativeAnswer);
    }

    [TestMethod]
    public void TestPositiveModulo()
    {
        var calculator = new Calculator();

        int resultPositive = calculator.CommonModulo(3, 3);

        Assert.AreEqual(0, resultPositive);
    }

    [TestMethod]
    public void TestNegativeModulo()
    {
        var calculator = new Calculator();

        int resultNegative = calculator.CommonModulo(-1, 3);

        Assert.AreEqual(2, resultNegative);
    }

    [TestMethod]
    public void TestZeroModulo()
    {
        var calculator = new Calculator();

        int resultZero = calculator.CommonModulo(3, 3);

        Assert.AreEqual(0, resultZero);
    }

    // END OF COMMON CORE STATE STANDARD MATHEMATICS

    // reverse polish Notation
    [TestMethod]
    public void TestZeroModuloPolish()
    {
        var calculator = new Calculator();

        int resultZero = calculator.PolishNotationOperations(['3', '3', '%']);

        Assert.AreEqual(0, resultZero);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    "the Stack is empty! Please put in order two numbers and an operation")]
    public void TestErrorStackEmptyPolish()
    {
        var calculator = new Calculator();

        calculator.PolishNotationOperations([]);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    @"Please enter the correct number of numbers for the operation, 
    two numbers in the array that come before the operation sign")]
    public void TestErrorNotEnoughNumbersPolish()
    {
        var calculator = new Calculator();

        calculator.PolishNotationOperations(['2', '-']);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    "Please make sure the first two entries in the array are numbers!")]
    public void TestErrorTooManyOperationsPolish()
    {
        var calculator = new Calculator();

        calculator.PolishNotationOperations(['2', '-', '-']);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException),
    "Can't divide by 0!")]
    public void TestErrorDivideByZeroPolish()
    {
        var calculator = new Calculator();

        calculator.PolishNotationOperations(['0', '2', '/']);
    }

    [TestMethod]
    public void TestMultiplyPolish()
    {
        var calculator = new Calculator();

        int result = calculator.PolishNotationOperations(['2', '2', '*']);

        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void TestMinusPolish()
    {
        var calculator = new Calculator();

        int result = calculator.PolishNotationOperations(['2', '3', '-']);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestAddPolish()
    {
        var calculator = new Calculator();

        int result = calculator.PolishNotationOperations(['2', '3', '*']);

        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestPowerPolish()
    {
        var calculator = new Calculator();

        int result = calculator.PolishNotationOperations(['0', '2', '^']);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestModuloPolish()
    {
        var calculator = new Calculator();

        int result = calculator.PolishNotationOperations(['3', '4', '%']);

        Assert.AreEqual(1, result);
    }

}


// Handful documentation:
// https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-8-0
// 

// Notes:
//      types of math:
//          - common core
//          - Reverse polish notation like "34+" = "7"

