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
            ter = "A";
        }
        else if(percent >= 90)
        {
            ter = "A-";
        }
        else if (percent >= 87)
        {
            ter = "B+";
        }
        else if (percent >= 83)
        {
            ter = "B";
        }
        else if (percent >= 80)
        {
            ter = "B-";
        }
        else if (percent >= 77)
        {
            ter = "C+";
        }
        else if (percent >= 73)
        {
            ter = "C";
        }
        else if (percent >= 70)
        {
            ter = "C-";
        }
        else if (percent >= 67)
        {
            ter = "D+";
        }
        else if (percent >= 63)
        {
            ter = "D";
        }
        else if (percent >= 60)
        {
            ter = "D-";
        }
        else
        {
            ter = "F";
        }
        Console.WriteLine($"Your grade is {ter}.");
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