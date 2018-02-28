using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            string value = Console.ReadLine();
            int n = int.Parse(value);
            int i;

            for (i = 0; i <= n; i++);
            Console.Write("*", i);


        }
    }
}