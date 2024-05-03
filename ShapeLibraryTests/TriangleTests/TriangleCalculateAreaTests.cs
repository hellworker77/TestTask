using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests.TriangleTests;

public class TriangleCalculateAreaTests
{
    [Fact]
    public void CalculateAreaTest()
    {
        var expectedSquare = 6;
        IShape triangle = new Triangle(3, 4, 5);

        var actualSquare = triangle.CalculateArea();
        
        Assert.Equal(expectedSquare, actualSquare);
    }
}