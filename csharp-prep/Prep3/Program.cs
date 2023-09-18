using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 0;
    
        while (guess !=  number)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        
        
            if (guess > number)
            {
                Console.Write("Guess lower,");
            }    
        
            else if (guess < number)
            {
                Console.Write("Guess higher,");
            }
        
            else
            {
                Console.Write("You guessed it right! :)");  
            }


        }

    }
}