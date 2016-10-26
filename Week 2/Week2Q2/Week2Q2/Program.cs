using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Q2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter length: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Area of the rectangle " + length + " x " + 
                width + " is " + calcAreaOfRectangle(length, width));
        }

        static float calcAreaOfRectangle(float length, float width) {
            return length * width;
        }
    }
}
