using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMessage("Podaj jakąś liczbę:");
                try
                {
                    var number = GetNumber();

                    if (IsNumberEven(number))
                    {
                        DisplayMessage("Ta liczba jest parzysta");
                    }
                    else
                    {
                        DisplayMessage("Ta liczba jest nieparzysta");
                    }
                }
                catch (Exception)
                {
                    DisplayMessage("Podano liczbę w nieprawidłowym formacie");
                }
                finally
                {
                    DisplayMessage("");
                }
            }
        }

        private static bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        private static int GetNumber()
        {
            var result = int.Parse(Console.ReadLine());
            
            return result;
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
