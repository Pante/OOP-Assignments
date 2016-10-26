using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Q8 {
    class Program {
        static void Main(string[] args) {
            printTimesTable(8);
            printTimesTable(11);
        }

        static void printTimesTable(int number, int times = 12) {
            for (int i = 0; i <= times; i++) {
                Console.WriteLine(i + " x " + number + " = " + (i * number));
            }
        }
    }
}
