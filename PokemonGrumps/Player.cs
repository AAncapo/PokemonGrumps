using System;
using System.Collections.Generic;
using static System.Console;

namespace PokemonGrumps
{
    class Player
    {
        List<Pokemon> PKMNteam = new List<Pokemon>(); //change accesibility and use getActivePKMN()
        public string Name;

        public Player(string name="I never")
        {
            Name = name;
        }

        public void AddPKMN(Pokemon PKMN) => PKMNteam.Add(PKMN);
        
        public Pokemon getActivePKMN() => PKMNteam[0];

        public void ActionPrompt(Pokemon enemy)
        {
            Pokemon activePKMN = PKMNteam[0];
            string sel="";
            while (sel != "r")
            {
                WriteLine($"\n> What will I never do?"); //aqui deberia decir el nombre del pkmn pero "i never" me gusta mas xd
                WriteLine("====================\n" +
                          "= f-FIGHT    b-BAG =\n" +
                          "= p-PKMN     r-RUN =\n" +
                          "====================");
                sel = ReadLine();
                switch (sel)
                {
                    case "f":
                        activePKMN.Fight(enemy);
                        break;
                    case "b":
                        //bag
                        break;
                    case "p":
                        displayPKMNteam(activePKMN);
                        ActionPrompt(enemy);
                        break;
                    case "r":
                        WriteLine("> eeeeeeeeee...... ok BYE!");
                        break;
                    default:
                        break;
                }
            }
            WriteLine("I never got $$$ for winning!");
            //distribuir EXP entre los pkmn q lucharon
            ReadKey(true);
        }

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
