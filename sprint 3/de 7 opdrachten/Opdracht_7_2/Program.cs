using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            String[] namen = new string[6] { "rico", "syon", "erel", "vincent", "job", "emanuel" };
            int i = rnd.Next(0,7);
            Console.WriteLine(namen[i]);
            
        }
    }
}
