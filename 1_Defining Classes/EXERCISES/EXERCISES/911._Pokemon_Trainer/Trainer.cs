using System.Collections.Generic;

class Trainer
{
    public Trainer(string name, List<Pokemon> pokemons, int numberOfBadges = 0)
    {
        Name = name;
        NumberOfBadges = numberOfBadges;
        Pokemons = pokemons;
    }

    public List<Pokemon> Pokemons { get; set; }

    public int NumberOfBadges { get; set; }

    public string Name { get; set; }

    public override string ToString()
    {        
        return $"{Name} {NumberOfBadges} {Pokemons.Count}"; 
    }
}

