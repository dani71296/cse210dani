using System;

class MindfulnessActivity
{
    private string _nameActivity;
    private string _description;
    private int _durationTime;
    public MindfulnessActivity (string nameActivity, string description)
    {
        _nameActivity=nameActivity;
        _description=description;

    }
    public void SetDuration()
    {
        Console.WriteLine("set the duration time in seconds ");
        string timeNumber = Console.ReadLine();
        _durationTime= int.Parse(timeNumber);

    } 
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"welcome to the {_nameActivity}");
        Console.WriteLine($"{_description}");
        SetDuration();
        Console.WriteLine("ready to start...");
        ShowCountdown(4);
        Console.WriteLine();

    }
     public void DisplayEndMessage()
     {
        Console.WriteLine("Good Job");
        //ShowCountdown(3);
        Console.WriteLine($"you have completed the activity: {_nameActivity} for {_durationTime} seconds");
        //ShowCountdown(3);

     }
     public int GetDuration()
    {
        return _durationTime;
    }

}