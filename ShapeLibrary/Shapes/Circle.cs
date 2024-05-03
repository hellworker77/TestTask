using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes;

public class Circle : IShape
{
    private readonly float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public bool Validate()
        => _radius > 0;

    public double CalculateArea()
        => Math.PI * _radius * _radius;
}