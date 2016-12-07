using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8 {
    class Square : Shape {

        public double Length { get; set; }

        public Square() : base() {
            // Do nothing
        }

        public Square(string type, double length) : base() {
            base.Type = type;
            this.Length = length;
        }

        public override double FindArea() {
            return Length * Length;
        }

        public override double FindPerimeter() {
            return Length * 4;
        }

        public override string ToString() {
            return base.ToString();
        }

    }
}
