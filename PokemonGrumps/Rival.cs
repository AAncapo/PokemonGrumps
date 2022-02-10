using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGrumps
{
    class Rival
    {
        Random randNum = new Random();
        public string Name { get; set; }
        public List<Pokemon> rivalPKMNteam = new List<Pokemon>();


        public Rival(string rivalName)
        {
            Name = rivalName;
        }

        public Rival()
        {

        }

        void setRandomName()
        {
            string[] names = { "Gravedigger Ted", "Dan", "Arin" };
            int totalNames = names.GetLength(0);
            Name = names[randNum.Next(0, totalNames)];
        }

        public void _AddPKMNteam(Pokemon PKMN)
        {
            rivalPKMNteam.Add(PKMN);
        }
    }
}
