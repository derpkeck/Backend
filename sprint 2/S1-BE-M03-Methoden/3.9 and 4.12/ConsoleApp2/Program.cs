using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Jan = 1;
            const int Feb = 2;
            const int mar = 3;
            const int apr = 4;
            const int may = 5;
            const int june = 6;
            const int July = 7;
            const int aug = 8;
            const int sept = 9;
            const int oct = 10;
            const int nov = 11;
            const int dec = 12;

            Console.WriteLine("vul de dag in");
            Console.ReadLine();

            Console.WriteLine("vul de maand in");
            int maand = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("vul het jaar in");
            int jaar = Convert.ToInt32( Console.ReadLine());

            int daysInJuly = Convert.ToInt32(System.DateTime.DaysInMonth(jaar, maand));
            Console.WriteLine(daysInJuly);
            Console.ReadLine();
        }
    }
}
