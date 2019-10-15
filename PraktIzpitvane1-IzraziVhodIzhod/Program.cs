using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktIzpitvane1_IzraziVhodIzhod
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadacha 1-1:
            Console.Write("Enter your weight: ");
            double earthWeight = double.Parse(Console.ReadLine());
            double moonWeight = earthWeight * 17 / 100;
            Console.WriteLine("Your weight on the Moon is {0} kilograms",Math.Round(moonWeight));
            //zadacha 1-2:
            Console.Write("Enter x=");
            double x = double.Parse(Console.ReadLine());
            double y = (Math.Pow(x,5)+Math.Sqrt(x+5)) / (Math.Sqrt(x+14)+3*x) - 4 - x;
            Console.WriteLine("y={0}",Math.Round(y,2));
            //zadacha 2-1:
            Console.Write("Enter number earth days: ");
            int eartDays  = int.Parse(Console.ReadLine());
            int jupiterYears = eartDays / 365 / 12;
            Console.WriteLine("{0} Earth days equals {1} Jupiter years", eartDays, jupiterYears);
            //zadacha 2-2:
            y = (x+Math.Sqrt(x+5)) / (Math.Sqrt(x+14)+3*x) - 24;
            Console.WriteLine("y={0}", Math.Round(y, 2));
            //zadacha 3-1:
            Console.Write("Enter distance in kilometres: ");
            double km = double.Parse(Console.ReadLine());
            double miles = km / 1.6;
            Console.WriteLine("{0} kilometres equals {1} miles", km, miles);
            //zadacha 3-2:
            y = (x+Math.Sqrt(Math.Pow(x,6)+5)) / (Math.Sqrt(x+14)+3*x) - x;
            Console.WriteLine("y={0}", Math.Round(y, 2));
            //zadacha 4-1:
            Console.WriteLine("Enter triange sides: ");
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            double a1 = a / 2;
            double b1 = b / 2;
            double c1 = c / 2;
            double p = (a1 + b1 + c1) / 2;
            double L = a1 + b1 + c1;
            double S = Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            Console.WriteLine("L={0}, S={1}", L,S);
            //zadacha 4-2:
            y = (Math.Sqrt(x) + Math.Sqrt(Math.Pow(x,3) + 5)) / (Math.Sqrt(3 + 14*x) + 3*x) - 24;
            Console.WriteLine("y={0}", Math.Round(y, 2));
            //zadacha 5-1:
            Console.WriteLine("Enter rectangle sides: ");
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int number = m / n;
            Console.WriteLine("There are {0} squares in the rectangle", number);
            //zadacha 5-2:
            y = (7 + Math.Sqrt(x + 5)) / (Math.Sqrt(3 + 14 * Math.Pow(x, 3)) - 3 * Math.Sqrt(x)) - Math.Pow(x, 3) ;
            Console.WriteLine("y={0}", Math.Round(y, 2));
            Console.ReadKey();
        }
    }
}
