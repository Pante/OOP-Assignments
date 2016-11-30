using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7 {
    class Program {

        private static Menu menu;
        private static bool loop = true;
        public static List<Circle> ShapeList = new List<Circle>();

        static void Main(string[] args) {
            ShapeList.Add(new Circle("Red", 10.0));
            ShapeList.Add(new Circle("Green", 20.0));
            ShapeList.Add(new Circle("Blue", 30.0));
            menu = new Menu();

            while(loop) {
                menu.Display();
                Handle();
            }
        }

        static void Handle() {
            switch(Console.ReadLine()) {

                case "1":
                    menu.listShapes();
                    break;

                case "2":
                    menu.displayAreas();
                    break;

                case "3":
                    menu.displayPerimeters();
                    break;

                case "4":
                    menu.addCircle();
                    break;

                case "5":
                    menu.delCircle();
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
