using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests.TriangleTests;

public class TriangleIsRightAngleTests
{
    [Fact]
    public void IsNotRightAngleTest()
    {
        ITriangle triangle = new Triangle(3, 4, 5.2f);

        var isRightAngle = triangle.IsRightAngle();
        
        Assert.False(isRightAngle);
    }
    
    [Fact]
    public void IsRightAngleTest()
    {
        ITriangle triangle = new Triangle(3, 4, 5);

        var isRightAngle = triangle.IsRightAngle();
        
        Assert.True(isRightAngle);
    }
}