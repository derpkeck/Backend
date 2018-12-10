using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 10;
            int max = 100;

            int[] getalen = new int[25];
            Random randnum = new Random();

            Console.WriteLine("normaal: ");
            for (int i = 0; i < getalen.Length; i++)
            {
                getalen[i] = randnum.Next(min, max);
                Console.WriteLine(getalen[i]);
            }
            Console.WriteLine("andersom");
            for (int j= 24; j>0 - 1; j--)
            {
                Console.WriteLine(getalen[j]);
            }
        }
    }
}
