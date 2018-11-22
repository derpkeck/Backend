using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_sprint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vier = 0;
            for (int i = 1901; i<2018; i++)
            {
                vier = vier + 1;
                if (vier == 4)
                {
                    Console.WriteLine(i + " is een schrikkeljaar");
                    vier = vier - vier;
                }
                else
                {

                }
            }
        }
    }
}
