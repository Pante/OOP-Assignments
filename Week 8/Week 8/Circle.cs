using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8 {
    class Circle : Shape {
        public double Radius { get; set; }

        public Circle() : base() { 
            // Do nothing
        }

        public Circle(String type, double radius): base() {
            base.Type = type;
            this.Radius = radius;
        }

        public override double FindArea() {
            return Math.PI * Radius * Radius;
        }

        public override double FindPerimeter() {
            return Math.PI * Radius * 2;
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
