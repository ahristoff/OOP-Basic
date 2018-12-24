
public class Dog:Animal
{
    
    public Dog(string name, int age, string gender)
        :base(name, age, gender)
    {
        Gender = gender;
    }
   
    public override string ProduceSound()
    {
        return "Woof!";
    }
}

