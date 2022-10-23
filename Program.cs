using System;

namespace HighLowGuessingGame
{
    internal static class Program
    {
        private static void Main()
        {
            var random = new Random();
            var guess = 1;
            bool playAgain;
            do
            {
                var target = random.Next(1, 100);
                var count = 0;
                playAgain = false;
                Console.WriteLine("Please enter a number between 1 and 100\n");
                while (guess!=target)
                {
                    try
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        guess = int.Parse(Console.ReadLine());
                    }
                    catch (Exception )
                    {
                        guess = 0;
                        Console.WriteLine("\nERROR: Invalid input, has to be an integer\n");
                    }

                    count++;
                    if (guess == 0)
                    {
                        goto LoopEnd;
                    }

                    if (guess<target)
                    {
                        Console.WriteLine("Your guess is too low!");
                    }
                    else if (guess>target)
                    {
                        Console.WriteLine("Your guess is too high!");
                    }
                }
                Console.WriteLine("Correct!\nGuesses: "+count);
                LoopEnd:
                if (guess==0)
                {
                    Console.WriteLine("Quit Game Successfully");
                }
                Console.WriteLine("Play again? [y/N]\n");
                var input = Console.ReadLine();
                if (input=="y"||input=="Y")
                {
                    playAgain = true;
                }
            } while (playAgain);
            Console.WriteLine("Game Over");
        }
    }
}