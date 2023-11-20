using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputfc;
            double localcur;
            double uahcur;

            Converter currency = new Converter();
            currency.X = 41.55; //static cur. x y z to uah
            currency.Y = 41;
            currency.Z = 0.61;

            currency.H = 41.90; //static cur. uah to x y z
            currency.C = 41.50;
            currency.D = 1.63;

            
            Console.WriteLine("Options of convertaion: UAH --> US Dollar, Euro, Rubl; \n Choose one option:   $UAH$, $USD$, $EUR$, $RUB$.");
            inputfc = Console.ReadLine();

            if (inputfc == "USD")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n USD " + uahcur / currency.H);
                localcur = currency.Z;
            }
            else if (inputfc == "EUR")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n EUR " + uahcur / currency.C);
                localcur = currency.Y;
            }
            else if (inputfc == "RUB")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n RUB " + uahcur / currency.D);
                localcur = currency.X;
            }
            else if (inputfc == "UAH")
            {
                Console.WriteLine("\nIt's an option to convert other currencies: \n US Dollar, Euro, Rubl --> UAH " +
                    "\nType what exactly you want to convert: $USD$, $EUR$, $RUB$");
                inputfc = Console.ReadLine();
                if (inputfc == "USD")
                {
                    Console.WriteLine("\nUSD quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nConvertation result:" + "\n UAH " + uahcur * currency.X);
                }
                else if (inputfc == "EUR")
                {
                    Console.WriteLine("\nEUR quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nConvertation result:" + "\n UAH " + uahcur * currency.Y);
                }
                else if (inputfc == "RUB")
                {
                    Console.WriteLine("\nRUB quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("Convertation result:" + "\n UAH " + uahcur / currency.Z);
                }
                else Console.WriteLine("\n **INPUT ERROR!**");
            }
            else
                Console.WriteLine("\n **INPUT ERROR!**");
        }
    }
}
