using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8 {
    class Program {
        public static List<Shape> ShapeList = new List<Shape>();

        static void Main(string[] args) {
            ShapeList.Add(new Circle("Circle", 10.0));
            ShapeList[0].Color = "Red";
            ShapeList.Add(new Circle("Circle", 20.0));
            ShapeList[1].Color = "Blue";
            ShapeList.Add(new Square("Square", 30.0));
            ShapeList[2].Color = "Blue";

            Menu menu = new Menu();
            menu.run();

        }

    }
}
