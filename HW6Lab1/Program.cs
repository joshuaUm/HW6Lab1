/// Homework No. 6 Lab No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 4 2021
/// 
/// Problem Statement : Create a guessing game, user inputs a number from 0-100 to guess a randomly generated number, they are told "Higher" or "Lower" depending on where they incorrectly guessed.
/// 
/// Plan:
/// 1. Generate number from 0-100 using Random class.
/// 2. Enter while loop.
/// 3. Prompt user for a number.
/// 4. If user entered the random number, end loop, otherwise say "higher" or "lower" depending on the range of error from the random number.
/// 5. Print number of iterations before correct number was inputted.

using System;

namespace HW6Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = -1, guessNumber = new Random().Next(0, 101), numGuesses = 0;
            do
            {
                Console.WriteLine("Enter Number:");
                userNumber = Int32.Parse(Console.ReadLine());
                numGuesses++;

                if (userNumber == guessNumber)
                {
                    Console.WriteLine("Correct.");
                    break;
                }
                else if (userNumber < guessNumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if (userNumber > guessNumber)
                {
                    Console.WriteLine("Lower.");
                }
            } while (userNumber != guessNumber);

            Console.WriteLine("Number of Guesses : " + numGuesses);
        }
    }
}
