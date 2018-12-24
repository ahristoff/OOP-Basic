
public class Rebel: IBuyer
{
    public const int Food = 5;

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
  
    public string Group { get; set; }
   
    public int Age { get; set; }
    
    public string Name { get; set; }
    
    public int BuyFood()
    {
        return Food;
    }
}

