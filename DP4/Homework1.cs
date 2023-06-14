using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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