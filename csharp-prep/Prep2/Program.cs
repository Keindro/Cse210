using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to grade letter determiner!");
        Console.Write("Please enter your percent grade:");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if(percent>= 93)
        { 
            letter = "A";
        }
        else if(percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent >= 83)
        {
            letter = "B";
        }
        else if (percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent >= 73)
        {
            letter = "C";
        }
        else if (percent >= 70)
        {
            letter = "C-";
        }
        else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >= 63)
        {
            letter = "D";
        }
        else if (percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (percent >= 70 )
        {
            Console.WriteLine("Congratulations, you passed.");  
        }
        else
        {
            Console.WriteLine("Sorry but you didn't meet the requierment to pass.");
        }

    }
}