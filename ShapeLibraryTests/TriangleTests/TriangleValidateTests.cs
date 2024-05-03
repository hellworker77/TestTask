using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests.TriangleTests;

public class TriangleValidateTests
{
    [Fact]
    public void CreateNegativeSideTriangle()
    {
        IShape triangle = new Triangle(-1, 1, 1);

        var isValid = triangle.Validate();
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void CreateZeroSideTriangle()
    {
        IShape triangle = new Triangle(0, 1, 1);

        var isValid = triangle.Validate();
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void CreateImpossibleTriangle()
    {
        IShape triangle = new Triangle(3, 1, 1);

        var isValid = triangle.Validate();
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void CreatePositiveSideTriangle()
    {
        IShape triangle = new Triangle(1, 1, 1);

        var isValid = triangle.Validate();
        
        Assert.True(isValid);
    }
}