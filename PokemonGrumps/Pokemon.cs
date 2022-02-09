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
        double needExp;

        string[,] pokedex =
        {
            {"Sch","FIRE",""},
            {"Knurttt","NORMAL",""},
            {"SPLAART!!!","ELECTRIC",""},
            {"Fuck King","GRASS","POISON"},
            {"Buntd,","BUG","POISON"},
            {"MAGIKRAP","WATER",""},
            {"TurntSNACO","ROCK",""},
        };

        Random randNum = new Random();

        public Pokemon(string name, string type1, string type2, int lvl, int hp)
        {
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Level = lvl;
            HitPts = hp;
        }

        public Pokemon()
        {
            int totalNames = pokedex.GetLength(0);
            int randName = randNum.Next(0, totalNames);
            Name = pokedex[randName, 0];
            Type1 = pokedex[randName, 1];
            Type2 = pokedex[randName, 2];
        }

        public void displayInfo()
        {
            Write($"> {Name} type:");BackgroundColor = assignColor(Type1); Write($"{Type1}");ResetColor();Write($"/");BackgroundColor = assignColor(Type2);
            Write($"{Type2}");ResetColor();WriteLine($"level:{Level} HP:{HitPts}" +
                    $"\n  atk:{atk} def:{def} sp.attack:{sp_atk} sp.defense:{sp_def}" +
                    $"\n  EXP < ########## >{actualExp}/{needExp}");
        }

        ConsoleColor assignColor(string type)
        {
            switch (type)
            {
                case "GRASS":
                    Color = ConsoleColor.Green;
                    break;
                case "WATER":
                    Color = ConsoleColor.Blue;
                    break;
                case "FIRE":
                    Color = ConsoleColor.Red;
                    break;
                case "NORMAL":
                    Color = ConsoleColor.DarkGray;
                    break;
                case "ELECTRIC":
                    Color = ConsoleColor.Yellow;
                    break;
                case "POISON":
                    Color = ConsoleColor.DarkMagenta;
                    break;
                case "FLYING":
                    Color = ConsoleColor.Gray;
                    break;
                case "ICE":
                    Color = ConsoleColor.Cyan;
                    break;
                case "BUG":
                    Color = ConsoleColor.DarkYellow;
                    break;
                case "ROCK":
                    Color = ConsoleColor.DarkGray;
                    break;
                case "GROUND":
                    Color = ConsoleColor.DarkGreen;
                    break;
                case "FIGHTING":
                    Color = ConsoleColor.DarkRed;
                    break;
                case "PSYCHIC":
                    Color = ConsoleColor.Magenta;
                    break;
                case "GHOST":
                    Color = ConsoleColor.DarkMagenta;
                    break;
                default:
                    break;
            }
            return Color;
        }

        public void useMove()
        {
            WriteLine("> {0} used scratch!", Name);
        }

        //public void aWildPokemonAppear()
        //{
        //    wild.displayInfo();
        //    WriteLine("> A wild '{0}' appear!", wild.Name);
        //}
    }
}
