using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Activities");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("4. Quit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;

            case 2:
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;

            case 3:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
                break;

            case 4:
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}