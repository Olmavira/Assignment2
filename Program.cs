using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;


namespace Assignment2
{
    class Program
    {
        public static void ProcessEachItem(Player player, Action<Item> process)
        {
            foreach (Item i in player.Items)
            {
                process(i);
            }
        }
        public static void PrintItem(Item item)
        {
            Console.WriteLine("Item id is: " + item.Id + " and level is: " + item.Level);
        }
        static async Task Main(string[] args)
        {
            //Task<int> creating_Players = CreateMillionPlayers();
            //Console.WriteLine("Waiting results");
            //int result = await creating_Players;
            //Kohta 1
            //Auxiliary.CreateMillionPlayers();
            // Console.WriteLine("Waiting results");
            //Console.WriteLine("Done");


            //Kohta 2

            // Auxiliary.CreateItems();




            //Kohta 3
            // Auxiliary.Kohta3();

            //Kohta 4
            //Auxiliary.Kohta4();

            //Kohta 5
            // Player player = new Player();

            // player.Items = new List<Item>();
            // player.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });
            // Action<Item> delegaatti = PrintItem;

            // ProcessEachItem(player, delegaatti);

            //Kohta 6
            //    Action<Player, Action<Item>> Processeachitem = (player, process) =>
            //     {
            //         foreach (Item i in player.Items)
            //         {
            //             process(i);
            //         }
            //     };
            //     Action<Item> delegaatti = (item) => Console.WriteLine("Item id is: " + item.Id + " and level is: " + item.Level);
            //     Player player = new Player();

            //     player.Items = new List<Item>();
            //     player.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            //     player.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });

            //     Processeachitem(player, delegaatti);

            //Kohta 7
            List<Player> players = new List<Player>();
            List<PlayerForAnotherGame> playersForAnotherGame = new List<PlayerForAnotherGame>();
            for (int i = 0; i < 1000; i++)
            {
                Random rand = new Random();
                int randInt = rand.Next(100000);
                players.Add(new Player() { Score = randInt });

            }

            for (int i = 0; i < 1000; i++)
            {
                Random rand = new Random();
                int randInt = rand.Next(100000);
                playersForAnotherGame.Add(new PlayerForAnotherGame() { Score = randInt });

            }
            Game<Player> game = new Game<Player>(players);
            Game<PlayerForAnotherGame> anotherGame = new Game<PlayerForAnotherGame>(playersForAnotherGame);

            game.GetTop10Players();
            anotherGame.GetTop10Players();
        }
    }
}


