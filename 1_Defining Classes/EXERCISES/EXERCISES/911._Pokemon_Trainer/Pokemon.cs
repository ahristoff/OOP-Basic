
class Pokemon
{
    public Pokemon(string name, string element, int health)
    {
        Name = name;
        Element = element;
        Health = health;
    }

    public int Health { get; set; }
   
    public string Element { get; set; }

    public string Name { get; set; }
}

