
class Company
{
    public Company(string name, string department, string salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }

    public string Salary { get; set; }

    public string Department { get; set; }
  
    public string Name { get; set; }
}

