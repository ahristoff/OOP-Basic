
public class Rectangle:Shape
{

    public Rectangle(double height, double weidth)
    {
        Height = height;
        Weidth = weidth;
    }

    public double Weidth { get; set; }
   
    public double Height { get; set; }
  

    public override double CalculateArea()
    {
        return Height * Weidth;
    }

    public override double CalculatePerimeter()
    {
       return 2 * Height + 2 * Weidth;
    }

    public override string Draw()
    {
        return base.Draw() + " " +"Rectangle";
    }
}

