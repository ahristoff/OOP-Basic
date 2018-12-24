
public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private string fullName;
  
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName; 
        this.lastName = lastName;
        this.age = age;
    }

    public int Age  
    {
        get { return age; }        
    }

    public string LastName        
    {
        get { return lastName; }      
    }

    public string FirstName    
    {
        get { return firstName; }   
    }

    public string FullName
    {
        get { return FirstName + " " + LastName; }
        set { fullName = value; }
    }

    public override string ToString()
    {
        return $"{FullName} is {age} years old.";
    }
}

