
public class StreetExtraordinaire : ICat
{
    private int Decibels { get; set; }

    public string Breed { get; set; }

    public string Name { get; set; }

    public StreetExtraordinaire(string breed, string name, int decibels)
    {
        this.Decibels = decibels;
        Breed = breed;
        Name = name;
    }
  
    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.Decibels}";
    }
   
}