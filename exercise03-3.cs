using System;

namespace exercise03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            bool correct = false;
            while (correct==false)
            {
                Console.WriteLine("Please guess a number between 1 to 3.");
                int guessedNumber = int.Parse(Console.ReadLine());
                if(guessedNumber<1 || guessedNumber > 3)
                {
                    Console.WriteLine("The number is not in the valid range, please enter again that between 1 to 3.");
                }
                if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("The number is less than the correct number.");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("The number is larger than the correct number.");
                }
                else
                {
                    Console.WriteLine("Your guess is correct.");
                    correct = true;
                }
            }
        }
    }
}
