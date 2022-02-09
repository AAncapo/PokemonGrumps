using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Player
    {
        List<Pokemon> PKMNteam = new List<Pokemon>();

        public void AddPKMN(Pokemon PKMN)
        {
            PKMNteam.Add(PKMN);
        }

        void displayPKMNTeam()
        {
            WriteLine("\n============ POKéMONs ============");
            for (int i = 0; i < PKMNteam.Count; i++)
            {
                PKMNteam[i].displayInfo();
            }
            WriteLine("==================================");
            if (PKMNteam.Count > 1)
            {
                Write("> do you want to change pokémons?  (y/n) ");
                string sel = ReadLine();
                if (sel == "y")
                {
                    Write("> Select one pokemon to swap");
                    //take pokemon from list
                }
                else
                    ActionPrompt();
            }
        }

        public void ActionPrompt()
        {
            WriteLine("\n> What will 'I never' do?");
            WriteLine("====================\n" +
                      "= f-FIGHT    b-BAG =\n" +
                      "= p-PKMN     r-RUN =\n" +
                      "====================");
            string sel = ReadLine();
            switch (sel)
            {
                case "f":
                    //starts fight
                    break;
                case "b":
                    //bag
                    break;
                case "p":
                    displayPKMNTeam();
                    //change pokemons
                    break;
                case "r":
                    //escape
                    WriteLine("> STOP RIGHT THERE CRIMINAL SCUM!");
                    //exit to somewere idk
                    break;
                default:
                    break;
            }
        }
    }
}
