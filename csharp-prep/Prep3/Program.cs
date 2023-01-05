using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnum = new Random();
        int correctnum = randomnum.Next(1, 101);

        int guess = -1;

        while (guess != correctnum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (correctnum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (correctnum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }  
    }
}