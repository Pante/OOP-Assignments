using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Q2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a whole number: ");
            int count = Int32.Parse(Console.ReadLine());
            int answer = 1;

            if(count == 0) {
                Console.WriteLine("0! = 1");
            } else {
                Console.Write(count + "! = ");
                for(int i = count; i > 1; i--) {
                    Console.Write(i + " x ");
                    answer *= i;
                }
                Console.Write("1 = " + answer);
            }

            Console.ReadLine();
        }
    }
}
