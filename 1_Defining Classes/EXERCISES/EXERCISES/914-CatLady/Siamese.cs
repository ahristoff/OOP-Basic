
public class Siamese : ICat
{
    private int earSize { get; set; }

    public string Breed { get; set; }

    public string Name { get; set; }

    public Siamese(string breed, string name, int earSize)
    {
        this.earSize = earSize;
        Breed = breed;
        Name = name;
    }
    
    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.earSize}";
    }
}
