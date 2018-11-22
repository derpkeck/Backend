using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7_sprint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice;
            int getal = 0;
            int teller = 0;
            while (getal < 1000)
            {
                dice = rnd.Next(1, 7);
                getal = dice + getal;
                Console.WriteLine(dice + "| total is nu " + getal);
                teller = teller + 1;

            }
            Console.WriteLine("je hebt in " + teller + " keer een total van " + getal + " gegooid");
        }
    }
}
