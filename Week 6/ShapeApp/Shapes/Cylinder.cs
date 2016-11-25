using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Shapes {
    class Cylinder : Circle {

        public double Length { get; set; }


        public Cylinder(double radius = 0, double length = 0) : base(radius) {
            Length = length;
        }


        public override double CalculateArea() {
            return base.CalculateArea() * 2 + (Radius * 2 * Math.PI * length);
        }

        public double CalculateVolume() {
            return base.CalculateArea() * Length;
        }


        public override string ToString() {
            // Redundancy at its finest.
            return base.ToString();
        }


    }
}
