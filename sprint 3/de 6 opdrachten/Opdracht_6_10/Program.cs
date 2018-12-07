using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_10
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 0;
            int b = 0;
            Console.WriteLine("geef een getal in");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef nog een getal");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("getal 1 = voor de swap: {0}", a);
            Console.WriteLine("getal 2 = voor de swap: {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("getal 1 = na de swap: {0}", a);
            Console.WriteLine("getal 2 = na de swap: {0}", b);
        }
    }
}
