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
        public string Name { get; set; }
        public string Type1 { get; set; }
        string Type2;
        int Level;
        int totalHp;
        public int currentHp;
        public int atk, def, speed, expPts, expLvUp;
        Random randNum = new Random();
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
        //initial pkmn
        public Pokemon(string name, string type1, string type2, int lvl)
        {
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Level = lvl;
            setRandomStats();
        }
        //wild pokemn
        public Pokemon()
        {
            int totalNames = pokedex.GetLength(0);
            int randName = randNum.Next(0, totalNames);
            Name = pokedex[randName, 0];
            Type1 = pokedex[randName, 1];
            Type2 = pokedex[randName, 2];
            Level = randNum.Next(2, 6);
            setRandomStats();
        }

        void setRandomStats()
        {
            ////placeholder////
            totalHp = Level + 15;
            currentHp = totalHp;
            atk = Level + 6;
            def = Level + 5;
            speed = Level + 6;
            expPts = Level * 20;
            expLvUp = expPts + 20;
        }

        //public void levelUp()
        //{
        //    Level++;
        //}

        public void displayInfo()
        {
            Write($"> {Name} type:");
            typeColor(Type1);
            Write($"/");
            typeColor(Type2);
            WriteLine($" level:{Level} HP:{totalHp}" +
            $"\n  atk:{atk} def:{def}" +
            $"\n  EXP < ########## >{expPts}/{expLvUp}");
        }

        //ConsoleColor[] typeColors =
        //    {
        //    ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.DarkGray,ConsoleColor.Yellow, ConsoleColor.DarkMagenta,ConsoleColor.Gray
        //    };

        public void typeColor(string type)
        {
            ConsoleColor typeColor = ConsoleColor.Gray;
            switch (type)
            {
                case "GRASS":
                    typeColor = ConsoleColor.Green;
                    break;
                case "WATER":
                    typeColor = ConsoleColor.Blue;
                    break;
                case "FIRE":
                    typeColor = ConsoleColor.Red;
                    break;
                case "NORMAL":
                    typeColor = ConsoleColor.DarkGray;
                    break;
                case "ELECTRIC":
                    typeColor = ConsoleColor.Yellow;
                    break;
                case "POISON":
                    typeColor = ConsoleColor.DarkMagenta;
                    break;
                case "FLYING":
                    typeColor = ConsoleColor.Gray;
                    break;
                case "ICE":
                    typeColor = ConsoleColor.Cyan;
                    break;
                case "BUG":
                    typeColor = ConsoleColor.DarkYellow;
                    break;
                case "ROCK":
                    typeColor = ConsoleColor.DarkGray;
                    break;
                case "GROUND":
                    typeColor = ConsoleColor.DarkGreen;
                    break;
                case "FIGHTING":
                    typeColor = ConsoleColor.DarkRed;
                    break;
                case "PSYCHIC":
                    typeColor = ConsoleColor.Magenta;
                    break;
                case "GHOST":
                    typeColor = ConsoleColor.DarkMagenta;
                    break;
                default:
                    break;
            }
            BackgroundColor = typeColor;
            Write(type);
            ResetColor();
        }

        //public void useMove()
        //{
        //    WriteLine("> {0} used scratch!", Name);
        //}
    }
}
