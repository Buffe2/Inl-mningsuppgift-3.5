using System;
namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int intNr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            int intNr2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Välj nu ett räknesätt.");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string val = Console.ReadLine();
            

            switch (val)
            {
                case "1":
                    Console.WriteLine("Summan av dina tal är = ");
                    Console.WriteLine(intNr1 + intNr2);
                    break;

                case "2":
                    Console.WriteLine("Differansen av dina tal är = ");
                    Console.WriteLine(intNr1 - intNr2);
                    break;

                case "3":
                    Console.WriteLine("Produkten av dina tal är = ");
                    Console.WriteLine(intNr1 * intNr2);
                    break;

                default:
                    Console.WriteLine("Kvoten av dina tal är = ");
                    Console.WriteLine(intNr1 / intNr2);
                    break;
            }
        }
    }
}