using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string ant moet leeg zo dat je hem later kan gebruiken*/
            string ant = "";
            /* van af hier ga je alles invullen (voornaam, tussenvoegsels en achternaam)*/
            Console.WriteLine("wat is je naam");
            string voornaam = Console.ReadLine();

            Console.WriteLine("wat zijn je tussenvoegsels");
            string tussenvoegsels = Console.ReadLine();

            Console.WriteLine("wat is je achternaam");
            string achternaam = Console.ReadLine();
            /* van af hier zet je alles in ant*/
            ant = ant + voornaam + tussenvoegsels + achternaam;
            /* ant.lengte betekend dat hij de letters van ant bij elkaar opteld*/
            Console.WriteLine(ant.Length);
            Console.ReadLine(); 
        }
    }
}
