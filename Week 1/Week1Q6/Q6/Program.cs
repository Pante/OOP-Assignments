using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6 {
    class Program {
        static void Main(string[] args) {
            new Controller(new Menu(new List<string> {"Cindy", "Kelvin", "Sean", "Lucy", "Sarah", "Melvin"})).handle();
        }
    }

    class Controller {

        private Menu menu;

        public Controller(Menu menu) {
            this.menu = menu;
        }


        public void handle() {
            while (true) {
                displayMenu();

                string choice;
                if ((choice = Console.ReadLine()).Equals("1")) {
                    menu.addStudent();

                } else if (choice.Equals("2")) {
                    menu.displayAll();

                } else if (choice.Equals("3")) {
                    menu.removeStudent();

                } else if (choice.Equals("0")) {
                    break;

                } else {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private void displayMenu() {
            Console.WriteLine("1. Add a new student to the list\n" +
                            "2 .Display all students in the list\n" + 
                            "3. Remove an existing student from the list\n" + 
                            "0. Quit this program"
                            );

        }

    }

    class Menu {

        private List<string> students;


        public Menu(List<string> students) {
            this.students = students;
        }

        public void addStudent() {
            Console.WriteLine("Enter the name of the student to add to the list");
            string name;
            students.Add((name = Console.ReadLine()));
            Console.WriteLine(name + " is added to the list");
        }

        public void displayAll() {
            Console.WriteLine("No.  Name. ");
            foreach (string student in students) {
                Console.WriteLine((students.IndexOf(student) + 1) + "    " + student);
            }
        }

        public void removeStudent() {
            Console.WriteLine("Enter the name of the studet to be removed from the list");
            string name;
            students.Remove(name = Console.ReadLine());
            Console.WriteLine(name + " has been removed from the list");
        }

    }
}
