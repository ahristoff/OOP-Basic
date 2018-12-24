using System;
using System.Text;

public class Book
{
    private string title;
    private decimal price;
    private string author;

    public Book(string author, string title, decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }

    public string Author
    {
        get { return author; }
        protected set
        {
            var text = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (text.Length > 1 && char.IsDigit(text[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }

            author = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        protected set
        {

            if (value <= 0)
            {
                throw new ArgumentException("Price not valid");
            }

            price = value;
        }
    }
  
    public string Title
    {
        get { return title; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Type: Book");
        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Author: {Author}");
        sb.AppendLine($"Price: {Price:f2}");

        return sb.ToString();        
    }  
}

