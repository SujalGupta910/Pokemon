using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class database
    {
        public List<string> pokelist;
        public Dictionary<string,string> pokeimg;
        public database(){
            this.pokelist = new List<string>() { "Pikachu","Squirtle","Jigglypiff"};
            this.pokeimg = new Dictionary<string, string>();
            
            pokeimg.Add(pokelist[0],
                @"
.__                           __.
   \ `\~~---..---~~~~~~--.---~~| /   
    `~-.   `                   .~         _____ 
        ~.                .--~~    .---~~~    /
         / .-.      .-.      |  <~~        __/
        |  |_|      |_|       \  \     .--'
       /-.      -       .-.    |  \_   \_
       \-'   -..-..-    `-'    |    \__  \_ 
        `.                     |     _/  _/
          ~-                .,-\   _/  _/
         /                 -~~~~\ /_  /_
        |               /   |    \  \_  \_ 
        |   /          /   /      | _/  _/
        |  |          |   /    .,-|/  _/ 
        )__/           \_/    -~~~| _/
          \                      /  \
           |           |        /_---` 
           \    .______|      ./
           (   /        \    /        
           `--'          /__/");
            pokeimg.Add(pokelist[1],
                @"
           ___
      _.-~~   ~~~-.
     /         _   ~.
    |#`       /#`    \
    |-'|      |-'|    | 
    /--        --     |-.
    \__   .  .        / /\_  
     \ ~~--___---~~/\| |   ~-.
  .---`~~--____---_)  \ \-__  \
  ) <    |__    __\_   \ \     |
  ~-.__ /   ~~~~   \   \ \     |
       ~-.   |     .~-.-' |    |
        | \___|___/     / /     | 
        | /   |   \     | |  /  |
         \     |   ~-___ \ \/  /
         /\__ / `._ /   ~-\ \_/
        /    \_____|      |`~
       |      |    |      |   
        \     |    |      |
         >______)   /_/\/\_\");
            pokeimg.Add(pokelist[2],
                @"
      --_                       _--
     ||\_\__                 __/_/||
     ||  \  \__...-----...__/  /  ||
     \\  _\_/    /     \    \_/_  //
      |_/       |       |       \_| 
      /    __   /     _/    __    \
     /  .-~--~-.\    / ) .-~--~-.  \
    |   ||    || \____/  ||    ||   |
    |   `-_--_-'         `-_--_-'   |
    |      ~~               ~~      | 
    |              ___              |
    |              `-'              |
     \ \_  \                /  _/  /         
      \_ \_/                \_/  _/ 
        \___                 ___/   Amw
        ..--\__           __/--..
      .~    __-~~~-----~~~-__    ~.
     (__.--~                 ~--.__)");
        
        
        
        
        }

        public string randp()
        {
            Random rand = new Random();
            return pokelist[rand.Next(pokelist.Count)];
        }
    }
    class Poke
    {
        public string name;
        public string type;
        public int age;
        public Poke(string type)
        {
            this.type = type;
            var rand = new Random();
            this.age = rand.Next(10);
        }
        public void askname()
        {
            Console.WriteLine("What would you like to name your pokemon?");
            this.name = Console.ReadLine();
        }


    }
}
