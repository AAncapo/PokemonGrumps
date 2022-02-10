using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGrumps
{
    class Rival
    {
        public string Name { get; set; }
        public List<Pokemon> rivalPKMNteam = new List<Pokemon>();

        public Rival(string rivalName)
        {
            Name = rivalName;
        }

        public Rival()
        {

        }

        public void _AddPKMNteam(Pokemon PKMN)
        {
            rivalPKMNteam.Add(PKMN);
        }


    }
}
