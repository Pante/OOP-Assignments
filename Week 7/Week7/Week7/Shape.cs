using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7 {
    abstract class Shape {
        public string type;
        public string color;

        public Shape() {
            // Do nothing
        }

        public Shape(string type, string color) {
            this.type = type;
            this.color = color;
        }

        public abstract double FindArea();
        public abstract double FindPerimeter();

        // If you insist
        public override string ToString() {
            return base.ToString();
        }
    }
}
