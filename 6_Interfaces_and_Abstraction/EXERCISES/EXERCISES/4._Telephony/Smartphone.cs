using System;

public class Smartphone:ICall, IBrowser
{

    public string Call(string number)
    {

        for (int i = 0; i < number.Length; i++)
        {

            if (!char.IsDigit(number[i]))
            {
                throw new AggregateException("Invalid number!");
            }         
        }

        return $"Calling... {number}";
    }

    public string Browser(string number)
    {

        for (int i = 0; i < number.Length; i++)
        {

            if (char.IsDigit(number[i]))
            {
                throw new AggregateException("Invalid URL!");
            }
        }

        return $"Browsing: {number}!";
    }
}

