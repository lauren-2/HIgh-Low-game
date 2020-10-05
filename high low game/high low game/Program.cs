using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low_game
{
    class Program
    {
        static void Main(string[] args)
        {
           // Welcome message
            Console.WriteLine("Welcome to the high low game");
        
           // choose random number
            Random rng = new Random();
            int number = rng.Next(1, 11);
            int tries = 0; 
           
            while (true)
            {
                // Enter user guess
                Console.Write("Enter Guess:");
                int guess = Convert.ToInt32(Console.ReadLine());
                tries = tries + 1;
                // compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low. Go higher!!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high. Go lower!!");
                }
                else
                {
                    Console.WriteLine("Correct. Well done!!");
                    Console.WriteLine(tries + "Guesses");
                    break;
                }
            }

                // Wait for a key press
            Console.ReadKey();
        }
            
    }
}
