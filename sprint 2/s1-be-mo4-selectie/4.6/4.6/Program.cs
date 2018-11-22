using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef de hoeveelheid werkuren aan");
            int werkuren = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef aan hoe veel jaar je hem al hebt");
            int jaar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef aan hoeveel storingen hij per jaar heeft");
            int storingen = Convert.ToInt32(Console.ReadLine());
            if (werkuren > 10000)
            {
                Console.WriteLine("koop een nieuwe ");
            }
            else
            {
                if (jaar > 7)
                {
                    Console.WriteLine("koop een nieuwe ");
                }
                else
                {
                    if (storingen > 25)
                    {
                        Console.WriteLine("koop een nieuwe ");
                    }
                    else
                    {
                        Console.WriteLine("deze kan nog wel een jaartje er me door ");
                    }
                }
            }
        }
    }
}
