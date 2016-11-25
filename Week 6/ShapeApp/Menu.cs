using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Shapes;

namespace ShapeApp {
    class Menu {

        public void Display() {
            string menu = "----------------M E N U---------------- -"
                + "\n[1] Change the radius of circle"
                + "\n[2] Change the radius of cylinder"
                + "\n[3] Change the length of cylinder"
                + "\n[4] Display the area of circle"
                + "\n[5] Display the surface area of cylinder"
                + "\n[6] Display the volume of cylinder"
                + "\n[0] Exit"
                + "\n------------------------------------------"
                + "\nEnter your option:";

            Console.WriteLine(menu);
        }


        public void ChangeRadius(Circle circle) {
            Console.WriteLine("Current radius of " + circle.GetType().Name + ": " + circle.Radius);
            Console.WriteLine("Enter new radius: ");
            circle.Radius = double.Parse(Console.ReadLine());
        }

        public void ChangeLength(Cylinder cylinder) {
            Console.WriteLine("Current length of cylinder");
            Console.WriteLine("Enter new length: ");
            cylinder.Length = double.Parse(Console.ReadLine());
        }


        public void DisplayArena(Circle circle) {
            Console.WriteLine("Area of " + circle.GetType().Name + ": " + circle.CalculateArea());
        }

        public void DisplayVolume(Cylinder cylinder) {
            Console.WriteLine("Area of cylinder: " + cylinder.CalculateVolume());
        }

    }
}
