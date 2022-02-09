using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Game
    {
        Dialog text = new Dialog();
        Player Inever = new Player();
        Pokemon initialPKMN;

        public void Intro()
        {
            Title = "Pokemon GRUMPS";
            text.fancyTitle();
            //text.IntroductionDialog();

            //elige tu pokemon inicial
            InitialPkmn();
            //pelea contra trainer Claarff
        }

        public void InitialPkmn()
        {
            WriteLine("Oak: You need your own POKéMON for your protection.\n" +
                "There are three POKéMON here. You can have one.\nGo on, choose!");
            string choice;
            string selection;
            Write("b- BULBASAUR   s- SQUIRTLE   c- CHARMANDER   ");
            choice = ReadLine();
            if (choice == "b")
            {
                Write("Oak: I see! Bulbasur is your choice. It's very easy to raise.\n" +
                    "So, I never, you want to go with the grass POKéMON BULBASAUR?\n(y/n) ");
                selection = ReadLine();
                if (selection == "y")
                {
                    initialPKMN = new Pokemon("Baelba", "GRASS", "", 5, 15);
                    Inever.AddPKMN(initialPKMN);
                    WriteLine("\n> I never received the BULBASAUR from PROF. Oak!");
                    Inever.ActionPrompt();
                }
                else InitialPkmn();
            }
            else if (choice == "s")
            {
                Write("Oak: Hm! Squirtle is your choice. It's one worth raising.\n" +
                    "So, I never, you've decided on water POKéMON SQUIRTLE?\n(y/n) ");
                selection = ReadLine();
                if (selection == "y")
                {
                    //add squirtle to team.
                    initialPKMN = new Pokemon("Sqertol", "WATER", "", 5, 15);
                    Inever.AddPKMN(initialPKMN);
                    WriteLine("\n> I never received the SQUIRTLE from PROF. Oak!");
                    Inever.ActionPrompt();
                }
                else InitialPkmn();
            }
            else if (choice == "c")
            {
                Write("Oak: Ah! Charmander is your choice. You should raise it patiently.\n" +
                    "So, I never, you're claiming the fire POKéMON CHARMANDER?\n(y/n) ");
                selection = ReadLine();
                if (selection == "y")
                {
                    //add charmander to team.
                    initialPKMN = new Pokemon("Sch", "FIRE", "", 5, 15);
                    Inever.AddPKMN(initialPKMN);
                    WriteLine("\n> I never received the CHARMANDER from PROF. Oak!");
                    Inever.ActionPrompt();
                }
                else InitialPkmn();
            }
            else InitialPkmn();
        }
    }
}
