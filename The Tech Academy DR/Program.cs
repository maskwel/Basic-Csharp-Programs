using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace The_Tech_Academy_DR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            string courseName;
            int coursePageNum;
            bool help;
            string studentExp;
            string studentFb;
            int studentHours;


            Console.WriteLine("The Tech Academy.\n\nStudent Daily Report.");

            Console.WriteLine("\nWhat is your name?");
            studentName = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            courseName = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            coursePageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false.\"");
            help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            studentExp = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            studentFb = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            studentHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!" +
                "\n\nPress any key to exit.");

            Console.ReadKey();
        }
    }
}
