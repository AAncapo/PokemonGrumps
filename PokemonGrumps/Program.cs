using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGrumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Intro();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
