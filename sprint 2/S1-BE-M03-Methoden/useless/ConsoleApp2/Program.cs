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
            DateTime datum;

            Console.Write("vul de datum in(dd-mm-yyyy: ");
            datum = DateTime.Parse(Console.ReadLine());
           

            int days = Convert.ToInt32(System.DateTime.DaysInMonth(datum.Year, datum.Month));
            Console.WriteLine("in de maand {0} zitten {1} dagen.", datum.ToString("MMMM", new System.Globalization.CultureInfo("nl-NL")), days);
            Console.ReadLine();
        }
    }
}
