
public abstract class Animal
{
   
    public Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;

    }

    public string FavouriteFood { get; set; }    

    public string Name { get; set; }    

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }

}

