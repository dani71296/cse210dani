using System;
using System.Numerics;

class Program
{
   
        static string DisplayWelcome()
        {
            return"welcome to the program";
        }
        static string PromptUserName()
        {
            Console.WriteLine("Plase enter your name:");
            string nameUserInput= Console.ReadLine();
            return nameUserInput;
            
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Plase enter your favorite number:");
            string numberUserInput= Console.ReadLine();
            int numerTiped= int.Parse(numberUserInput);
            return numerTiped;
            
        }
        static int SquareNumber(int numerTiped)
        {
            int total=numerTiped*numerTiped;
            return total;
        }
        static void DisplayResults()
        {
            string welcomeMessage = DisplayWelcome();  
            string userName = PromptUserName();  
            int userNumber = PromptUserNumber();  
            int squaredNumber = SquareNumber(userNumber);
            //Console.WriteLine(welcomeMessage);
            //Console.WriteLine(userName);
            //Console.WriteLine(userNumber);
            Console.WriteLine($"Brother {userName}, the square of your  number is {squaredNumber}");
        }
        static void Main(string[] args)
        {
            DisplayResults();
        }
}