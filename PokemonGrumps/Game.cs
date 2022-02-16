using System;
using System.IO;
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
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine($">>{txt}");
            ResetColor();
        }
    }
}
