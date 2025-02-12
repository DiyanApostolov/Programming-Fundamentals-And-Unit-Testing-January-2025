using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        //Arrange
        int inputNumber = 0;
        int expected = 1;

        //Act
        int result = Factorial.CalculateFactorial(inputNumber);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int inputNumber = 5;
        int expected = 120;

        //Act
        int result = Factorial.CalculateFactorial(inputNumber);

        //Assert
        Assert.AreEqual(expected, result);
    }
}
