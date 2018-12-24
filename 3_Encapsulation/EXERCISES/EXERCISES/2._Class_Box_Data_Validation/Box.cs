using System;
using System.Text;

class Box
{
    private double lenght;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        Length = lenght;
        Width = width;
        Height = height;
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }

            height = value;
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }

            width = value;
        }
    }

    public double Length
    {
        get { return lenght; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }

            lenght = value;
        }
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
        var lastSurfaceArea = 2 * (this.height * this.lenght) + 2 * (this.height * this.width);

        return lastSurfaceArea;
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

