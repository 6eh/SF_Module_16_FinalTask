namespace Practices.Tests;

public class CalculatorTests
{
    [Test]
    public void AdditionalMustReturnCorrectValue()
    {
        Calculator calculator = new ();
        Assert.That(calculator.Additional(1, 1) == 2);
    }

    [Test]
    public void SubtractionMustReturnCorrectValue()
    {
        Calculator calculator = new();
        Assert.True(calculator.Subtraction(8, 1) == 7);
    }

    [Test]
    public void MiltiplicationMustReturnCorrectValue()
    {
        Calculator calculator = new();
        Assert.True(calculator.Miltiplication(8, 10) == 80);
    }

    [Test]
    public void DivisionMustReturnCorrectValue()
    {
        Calculator calculator = new();
        Assert.That(calculator.Division(100, 2) == 50);
    }
}
