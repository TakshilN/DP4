using DP4;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

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
    internal class Swap
    {
        static void Main(string[] args)
        {
            //Swap values of two integer variables using third variable

            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("Before Swaping");

            Console.WriteLine("Value of a is" + a);

            Console.WriteLine("Value of b is" + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swaping");

            Console.WriteLine("value of a is" + a);

            Console.WriteLine("value of b is" + b);

        }
    }
}


namespace DP4
{
    internal class Swap2
    {
        static void Main(string[] args)
        {
            //Swap values of two integer variables without using a third variable.

            int a = 5;
            int b = 10;

            Console.WriteLine("Before Swaping");

            Console.WriteLine("Value of a is" + a);

            Console.WriteLine("Value of b is" + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swaping");

            Console.WriteLine("value of a is" + a);

            Console.WriteLine("value of b is" + b);

        }
    }
}

namespace DP4
{
    internal class Marks_Grade
    {
        static void Main(string[] args)
        {
            /*Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
             Display grade as below.
             Percentage > 80% - Grade A
             Percentage > 70% - Grade B
             Percentage > 60% - Grade C
             Percentage < 60% - Grade D*/

         
            int r, marks1, marks2, marks3, total;

            float percentage;
            string n;

            Console.WriteLine("Enter Student Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();

            Console.WriteLine("Enter Subject-1 Marks : ");
            marks1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject-2 Marks : ");
            marks2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject-3 Marks :");
            marks3 = Convert.ToInt32(Console.ReadLine());

            total = marks1 + marks2 + marks3;

            percentage = total / 3.0f;

            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);

            if (percentage >= 80)
            {
                Console.WriteLine("Grade is A");
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Console.WriteLine("Grade is B");
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Console.WriteLine("Grade is C");
            }
            else if (percentage <= 60)
            {
                Console.WriteLine("Grade is D");
            }
        }
    }
}

namespace DP4
{
    internal class Vowel_OrNot
    {
        //WAP to accept a character from user & check whether it is vowel or not (using switch)

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Alphabet");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is Not Vowel");
                    break;
            }
        }
    }
}

namespace DP4
{
    internal class Vowel_OrNot2
    {
        static void Main(string[] args)
        {
            //WAP to accept a character from user & check whether it is vowel or not

            char ch;

            Console.WriteLine("Input a symbol: ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch == 'a') || (ch == 'e') || (ch == 'i') ||
                    (ch == 'o') || (ch == 'u'))
            {
                Console.WriteLine("It's Lowercase Vowel.");
            }
            else if ((ch == 'A') || (ch == 'E') || (ch == 'I') ||
                    (ch == 'O') || (ch == 'U'))
            {
                Console.WriteLine("It's Uppercase Vowel");
            }
            else
            {
                Console.Write("It's Not Vowel");
            }
            
        }
    }
}

namespace DP4
{
    internal class Posi_Neg_Zero
    {
        static void Main(string[] args)
        {
            //WAP to accept a number from the user & check number is +ve or -ve or zero.

            int n1;

            Console.WriteLine("Accept number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 >+ 0)
            {
                Console.WriteLine(n1 + " is +ve number");
            }
            else if (n1 <- 0)
            {
                Console.WriteLine(n1 + " is -ve number");
            }
            else
            {
                Console.WriteLine(n1 + " is zero");
            }
        }
    }
}

namespace DP4
{
    internal class MaxNum_Logical
    {
        static void Main(string[] args)

        { 
            //Write a C# program to find maximum between three numbers (using logical operator)


            int[] num = { 56, 23, 10 };
            int MaxNum = num.Max();

            Console.WriteLine($"The Maximum Number is {MaxNum}");
        }
    }
}

namespace DP4
{
    internal class CharDigitSpecial
    {
        static void Main(string[] args)
        {
            //    Write a C# program to input any character and check whether it is alphabet, digit or special character 

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
    internal class BillUnit
    {
        static void Main(string[] args)
        {
            /* Write a C# program to input electricity consumption unit and calculate total electricity bill according to the given condition: 
            For first 50 units Rs. 0.50 / unit For next 100 units Rs. 0.75 / unit For next 100 units Rs. 1.20 / unit For unit above 250 Rs. 1.50 /
            unit An additional surcharge of 20 % is added to the bill*/

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

//4.Create class Student, with roll no , name , percentage auto implemented properties. Use property initialize syntax to assign the values. Print the student details
//7.Create Student class with roll no, name, accept 3 subjects marks from constructor.Calculate the total marks & percentage.Display student details using ToString()

public class Student_Details
{
    private int Maths, Chemistry, Physics;
    private double Total, Percent;
    public int Roll_no { get; set; }
    public string Name { get; set; }
    public double Percentage { get; set; }

    public string PrintSD()
    {
        return $" Student name is {Name}\nRoll numbre is {Roll_no}\n Percentage is {Percentage}";
    }

    public Student_Details(int Maths, int Chemistry, int Physics)
    {
        this.Maths = Maths;
        this.Chemistry = Chemistry;
        this.Physics = Physics;
    }
    public void Calculate()
    {
        Total = Maths + Chemistry + Physics;
        Percent = (Total / 300) * 100;
    }
    public override string ToString()
    {
        return $"The Total is ={Total}\nPercent is ={Percent}";
    }


}

//1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary  & display employee details using ToString() method
 //	HRA- 40% of basic salary
 //TA – 20% of basic salary
 //PF -12 % of basic salary

    public class Employee_details
{
    private int id, bs;
    private string name;
    private double hra, gs, ta, pf;

    public Employee_details(int id, string name, int bs)
    {

        this.id = id;
        this.bs = bs;
        this.name = name;
    }
    public void CalculateSal()
    {

        hra = bs * 0.40;

        ta = bs * 0.20;

        pf = bs * 0.12;

        gs = (hra + ta + bs) - pf;

    }
    public string ToString()
    {
        return $"Name is {name}\nid is {id}\ngross salary is {gs}";
    }
}


namespace DP4
{	//Create class Product. Add fields like id, name and price.Create properties for each field. Use object initializer syntax initialize the object. Print product details using ToString()
    internal class Product_details
    {
        private int id;
        double price;
        private string name;
        private double dic_per1;
        private double cost_pri;
        private double sell_pri;
        public double DiscountAmount { get; set; }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price

        {
            set { price = value; }
            get { return price; }
        }
        public double Cost
        {
            set { cost_pri = value; }
            get { return cost_pri; }
        }
        public double DiscountPrecentage
        {
            set { dic_per1 = value; }
            get { return dic_per1; }
        }
        public double Sell
        {
            set { sell_pri = value; }
            get { return sell_pri; }
        }
        public void CalculateDis()
        {
            DiscountAmount = Price * DiscountPrecentage / 100;
        }
        public override string ToString()
        {
            return $"product id is {id}\nname is {name}\nprice is {price} discount is {DiscountAmount}";
        }

    }
}

namespace DP4
{
    internal class Product5
    {
        public int id;
        public string name;
        public double price;

        public int Id { set; get; }
        public string Name { set; get; }

        public double Price { set; get; }

        public string ToStringP()
        {
            return $"Product name  is {Name}\nProdct id is {Id}\nPrice is {Price}";
        }
    }
}

//namespace DP4
//{
//    public class Product_details1
//    {
//        private int id;
//        double price;
//        private string name;
//        private double dic_per1, NewPrice, DiscountPrice;

//        public int ID
//        {
//            set { id = value; }
//            get { return id; }
//        }
//        public string Name
//        {
//            set { name = value; }
//            get { return name; }
//        }
//        public double Price

//        {
//            set { price = value; }
//            get { return price; }
//        }

//        public double dic_per
//        {
//            set { dic_per = value; }
//            get { return dic_per; }
//        }

//        public void CalculateDis()

//        {
//            DiscountPrice = Price * (dic_per / 100);
//            NewPrice = Price - DiscountPrice;
//        }

//        public string DisplayP()
//        {
//            return $"Price is {price},discounted price is {DiscountPrice}";
//        }
//        public override string ToString()

//        {
//            return $"product id is {ID}:name is {Name}:price is {Price}:discount price is {DiscountAmount}";
//        }
//    }
//}

//using static New_Assignment_practice.Student_Details;

namespace DP4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee_details e1 = new Employee_details(123, "pankaj", 30000);
            e1.CalculateSal();
            Console.WriteLine(e1.ToString());

            Product_details p1 = new Product_details() { ID = 123, Name = "pratik", Price = 20000 };
            Console.WriteLine($"product details are {p1.ID}:{p1.Name}:{p1.Price}");

            Product_details p2 = new Product_details();
            p2.ID = 111;
            p2.Name = "pankaj";
            p2.Price = 30000;
            p2.DiscountPrecentage = 20;
            p2.CalculateDis();
            Console.WriteLine(p2);


            Student_Details s1 = new Student_Details(80, 70, 75);
            s1.Roll_no = 123;
            s1.Name = "pankaj";
            s1.Percentage = 88;
            Console.WriteLine(s1.PrintSD());

            Student_Details s2 = new Student_Details(85, 93, 87);
            s2.Calculate();
            Console.WriteLine(s2);

        }
    }
}

//namespace DP4
//{
//    public class Array
//    {
//        static void Main(string[] args)
//        {
//            //syntax
//            // set of integers
//            int[] numbers = new int[10] { 78, 45, 12, 89, 23, 90, 11, 4, 8, 9 };
//            int[] nos = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };

//            foreach (var item in numbers)
//            {
//                Console.WriteLine(item);
//            }
//            // sort

//            Array.Sort (numbers);
//            Console.WriteLine("------after sort------");
//            foreach (var item in numbers)
//            {
//                Console.WriteLine(item);
//            }
//            Array.Reverse(numbers);
//            Console.WriteLine("------after reverse------");
//            foreach (var item in numbers)
//            {
//                Console.WriteLine(item);
//            }

//            Array.Copy(numbers, 3, nos, 5, 3);
//            Console.WriteLine("------------------");
//            foreach (var item in nos)
//            {
//                Console.WriteLine(item);
//            }
//        }


//    }
//}

