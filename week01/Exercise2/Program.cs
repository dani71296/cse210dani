using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade porcentage?");
        string gradePorcentage = Console.ReadLine();
        int numberPorcentage= int.Parse(gradePorcentage);
        if (numberPorcentage>=70 && numberPorcentage<= 80)
        {
            Console.WriteLine("congratulation your letter grade is C");           
        }
        else if (numberPorcentage>=80 && numberPorcentage<= 90)
        {
            Console.WriteLine("congratulation your letter grade is B");
        }
        else if (numberPorcentage>=90 && numberPorcentage<= 100)
        {
            Console.WriteLine("congratulation your letter grade is A");
        }
        else if (numberPorcentage >= 60 && numberPorcentage <= 70)
        {
            Console.WriteLine("keep learning you can doit for the nex time your letter grade is D");
        }
        else 
        {
            Console.WriteLine("try the next time we love you your letter grade is F");
        }
    }
}