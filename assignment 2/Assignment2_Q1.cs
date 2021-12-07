using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Area of circle : {3.14 * r * r}");
            Console.ReadKey();
        }
    }
}
