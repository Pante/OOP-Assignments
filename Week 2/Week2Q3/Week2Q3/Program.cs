using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Q3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the total price: ");
            double price = double.Parse(Console.ReadLine());

            for(int i = 5; i < 10; i += 2)
                Console.WriteLine("GST for $" + price + " based on " + i + 
                    "% GST is $" + calcGST(price, i));
        }

        static double calcGST(double totalPrice, double percentageGST = 7) {
            return totalPrice * (percentageGST/100);
        }
    }
}
