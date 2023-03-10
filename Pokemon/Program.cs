using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Pokemon
{
    class Program
    {
        public static void menu()
        {
            database db = new database();
            int opt = 0;
            while (opt != 5)
            {
                WriteLine("What would you like to do now?");
                WriteLine("1. Look around\n2. Move south\n3. Move north\n4. Move west\n4. Move east\n5. Exit");
                opt = Convert.ToInt32(ReadLine());
                if (opt == 1)
                {
                    WriteLine("Looking..."); Thread.Sleep(500);
                    WriteLine("Looking..."); Thread.Sleep(500);
                    WriteLine("Looking..."); Thread.Sleep(500);
                    string pfound = db.randp();
                    WriteLine(db.pokeimg[pfound]);
                    WriteLine($"Woohoo! You found a {pfound}");


                }
                else if (opt == 2)
                {

                }
                else if (opt == 3) { }
                else if (opt == 4) { }
                else if (opt == 5) { WriteLine("Thank you for playing!"); break; }
                else break;
            }
        }
        static void Main(string[] args)
        { 
            Title = "Best Pokemon game of all time";
            database db = new database();
            string title = @"
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|";
            WriteLine(title);
            WriteLine("\nWelcome new player!");
            WriteLine("What is your name?");
            string name = ReadLine();
            WriteLine($"Let's start, {name}!");
            menu();





            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
