using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes;

public class Triangle : IShape, ITriangle
{
    private readonly float _sideA;
    private readonly float _sideB;
    private readonly float _sideC;

    public Triangle(float sideA, float sideB, float sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public bool Validate()
        => !IsThereNegativeOrZeroSides() && IsTrianglePossible();

    public double CalculateArea()
    {
        var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) *(halfPerimeter - _sideC));
    }
    public bool IsRightAngle()
    {
        double delta = 1e-10;
        return Math.Abs(_sideA * _sideA + _sideB * _sideB - _sideC * _sideC) < delta ||
               Math.Abs(_sideC * _sideC + _sideB * _sideB - _sideA * _sideA) < delta ||
               Math.Abs(_sideA * _sideA + _sideC * _sideC - _sideB * _sideB) < delta;
    }
    private bool IsThereNegativeOrZeroSides()
        => _sideA <= 0 || _sideB <= 0 || _sideC <= 0;

    private bool IsTrianglePossible()
        => _sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA;
    
}
