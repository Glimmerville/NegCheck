using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_or_neg_bookchap10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for user input of one number (convert to int)
            //ask for user input of second number (convert to int)
            //compare first int && second int to 0; if either is < 0 result negative
            //I think they really want you to check the signs (?)
            //So I guess I could leave the input as a string and check index[0]
            //but that sounds like a dumb idea (but it would work)
            Console.WriteLine("I will determine if your two numbers will multiply to become positive or negative");
            Console.WriteLine("Because I have nothing better to do");
            string PlayAgain = "Y";
            while (PlayAgain == "Y" || PlayAgain == "y")
            {
                Console.WriteLine("Give me the first number");
                string firstInput = Console.ReadLine();
                if (firstInput[0] == '-')
                {
                    Console.WriteLine("Well that one is Negative, but if the next one is also Negative, they will multiply and become positive! So what is the next one?");
                }
                Console.WriteLine("Ok give me the second number");
                string secondInput = Console.ReadLine();
                if (firstInput[0] == secondInput[0])
                {
                    Console.WriteLine("Oh they're going to be positive!");
                }
                int firstDig = int.Parse(firstInput);
                int secondDig = int.Parse(secondInput);
                if (firstDig < 0 && secondDig > 0 || firstDig > 0 && secondDig < 0)
                {
                    Console.WriteLine("They are going to be negative.");
                }
                Console.WriteLine("Do you want to do this again? Y/N");
                PlayAgain = Console.ReadLine();
            }
        }
    }
}
