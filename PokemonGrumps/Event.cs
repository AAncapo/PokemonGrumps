using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Event
    {
        static Player Inever = new Player();
        static Pokemon playerPKMN;
        static Player Claarf = new Player("Claarff");
        static Pokemon rivalPKMN;

        public static void Intro()
        {
            //introduction text
            //get from .txt
            string choice;
            string selection = "";
            while (selection != "y")
            {
                WriteLine("Oak: You need your own POKéMON for your protection.\n" +
                "There are three POKéMON here. You can have one.\nGo on, choose!");
                Write("b- BULBASAUR   s- SQUIRTLE   c- CHARMANDER   \n");
                choice = ReadLine();
                if (choice == "b")
                {
                    Write("Oak: I see! Bulbasur is your choice. It's very easy to raise.\n" +
                        "So, I never, you want to go with the grass POKéMON BULBASAUR?\n(y/n) ");
                    selection = ReadLine();
                    if (selection == "y")
                    {
                        WriteLine("\n> I like turtles so we should probably go with charmander");
                        pickCharmanderAnywaysXD();
                    }
                }
                else if (choice == "s")
                {
                    Write("Oak: Hm! Squirtle is your choice. It's one worth raising.\n" +
                        "So, I never, you've decided on water POKéMON SQUIRTLE?\n(y/n) ");
                    selection = ReadLine();
                    if (selection == "y")
                    {
                        WriteLine("\n> I like turtles so we should probably go with charmander");
                        pickCharmanderAnywaysXD();
                    }
                }
                else if (choice == "c")
                {
                    Write("Oak: Ah! Charmander is your choice. You should raise it patiently.\n" +
                        "So, I never, you're claiming the fire POKéMON CHARMANDER?\n(y/n) ");
                    selection = ReadLine();
                    if (selection == "y")
                        pickCharmanderAnywaysXD();
                }
            }
        }

        static void pickCharmanderAnywaysXD()
        {
            playerPKMN = new Pokemon("Sch", "FIRE", "", 5);
            Inever.AddPKMN(playerPKMN);
            rivalPKMN = new Pokemon("SQUIRTLE", "WATER", "", 5); //claarff pick water
            Claarf.AddPKMN(rivalPKMN);
            WriteLine("\n> I never received the CHARMANDER from PROF. Oak!\n");
        }

        public static void RivalWantsToFight()
        {
            WriteLine("> RIVAL {0} would like to battle!", Claarf.Name);
            WriteLine("> RIVAL {0} sent out {1}!", Claarf.Name, Claarf.getActivePKMN().NAME);
            WriteLine("Go! {0}!", Inever.getActivePKMN().NAME);
            Inever.ActionPrompt(Claarf.getActivePKMN());
        }
    }
}
