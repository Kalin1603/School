namespace Songs
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter song number:");
            int n = int.Parse(Console.ReadLine());
            Song[] songs = new Song[n];
            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split('_')
                    .ToArray();
                string list = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];
                string actor = songInfo[3];
                songs[i] = new Song();
                songs[i].TypeList = list;
                songs[i].Name = name;
                songs[i].Time = time;
                songs[i].Actor = actor;
            }
            Console.Write("Playlist: ");
            string printLisType = Console.ReadLine();
            Song[] selectedSong = songs
                .Where(x => x.TypeList == printLisType)
                .ToArray();
            for (int i = 0; i < selectedSong.Length; i++)
            {
                Console.WriteLine(selectedSong[i].Name);
            }

            Console.Write("Actor: ");
            string printActor = Console.ReadLine();
            Song[] selectedActor = songs
                .Where(x => x.Actor == printActor)
                .ToArray();
            for (int i = 0; i < selectedActor.Length; i++)
            {
                Console.WriteLine(selectedActor[i].Actor);
            }
        }
    }
}
