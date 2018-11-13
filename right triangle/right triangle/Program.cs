using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_triangle
{
    class Program
    {
        static void right_triangle(int a , int b , int c)
        {
            if (((a * a) + (b * b) ==(c*c)))
            {
                Console.WriteLine("This is a right triangle");
            }
            else
                Console.WriteLine("This is not a right triangle");
        }
        static void Main(string[] args)
        {
            int a,b,c;
            Console.Write("Please enter side 1 : ");
            a =int.Parse( Console.ReadLine());
            Console.Write("Please enter side 2 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Please enter Hypotenuse : ");
            c = int.Parse(Console.ReadLine());
            right_triangle(a, b, c);
            Console.ReadKey();
        }
    }
}
