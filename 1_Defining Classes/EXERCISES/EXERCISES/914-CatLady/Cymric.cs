
public class Cymric : ICat
{
    public double FurLength { get; set; }

    public string Breed { get; set; }

    public string Name { get; set; }

    public Cymric(string breed, string name, double furLength)
    {
        FurLength = furLength;
        Breed = breed;
        Name = name;
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.FurLength:f2}";
    }
}
