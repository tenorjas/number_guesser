using System;

namespace number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,100);
            int guess = 0;
            int numGuesses = 0;

            Console.WriteLine("This program generates a random integer between 1 and 100.");
            Console.WriteLine("Your objective is to guess the number.");
            Console.WriteLine("Please enter a guess:");
            guess = int.Parse(Console.ReadLine());
            numGuesses ++;

            while (guess != randomNumber)
            {
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high.");
                }
                Console.WriteLine("Please enter another guess:");

                guess = int.Parse(Console.ReadLine());
                numGuesses ++;
            }

            Console.WriteLine("Congratulations!  You guessed the number correctly!");
            Console.WriteLine($"The random number was {randomNumber}.");
            Console.WriteLine($"You needed {numGuesses} guesses to guess the number.");
        }
    }
}
