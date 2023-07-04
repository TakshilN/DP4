﻿using DP4;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DP4
{
    internal class Homework1
    {
        static void Main(string[] args)
        {
            //2. Print student details(roll no.,name,branch,percentage,age,address)

            Console.WriteLine("Enter your roll no.");
            int rollnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("which branch");
            string branch = Console.ReadLine();

            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your percentage");
            double per = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your address");
            string add = Console.ReadLine();

            //by using $ sign

            Console.WriteLine($"Hello {name} your roll no. is {rollnumber} your branch is {branch} your age is {age} and percentage = {per} your address is {add}");

            //by using concatination

            Console.WriteLine("My name is "+name+" my roll no. is "+rollnumber+" my branch is "+branch+" my age is "+age+" my percentage = "+per+" my address is "+add);

            //by using + sign

            Console.WriteLine("My name is " +name);
            Console.WriteLine("My roll no. is " + rollnumber);
            Console.WriteLine("My branch is " + branch);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My percentage = " + per);
            Console.WriteLine("My address is " + add);

            //by using placeholder

            Console.WriteLine("My name is {0} , roll no. is {1} , branch is {2} , age is {3} , percentage = {4} , address is {5}",name,rollnumber,branch,age,per,add);

        }
    }
}

namespace DP4
{
    internal class Homework2
    {
        static void Main(string[] args)
        {
            //1. Print your own details
            string name = "Takshil";
            int age = 24;
            double percentage = 75;
            char gender = 'M';
            string bloodgroup = "b+";
            DateOnly date = new DateOnly(2000, 09, 08);
            string add = "Sindewahi, Maharashtra, India";
            string branch = "Sowfware developer";

            //using + sign

            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Gender = " + gender);
            Console.WriteLine("My date of birth is " + date);
            Console.WriteLine("My blood group is " +bloodgroup);
            Console.WriteLine("My address is " +add);
            Console.WriteLine("percentage = " +percentage);
            Console.WriteLine("My branch is " +branch);
 
            //In one sentanse
            //concatination
            Console.WriteLine("My name is "+name+" age is "+age+" Gender is "+gender+" My date of birth is "+date+" My blood group is "+bloodgroup+" My address is "+add+" Percentage = "+percentage+" My branch is "+branch);

            //or placeholder
            Console.WriteLine("My name is {0} , Age is {1} , Gender = {2} , Date of Birth = {3} , Blood Group = {4} , My address is {5} , Percentage = {6} , My branch is {7}",name,age,gender,date,bloodgroup,add,percentage,branch);

            //using $ sign
            Console.WriteLine($"My name is {name} Age is {age} Gender is {gender} Date of birth is {date} Blood group is {bloodgroup} Address is {add} Percentage is {percentage} And branch is {branch}");

        }
    }
}
 namespace DP4
{
    internal class Homework3
    {
        static void Main(string[] args)
        {
            //3. Print enmployee details (enp id, name, dept, salary) (without own details)

            Console.WriteLine("Enter your employee id");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your department");
            string dept = Console.ReadLine();

            Console.WriteLine("Enter your salary");
            string salary = Console.ReadLine();

            //by using $ sign

            Console.WriteLine($"Hello {name} your employee id is {empID} your department is {dept} your salary is {salary}");

            //by using concatination

            Console.WriteLine("My employee id is "+empID+" My name is "+name+" My department is "+dept+" My salary is "+salary);

            //by using + sign

            Console.WriteLine("Employee id = " + empID);
            Console.WriteLine("Name = " + name );
            Console.WriteLine("Department = " + dept);
            Console.WriteLine("Salary = " + salary);
            

            //by using placeholder

            Console.WriteLine("My employee id is {0} , My name is {1} , My department is {2} , My salary is {3} ", empID, name, dept, salary);
        }
    }
}

namespace DP4
{
    internal class Homework4
    {
        static void Main(string[] args)
        {
            //3. Print enmployee details (enp id, name, dept, salary) (with my own details)

            int empID = 01220;
            string name = "Takshil";
            string dept = "IT Department";
            string salary = "50,055";

            //by using $ sign

            Console.WriteLine($"Hello {name} your employee id is {empID} your department is {dept} your salary is {salary}");

            //by using concatination

            Console.WriteLine("My employee id is " + empID + " My name is " + name + " My department is " + dept + " My salary is " + salary);

            //by using + sign

            Console.WriteLine("Employee id = " + empID);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Department = " + dept);
            Console.WriteLine("Salary = " + salary);


            //by using placeholder

            Console.WriteLine("My employee id is {0} , My name is {1} , My department is {2} , My salary is {3} ", empID, name, dept, salary);
        }
    }
}

namespace DP4
{
    internal class Homework5
    {
        static void Main(string[] args)
        {
            int num1 = 50, num2 = 67, sum;
            sum = num1 + num2;

            Console.WriteLine($"Addition of {num1} and {num2} is {sum}");
        }
    }
}

namespace DP4
{
    internal class Homework6
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"Addition of {num1} and {num2} is {sum}");
        }
    }
}

namespace DP4
{ 
    internal class Nested
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Division");
            Console.WriteLine("Select any one number to perform the operation");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter your 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            if (option == 1)
            {
                int sum = num1 + num2;
                Console.WriteLine($"Addition is {sum}");
            }
            else if (option == 2)
            {
                int sub = num1 - num2;
                Console.WriteLine($"Subtraction is {sub}");
            }
            else if (option == 3)
            {
                int mul = num1 * num2;
                Console.WriteLine($"Multiplication is {mul}");
            }
            else if (option == 4)
            {
                int div = num1 / num2;
                Console.WriteLine($"Divion is {div}");
            }
            else if (option == 5)
            {
                int mod = num1 % num2;
                Console.WriteLine($"MOdification is {mod}");
            }
        }
    }
}

namespace DP4
{
    internal class Switch
    {
        static void Main(string[] args)
        { 
           
           

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.WriteLine("5.Mod");
            
            Console.WriteLine("Enter your option");
            int option = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("enter your 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:Console.WriteLine("You choose addition");
                    int sum = num1 + num2;
                    Console.WriteLine($"Your ans is {sum}");
                    break;

                case 2:Console.WriteLine("You choose subtraction");
                    int sub = num1 - num2;
                    Console.WriteLine($"Your ans is {sub}");
                    break;

                case 3:Console.WriteLine("You choose Multiplication");
                    int mul = num1 * num2;
                    Console.WriteLine($"Your ans is {mul}");
                    break;

                case 4:Console.WriteLine("You choose divison");
                    int div = num1 / num2;
                    Console.WriteLine($"Your ans is {div}");
                    break;

                case 5:Console.WriteLine("You choose mod");
                    int mod = num1 % num2;
                    Console.WriteLine($"Your ans is {mod}");
                    break;

                default : Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}

namespace DP4
{
    internal class Switch1
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.WriteLine("5.Mod");

            Console.WriteLine("Select your option");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
          

            switch (option)
            {
                case 1:
                    int sum = num1 + num2;
                    Console.WriteLine($"You choose addition & ans is {sum}");
                    break;

                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine($"You choose subtraction & ans is {sub}");
                    break;

                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine($"You choose multiplication & ans is{mul}");
                    break;

                case 4:
                    int dev = num1 / num2;
                    Console.WriteLine($"You choose divison & ans is {dev}");
                    break;

                case 5:
                    int mod = num1 % num2;
                    Console.WriteLine($"You choose mod & ans is {mod}");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}

namespace DP4
{
    internal class Switch3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0. Sunday");
            Console.WriteLine("1. Monday");
            Console.WriteLine("2. Tuesday");
            Console.WriteLine("3. Wednesday");
            Console.WriteLine("4. Thursday");
            Console.WriteLine("5. Friday");
            Console.WriteLine("6. Saturday");

            Console.WriteLine("Choose your number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("You choose sunday");
                    break;

                case 1:
                    Console.WriteLine("You choose monday");
                    break;

                case 2:
                    Console.WriteLine("You choose tuesday");
                    break;

                case 3:
                    Console.WriteLine("You choose wednesday");
                    break;

                case 4:
                    Console.WriteLine("You choose thursday");
                    break;

                case 5:
                    Console.WriteLine("You choose friday");
                    break;

                case 6:
                    Console.WriteLine("You choose saturday");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}

namespace DP4
{
    internal class Loop1_50
    {
        static void Main(string[] args)
        {
            //Print the value from 1 to 50 

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

namespace DP4
{
    internal class Loop50_20
    {
        static void Main(string[] args)
        {
            //Print the value from 50 to 20

            for (int i = 50; i >= 20; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

namespace DP4
{
    internal class LoopEven1_100
    {
        //Print the even number from 1 to 100

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

namespace DP4
{
    internal class LoopTable
    {
        static void Main(string[] args)
        {
            //Accept the number and print the its table

            Console.WriteLine("Enter Your Number");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n * i}");
            }
        }
    }
}

namespace DP4
{
    internal class WLoopTable
    {
        static void Main(string[] args)
        {
            // //Accept the number and print the its table (using whileloop)

            Console.WriteLine("Enter Your Number");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{n * i}");
                i++;
            }
        }
    }
}

namespace DP4
{
    internal class WLoopEven1_100
    {
        static void Main(string[] args)
        {
            //Print the even number from 1 to 100 (using whileloop)

            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}

namespace DP4
{
    internal class WLoop50_20
    {
        static void Main(string[] args)
        {
            //Print the value from 50 to 20 (using whileloop)

            int i = 50;
            while (i >= 20)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}

namespace DP4
{
    internal class WLoop1_50
    {
        static void Main(string[] args)
        {
            //Print the value from 1 to 50 (using whileloop)

            int i = 1;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

namespace DP4
{
    internal class Patern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Patern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Pater3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Patern4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Row");
            int row = Convert.ToInt32 (Console.ReadLine());
            for (int i = 1 ; i <= row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    if (i == 1 || j == i)
                    {
                        Console.Write(" * ");
                    }
                    else if (i <= row || j <= row)
                    {
                        Console.WriteLine(" 1 ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
}

namespace DP4
{
    internal class Patern5
    {
        static void Main(string[] args)
        {
            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Patern6
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Patern7
    {
        static void Main(string[] args)
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

namespace DP4
{
    internal class Patern9
    {
        static void Main(string[] args)
        {
            int val = 8;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

namespace DP4
{
    internal class Patern10
    {
        static void Main(string[] args)
        {
            int number = 8;

            for (int i = 0; i < number; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                if (i != number - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" * ");
                }
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Patern11
    {
        static void Main(string[] args)
        {
            int number = 7;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

namespace DP4
{
    internal class Patern12
    {
        static void stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        }

        static void spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");
        }
        static void Main(string[] args)
        {

            int n = 8;

            for (int i = 0; i < n; ++i)
            {
                stars(i + 1);
                spaces(n - i - 1);
                stars(n - i + 1);
                spaces(2 * i);
                stars(n - i);
                spaces(n - i - 1);
                stars(i + 1);

                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class RHalf_Pyra
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class LHalf_Pyra   
    {
        static void Main(string[] args)
        {
            // first loop is for printing the rows
            int rows = 5;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 2 * (rows - i) - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace DP4
{
    internal class Full_Pyra
    {
        static void Main(string[] args)
        {
            int rows = 5;

            // first loop to print all rows
            for (int i = 0; i < rows; i++)
            {

                // inner loop 1 to print white spaces
                for (int j = 0; j < 2 * (rows - i) - 1; j++)
                {
                    Console.Write(" ");
                }

                // inner loop 2 to print star * character
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}

namespace DP4
{
    internal class Invert_Half
    {
        static void Main(string[] args)
        {
            int rows = 5;

            // first loop to print all rows
            for (int i = 0; i < rows; i++)
            {

                // first inner loop to print the * in each row
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

        }
    }
}


namespace DP4
{
    internal class Invert_Full
    {
        static void Main(string[] args)
        {
            int rows = 5;

            // first loop for printing all rows
            for (int i = 0; i < rows; i++)
            {

                // first inner loop for printing leading white
                // spaces
                for (int j = 0; j < 2 * i; j++)
                {
                    Console.Write(" ");
                }

                // second inner loop for printing stars *
                for (int k = 0; k < 2 * (rows - i) - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

        }
    }
}


namespace DP4
{
    public class Product
    {

        private int Producode;
        private int Produprice;
        private string? Produname;

        public string Name
        {
            set { Produname = value; }
            get { return Produname; }
        }
        public int Code
        {
            set { Producode = value; }
            get { return Producode; }
        }
        public int Price
        {
            set { Produprice = value; }
            get { return  Produprice; }
        }
        public string PrintDet()
        {
            return $"Product detail is {Produname} , {Producode} , {Produprice}";
        }
    }
}

public class Product_detail
{
    static void Main(string[] args)
    {
        Product product = new Product();
        product.Name = "Mobile";
        product.Code = 12;
        product.Price = 20;

        Console.WriteLine($"Product detail is {product.Name} , {product.Code} , {product.Price}");
    }
}


class project
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double bs, hra, ta, da, pf, gross;
        private static int count;
        public Employee(string name, double bs)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
        }
        // to allow method to be overriden we use virtual keyword
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da) - pf;
        }
        //public string PrintEmpSalary()
        //{
        //    return $"id={id}, name={name}, gross ={gross}";
        //}
        //ToString()  --> from base class object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }

    public class Ceo : Employee
    {
        private double comm;
        // first always it calls to base class constructor
        // base keyword is used to call the base class members (constructor,method,protected members)

        public Ceo (string name, double bs, double comm) : base(name, bs) //parametric constructor
        {
            this.comm = comm;

        }
        // method which is sam in base class should override the implementation
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da + comm) - pf;
        }
        // ToString() --> gives the string representation of an object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }


    static void Main(string[] args) // method
    {
        Ceo ceo  = new Ceo("Rohan", 97800, 3500);
        ceo .CalculateSalary();
        Console.WriteLine(ceo);// ToString() get called implicitly 

        Employee employee = new Employee("Suraj", 23000);
        employee.CalculateSalary();
        Console.WriteLine(employee);
    }

}

class Prime
{
    static void Main(string[] args)
    {
        int num1;

        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 == 0 || num1 == 1)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            for (int a = 2; a <= num1 / 2; a++)
            {
                if (num1 % a == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }

            }
            Console.WriteLine("Prime");
        }

    }
}

class project2
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double bs, hra, ta, pf, gross;
        private static int count;
        public Employee(string name, double bs)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
        }
        // to allow method to be overriden we use virtual keyword
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra) - pf;
        }
        //public string PrintEmpSalary()
        //{
        //    return $"id={id}, name={name}, gross ={gross}";
        //}
        //ToString()  --> from base class object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }

    public class Employee1 : Employee
    {
        private double comm;
        // first always it calls to base class constructor
        // base keyword is used to call the base class members (constructor,method,protected members)

        public Employee1 (string name, double bs, double comm) : base(name, bs) //parametric constructor
        {
            this.comm = comm;

        }
        // method which is sam in base class should override the implementation
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + ta + comm) - pf;
        }
        // ToString() --> gives the string representation of an object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }


    static void Main(string[] args) // method
    {
        //Ceo ceo = new Ceo("Rohan", 97800, 3500);
        //ceo.CalculateSalary();
        //Console.WriteLine(ceo);// ToString() get called implicitly 

        Employee employee = new Employee("Suraj", 23000);
        employee.CalculateSalary();
        Console.WriteLine(employee);
    }

}

namespace DP4
{
    public class Array1
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for arr[{i},{j}]");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] arr2 = new int[3, 3];

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for arr[{i},{j}]");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("------1st Matrix------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------2nd Matrix------");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------Addition of 2 Matrix------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + arr2 [i, j] +" ");
                }
                Console.WriteLine();
            }

        }

    }
}

namespace DP4
{
    public class Array3
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(10); // boxing
            list.Add("Hello");
            list.Add(77.77);

            string s = list[1].ToString();
            int a = (int)list[0]; // unboxing
            Console.WriteLine(a);

            double d = (double)list[2];
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}

namespace DP4
{
    public class Array4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60 };
            int[] arr2 = new int[8];
            ArrayList list = new ArrayList();

            list.Add(11);
            list.Add(33);
            list.Add(77);

            list.Insert(0, 1);
            list.Insert(2, 200);

            list.AddRange(arr);

            list.Remove("Hello");
            list.RemoveAt(0);
            list.RemoveRange(1, 3);
            list.RemoveAt(0);

            list.Sort();
            //list.Reverse();

            list.CopyTo(arr2);

            bool res = list.Contains(250);
            Console.WriteLine(res);

            Console.WriteLine("No of elements present in the collection " + list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}


namespace DP4
{
    public class Lifo
    {
        static void Main(string[] args)
        {

            // LIFO (Last in first out)

            Stack stack = new Stack();
            // Push, Pop, Peek

            stack.Push(100);
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);

            stack.Pop(); //removes the top element in the collections

            Console.WriteLine($"Top element in the stack {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}

namespace DP4
{
    public class Queue1
    {

        static void Main(string[] args)
        {
            // Queue --> FIFO (first in first out)
            Queue queue = new Queue();
            queue.Enqueue(101);
            queue.Enqueue(202);
            queue.Enqueue(303);

            queue.Dequeue();//remove the first element- 10

            Console.WriteLine($"first element in the list {queue.Peek()}");
            Console.WriteLine($"total elements in the queue {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }


    }
}

namespace DP4
{
    public class HashTable
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Takshil" , 91861577777);
            hashtable.Add("Rohan", 917765258322);
            hashtable.Add("Rohit" , 917763536512);

            //hashtable.Remove(63);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("After Remove");

            hashtable.Remove("Rohit");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  " +item.Value);
            }
        }

    }
}