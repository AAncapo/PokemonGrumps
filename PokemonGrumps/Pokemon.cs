using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Pokemon
    {
        string Name;
        string Type1;
        string Type2;
        ConsoleColor Color;
        int Level;
        int HitPts;
        int atk, def, sp_atk, sp_def;
        double actualExp;
        double neededExp;

        string[,] pokedex =
        {
            {"Sch","FIRE",""},
            {"Knurttt","POISON","Bundt."},
            {"SPLAART!!!","ELECTRIC",""},
            {"Fuck King","GRASS",""},
            {"Buntd,","BUG","POISON"},
            {"MAGIKRAP","WATER",""},
            {"TurntSNACO","ROCK",""},
        };

        Random randNum = new Random();

        public Pokemon()
        {
            int totalNames = pokedex.GetLength(0);
            int randName = randNum.Next(0, totalNames);
            Name = pokedex[randName, 0];
            Type1 = pokedex[randName, 1];
            Type2 = pokedex[randName, 2];
            Color = ConsoleColor.DarkGray; //placeholder
        }

        public void displayInfo()
        {
            WriteLine($"> {Name} type:{Type1}/{Type2} level:{Level} HP:{HitPts}" +
                    $"\n  atk:{atk} def:{def} sp.attack:{sp_atk} sp.defense:{sp_def}" +
                    $"\n  EXP < ########## >{actualExp}/{neededExp}");
        }

        public void setInitialPKMN(string name, string type1, string type2, ConsoleColor color, int lvl, int hp)
        {

        }

        void assignColorToType()
        {

        }

        public void useMove()
        {
            WriteLine("> {0} used scratch!", Name);
        }

        //public void aWildPokemonAppear()
        //{
        //    int totalNames = pokedex.GetLength(0);//rows
        //    Random randNum = new Random();
        //    int randName = randNum.Next(0, totalNames);
        //    string wildName = pokedex[randName, 0];
        //    string wildType1 = pokedex[randName, 1];
        //    string wildType2 = pokedex[randName, 2];
        //    Pokemon wild = new Pokemon(wildName, wildType1, wildType2, ConsoleColor.Cyan, 5, 15);
        //    wild.displayInfo();
        //    WriteLine("> A wild '{0}' appear!", wild.Name);
        //}
    }
}
