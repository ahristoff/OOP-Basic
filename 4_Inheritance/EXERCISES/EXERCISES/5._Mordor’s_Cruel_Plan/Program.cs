using System;

public class Program
{
    public static void Main()
    {
        var gandalf = FeedGandalf();

        Console.WriteLine(gandalf.HappinessPoints);
        Console.WriteLine(gandalf.CalculateMood());
    }

    private static Gandalf FeedGandalf()
    {
        var foods = Console.ReadLine().ToLower().Split();

        var gandalf = new Gandalf();

        foreach (var x in foods)
        {
            gandalf.EatFood(x);
        }

        return gandalf;
    }
}

