using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercise = new List<Activity>();

        Running jog = new Running("12/01/2023", 2, .25);
        exercise.Add(jog);

        Cycling bike = new Cycling("12/05/2023", 25, 15);
        exercise.Add(bike);

        Swimming swim = new Swimming("12/10/2023", 30, 90);
        exercise.Add(swim);


        exercise.ForEach(delegate (Activity act)
        {
            Console.WriteLine(act.GetSummary());
        });
    }
}