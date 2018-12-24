using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var cats = new List<ICat>();

        while (input != "End")
        {
            var com = input.Split();

            if (com[0] == "Siamese")
            {
                ICat cat = new Siamese(com[0], com[1], int.Parse(com[2]));
                cats.Add(cat);
            }

            else if (com[0] == "Cymric")
            {
                ICat cat = new Cymric(com[0], com[1], double.Parse(com[2]));
                cats.Add(cat);
            }

            else if (com[0] == "StreetExtraordinaire")
            {
                ICat cat = new StreetExtraordinaire(com[0], com[1], int.Parse(com[2]));
                cats.Add(cat);
            }

            input = Console.ReadLine();
        }

        var name = Console.ReadLine();       

        foreach (var x in cats)
        {
            var SiameseAsCat = x as Siamese;
            var CymricAsCat = x as Cymric;
            var StreetExtraordinaireAsCat = x as StreetExtraordinaire;

            if (SiameseAsCat != null && SiameseAsCat.Name == name)
            {
                Console.WriteLine(SiameseAsCat);
            }

            else if (CymricAsCat != null && CymricAsCat.Name == name)
            {
                Console.WriteLine(CymricAsCat);
            }

            else if (StreetExtraordinaireAsCat != null && StreetExtraordinaireAsCat.Name == name)
            {
                Console.WriteLine(StreetExtraordinaireAsCat);
            }
        }
    }
}
