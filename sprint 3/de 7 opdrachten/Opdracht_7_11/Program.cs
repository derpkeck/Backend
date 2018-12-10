using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 10;
            int max = 100;

            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] som = new int[10];
            Random randnum = new Random();

            Console.WriteLine("array1 - array2 - som");
            for (int i=0; i<array1.Length; i++)
            {
                array1[i] = randnum.Next(min, max);
                array2[i] = randnum.Next(min, max);
                som[i] = array1[i] + array2[i];
                Console.WriteLine(array1[i] + " - " + array2[i] + " - " + som[i]);
            }
        }
    }
}
