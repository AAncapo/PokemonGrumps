using System;
using System.Collections.Generic;
using static System.Console;

namespace PokemonGrumps
{
    class Pokemon
    {
        public string NAME { get; set; }
        string TypeA;
        string TypeB;
        int LVL;
        int maxHP;
        int currentHp;
        int ATK, DEF, SPEED, EXP, EXPnext;
        string[] moves = new string[4]; //7 lines max each
        string noMove = "-?????-";
        Random randNum = new Random();
        
        //initial pkmn
        public Pokemon(string name, string type1, string type2, int lvl)
        {
            NAME = name;
            TypeA = type1;
            TypeB = type2;
            LVL = lvl;
            setRandomStats();
        }
        //wild pokemn
        public Pokemon()
        {
            int totalNames = pokedex.GetLength(0);
            int randName = randNum.Next(0, totalNames);
            NAME = pokedex[randName, 0];
            TypeA = pokedex[randName, 1];
            TypeB = pokedex[randName, 2];
            LVL = randNum.Next(2, 6); //assign lvl by area in game
            setRandomStats();
        }

        void setNewMoves()
        {
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == noMove) moves[i] = "(///-)t";
                else moves[i] = noMove;
            }
        }

        void setRandomStats()
        {
            ////placeholder////
            maxHP = LVL + 15;
            currentHp = maxHP;
            ATK = LVL + 6;
            DEF = LVL + 5;
            SPEED = LVL + 6;
            EXPnext = LVL * 20;
        }

        void gainEXP()
        {
            EXP += 50;
            if (EXP == EXPnext) LVL++;
            setRandomStats();
        }

        void wildCombatAI()
        {

        }

        public void displayInfo()
        {
            Write($"> {NAME} type:");
            //Game.typeColor(TypeA);
            Write($"/");
            //Game.typeColor(TypeB);
            WriteLine($" level:{LVL} HP:{maxHP}" +
            $"\n  atk:{ATK} def:{DEF}" +
            $"\n  EXP < ########## > {EXP}/{EXPnext}");
        }


        public void Fight(Pokemon enemy)
        {
            useMove();
        }

        public void useMove()
        {
            WriteLine("> Select a move\n");
            WriteLine($"0 => {moves[0]}    1 => {moves[1]}\n" +
                      $"\n" +
                      $"2 => {moves[2]}    3 => {moves[3]}\n");
            int move = int.Parse(ReadLine());
            //get index in movelist.txt
            WriteLine("> {0} used {1}!", NAME, moves[move]);
            //if index not found(=-1) "I never added a move to that slot"
            //int moveDMG = 
            //return moveDMG;
        }

        void takeDamage(int dealtDMG)
        {
            currentHp -= dealtDMG-DEF;
        }

        int calculateTypeDamage(Pokemon defender)
        {
            //a-attacker   d-defender
            int aType1 = Array.IndexOf(types, TypeA);
            int aType2 = Array.IndexOf(types, TypeB);
            int dType1 = Array.IndexOf(types, defender.TypeA);
            int dType2 = Array.IndexOf(types, defender.TypeB);
            //Nota: si algun type2 es "" obtiene el valor 0
            double dmgType1, dmgType2, totaldmgMod;
            //calculate attacker damage
            dmgType1 = damageChart[aType1, dType1] + damageChart[aType1, dType2];
            dmgType2 = damageChart[aType2, dType1] + damageChart[aType2, dType2];
            totaldmgMod = dmgType1 + dmgType2;
            int dealtTypeDMG = Convert.ToInt32(totaldmgMod);
            return dealtTypeDMG;
        }
        
        //todo esto tiene que ser almacenado en un .txt//
        
        string[,] pokedex =
        {
            {"Knurttt","NORMAL",""},
            {"SPLAART!!!","ELECTRIC",""},
            {"Fuck King","GRASS","POISON"},
            {"Buntd,","BUG","POISON"},
            {"MAGIKRAP","WATER",""},
            {"TurntSNACO","ROCK",""},
        };
        double[,] damageChart =
        {
             //NORML|FIRE |WATER|GRASS|ELTRC| ICE |FIGHT|POISN|GROND|FLYNG|PSYCH| BUG |ROCK |GHOST|DRAGN|DARK |STEEL|
            {0,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  ,  0  },
            {0,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  , 0.5 },//NRML
            {0,  1  , 0.5 , 0.5 ,  2  ,  1  ,  2  ,  1  ,  1  ,  1  ,  1  ,  1  ,  2  , 0.5 ,  1  , 0.5 ,  1  ,  2  },//FIRE
            {0,  1  ,  2  , 0.5 , 0.5 ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  ,  1  ,  1  ,  2  ,  1  , 0.5 ,  1  ,  1  },//WATR
            {0,  1  , 0.5 ,  2  , 0.5 ,  1  ,  1  ,  1  , 0.5 ,  2  , 0.5 ,  1  , 0.5 ,  2  ,  1  , 0.5 ,  1  , 0.5 },//GRAS
            {0,  1  ,  1  ,  2  , 0.5 , 0.5 ,  1  ,  1  ,  1  ,  0  ,  2  ,  1  ,  1  ,  1  ,  1  , 0.5 ,  1  ,  1  },//ELTR
            {0,  1  , 0.5 , 0.5 ,  2  ,  1  , 0.5 ,  1  ,  1  ,  2  ,  2  ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  , 0.5 },//ICE
            {0,  2  ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  , 0.5 ,  1  , 0.5 , 0.5 , 0.5 ,  2  ,  0  ,  1  ,  2  ,  2  },//FIGT
            {0,  1  ,  1  ,  1  ,  2  ,  1  ,  1  ,  1  , 0.5 , 0.5 ,  1  ,  1  ,  1  , 0.5 , 0.5 ,  1  ,  1  ,  0  },//POSN
            {0,  1  ,  2  ,  1  , 0.5 ,  2  ,  1  ,  1  ,  2  ,  1  , 0.5 ,  1  , 0.5 ,  2  ,  1  ,  1  ,  1  ,  2  },//GRND    
            {0,  1  ,  1  ,  1  ,  2  , 0.5 ,  1  ,  2  ,  1  ,  1  ,  1  ,  1  ,  2  , 0.5 ,  1  ,  1  ,  1  , 0.5 },//FLYN    
            {0,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  2  ,  2  ,  1  ,  1  , 0.5 ,  1  ,  1  ,  1  ,  1  ,  0  , 0.5 },//PSYC
            {0,  1  , 0.5 ,  1  ,  2  ,  1  ,  1  , 0.5 , 0.5 ,  1  , 0.5 ,  2  ,  1  ,  1  , 0.5 ,  1  ,  2  , 0.5 },//BUG
            {0,  1  ,  2  ,  1  ,  1  ,  1  ,  2  , 0.5 ,  1  , 0.5 ,  2  ,  1  ,  2  ,  1  ,  1  ,  1  ,  1  , 0.5 },//ROCK
            {0,  0  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  ,  1  ,  2  ,  1  , 0.5 , 0.5 },//GHOS
            {0,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  , 0.5 },//DRAG
            {0,  1  ,  1  ,  1  ,  1  ,  1  ,  1  , 0.5 ,  1  ,  1  ,  1  ,  2  ,  1  ,  1  ,  2  ,  1  , 0.5 , 0.5 },//DARK
            {0,  1  , 0.5 , 0.5 ,  1  ,  1  ,  2  ,  1  ,  1  ,  1  ,  1  ,  1  ,  1  ,  2  ,  1  ,  1  ,  1  , 0.5 },//STEL
            //row-attacker//column-defender//
            //0-miss 0.5-half 1-normal 2-doble//
        };
        string[] types = 
            {"", "NORMAL", "FIRE", "WATER", "GRASS", "ELECTRIC", "ICE", "FIGHT", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL" };
    }
}
