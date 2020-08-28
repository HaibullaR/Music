using Music.Model;
using System;
using System.Collections.Generic;

namespace Music
{
    class Program
    {
        /*
         Создать консольное приложение, 
         которое позволит пользователям просматривать 
         заранее заготовленный список Рок-групп, 
         их альбомы с описанием, а также песни.
        */
        static void Main(string[] args)
        {
            var RockBands = new List<RockBand>();
            var Musiciants = new List<Musiciant>();
            var Albums = new List<Album>();
            var Songs = new List<Song>();
            var userCommand = 1;
            var indexRockBand = 0;
            var indexAlbum = 0;
            Seed(RockBands, Musiciants, Albums, Songs);

            Console.WriteLine("Приветствую вас! Я программа которая представляет вашему вниманию список наилучших рок групп мира !");
            
            do
            {
                if (userCommand == 1)
                {
                    for (int i = 0; i < RockBands.Count; i++)
                        Console.WriteLine($"{i + 1}: {RockBands[i].Name}");

                    Console.Write("Выберите группу чтобы просмотреть альбом:");
                    if (int.TryParse(Console.ReadLine(), out indexRockBand))
                    {
                        if (indexRockBand < RockBands.Count && indexRockBand > 0)
                            userCommand = 2;
                        else
                            Console.WriteLine("Такой группы нету");
                    }
                }

                if (userCommand == 2)
                {
                    var band = RockBands[indexRockBand - 1];
                    for (int i = 0; i < band.Albums.Count; i++)
                        Console.WriteLine($"{i + 1}: {band.Albums[i].Name}" +
                                          $"\nОписание: {band.Albums[i].Description}" +
                                          $"\nДата выхода:{band.Albums[i].DateOfIssue}");

                    Console.Write("Выберите альбом чтобы посмотреть список песен:");
                    if (int.TryParse(Console.ReadLine(), out indexAlbum))
                    {
                        if (indexAlbum < band.Albums.Count && indexAlbum > 0)
                            userCommand = 3;
                        else
                            Console.WriteLine("Такого альбома нету");
                    }

                }

                if (userCommand == 3)
                {
                    var album = RockBands[indexRockBand - 1].Albums[indexAlbum];
                    for (int i = 0; i < album.Songs.Count; i++)
                        Console.WriteLine($"{i + 1}: {album.Songs[i].Name}" +
                                          $"\nОписание: {album.Songs[i].Description}");
                }


                Console.WriteLine("Для выхода введите 0, либо 1 чтобы просмотреть список групп:");
                var res = int.TryParse(Console.ReadLine(), out userCommand);
                if (!res || userCommand != 1) userCommand = 1;
                Console.Clear();
            }
            while (userCommand != 0);
        }

























        public static void Seed(List<RockBand> RockBands, List<Musiciant> Musiciants, List<Album> Albums, List<Song> Songs)
        {
            const int FIVE = 5;

            for (int i = 0; i < FIVE; i++)
            {
                Songs.Add(new Song
                {
                    Name = "THE BEST SONG",
                    Description = "NAME IT'S TRUE",
                    Sound = "TRA TRA TRA TRA TA TATA"
                });
            }

            for (int i = 0; i < FIVE; i++)
            {
                Albums.Add(new Album
                {
                    Name = "THE BEST ALBUM",
                    DateOfIssue = DateTime.Now,
                    Description = "NAME IT'S TRUE",
                    Songs = Songs
                });
            }

            for (int i = 0; i < FIVE; i++)
            {
                RockBands.Add(new RockBand
                {
                    Name = "THE BEST Rock Band",
                    Albums = Albums,
                    Musicians = Musiciants
                });
            }
        }
    }
}
