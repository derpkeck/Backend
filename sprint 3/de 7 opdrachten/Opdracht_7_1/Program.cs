using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getalen = new int[5];
            int count = 1;
            Console.WriteLine("vul 5 getalen in");
            for (int i=0; i<getalen.Length; i++)
            {
                getalen[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i< getalen.Length; i++)
            {
                Console.WriteLine("nummer "+count+ " is: " + getalen[i]);
                count = count + 1;
            }
           
            
        }
    }
}
