using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;

namespace PokemonGrumps
{
    class Pokemon
    {
        public string NAME { get; set; }
        string TypeA, TypeB;
        int maxHP, currentHp, LVL, ATK, DEF, SPEED;
        Move[] moves = new Move[4]; //7 lines max each
        //string noMove = "-?????-";
        public Pokemon(int Id)
        {
            NAME = POKEDEX[Id,0];
            TypeA = POKEDEX[Id,1];
            TypeB = POKEDEX[Id,2];
            LVL = int.Parse(POKEDEX[Id,3]); //assign lvl by area in game
            // placeholders 
            maxHP = LVL + 15;
            currentHp = maxHP;
            ATK = LVL + 6;
            DEF = LVL + 5;
            SPEED = LVL + 6;
            setMoves(Id);
        }

        string[] pkmnType =
            {"NORMAL", "FIRE", "WATER", "GRASS", "ELECTRIC", "ICE", "FIGHT", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL" };

        static string[,] POKEDEX = new string[10, 4];
        public static void Pokedex()
        {
            string path = "pokedex.txt";
            //0-name 1-typeA 2-typeB 3-lvl
            string lines = File.ReadAllText(path);
            string[] data = lines.Split('.');
            int z = 0;
            for (int i = 0; i < POKEDEX.GetLength(0); i++)
            {
                for (int j = 0; j < POKEDEX.GetLength(1); j++)
                {
                    POKEDEX[i, j] = data[z];
                    z++;
                }
            }
        }

        void setMoves(int Id)
        {
            if (Id == 0)//charmander
            {
                moves[0] = new Move(1);
                moves[1] = new Move(2);
                moves[2] = new Move(0);
                moves[3] = new Move(0);
            }
            else if (Id == 1)//squirtle
            {
                moves[0] = new Move(8);
                moves[1] = new Move(9);
                moves[2] = new Move(0);
                moves[3] = new Move(0);
            }
        }

        public void displayInfo()
        {
            Write($"> {NAME} type:");
            Write(TypeA);
            Write($"/");
            Write(TypeB);
            WriteLine($" level:{LVL} HP:{maxHP}" +
            $"\n  atk:{ATK} def:{DEF}");
        }

        public void Fight(Pokemon enemy)
        {
            useMove(enemy);
        }
        
        void useMove(Pokemon enemy)
        {
            WriteLine("> Select a move\n");
            WriteLine($"0 => {moves[0].Tag}    1 => {moves[1].Tag}\n" +
                      $"\n" +
                      $"2 => {moves[2].Tag}    3 => {moves[3].Tag}\n");
            int move = int.Parse(ReadLine());
            WriteLine("> {0} used {1}!", NAME, moves[move].Tag);
            calculateTypeDamage(moves[move].Type, enemy);
        }

        void takeDamage(int dealtDMG)
        {
            currentHp -= dealtDMG-DEF;
            WriteLine($"{NAME} received {dealtDMG} damage!");
        }

        //Cuando ataca toma el tipo del move contra los tipos del pkmn enemigo
        void calculateTypeDamage(int moveTypeId, Pokemon defender)
        {
            generateDamageChart();
            int defenderType1 = Array.IndexOf(pkmnType, defender.TypeA);
            int defenderType2 = Array.IndexOf(pkmnType, defender.TypeB);
            //Damage deal by move to enemy type1
            double moveToType1 = dmgchart[moveTypeId, defenderType1];
            //Damage dealt by move to enemy type2 if exists
            if (defenderType2 >= 0) //Array.IndexOf devuelve -1 si el valor no se encuentra en el array.
            {
                double moveToType2 = dmgchart[moveTypeId, defenderType2];
                defender.takeDamage(ATK * Convert.ToInt32((moveToType1 + moveToType2)));
            }
            else defender.takeDamage(ATK * Convert.ToInt32(moveToType1));
            Game.debuggingText($" the move type is {pkmnType[moveTypeId]} and the enemy type is {defender.TypeA} \nso the damagechart returned {moveToType1}");
        }

        double[,] dmgchart = new double[17, 17];
        void generateDamageChart()
        {
            //row-attacker//column-defender//
            //0-miss .5-half 1-normal 2-doble//
            string chart = "types_damage_chart.txt";
            string read = File.ReadAllText(chart);
            string[] nums = read.Split(' ');
            int z = 0;
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    dmgchart[i, j] = double.Parse(nums[z]);
                    z++;
                }
            }
        }
    }
}
