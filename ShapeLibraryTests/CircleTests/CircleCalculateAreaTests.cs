using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests.CircleTests;

public class CircleCalculateAreaTests
{
    [Fact]
    public void CalculateAreaTest()
    {
        var radius = 5;
        var expectedSquare = radius * radius * Math.PI;
        IShape circle = new Circle(radius);

        var actualSquare = circle.CalculateArea();
        
        Assert.Equal(expectedSquare, actualSquare);
    }
}