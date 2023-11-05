using System;
using System.Collections.Generic;

public class FitnessActivity : Activity
{
    //Constructor
    public FitnessActivity()
    {
        
    }
    
    //Constructor, showing inheritance of class members from the base class
    public FitnessActivity(string activityName, string activityDescription, 
    int intendedDuration, string endingText) : base(activityName, activityDescription, endingText, intendedDuration)
    {
        
    }

    public string StartFitnessActivity(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);
        
        pauseActivity();
        DisplayAnimation();
        
        Console.WriteLine("Stand up, stretch, seat and hit the enter key");
        Console.WriteLine("get ready...");
            
        int countF = 0;
        while (DateTime.Now < futureTime)
        {
            
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                DisplayAnimation();
                Console.WriteLine("Stand up, stretch, seat and hit the enter key");
                Console.WriteLine("get ready...");
                Thread.Sleep(500);
            }           
            countF = countF + 1;


        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Listing Activity {countF} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}