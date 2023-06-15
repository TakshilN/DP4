using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DP4
{
    internal class Arithmatic
    {
        static void Main(string[] args)
        {
            //without convertion
           
            int num1 = 30, num2 = 25, result1, result2;
            result1 = num1 / num2;
            result2 = num2 % num1;
            Console.WriteLine($"division is {result1}");
            Console.WriteLine($"mod is {result2}");
        }
    }
}

namespace DP4
{
    internal class Arithmatic2
    {
        static void Main(string[] args)
        {

            int num1 = 30, num2 = 25, result2;
            double result1;
            result1 = (double)num1 / num2;
            result2 = num2 % num1;
            Console.WriteLine($"division is {result1}");
            Console.WriteLine($"mod is {result2}");
        }
    }
}

namespace DP4
{
    internal class Arithmatic3
    {
        static void Main(string[] args)
        {
            int num1 = 77, num2 = 15;
            
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            double div = (double)num1 / num2;
            int mod = num1 % num2;

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"sub = {sub}");
            Console.WriteLine($"mul = {mul}");
            Console.WriteLine($"div = {div}");
            Console.WriteLine($"mod = {mod}");
        }
    }
}


namespace DP4
{
    internal class Relational
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 5;

            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);

            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 >= num2);

            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
        }
    }
}

namespace DP4
{
    internal class Logical
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 9, num3 = 3;
            Console.WriteLine(num1 > num2 && num1 > num3);

        }
    }
}

namespace DP4
{
    internal class Logicalor
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 9, num3 = 2;
            Console.WriteLine(num1 > num2 || num1 > num3);
        }
    }
}

namespace DP4
{
    internal class Logicalnot
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 9, num3 = 8;
            Console.WriteLine(!(num1 > num2 || num1 > num3));
        }
    }
}

namespace DP4
{
    internal class Unary
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 10;
            int res1 = num1--;
            int res2 = --num2;
            Console.WriteLine($"res1 {res1} num1 = {num1}");
            Console.WriteLine($"res2 {res2} num2 = {num2}");
        }
    }
}

namespace DP4
{
    internal class Unary2
    {
        static void Main(string[] args)
        {
            int num1 = 10;

            Console.WriteLine($"{num1++}, {++num1}, {num1++}");

            int num2 = 10;
            Console.WriteLine($"{--num2}, {++num2}, {num2++}, {++num2}");

            int num3 = 10;

            int res1 = num3++;
            int res2 = ++num3 +num3++;

            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}

namespace DP4
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 25;
            bool result = (num1 > num2) ? true : false;

            int res = (num1 > num2) ? num1 : num2;
            string res2 = (num1 > num2) ? "Num1 is greater" : "Num2 is greater";
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}

namespace DP4
{
    internal class Ternary2
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            bool result = (num1 > 0 % 2) ? true : false;
            int res = (num1 > 0 % 2) ? num1 : 0;
            string res2 = (num1 > 0 % 2) ? "even" : "odd";
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}

namespace DP4
{
    internal class Ternary3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int num = Convert.ToInt32(Console.ReadLine());
            string res = (num % 2 == 0) ? "even" : "odd";

            Console.WriteLine(res);

            Console.WriteLine("enter your number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your number");
            int num2 = Convert.ToInt32(Console.ReadLine());
           
            string res1 = (num1 % 2 == 0) ? "even" : "odd";
            string res2 = (num2 % 2 == 1) ? "odd" : "even";

            Console.WriteLine(res1);
            Console.WriteLine(res2);

        }
    }
}

namespace DP4
{
    class HelloWorld
    {
        public void print()
        {
            int[] num = { 1, 2, 3, };
            int MaxNum = num.Max();

            Console.WriteLine(MaxNum);
        }
    }
}