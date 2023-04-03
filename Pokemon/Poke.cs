using System;
using ConsoleTables;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class database
    {
        public List<Poke> Pokeball; //list of pokemon caught
        public List<string> pokelist;  //list of pokemon names
        public Dictionary<string,string> pokeimg; //pokemon ascii image
        public database(){
            this.Pokeball = new List<Poke>();
            this.pokelist = new List<string>() { "Pikachu","Squirtle","Jigglypiff","Psyduck","Ditto","Bulbasaur","Eevee"};
            this.pokeimg = new Dictionary<string, string>();
            pokeimg.Add(pokelist[6], @"
  ._                            _.-|
  |_~~`--._                 _.-~   /
    ~-._   ~-._.-~~~~~~~-.-~    _.~
        ~-._ /             \_.-~ 
            |  .-.   .-.   | 
            |. |_| . |_|   |         __.-|
            /    .__,      |    _.--~    |
            \             /_--~~  \     / 
            /~-._______.-~  \     |____|      
           |  /         \    |        /
            ~|_       |_|_-~~        / 
             | ~-\_/-~    |        _~ 
             |   |   |    /     _-~ 
              |  |  /    |__---~ 
              |,_|,_|____(");
            pokeimg.Add(pokelist[5], @"
              __....___ ,  .
          _.-~ __...--~~ ~/\
         / /  /          |  |
        | |  |            \  \
   _ _..---..-~\           |  | 
  |  ~  .-~-.    \-.__      /  | 
  /     \.-~        .-~-._/   // 
 |/-. <| __  .-\    \     \_ //  
 || o\   \/ /o  |    ~-.-~  \/         
/  ~~        ~~              |      
\__         ___--/   \  _-~-  \ 
 / ~~--.--~~    /     |/   __  |
|/\ \          |_~|   /    \|  |
|\/  \__       /_-   /\        |
|_ __| |`~-.__|_ _ _/  \ _ _ _/
' '  ' ' ''   ' ' '     ' ` `");
            pokeimg.Add(pokelist[4],
                @"
  /~\_.-~-._,--.._
 |                ~-.._   
  |     .     .        \
  |                    / 
  |     --....,       | \ 
  /                      \
 |                        |
 |                        \
 /                         |
 \_.-._  __...___.._______/");
            pokeimg.Add(pokelist[3],
                @"
                    // //  //
          __    ____||_//  //
        _/__--~~        ~~~-_
       /  /___        ___    \
      /  /(  +)      ( + )    |
     /  |  ~~~    __  ~~~   _/\/|
    |    \  ___.-~  ~-.___  \   / 
     \    \(     ` '      ~~)|   \
      \     )              / |    \
       \/   /              \ |    |
       /   |               | |    |
      |    /               |  \__/
      |    \_            _/      |    ___
      \      ~----...---~       /_.-~~ _/
       \_                      |    _-~ 
         \                    /  _-~ 
          ~-.__             _/--~
         _.-~  ~~~-----~~~~~
        ~-.-. _-~     /_ ._ \ 
             ~       ~  ~  ~-");
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
        \___                 ___/
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
        public Poke(string type)
        {
            this.type = type;
            this.name = Askname(type);
        }
        public string Askname(string type)
        {
            Console.WriteLine($"What would you like to name your {type}?");
            string name = Console.ReadLine();
            return name;
        }


    }
}
