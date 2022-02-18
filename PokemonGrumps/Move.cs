using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;

namespace PokemonGrumps
{
    class Move
    {
        public string Tag;
        public int Type;
        int Pow;
        string[] moveType = { "NORMAL", "FIRE", "WATER", "GRASS", "ELECTRIC", "ICE", "FIGHT", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL" };
        public static string[,] movelist = new string[15, 3];

        public Move(int moveId)
        {
            Tag = movelist[moveId, 0].ToUpper();
            Type = int.Parse(movelist[moveId, 1]);
            Pow = int.Parse(movelist[moveId, 2]);
        }

        public void displayMoveDetails()
        {
            WriteLine($"========Move Details========\n> {Tag} - {moveType[Type]} - Pow. {Pow}\nEffect:\n============================\n");
        }
        
        public static void Moves()
        {
            string moves = "moves.txt";
            string lines = File.ReadAllText(moves);
            string[] data = lines.Split('.');
            int z = 0;
            for (int y = 0; y < movelist.GetLength(0); y++)
            {
                for (int x = 0; x < movelist.GetLength(1); x++)
                {
                    movelist[y, x] = data[z];
                    z++;
                }
            }
        }
    }
}
