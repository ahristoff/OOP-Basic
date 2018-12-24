using System;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int secunds;

    public Song(string artistName, string songName, int minutes, int secunds)
    {
        ArtistName = artistName;
        SongName = songName;
        Minutes = minutes;
        Secunds = secunds;
    }

    public int Secunds
    {
        get { return secunds; }
        set
        {

            if (value < 0 || value > 59)
            {
                throw new AggregateException("Song seconds should be between 0 and 59.");
            }

            secunds = value;
        }
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {

            if (value > 14 || value < 0)
            {
                throw new AggregateException("Song minutes should be between 0 and 14.");
            }

            minutes = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {

            if (value.Length < 3 || value.Length > 30)
            {
                throw new AggregateException("Song name should be between 3 and 30 symbols.");
            }

            songName = value;
        }
    }

    public string ArtistName
    {
        get { return artistName; }
        set
        {

            if (value.Length < 3 || value.Length > 20)
            {
                throw new AggregateException("Artist name should be between 3 and 20 symbols.");
            }

            artistName = value;
        }
    }
}

