using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program {
    class Program {

        static void Main(string[] args) {
            Rectangle outerRectangle = new Rectangle();
            outerRectangle.length = 20;
            outerRectangle.width = 14;

            Rectangle innerRectangle = new Rectangle();
            innerRectangle.length = 15;
            innerRectangle.width = 8;

            Console.WriteLine("Area of shaded region in rectangle = " + (getArea(outerRectangle) - getArea(innerRectangle)));

            outerRectangle.length = 25;
            outerRectangle.width = 18;

            Circle circle = new Circle();
            circle.radius = 5;

            Console.WriteLine("Area of shaded region in rectangle = " + (getArea(outerRectangle) - getArea(circle)));
        }

        private static double getArea(Rectangle rectangle) {
            return rectangle.length * rectangle.width;
        }

        private static double getArea(Circle circle) {
            return circle.radius * circle.radius * Math.PI;
        }
    }

    struct Rectangle {
        public double length;
        public double width;
    }

    struct Circle {
        public double radius;
    }
}
