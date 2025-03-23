using System;
class Program
{
   static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only Son");
        StartGame(scripture);
    }

    static void StartGame(Scripture scripture)
    {
        Console.WriteLine("¡Welcome to the scripture game!");
        Console.WriteLine("press enter to hide words or quit to exit");

        while (true)
        {
            Console.WriteLine(scripture.DisplayScripture());

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("goodbye..");
                break;
            }
            Console.Clear();
            Console.WriteLine("press enter to hide words or quit to exit");
            scripture.HideRandomWords(1); 
        }

        Console.WriteLine("¡end game!");
    }
}