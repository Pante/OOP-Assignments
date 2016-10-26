using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Q1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("The result of adding one to " + num +" is " + addOne(num));
        }

        static int addOne(int number) {
            return number++;
        }
    }
}
