namespace GeometryLibrary.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_IsCorrect()
    {
        Triangle triangle1 = new Triangle(1, 1, Math.Sqrt(2));
        Triangle triangle2 = new Triangle(4, 3, 5);

        Assert.Equal(0.5, triangle1.CalculateArea(), 1e-10);
        Assert.Equal(6, triangle2.CalculateArea());
    }

    [Fact]
    public void CreateTriangleWithIncorrectSides_ThrowException()
    {
        Assert.Throws<ArgumentException>( () => new Triangle(5, 10, 16));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 5, 4));
        Assert.Throws<ArgumentException>(() => new Triangle(-10, 10, 4));
    }
    
    [Fact]
    public void TestIsRightAngled()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());

        Triangle nonRightTriangle = new Triangle(4, 4, 4);
        Assert.False(nonRightTriangle.IsRightAngled());
    }
}