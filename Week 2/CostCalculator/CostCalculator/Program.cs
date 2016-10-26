using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double costPerTicket = 10.00;

            while (true)
            {
                Console.WriteLine("Cost per Ticket: $" + costPerTicket);
                Console.Write("Enter the no. of tickets to purchase: ");
                int num = Convert.ToInt32(Console.ReadLine());

                double totalCost = calculateTotal(costPerTicket, num);

                Console.WriteLine("The total cost for " + num + " ticket is $" + totalCost);

                Console.Write("Try again? (y or n): ");
                char again = Convert.ToChar(Console.ReadLine());
                if (again == 'n')
                {
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                }
            }
            
        }

        static double calculateTotal(double costPerTicket, int numOfTicket)
        {
            double totalCost = costPerTicket * numOfTicket;

            // 10% discount is given if no. of ticket is more than 5.
            if (numOfTicket > 5);
            {
                totalCost = 0.9 * totalCost;
            }

            return totalCost;
        }
    }
}
