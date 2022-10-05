using System;
namespace Uppgift3_16
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur lång är den låten du vill spela");

            int svar = int.Parse(Console.ReadLine());
            
            if(svar >= 245 && svar <= 420)
            {
                Console.WriteLine("Du får spela den här låten");

            }
            else
            {
                Console.WriteLine("Du får inte spela låten");
            }
        }
    }
}