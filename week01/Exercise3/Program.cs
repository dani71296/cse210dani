using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        //Console.WriteLine("what is your magic number?");
        //string numberUserInput= Console.ReadLine();
        //int numberConverted= int.Parse(numberUserInput);
        Console.WriteLine("what is your guess?");
        string guessUserInput= Console.ReadLine();
        int guessConverted= int.Parse(guessUserInput);
        int number = randomGenerator.Next(1, 20);
        
        while (guessConverted!=number)
            {
                Console.WriteLine("what is your guess? ");
                 guessConverted = int.Parse(Console.ReadLine());
            
                if (guessConverted<number)
                {
                    Console.WriteLine(" Higher ");
                }
                else if (guessConverted>number)
                {
                    Console.WriteLine(" Lower ");
                }
            }
        Console.WriteLine("you guessed it");
            
         
    }
}