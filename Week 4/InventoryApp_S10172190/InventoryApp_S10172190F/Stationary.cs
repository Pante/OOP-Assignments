using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    abstract class Stationary {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Stationary() { }

        public Stationary(string n, string c, double p) {
            Name = n;
            Color = c;
            Price = p;
        }

        public abstract double CalculateAmount();

        public override string ToString() {
            return "Name: " + Name + ", Color: " + Color + ", Price: " + Price;
        }
    }
}
