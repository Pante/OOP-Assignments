using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {

    class Program {

        private static List<Stationary> itemList = new List<Stationary> {
            new Paper("Synthetic Paper", "Blue", 0.05, 500),
            new Ribbon("Velvet Ribbon", "Red", 0.5, 10),
            new Paper("Premium Paper", "White", 0.06, 800),
            new Ribbon("Silk Ribbon", "Pink", 0.8, 12.5)
        };

        static void Main(string[] args) {
            ListItemAmount(itemList);
            IncreaseItemQuantity(itemList);
        }


        private static void ListItemAmount(List<Stationary> items) {
            for (int i = 0; i < items.Count; i++) {
                Stationary stationary = items[i];
                Console.WriteLine(String.Format("{0:0} {1:5} {2:5} {3:0.00} {4:0.00}", (i + 1), stationary.Name, stationary.Color, stationary.Price, stationary.CalculateAmount()));
            }
        }

        private static void IncreaseItemQuantity(List<Stationary> items) {
            for (int i = 0; i < items.Count; i++) {
                Stationary stationary = items[i];
                
                if (stationary is Paper) {
                    ((Paper) stationary).Weight += 10;

                } else {
                    ((Ribbon) stationary).Length *= 1.2;
                }
            }
        }


        public override string ToString() {
            throw new AbusedToStringException();
        }

    }
}
