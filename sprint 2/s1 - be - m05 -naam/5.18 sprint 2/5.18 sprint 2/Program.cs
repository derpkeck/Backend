using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _5._18_sprint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een e-mail in");
            string emailtocheck = Console.ReadLine();
            if (isvalidemail(emailtocheck) && ( emailtocheck.EndsWith(".com") || emailtocheck.EndsWith(".nl")))
            {
                Console.WriteLine("dat was een goed emailadres");
            }
            else
            {
                Console.WriteLine("dit is geen echt mailadres");
            }
            Main(args);
        }
        private static bool isvalidemail(string emailtocheck)
        {
            try
            {
                MailAddress mail = new MailAddress(emailtocheck);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
