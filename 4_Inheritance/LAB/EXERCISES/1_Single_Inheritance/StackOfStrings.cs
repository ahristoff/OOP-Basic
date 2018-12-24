using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data = new List<string>();

    public bool IsEmpty()
    {
        return data.Count == 0;
    }

    public void Push(string newElement)
    {
        data.Add(newElement);
    }

    public string Peek()
    {
        string res = "";

        if (!IsEmpty())
        {
            res = data[data.Count - 1];
        }

        return res;
    }

    public string Pop()
    {
        string res = "";

        if (!IsEmpty())
        {
            var lastIndex = data.Count - 1;
            res = data[lastIndex];
            data.RemoveAt(lastIndex); 
        }

        return res;
    }
}

