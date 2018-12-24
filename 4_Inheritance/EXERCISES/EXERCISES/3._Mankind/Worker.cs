using System;
using System.Text;

class Worker:Human
{
    private decimal weekSalary;
    private decimal hoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal hoursPerDay)
        :base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        HoursPerDay = hoursPerDay;
    }

    public decimal HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {

            if (value < 1 || value > 12)
            {
                throw new AggregateException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.hoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {

            if (value <= 10)
            {
                throw new AggregateException("Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public decimal GetSalaryPerHour()
    {
        return WeekSalary / (5 * HoursPerDay);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append(base.ToString());
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.HoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");

        return sb.ToString();
    }
}

