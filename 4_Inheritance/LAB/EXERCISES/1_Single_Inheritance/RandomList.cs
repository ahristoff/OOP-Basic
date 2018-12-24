using System;
using System.Collections.Generic;

public class RandomList: List<string>
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {        
        string res = null;

        if (this.Count  > 0) 
        {
            var index = rnd.Next(0, this.Count - 1);            
            res = this[index];
            this.RemoveAt(index);
        }

        return res;
    }
}

