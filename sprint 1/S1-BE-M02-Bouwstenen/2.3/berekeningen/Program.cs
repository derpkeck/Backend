using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berekeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            int intgetal1, intgetal2, intsom, intmin1, intmin2, intkeer, intdelen1, intdelen2, intmode1, intmode2;
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.Write("geef getal1: ");
            intgetal1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("geef getal2: ");
            intgetal2 = Convert.ToInt16(Console.ReadLine());
            // vanaf hier word alles berekend.
            intsom = intgetal1 + intgetal2;
            Console.Write(intgetal1+"+"+intgetal2+"="+intsom.ToString());
            Console.ReadLine();
            intmin1 = intgetal1 - intgetal2;
            Console.Write(intgetal1+"-"+intgetal2+"="+intmin1.ToString());
            Console.ReadLine();
            intmin2 = intgetal2 - intgetal1;
            Console.Write(intgetal2+"-"+intgetal1+"="+intmin2.ToString());
            Console.ReadLine();
            intkeer = intgetal1 * intgetal2;
            Console.Write(intgetal1 + "x" + intgetal2 + "=" + intkeer.ToString());
            Console.ReadLine();
            intdelen1 = intgetal1 / intgetal2;
            Console.Write(intgetal1 + "/" + intgetal2 + "=" + intdelen1.ToString());
            Console.ReadLine();
            intdelen2 = intgetal2 / intgetal1;
            Console.Write(intgetal2 + "/" + intgetal1 + "=" + intdelen2.ToString());
            Console.ReadLine();
            intmode1 = intgetal1 % intgetal2;
            intmode2 = intgetal2 % intgetal1;
            Console.Write(intgetal1 + "%" + intgetal2 + "=" + intmode1.ToString());
            Console.ReadLine();
            Console.Write(intgetal2 + "%" + intgetal1 + "=" + intmode2.ToString());
            Console.ReadLine();
        }
    }
}
