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
        public bool isActive;
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
            setStats();
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
            setStats();
        }

        void setStats()
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
                   
        public void levelUp()
        {
            Level++;
        }

        public void displayInfo()
        {
            Write($"> {Name} type:");
            BackgroundColor = assignColor(Type1); 
            Write($"{Type1}");
            ResetColor();
            Write($"/");
            BackgroundColor = assignColor(Type2);
            Write($"{Type2}");
            ResetColor();
            WriteLine($"level:{Level} HP:{totalHp}" +
            $"\n  atk:{atk} def:{def}" +
            $"\n  EXP < ########## >{expPts}/{expLvUp}");
        }

        public ConsoleColor assignColor(string type)
        {
            ConsoleColor Color = ConsoleColor.Gray;
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

        //public void useMove()
        //{
        //    WriteLine("> {0} used scratch!", Name);
        //}
    }
}
