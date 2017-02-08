using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Ribbon : Stationary {
        public double Length { get; set; }

        public Ribbon() : base() { }

        public Ribbon(string n, string c, double p, double l) : base(n, c, p) {
            Length = l;
        }

        public override double CalculateAmount() {
            return base.Price * Length;
        }

        public override string ToString() {
            return base.ToString() + ", Length: " + Length;
        }
    }

}
