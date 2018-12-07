using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vul een getal in");
            string getal = Console.ReadLine();
            int lengte = getal.Length;
            for (int i = 0; i < lengte - 1; i++)
            {
                Console.Write("{0} + ", getal[i]);
            }
            Console.Write(getal[lengte - 1]+" = " + SomCijfers(getal));
            Console.ReadLine();
        }
        static double SomCijfers(string getal2)
        {
            double som = 0;
            int lengte = getal2.Length;
            for(int i=0;i < lengte; i++)
            {
                som = som + Convert.ToInt32(getal2[i].ToString());
            }
            return som;
        }
    }
}
