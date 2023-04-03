using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;
using ConsoleTables;

namespace Pokemon
{
    class Program
    {
        public static void menu(database db)
        {
            int pokecaught = 0;
            int opt = 0;
            while (opt != 3)
            {
                WriteLine("What would you like to do now?");
                WriteLine("1. Look around  2.See Pokedex  3. Exit");
                opt = Convert.ToInt32(ReadLine());
                if (opt == 1) {pokecaught = LookAround(pokecaught,db); }
                else if (opt == 2)
                {
                    if(pokecaught==0) { WriteLine("You haven't caught any pokemon yet"); }
                    else
                    {
                        var tab = new ConsoleTable("Name","Type");
                        foreach (Poke pokemon in db.Pokeball)
                        {
                            tab.AddRow(pokemon.name, pokemon.type);
                            Console.WriteLine();
                        }
                        tab.Write();
                    }
                }
                else if (opt == 3) { WriteLine("Thank you for playing!"); break; }
                else break;
            }
        }
        //opt1
        public static int LookAround(int cnum,database db)
        {
            WriteLine("Looking..."); Thread.Sleep(1000);
            WriteLine("Looking..."); Thread.Sleep(1000);
            WriteLine("Looking..."); Thread.Sleep(1000);
            //Player will have a 50% chance of finding a pokemon
            string[] chance = new string[] { "", db.randp()};
            Random rand = new Random();
            string pfound = chance[rand.Next(2)];
            if (pfound.Equals("")) WriteLine("It seems no pokemon is around...");
            else
            {
                WriteLine(db.pokeimg[pfound]);
                WriteLine($"Woohoo! You found a {pfound}");
                WriteLine("Wanna try and catch it?(Y/N)");
                string ans = ReadLine();
                if (!(ans == "Y" || ans == "y"))
                {
                    WriteLine("Well, It's nice to see a wild pokemon live its wild pokemon life out in the wild...");
                }
                else
                {
                    WriteLine("Ready to throw your pokeball? press Enter when you see GO!");
                    WriteLine("3..."); Thread.Sleep(500);
                    WriteLine("2..."); Thread.Sleep(500);
                    WriteLine("1..."); Thread.Sleep(500);
                    WriteLine("GO!");
                    ReadKey();
                    int caught = rand.Next(2);
                    //again 50% chance of pokemon getting caught
                    if (caught != 0) { WriteLine("Couldn't catch it...better luck next time.."); }
                    else
                    {
                        WriteLine($"Whoa...you caught a {pfound}!! You seem like a gifted player!");
                        Poke tempoke = new Poke(pfound);
                        db.Pokeball.Add(tempoke);
                        cnum++;
                        WriteLine(db.Pokeball.Count);
                    }
                }

            }
            return cnum;
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
            menu(db);





            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
