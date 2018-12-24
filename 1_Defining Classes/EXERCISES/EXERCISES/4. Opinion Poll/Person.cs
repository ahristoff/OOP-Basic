
public class Person
{
    private string name;
    private int age;

    public Person(int age, string name)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }  
}
