using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a ");
            string valuea = Console.ReadLine();
            int a = int.Parse(valuea);

            Console.Write("Insert b ");
            string valueb = Console.ReadLine();
            int b = int.Parse(valueb);
            int c;
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Incorrect value");
            }
            else
                Console.WriteLine(c = a * b);
            Console.ReadKey();


        }
    }
}
