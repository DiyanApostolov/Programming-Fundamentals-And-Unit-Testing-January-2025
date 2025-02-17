using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> inputList = new() { 42 };
        int expected = 42;

        //Act
        int result = MaxNumber.FindMax(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> inputList = new() { 42, 5, 18, 102, 57 };
        int expected = 102;

        //Act
        int result = MaxNumber.FindMax(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> inputList = new() { -42, -5, -18, -102, -57 };
        int expected = -5;

        //Act
        int result = MaxNumber.FindMax(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> inputList = new() { -42, 5, -18, -102, 57 };
        int expected = 57;

        //Act
        int result = MaxNumber.FindMax(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> inputList = new() { 42, 5, 18, 102, 57, 102 };
        int expected = 102;

        //Act
        int result = MaxNumber.FindMax(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
