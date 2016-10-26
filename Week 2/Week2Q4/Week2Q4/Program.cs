using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Q4 {
    class Program {
        static void Main(string[] args) {
            breakfastMenu();
            Console.Write("Enter your choice of breakfast menu: ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice > 5 || choice < 1) {
                Console.WriteLine("Invalid choice.");
            } else {
                Console.Write("You will be served ");
                if(choice == 1) {
                    Console.WriteLine("Toast bread with coffee");
                } else if(choice == 2) {
                    Console.WriteLine("Cereals in chocolate milk");
                } else if(choice == 3) {
                    Console.WriteLine("Croissant sandwich with tuna filling");
                } else if(choice == 4) {
                    Console.WriteLine("Hotcakes with syrup");
                } else if(choice == 5) {
                    Console.WriteLine("French toast with tea");
                }
            }
        }

        public static void breakfastMenu() {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Breakfast Menu");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Toast bread with coffee");
            Console.WriteLine("2. Cereals in chocolate milk");
            Console.WriteLine("3. Croissant sandwich with tuna filling");
            Console.WriteLine("4. Hotcakes with syrup");
            Console.WriteLine("5. French toast with tea");
        }


    }
}
