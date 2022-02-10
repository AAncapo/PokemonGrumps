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
        public string Name;
        int money;
        //int gymBadges = 0;
        public Player(string name = "I never")
        {
            Name = name;
        }

        public void AddPKMN(Pokemon PKMN)
        {
            PKMNteam.Add(PKMN);
        }

        public void ActionPrompt(Pokemon rivalPKMN)
        {
            Pokemon activePKMN = PKMNteam[0];
            string sel="";
            while (rivalPKMN.currentHp > 0 && sel != "r")
            {
                WriteLine($"\n> What will I never do?");
                WriteLine("====================\n" +
                          "= f-FIGHT    b-BAG =\n" +
                          "= p-PKMN     r-RUN =\n" +
                          "====================");
                sel = ReadLine();
                switch (sel)
                {
                    case "f":
                        Fight(activePKMN, rivalPKMN);
                        break;
                    case "b":
                        //bag
                        break;
                    case "p":
                        displayPKMNteam(activePKMN);
                        ActionPrompt(rivalPKMN);
                        break;
                    case "r":
                        WriteLine("> eeeeeeeeee BYE!");
                        break;
                    default:
                        break;
                }
            }
            WriteLine("> Foe '{0}' fainted!", rivalPKMN.Name);
        }
        //FIGHT----------------------------------------------------------------------FIGHT//
        public void Fight(Pokemon activePKMN, Pokemon rival)
        {
            WriteLine("> Select a move\n 0 SCRATCH  1 GROWL  2 BACK");
            int sel = int.Parse(ReadLine());
            if (sel == 0)
            {
                Write("enemy previous hp {0} ", rival.currentHp);
                WriteLine($"{activePKMN.Name} used scratch!");
                rival.currentHp -= (activePKMN.atk + 5) - rival.def;
                WriteLine($"'{rival.Name}' loses {(activePKMN.atk + 5) - rival.def} HP");
                WriteLine("enemy actual hp {0} ", rival.currentHp);
            }
            else if (sel == 1)
            {
                WriteLine($"{activePKMN.Name} used growl!");
                rival.atk -= 5;
                WriteLine($"'{rival.Name}' attack power lowers!");
            }
            else ActionPrompt(rival);
        }
        //PKMN----------------------------------------------------------------------PKMN//
        void displayPKMNteam(Pokemon activePKMN)
        {
            WriteLine("\n============ POKéMONs ============");
            for (int i = 0; i < PKMNteam.Count; i++)
            {
                PKMNteam[i].displayInfo();
            }
            WriteLine("==================================");
            if (PKMNteam.Count > 1)
            {
                Write("> Select one pokemon to swap ");
                int selected = int.Parse(ReadLine());
                //take pokemon from list
                activePKMN = PKMNteam[selected];
            }
        }
    }
}
