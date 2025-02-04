using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Pokemon(string name)
        {
            this.Name = name;
            this.Health = 100;
        }

        public int Attack1()
        {
            Random rnd = new Random();
            return rnd.Next(10,91);
        }

        public int Attack2()
        {
            Random rnd = new Random();
            return rnd.Next(30, 71);
        }

        public int Attack3()
        {
            Random rnd = new Random();         
            return rnd.Next(40, 61);
        }

        public int Heal()
        {
            Random rnd = new Random();
            int healValue = rnd.Next(20, 71);
            Health += healValue;
            if (Health > 100)
            {
                Health = 100;
            }
            return healValue;
        }

    }
}