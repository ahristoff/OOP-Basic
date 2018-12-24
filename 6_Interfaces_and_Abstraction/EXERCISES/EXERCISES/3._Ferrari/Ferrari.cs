using System.Text;

public class Ferrari:IFerrari
{

    public Ferrari(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public string Brakes()
    {
        return "Brakes!/";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!/";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append("488-Spider/");
        sb.Append(Brakes());
        sb.Append(GasPedal());
        sb.Append($"{Name}");

        return sb.ToString();
    }
}

