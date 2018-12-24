using System;

public class Program
{
    static void Main()
    {
        var calls = Console.ReadLine().Split();

        for (int i = 0; i < calls.Length; i++)
        {
            try
            {
                ICall call = new Smartphone();

                Console.WriteLine($"{call.Call(calls[i])}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        var sites = Console.ReadLine().Split();

        for (int i = 0; i < sites.Length; i++)
        {
            try
            {
                IBrowser site = new Smartphone();

                Console.WriteLine($"{site.Browser(sites[i])}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

