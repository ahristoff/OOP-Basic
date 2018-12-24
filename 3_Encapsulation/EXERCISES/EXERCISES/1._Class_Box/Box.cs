using System.Text;

class Box
{
    private double lenght;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.lenght = lenght;
        this.width = width;
        this.height = height;
    }   

    public double Volume()
    {
        var volume = this.height * this.width * this.lenght;
        return volume;
    }

    public double SurfaceArea()
    {
        var surfaceArea = 2 * (this.height * this.width) + 2 * (this.height * this.lenght) + 2 * (this.lenght * this.width);
        return surfaceArea;
    }

    public double LateralSurfaceArea()
    {
        var surfaceArea = 2 * (this.height * this.lenght) + 2 * (this.height * this.width);
        return surfaceArea;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
        sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
        sb.AppendLine($"Volume - {Volume():f2}");

        return sb.ToString().Trim(); 
    }
}

