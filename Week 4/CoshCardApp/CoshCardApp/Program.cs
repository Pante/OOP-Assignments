using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoshCardApp {
    class Program {

        static bool loop = true;

        static void Main(string[] args) {

            Menu menu = new Menu(InitCardList());

            while (loop) {
                try {
                    menu.Display();
                    handle(menu);
                } catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        static void handle(Menu menu) {
            Console.WriteLine("Enter your option: ");

            switch (Console.ReadLine()) {
                case "1":
                    menu.ListCards();
                    break;

                case "2":
                    menu.TopUpCard();
                    break;

                case "3":
                    menu.DeductCard();
                    break;

                case "4":
                    menu.SearchCard();
                    break;

                case "5":
                    menu.AddCard();
                    break;

                case "6":
                    menu.RemoveCard();
                    break;

                case "0":
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static List<Cashcard> InitCardList() {
            return new List<Cashcard> {
                new Cashcard("001", 25),
                new Cashcard("002", 25),
                new Cashcard("003", 30),
                new Cashcard("004", 30),
                new Cashcard("005", 50)
            };
        }

    }
}
