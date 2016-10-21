using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    class Program {

        private static int number;
        private const string prompt = "Enter a number between 1 and 100 (or -1 to exit)";

        static void Main(string[] args) {

            Console.WriteLine("Welcome to the number guessing game");
            Random random = new Random();

            while (true) {
                Console.WriteLine(prompt);
                number = random.Next(1, 101);

                handleGuesses();

                Console.WriteLine("Play again (Y : N) ?: ");

                if (Console.ReadLine().Equals("N", StringComparison.InvariantCultureIgnoreCase)) {
                    break;
                }
            }

        }

        private static void handleGuesses() {
            while (true) {
                try {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == -1) {
                        break;

                    } else if (guess > number) {
                        Console.WriteLine("Your guess it too high!");
                        Console.WriteLine("Guess again, " + prompt);

                    } else if (guess < number) {
                        Console.WriteLine("Your guess it too low!");
                        Console.WriteLine("Guess again, " + prompt);

                    } else {
                        Console.WriteLine("Bingo! The correct is " + number);
                        break;
                    }

                } catch (FormatException e) {
                    Console.WriteLine("Invalid input, " + prompt);
                }
            }
        }

    }
}
