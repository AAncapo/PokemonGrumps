using System;
using static System.Console;

namespace PokemonGrumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Pokemon GRUMPS";
            WindowHeight = 40;
            WindowWidth = 70;
            WriteLine(@" _____ _____ _____     _____ _____ _____ 
|  _  |     |  |  |___|     |     |   | |
|   __|  |  |    -| -_| | | |  |  | | | |
|__|  |_____|__|__|___|_|_|_|_____|_|___|");
            Write("\t");
            BackgroundColor = ConsoleColor.Red;
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Fire/Red - Grumps Edition\n");
            ResetColor();

            Game newGame = new Game();

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
