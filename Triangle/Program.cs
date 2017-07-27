using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Wide");
            
            Console.Write("Please enter the Base :");
            int b = int.Parse(Console.ReadLine());
            while (b < 0) {
                Console.WriteLine("Value of Base cannot negative, Please enter again");
                Console.WriteLine("");
                Console.Write("Please enter the Base :");
                 b = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter the Height :");
            int h = int.Parse(Console.ReadLine());
            while (h < 0)
            {
                Console.WriteLine("Value of Height cannot negative, Please enter again");
                Console.WriteLine("");
                Console.Write("Please enter the Height :");
                h = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nYou have input Base and Height \n");
            Console.WriteLine("\nTriangle Wide : {0}", (b * h) / 2);

            Console.WriteLine("Thank you");
            Console.ReadKey();

        }
    }
}
