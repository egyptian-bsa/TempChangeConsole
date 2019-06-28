using System;

namespace TempChangeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid Fahrenheit temperature.");
            string strDegText = Console.ReadLine();
            double DegText, CelText;
            DegText = double.Parse(strDegText);
            CelText = (5.0 / 9.0) * (DegText - 32.0);
            Console.WriteLine("It is " + CelText.ToString() + " degrees in Celsius.");

            if (DegText > 100)
            {
                Console.WriteLine("It's Hot! Better Hydrate");

            }
            else if (DegText <= 32)
            {
                Console.WriteLine("It's Cold! Better pack long underwear");

            }
            Console.ReadLine();
        }
    }
}
