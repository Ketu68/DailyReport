using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
//            int hours;
//            string help[], experiences[], feedback[];

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pagenumstr = Console.ReadLine();
            int page = Convert.ToInt32(pagenumstr);
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpstr = Console.ReadLine();
            bool help = Convert.ToBoolean(helpstr);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursstr = Console.ReadLine();
            int hours = Convert.ToInt32(hoursstr);
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.Read();
        }
    }
}
