using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>
            {
                new Song("Imagine Dragons", "Bleeding Out"),
                new Song("Imagine Dragons", "It's Time"),
                new Song("Imagine Dragons", "Radioactive"),
                new Song("U2", "Sunday Bloody Sunday"),
                new Song("U2", "Pride(In The Name Of Love)"),
                new Song("Tom Petty", "Last Dance With Mary Jane"),
                new Song("Tom Petty", "It's Good To Be King"),
                new Song("Johnny Cash", "Hurt"),
                new Song("Johnny Cash", "Hurt"),
                new Song("Johnny Cash", "Ain't No Grave"),
                new Song("Josh Ritter", "Girl In The War"),
                new Song("Buddy Miller", "With God On Our Side"),
                new Song("Lucinda Williams", "Essence")
        };

            goodSongs = allSongs
                        .Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach(Song song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}.");
            }
            Console.ReadKey();                        
         }
    }
}
