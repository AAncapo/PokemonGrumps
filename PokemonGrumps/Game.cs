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
        Pokemon playerPKMN;
        Player Inever = new Player();

        public Game()
        {
            Intro();
            intoBattleArea();
        }

        void Intro()
        {
            Title = "Pokemon GRUMPS";
            text.fancyTitle();
            text.IntroductionDialog();
            InitialPkmn();
            //pelea contra trainer Claarff
        }

        void InitialPkmn()
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
                    playerPKMN = new Pokemon("Baelba", "GRASS", "", 5);
                    Inever.AddPKMN(playerPKMN);
                    WriteLine("\n> I never received the BULBASAUR from PROF. Oak!");
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
                    playerPKMN = new Pokemon("Sqertol", "WATER", "", 5);
                    Inever.AddPKMN(playerPKMN);
                    WriteLine("\n> I never received the SQUIRTLE from PROF. Oak!");
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
                    playerPKMN = new Pokemon("Sch", "FIRE", "", 5);
                    Inever.AddPKMN(playerPKMN);
                    WriteLine("\n> I never received the CHARMANDER from PROF. Oak!");
                }
                else InitialPkmn();
            }
            else InitialPkmn();
        }

        void intoBattleArea()
        {
            Random randNum;
            int encounterChance = 0;
            while (encounterChance < 50)
            {
                randNum = new Random();
                encounterChance = randNum.Next(1, 101);
                WriteLine(encounterChance); //simulando camina en hierba alta
            }
            Pokemon wild = new Pokemon();
            ConsoleColor bg = wild.assignColor(wild.Type1);
            Write("> A wild "); BackgroundColor = bg; Write($"{wild.Name}"); ResetColor(); WriteLine(" appear!");
            Inever.ActionPrompt(wild);
        }
    }
}
