using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Shapes;

namespace ShapeApp {
    class Program {

        private static Menu menu;
        private static bool loop;
        private static Circle circle;
        private static Cylinder cylinder;

        static void Main(string[] args) {
            menu = new Menu();
            loop = true;

            circle = new Circle(5);
            cylinder = new Cylinder(5, 10);

            while (loop) {
                menu.Display();
                Handle();
            }
        }

        static void Handle() {
            switch (Console.ReadLine()) {

                case "1":
                    menu.ChangeRadius(circle);
                    break;

                case "2":
                    menu.ChangeRadius(cylinder);
                    break;

                case "3":
                    menu.ChangeLength(cylinder);
                    break;

                case "4":
                    menu.DisplayArena(circle);
                    break;

                case "5":
                    menu.DisplayArena(cylinder);
                    break;

                case "6":
                    menu.DisplayVolume(cylinder);
                    break;

                case "0":
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }
        }
    }
}
