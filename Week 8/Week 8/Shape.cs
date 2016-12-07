using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8 {
    abstract class Shape {
        public String Type { get; set; }
        public String Color { get; set; }

        public Shape() {
            // Do nothing
        }

        public Shape(String type, String color) {
            this.Type = type;
            this.Color = color;
        }

        abstract public double FindArea();
        abstract public double FindPerimeter();

        public override string ToString() {
            return base.ToString();
        }

    }
}
