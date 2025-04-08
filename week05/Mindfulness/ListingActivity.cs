using System;

class ListingActivity : MindfulnessActivity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public ListingActivity() 
        : base("Listen Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {   
    }
    public void Run()
    {
        DisplayStartMessage();
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(randomPrompt);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        

        

        GetList(GetDuration());

        DisplayEndMessage();
    }

    public void GetList(int durationTime)
    {
        Console.WriteLine("Please start listing...");
        DateTime endTime = DateTime.Now.AddSeconds(durationTime);
        while (DateTime.Now < endTime)
        {
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine($"You listed: {userInput}");
            }
            else
            {
                Console.WriteLine("No input detected, try again.");
            }
        }
    }
}