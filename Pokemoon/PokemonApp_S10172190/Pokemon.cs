using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp_S10172190 {
    class Pokemon {

        public string name { get; set; }
        public int combatPoints { get; set; }
        public int healthPoints { get; set; }


        public Pokemon() { }

        public Pokemon(string name, int combatPoints, int healthPoints) {
            this.name = name;
            this.combatPoints = combatPoints;
            this.healthPoints = healthPoints;
        }


        public double CalculateStrength() {
            return ((double) combatPoints) / 10 + (double) healthPoints * 3;
        }


        public override string ToString() {
            return string.Format("{0, -10} {1, 13} {2, 13} {3, 10:0.00}", name, combatPoints, healthPoints, CalculateStrength());
        }

    }
}
