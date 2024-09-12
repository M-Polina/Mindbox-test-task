namespace GeometryLibrary.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_IsCorrect()
    {
        int radius1 = 1;
        int radius2 = 125;
        double radius3 = 12.4;
        Circle circle1 = new Circle(radius1);
        Circle circle2 = new Circle(radius2);
        Circle circle3 = new Circle(radius3);

        Assert.Equal(Math.PI * radius1 * radius1, circle1.CalculateArea());
        Assert.Equal(Math.PI * radius2 * radius2, circle2.CalculateArea());
        Assert.Equal(Math.PI * radius3 * radius3, circle3.CalculateArea(), 1e-10);
    }

    [Fact]
    public void CreateCircleWithNotPositiveRadius_ThrowException()
    {
        int radius1 = 0;
        int radius2 = -15;

        Assert.Throws<ArgumentException>( () => new Circle(radius1));
        Assert.Throws<ArgumentException>(() => new Circle(radius2));
    }
}