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
        //int gymBadges = 0;

        public void AddPKMN(Pokemon PKMN)
        {
            PKMNteam.Add(PKMN);
        }

        void setActive(int i)
        {
            if (!PKMNteam[i].isActive)
            {
                PKMNteam[i].isActive=true;
            }
        }

        public void ActionPrompt(Pokemon rival)
        {
            Pokemon activePKMN = PKMNteam[0];
            while (rival.currentHp>0)
            {
                WriteLine($"\n> What will I never do?");
                WriteLine("====================\n" +
                          "= f-FIGHT    b-BAG =\n" +
                          "= p-PKMN     r-RUN =\n" +
                          "====================");
                string sel = ReadLine();
                switch (sel)
                {
                    case "f":
                        Fight(activePKMN, rival);
                        break;
                    case "b":
                        //bag
                        break;
                    case "p":
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

                            PKMNteam[selected].isActive = true;
                            //take pokemon from list
                            ActionPrompt(rival);
                        }
                        break;
                    case "r":
                        WriteLine("> eeeeeeeeee BYE!");
                        break;
                    default:
                        break;
                }
            }
            WriteLine("> the wild '{0}' has been defeated! {1} got tolevel up!", rival.Name, activePKMN.Name);
        }

        public void Fight(Pokemon activePKMN, Pokemon rival)
        {
            WriteLine("> Select a move\n 0 SCRATCH  1 GROWL  2 BACK");
            int sel = int.Parse(ReadLine());
            if (sel == 0)
            {
                Write("enemy previous hp-{0} ", rival.currentHp);
                WriteLine($"{activePKMN.Name} used scratch!");
                rival.currentHp -= (activePKMN.atk + 5) - rival.def;
                WriteLine($"'{rival.Name}' loses {(activePKMN.atk + 5) - rival.def} HP");
                WriteLine("enemy actual hp-{0} ", rival.currentHp);
            }
            else if (sel == 1)
            {
                WriteLine($"{activePKMN.Name} used growl!");
                rival.atk -= 5;
                WriteLine($"'{rival.Name}' attack power lowers!");
            }
            else ActionPrompt(rival);
        }
    }
}
