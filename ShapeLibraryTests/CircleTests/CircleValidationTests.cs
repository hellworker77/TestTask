using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibraryTests.CircleTests;

public class CircleValidationTests
{
    [Fact]
    public void CreateNegativeRadiusCircle()
    {
        IShape circle = new Circle(-10);

        var isValid = circle.Validate();
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void CreateZeroRadiusCircle()
    {
        IShape circle = new Circle(0);

        var isValid = circle.Validate();
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void CreatePositiveRadiusCircle()
    {
        IShape circle = new Circle(1);

        var isValid = circle.Validate();
        
        Assert.True(isValid);
    }
}