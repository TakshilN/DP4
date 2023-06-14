using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4
{
    internal class dp4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your percentage");
            double per = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello {name} your age is {age} and percentage = {per}");
        }
    }
}
