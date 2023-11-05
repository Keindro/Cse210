using System;
using System.Collections.Generic;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        
    }
    //Constructor, showing inheritance of class members from the base class
    public BreathingActivity(string activityName, string activityDescription, 
    int intendedDuration, string endingText) : base(activityName, activityDescription, endingText, intendedDuration)
    {

        
    }

    //Method to initiate and terminate the breathe exercise
    public string StartBreathingActivity(int intendedDuration)
    {
        DateTime currentTime = DateTime.Now;
        
        DateTime futureTime = currentTime.AddSeconds(intendedDuration);
        pauseActivity();
        Console.WriteLine("Hit enter ");
            
        int countB = 0;
        while (DateTime.Now < futureTime)
        {
            DisplayAnimation();
            Console.WriteLine("Breathe in..");
            Console.WriteLine();      

            DisplayAnimation();
            Console.WriteLine("Now breathe out.." );
            Console.WriteLine();

            countB = countB + 2;

        }
        Console.WriteLine(ConclusionMsg());
        Console.Write($"You completed this Breathing exercise {countB} times in {intendedDuration} seconds. ");
        return Console.ReadLine();
        
    }
}