using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_sprint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tik je eerste getal in");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tik je tweede getal in");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            int veelvoud = getal1 / getal2;
            if (veelvoud == 0)
            {
                Console.WriteLine("het tweede getal is het veelvoud van het eerste getal");
            }
            else
            {
                Console.WriteLine("het tweede getal is geen veelvoud van het eerste getal");
            }
        }
    }
}
