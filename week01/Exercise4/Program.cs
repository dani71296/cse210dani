using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersByUser = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        string numberUserInput= Console.ReadLine();
        int numerTiped= int.Parse(numberUserInput);
        while(numerTiped!=0)
        {
            numbersByUser.Add(numerTiped);
             Console.WriteLine("Enter number: ");
            numberUserInput= Console.ReadLine();
            numerTiped= int.Parse(numberUserInput);
        }
        int sum = 0;
        int maxNumber = numbersByUser[0];
        foreach (int numbs in numbersByUser)
        {
            sum+= numbs;
            if (numbs > maxNumber) 
            {
                maxNumber = numbs;
            }
        }
        Console.WriteLine($"the total sum is {sum} ");
        int total= numbersByUser.Count;
        float average = sum/total;
        Console.WriteLine($"the average is {average} ");
        Console.WriteLine($"The highest number is {maxNumber}");

    }
}