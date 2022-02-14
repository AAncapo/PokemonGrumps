using System;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Game
    {
        public Game()
        {
            Event.Intro();
            Event.RivalWantsToFight();
            //Explore
        }

        public static void debuggingText(string txt)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($">>{txt}");
            ResetColor();
        }
    }
}
