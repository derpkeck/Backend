using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 10000;

            int[] getalen = new int[25];
            Random randnum = new Random();

            Console.WriteLine("even: ");
            for (int i=0; i<getalen.Length; i++)
            {
                getalen[i] = randnum.Next(min, max);
                if((getalen[i]%2) == 0)
                {
                    Console.WriteLine(getalen[i]);
                }
            }
            Console.WriteLine("oneven: ");
            for (int i=0; i<getalen.Length; i++)
            {
                if ((getalen[i] % 2) != 0)
                {
                    Console.WriteLine(getalen[i]);
                }
            }
        }
    }
}
