using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Q1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Enter weight: ");
            float weight = float.Parse(Console.ReadLine());

            float bmi = weight / (height * height);
            Console.WriteLine("BMI calculated: " + Math.Round(bmi, 2));
            Console.Write("Catergory: ");
            if(bmi < 18.5)
                Console.Write("Underweight");
            else if(bmi < 25)
                Console.Write("Normal weight");
            else if(bmi < 30)
                Console.Write("Overweight");
            else
                Console.Write("Obesity");

            //To prevent program from ending
            Console.ReadLine();
        }
    }
}