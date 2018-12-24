using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var songs = GetSongs();
        var time = CalculationSongLenght(songs);
        Print(songs, time);
    }

    private static void Print(List<Song> songs, int[] time)
    {
        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {time[0]}h {time[1]}m {time[2]}s");
    }

    private static int[] CalculationSongLenght(List<Song> songs)
    {
        var time = new int[3];

        var duration = 0;

        for (int i = 0; i < songs.Count; i++)
        {
            duration += songs[i].Minutes * 60 + songs[i].Secunds;
        }

        time[0] = (int)duration / 3600;
        time[1] = (int)((duration - time[0] * 3600) / 60);
        time[2] = (duration - time[0] * 3600) % 60;

        return time;
    }

    private static List<Song> GetSongs()
    {
        var num = int.Parse(Console.ReadLine());

        var songs = new List<Song>();

        var input = "";

        for (int i = 0; i < num; i++)
        {
            input = Console.ReadLine();

            try
            {
                var com = input.Split(new string[] { ";", ":" }, StringSplitOptions.RemoveEmptyEntries);

                var artistName = com[0];
                var songName = com[1];
                var minutes = 0;
                var secunds = 0;

                try
                {
                    minutes = int.Parse(com[2]);
                    secunds = int.Parse(com[3]);
                }
                catch (Exception)
                {
                    throw new AggregateException("Invalid song length.");
                }

                var song = new Song(artistName, songName, minutes, secunds);

                songs.Add(song);

                Console.WriteLine("Song added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return songs;
    }
}

