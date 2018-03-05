using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your number is ");
            string value = Console.ReadLine();
            int number = int.Parse(value);
            var sum = 0;
            if (number > 1000)
            {
                Console.WriteLine("Number is wrong");
            }
            else
            {
                for (var i = 0; i < number; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum = sum + i;
                    }
                }

                Console.WriteLine(sum);
            }
            Console.ReadKey();

        }


    }
}
