using System;
namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            double fltNr1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            double fltNr2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Välj nu ett räknesätt.");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string val = Console.ReadLine();            

            switch (val)
            {
                case "1":
                    Console.WriteLine("Summan av "+ fltNr1 + " + " + fltNr2 + " är = ");
                    Console.WriteLine(fltNr1 + fltNr2);
                    break;

                case "2":
                    Console.WriteLine("Differansen av " + fltNr1 + " - " + fltNr2 + " är = ");
                    Console.WriteLine(fltNr1 - fltNr2);
                    break;

                case "3":
                    Console.WriteLine("Produkten av " + fltNr1 + " * " + fltNr2 + " är = ");
                    Console.WriteLine(fltNr1 * fltNr2);
                    break;

                default:
                    Console.WriteLine("Kvoten av " + fltNr1 + " / " + fltNr2 + " är = ");
                    Console.WriteLine(fltNr1 / fltNr2);
                    break;
            }
        }
    }
}
