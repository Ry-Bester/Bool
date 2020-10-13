
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? please type true or false");

            bool DuiTest = Convert.ToBoolean(Console.ReadLine());
            //if (Dui == "false" || Dui == "no")
            //{
            //    DuiTest = true;
            //}
            Console.WriteLine("How many speeding tickets do you have?");
            int tic = Convert.ToInt32(Console.ReadLine());
            bool CD = (age > 15 && DuiTest == false && tic < 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(CD);
            Console.ReadLine();
        }
    }
}
