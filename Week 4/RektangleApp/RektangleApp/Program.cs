using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektangleApp {
    class Program {
        static void Main(string[] args) {
            Rectangle rectangle1 = new Rectangle(100, 50);
            Rectangle rectangle2 = new Rectangle(250, 100);

            Console.WriteLine("Rectangle 1 attributes: Length: " + rectangle1.Length + " Width: " + rectangle1.Width);
            Console.WriteLine("Area of Rectangle 1: " + rectangle1.FindArea());
            Console.WriteLine("Perimeter of Rectangle 2: " + rectangle2.FindPerimeter());

            Console.WriteLine("Rectangle 1: " + rectangle1.ToString());
            Console.WriteLine("Rectangle 2: " + rectangle2.ToString());
        }
    }

    public class Rectangle {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length = 0, double width = 0) {
            this.Length = length;
            this.Width = width;
        }


        public double FindArea() {
            return Length * Width;
        }

        public double FindPerimeter() {
            return (2 * Length) + (2 * Width);
        }

        public override string ToString() {
            return "\nLength: " + Length
                + "\nWidth" + Width
                + "\nArea: " + FindArea()
                + "\nPerimeter" + FindPerimeter();
        }

    }
}
