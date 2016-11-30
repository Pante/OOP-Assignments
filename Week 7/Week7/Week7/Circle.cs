using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7 {
    class Circle : Shape {
        protected double radius;

        public Circle() {
            // Do nothing
        }

        public Circle(string color, double radius) {
            base.color = color;
            this.radius = radius;
        }

        public override double FindArea() {
            return Math.PI * radius * radius;
        }

        public override double FindPerimeter() {
            return 2 * Math.PI * radius;
        }

        // If you insist again
        public override string ToString() {
            return base.ToString();
        }
    }
}
