namespace IsoscelesTriangle.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ValidIsoscelesTriangle_Input60and60and60_OutputValidIsoscelesTriangle()
    {
        //Arrange
        int firstAngle = 60;
        int secondAngle = 60;
        int thirdAngle = 90;

        string expected = "This is a valid Isosceles Triangle";

        //Act
        string actual = IsoscelesTriangle.Services.IsoscelesTriangle.ValidIsoscelesTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}