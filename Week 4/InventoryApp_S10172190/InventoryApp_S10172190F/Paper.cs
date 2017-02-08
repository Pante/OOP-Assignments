using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Paper : Stationary {
        public int Weight { get; set; }

        public Paper() : base() { }

        public Paper(string n, string c, double p, int w) : base(n, c, p) {
            Weight = w;
        }

        public override double CalculateAmount() {
            return base.Price * Weight;
        }

        public override string ToString() {
            return base.ToString() + ", Weight: " + Weight;
        }
    }
}
