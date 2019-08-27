using System;
using System.IO;

namespace DesignPatterns.TemplateMethodPattern
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            string userChoice = GetUserInput();
            if (userChoice.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            string choice = "no";
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                choice = Console.ReadLine();
            }
            catch(IOException ioe)
            {
                Console.WriteLine($"IO error while reading your input - {ioe.Message}");
            }

            return choice;
        }
    }
}
