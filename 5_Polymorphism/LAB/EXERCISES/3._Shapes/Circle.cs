using System;

public class Circle: Shape
{

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; set; }
   
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string Draw()
    {
        return base.Draw() + " " + "Circle";
    }
}

