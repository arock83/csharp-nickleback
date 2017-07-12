using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a List, named goodSongs, that will hold tuples consisting of two strings.

            List<(string, string)> goodsongs = new List<(string, string)>();

            //Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values: <artistName>, <songName>

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>{
                ("Nickleback", "Photograph"),
                ("The Killers", "Somebody Told Me"),
                ("Three 6 Mafia", "Stay Fly"),
                ("Nickleback", "Too Bad"),
                ("Fun", "The Gambler"),
                ("Muse", "Uprising"),
                ("Awolnation", "Sail")
            };

            //Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback"
            //If the band is not Nickelback, then add it to the goodSongs list.
            foreach(var song in allSongs)
            {
                if(song.Item1 != "Nickleback")
                {
                    goodsongs.Add(song);
                }
            }

            //Use another foreach loop to print out all the good songs.
            foreach(var song in goodsongs)
            {
                Console.WriteLine($"{song.Item2} by {song.Item1}");
            }
        }
    }
}
