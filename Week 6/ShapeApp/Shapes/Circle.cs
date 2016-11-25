using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Shapes {
    class Circle {

        public double Radius { get; set; }


        public Circle(double radius = 0) {
            Radius = radius;
        }


        public virtual double CalculateArea() {
            return Radius * 2 * Math.PI;
        }


        public override string ToString() {
            // Redundancy at its finest.
            return base.ToString();
        }

    }
}
