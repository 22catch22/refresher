using System;
using System.Collections.Generic;
namespace Refresher_1
{


    class Player
    {
        public string Name;
        public int Number;

        public Player(string playerName, int playerNumber)
        {
            Name = playerName;
           
            Number = playerNumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Players");
            Console.WriteLine("1- Display Players");
            Console.WriteLine("2 - Display Players with an Odd Number");
            Console.WriteLine("3 - Display Players starting with a letter ");
            Console.WriteLine("4 - Add Player");
            Console.WriteLine("Please enter You Choice");


            string userinput = Console.ReadLine();

            var playlist = new List<Player>();
            Player Player1 = new Player("Stinky Peterson", 88);
            playlist.Add(Player1);
            Player Player2 = new Player("T.J. Detweiler", 95);
            playlist.Add(Player2);
            Player Player3 = new Player("Gordon Freeman", 98);
            playlist.Add(Player3);
            Player Player4 = new Player("Jessie Chase", 19);
            playlist.Add(Player4);
            Player Player5 = new Player("Mario Mario", 81);
            playlist.Add(Player5);

          
            if (userinput == "1")
            {
                foreach (Player player in playlist)
                    Console.WriteLine(player.Name,player.Number);
            }
            if (userinput == "2")
            {
                foreach (Player player in playlist)
                {
                    if (player.Number % 2 != 0)
                    {
                        Console.WriteLine(player);
                    }
                }

                if (userinput == "3")
                {
                    Console.WriteLine("Please enter a letter");
                    
                    
                    foreach (Player p in playlist)
                    {
                        string uinput = Console.ReadLine();
                        if (uinput[0] == p.Name[0])
                        {
                         uinput.ToLower();
                         p.Name.ToLower();
                         Console.WriteLine(p);
                                }
                         
                    }
                    if (userinput == "4")
                    {
                        Player newPlayer = new Player(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        playlist.Add(newPlayer);

                    }



                }
            }
        }
    }
}
