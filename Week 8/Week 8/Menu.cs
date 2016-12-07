using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8 {
    class Menu {

        private bool flag = true;

        public Menu() { }

        public void run() {
            while(flag) {
                checkOption(displayMenu());
            }
        }

        private int displayMenu() {
            Console.Write("---------------- M E N U --------------------\n" +
                          "[1] List all the shapes\n" +
                          "[2] Display the areas of the shapes\n" +
                          "[3] Display the perimeters of the shapes\n" +
                          "[4] Change the size of a shape\n" +
                          "[0] Exit\n" +
                          "----------------------------------------------\n" +
                          "Enter your option: ");
            return Int32.Parse(Console.ReadLine());
        }

        private void checkOption(int option) {
            switch(option) {
                case 1:
                    listShape();
                    break;

                case 2:
                    displayArea();
                    break;

                case 3:
                    displayPerimeter();
                    break;

                case 4:
                    changeSize();
                    break;

                case 0:
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;

            }

        }

        private void listShape() {
            foreach(Shape i in Program.ShapeList)
                Console.WriteLine(i);
        }

        private void displayArea() {
            foreach(Shape i in Program.ShapeList)
                Console.WriteLine(i.FindArea());
        }

        private void displayPerimeter() {
            foreach(Shape i in Program.ShapeList)
                Console.WriteLine(i.FindPerimeter());
        }

        private void changeSize() {
            Console.Write("Enter your shape index: ");
            int index = Int32.Parse(Console.ReadLine());

            if(Program.ShapeList[index] is Circle) {
                Console.Write("Enter Radius: ");
                Circle i = (Circle)Program.ShapeList[index];
                i.Radius = Double.Parse(Console.ReadLine());

            } else if(Program.ShapeList[index] is Square) {
                Square i = (Square)Program.ShapeList[index];
                i.Length = Double.Parse(Console.ReadLine());
            }
        }
    }
}
