using System;

namespace Lab_03_Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput2;

            do
            {
                Console.WriteLine("Enter an integer between 1 & 100: ");
                var userInput = Console.ReadLine();
                int inputNumber = int.Parse(userInput);

                if (inputNumber >= 1 && inputNumber <= 100)
                {
                    if (!(inputNumber % 2 == 0))
                    {
                        Console.WriteLine(inputNumber + " This number is odd.");
                    }
                    else if (inputNumber % 2 == 0 && (inputNumber >= 2 && inputNumber <= 25))
                    {
                        Console.WriteLine(inputNumber + " The number is even and less than 25.");
                    }
                    else if (inputNumber % 2 == 0 && inputNumber >= 26)
                    {
                        Console.WriteLine(inputNumber + " This number is even.");
                    }
                    else if ((!(inputNumber % 2 == 0)) && (inputNumber > 60))
                    {
                        Console.WriteLine(inputNumber + " This number is odd.");
                    }
                }
                Console.WriteLine("Would you like to continue (y/n)? ");
                userInput2 = Console.ReadLine();

            } while (userInput2 == "y");

            if (userInput2 == "n")
            {
                Console.WriteLine("Thanks for playing, goodbye!");
            }

        }
    }
}
