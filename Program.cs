using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Classical,
            Rock,
            Acoustic,
            Acapella,
            Metal
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, int length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(int length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Name a song: ");
            string songTitle = Console.ReadLine();
            Console.WriteLine("Name the song's artist: ");
            string songArtist = Console.ReadLine();
            Console.WriteLine("Name the song's album: ");
            string songAlbum = Console.ReadLine();
            Console.WriteLine("How long is the song: (integer)");
            int songLength = int.Parse(Console.ReadLine());
            Console.WriteLine("What Genre is it: \nC - Classical \nR - Rock\nA - Acoustic \nP - Acapella \nM - Metal");
            Genre songGenre = Genre.Classical;
            char m = char.Parse(Console.ReadLine());
            switch (m)
            {
                case 'C':
                    songGenre = Genre.Classical;
                    break;
                case 'R':
                    songGenre = Genre.Rock;
                    break;
                case 'A':
                    songGenre = Genre.Acoustic;
                    break;
                case 'P':
                    songGenre = Genre.Acapella;
                    break;
                case 'M':
                    songGenre = Genre.Metal;
                    break;
            }
            Music song1 = new Music(songTitle, songArtist, songAlbum, songLength, songGenre);

            Music moreMusic = song1;
            Console.WriteLine("What is the new title?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What is the new length?");
            moreMusic.setLength(int.Parse(Console.ReadLine()));

            Console.WriteLine("Here is song #1");
            Console.WriteLine($"{song1.Display()}");
            Console.WriteLine(" ");
            Console.WriteLine("Here is song #2");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
