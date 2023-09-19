using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");
        while (number != 0)
        {
            Console.Write("Enter number:");
            string response = Console.ReadLine();
            number = int.Parse(response);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        double average = numbers.Average();
        Console.WriteLine($"The Average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is:{maxNumber}");
    }
}
