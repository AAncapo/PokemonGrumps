using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Dialog
    {
        public void fancyTitle()
        {
            Console.WriteLine(@" _____ _____ _____     _____ _____ _____ 
|  _  |     |  |  |___|     |     |   | |
|   __|  |  |    -| -_| | | |  |  | | | |
|__|  |_____|__|__|___|_|_|_|_____|_|___|");
            Console.Write("\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fire/Red - Grumps Edition\n");
            Console.ResetColor();
        }

        public void IntroductionDialog()
        {
            Write("well, hello there..."); ReadKey(true); WriteLine(" I shit my pants.");
            ReadKey(true);
            WriteLine("WELCOME TO THE WORLD OF POKéMON!!!!");
            ReadKey(true);
            WriteLine("Where I consistantly shit my pants.");
            ReadKey(true);
            WriteLine("My name is Oak.\n");
            Write("stands for: "); ReadKey(true);
            Write("oh..."); ReadKey(true); Write("ASS KRAP!..."); ReadKey(true); WriteLine("i shit my pants");
            ReadKey(true);
            Write("Oak: Let's begin with your name.\nWhat is it? ");
            ReadLine();
            Write("Oak: Right. Your name is 'I never'! .\n");
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("(this will be relevant later in the game)\n");
            ResetColor();
            ReadKey(true);
            WriteLine("Oak: Your very own POKéMON legend is about to unfold!");
            Write("AAAAAAAAAAAAAAAAAAAAA");
            ReadKey(true);
            WriteLine();
            Clear();

            //presenta a Claarff
        }
    }
}
