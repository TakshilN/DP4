﻿using System.Diagnostics.CodeAnalysis;

namespace DP4
{
    internal class ThreeSub
    {
        static void Main(string[] args)
        {
            //1. WAP to accept 3 subject marks from the user (from console) calculate the total & percentage display total and percentage of student

            int marathi, hindi, english, total, perc;

            Console.WriteLine("Enter marathi marks");

            marathi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre hindi marks");

            hindi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre english marks");

            english = Convert.ToInt32(Console.ReadLine());

            total = marathi + hindi + english;
            Console.WriteLine($"total of three subject is ={total}");

            perc = (marathi + hindi + english) / 3;
            Console.WriteLine($"percentage of three sub is = {perc}");
        }
    }
}

namespace DP4
{
    internal class GrossSalary
    {
        static void Main(string[] args)
        {
            //WAP to accept empid, empname and basic salary from user. Calculate the gross salary of emp from below points

                int Emp_ID, gross, Bs, Hra, Ta, Da, Pf, pt = 200;
                string Emp_name;

                Console.WriteLine("Entre Emp ID");
                Emp_ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("entre emp name");
                Emp_name = Console.ReadLine();

                Console.WriteLine(" entre basic sallary of emp");
                Bs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("hra is 40% of basic sallry = {hra}");
                Hra = (Bs * 40 / 100);

                Console.WriteLine("ta is 20 % of basic sallary = {ta}");
                Ta = (Bs * 20 / 100);

                Console.WriteLine(" da is 10 % of basic sallary = {da}");
                Da = (Bs * 10 / 100);

                Console.WriteLine(" pf is 12 % of basic sallary = {pf}");
                Pf = (Bs * 12 / 100);

                Console.WriteLine("gross sallary with allownce = {gross}");
                gross = (Bs + Hra + Ta + Da) - (Pf + pt);
                Console.WriteLine("add file");


            
        }
    }
}

namespace DP4
{
    internal class Area_circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");

            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;

            Console.WriteLine("Area of circle: " + Area);

            Console.ReadLine();
        }
    }
}

namespace DP4
{
    internal class Peri_rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the length and breadth of rectangle");

            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of a rectangle");

            int breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");

            int P = 2 * (length + breadth);

            Console.WriteLine(P);
        }
    }
}

namespace DP4
{
    internal class Third_angle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("angle one");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("angle two");

            int b = Convert.ToInt32(Console.ReadLine());

            int c = (a + b) - 180;

            Console.WriteLine(c);
        }
    }
}

namespace DP4
{
    internal class Greater_num
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine("the first number is greater" + num1);
            }
            else
            {
                Console.WriteLine($"the second number is greater" + num2);
            }
        }
    }
}

namespace DP4
{
    internal class EquilatenalTria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of an equivalent triangle");

            int a = Convert.ToInt32(Console.ReadLine());

            double area = 1.73 / 4 * (a) * 2;

            Console.WriteLine(area);
        }
    }
}

namespace DP4
{
    internal class Marks
    {
        static void Main(string[] args)
        {
            int marathi, hindi, english, computer, science;

            Console.WriteLine("Enter Marathi Marks:");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hindi Marks:");
            hindi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English Marks:");
            english = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Computer Marks:");
            computer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Science Marks:");
            science = Convert.ToInt32(Console.ReadLine());

            double avg, total, perc;

            total = marathi + hindi + english + computer + science;
            Console.WriteLine("Total Marks:" + total);

            avg = (total / 5);
            Console.WriteLine("Average Marks:" + avg);

            perc = (total / 500) * 100;
            Console.WriteLine("Percentage is:" + perc);
        }
    }
}

namespace DP4
{
    internal class ComponentInterest
    {
        static void Main(string[] args)
        {
            int n, P, T, R;
            double CI;

            Console.WriteLine("Enter Value of n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Priciple amount:");
            P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Rate:");
            R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Time period:");
            T = Convert.ToInt32(Console.ReadLine());

            CI = P * (1 + R / n) ^ (n * T);
            Console.WriteLine("Compound Interest is :" + CI);
        }
    }
}

namespace DP4
{
    internal class Celsius_Fahr
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Enter the temperature in Celsius");
            celsius = Convert.ToInt32(Console.ReadLine());



            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine(fahrenheit);
        }
    }
}

namespace DP4
{
    internal class Fehr_celcius
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Enter the temperatire in fahrenheit");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            celsius = (fahrenheit - 32) * 0.55;

            Console.WriteLine(celsius);
        }
    }
}

namespace DP4
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter a year ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("it is a leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");

            }
        }
    }
}

namespace DP4
{
    internal class Division_or_not
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 5 == 0 && num1 % 11 == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
        }
    }
}

namespace DP4
{
    internal class BillUnit
    {
        static void Main(string[] args)
        {
            double unit;
            double amt, total, surcharges;
            Console.WriteLine("Enter Total Units Consumed : ");
            unit = Convert.ToDouble(Console.ReadLine());

            if (unit <= 50)
            {
                amt = unit * 0.50;
            }
            else if (unit <= 150)
            {
                amt = 25 + ((unit - 50) * 0.75);
            }
            else
            {
                amt = 220 + ((unit - 200) * 1.50);
            }
            surcharges = amt * 0.20;
            total = amt + surcharges;
            Console.WriteLine($"Electricity Bill : {total}");
        }
    }
}

namespace DP4
{
    internal class MaxNum
    {
        static void Main(string[] args)
        {
            //Write a C# program to find maximum between three numbers(using logical operator)

            //int n1, n2, n3;
            //Console.WriteLine("Enter your no.");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your no.");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your no.");
            //n3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"greater number is {n2}" || $"greater number is {n3}");
        }
    }
}

namespace DP4
{
    internal class CharDigitSpecial
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch >= 'z') || (ch >= 'A' && ch >= 'Z'))
            {
                Console.WriteLine($"{ch} is character");
            }
            else if (ch >= 0 && ch <= 9)
            {
                Console.WriteLine($"{ch} is digit");
            }
            else
            {
                Console.WriteLine($"{ch} is special character");
            }
        }
    }
}

namespace DP4
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("Before Swaping");

            Console.WriteLine("Value of a is" + a);

            Console.WriteLine("Value of b is" + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("before swaping");

            Console.WriteLine("value of a is" + a);

            Console.WriteLine("value of b is" + b);
        }
    }
}