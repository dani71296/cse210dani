using System;

class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    public ReflectionActivity() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {   
    }
    public void Run()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            ShowCountdown(4);
            string randomPrompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(randomPrompt);
            string reflection= GetReflection();
            Console.WriteLine($"You wrote: {reflection}");
            
        }
        DisplayEndMessage();
    }
    public string GetReflection()
    {
        Console.WriteLine("START WRITING YOUR REFLECTION ");
        string reflection = Console.ReadLine();
        return reflection;
    }
}