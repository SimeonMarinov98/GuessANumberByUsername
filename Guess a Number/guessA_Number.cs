using System;

namespace Guess_a_Number
{
    internal class guessA_Number
    {
        static void Main(string[] args)
        {
            Random randomNumber=new Random();
            int computerNumber=randomNumber.Next(1,101);
            int playerNumber;
            while(true)
            {
                Console.Write("Guess a number!(1-100)");
                string input=Console.ReadLine();
                bool isValid = int.TryParse(input, out playerNumber);
                if(isValid)
                {
                    if(playerNumber==computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber<computerNumber)
                    {
                        Console.WriteLine("Too Low.");
                        

                    }
                    else if (playerNumber>computerNumber)
                    {
                        Console.WriteLine("Too High.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

        }
    }
}
