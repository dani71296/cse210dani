using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

        
    }
    public void Run()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());//DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"Breathing in ");
            ShowCountdown(4);
            Console.WriteLine($"Breathing out ");
            ShowCountdown(6);
        }
        DisplayEndMessage();
        

    }
}