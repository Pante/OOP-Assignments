using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoshCardApp {
    class Menu {

        private List<Cashcard> cards;

        public Menu(List<Cashcard> cards) {
            this.cards = cards;
        }


        public void Display() {
            Console.WriteLine("\n----------------------------------M E N U------------------------------------------" +
                            "\n[1]  List details of all cash cards" +
                            "\n[2]  Top up cash card" +
                            "\n[3]  Deduct cash card" +
                            "\n[4]  Search for a cash card by card id" +
                            "\n[5]  Add a new cash card" +
                            "\n[6]  Remove a cash card" +
                            "\n[0]  Exit" +
                            "\n---------------------------------------------------------------------------------------- -"
                            );
        }

        public void ListCards() {
            StringBuilder buffy = new StringBuilder();
            buffy.Append("S/No      ID      Value");

            for (int i = 0; i < cards.Count; i++) {
                buffy.Append(i + 1).Append("      ").Append(cards[i].id).Append("      ").Append(cards[i].balance);
            }

            Console.WriteLine(buffy.ToString());
        }


        public void TopUpCard() {
            while (true) {
                Console.WriteLine("Enter S/No of cash card to top up: ");
                int serial = int.Parse(Console.ReadLine()) - 1;

                if (serial >= cards.Count) {
                    Console.WriteLine("No such card with serial number: " + serial);
                    continue;
                }

                Console.WriteLine("Enter the amount to top up:");
                int amount = int.Parse(Console.ReadLine());
                cards[serial].TopUp(amount);

                Console.WriteLine("New balance: " + cards[serial].balance);
            }
        }

        public void DeductCard() {
            while (true) {
                Console.WriteLine("Enter S/No of cash card to deduct: ");
                int serial = int.Parse(Console.ReadLine()) - 1;

                if (serial >= cards.Count) {
                    Console.WriteLine("No such card with serial number: " + serial);
                    continue;
                }

                Console.WriteLine("Enter the amount to deduct up:");
                int amount = int.Parse(Console.ReadLine());
                if (cards[serial].Deduct(amount)) {
                    Console.WriteLine("New balance: " + cards[serial].balance);

                } else {
                    Console.WriteLine("Insufficent funds, amount not deducted.");
                }
            }
        }


        public void SearchCard() {
            Console.WriteLine("Enter the ID of the card to search: ");
            int serial = int.Parse(Console.ReadLine());

            if (serial < cards.Count) {
                Console.WriteLine("Card details: ID: " + cards[serial].id + " Value: " + cards[serial].balance);

            } else {
                Console.WriteLine("Invalid card ID");
            }
        }


        public void AddCard() {
            Console.WriteLine("Enter ID for new card: ");
            String id = Console.ReadLine();

            Console.WriteLine("Enter balance for new card: ");
            double amount = double.Parse(Console.ReadLine());
            
            cards.Add(new Cashcard(id, amount));
            Console.WriteLine("New card created");
        }


        public void RemoveCard() {
            Console.WriteLine("Enter the ID of the card to search: ");
            int serial = int.Parse(Console.ReadLine());

            if (serial < cards.Count) {
                cards.RemoveAt(serial);

            } else {
                Console.WriteLine("Invalid card ID");
            }
        }


    }
}
