
public class Frog:Animal
{
   
    public Frog(string name, int age, string gender)
        :base(name, age, gender)
    {
        Gender = gender;
    }
   
    public override string ProduceSound()
    {
        return "Ribbit";
    }
}

