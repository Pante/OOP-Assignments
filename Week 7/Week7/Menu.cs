using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7 {
    class Menu {

        public void Display() {
            string menu = "---------------- M E N U --------------------\n"
                        + "[1] List all the shapes\n"
                        + "[2] Display the areas of the shapes\n"
                        + "[3] Display the perimeters of the shapes\n"
                        + "[4] Add a new circle\n"
                        + "[5] Delete a circle\n"
                        + "[0] Exit\n"
                        + "----------------------------------------------\n"
                        + "Enter your option :";

            Console.Write(menu);
        }

        public void listShapes() {
            foreach(Circle i in Program.ShapeList) {
                Console.WriteLine(i.GetType());
            }
        }

        public void displayAreas() {
            foreach(Circle i in Program.ShapeList) {
                Console.WriteLine(i.FindArea());
            }
        }

        public void displayPerimeters() {
            foreach(Circle i in Program.ShapeList) {
                Console.WriteLine(i.FindPerimeter());
            }
        }

        public void addCircle() {
            Program.ShapeList.Add(new Circle());
        }

        public void delCircle() {
            Program.ShapeList.Remove(Program.ShapeList[Program.ShapeList.Count - 1]);
        }
    }
}