using System;
using System.Text;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public int Age
    {
        get { return age; }
        set
        {

            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0 )
            {
                throw new ArgumentException("Invalid input!");
            }

            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            name = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(this.GetType().Name);
        sb.AppendLine($"{Name} {Age} {Gender}");
        sb.AppendLine(this.ProduceSound());

        return sb.ToString().Trim();
    }
}

