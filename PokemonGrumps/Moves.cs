using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PokemonGrumps
{
    class Moves
    {
        public static string Type;
        public static string Tag;
        public static int Power;
        public static int PP;

        //sacarlo todo a partir de un .txt
        public static string[,] moveList =
        {
            {"","",""},//0
            {"NORMAL","SCRATCH","TACKLE"},
            {"FIRE","EMBER","-?????-"},
        };

        static int[] movePow = { 5, 8 };

        public Moves(string tag)
        {
            Tag = tag;
            setMoveDetails(tag);
        }

        void setMoveDetails(string tag)
        {
            //sets move details according to the tag
            //buscar un metodo q permita encontrar index en array multidimensional
            //power= .txt...
            //pp= txt...

            //placeholder
            Type = "FIRE";
            Power = 40;
            PP = 20;
        }
    }
}
