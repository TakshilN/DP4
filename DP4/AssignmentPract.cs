

using System.Runtime.Intrinsics.Arm;

namespace DP4
{

    internal class PROFIT_LOSS
    {
        static void Main(string[] args)
        {
            ///1. Write a C# Sharp program to calculate profit and loss on a transaction
            
            int cost, sell, pl;
            Console.WriteLine("calculate profit and loss");

            Console.WriteLine("enter cost prise");
            cost = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter selling prise");
            sell = Convert.ToInt32(Console.ReadLine());

            if (sell > cost)
            {
                pl = sell - cost;
                Console.WriteLine("you get profit" + pl);
            }
            else if (cost > sell)
            {
                pl = cost - sell;
                Console.WriteLine("you get loss " + pl);
            }
            else
            {
                Console.WriteLine("you dont get profit or loss");
            }



        }
    }
}
namespace DP4
{
    internal class Month
    {
        static void Main(string[] args)
        {
            //2. Write C# Sharp program to read any Month Number in integer and display Month name(use switch case)

            Console.WriteLine("1. January");
            Console.WriteLine("2. February");
            Console.WriteLine("3. March");
            Console.WriteLine("4. April");
            Console.WriteLine("5. May");
            Console.WriteLine("6. June");
            Console.WriteLine("7. July");
            Console.WriteLine("8. August");
            Console.WriteLine("9. September");
            Console.WriteLine("10. October");
            Console.WriteLine("11. November");
            Console.WriteLine("12. December");

            Console.WriteLine("Choose your option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("You Choose January");
                    break;

                case 2:
                    Console.WriteLine("You Choose February");
                    break;

                case 3:
                    Console.WriteLine("You Choose March");
                    break;

                case 4:
                    Console.WriteLine("You Choose April");
                    break;

                case 5:
                    Console.WriteLine("You Choose May");
                    break;

                case 6:
                    Console.WriteLine("You Choose June");
                    break;

                case 7:
                    Console.WriteLine("You Choose July");
                    break;

                case 8:
                    Console.WriteLine("You Choose August");
                    break;

                case 9:
                    Console.WriteLine("You Choose September");
                    break;

                case 10:
                    Console.WriteLine("You Choose October");
                    break;

                case 11:
                    Console.WriteLine("You Choose November");
                    break;

                case 12:
                    Console.WriteLine("You Choose Thursday");
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
    internal class UppercaseLowercase
    {
        static void Main(string[] args)
        {
            //3. Write C# Program to check uppercase or lowercase alphabets

            Console.WriteLine("enter alphabet");
            char alp = Convert.ToChar(Console.ReadLine());

            if (alp >= 'A' && alp <= 'Z')
            {
                Console.WriteLine(alp + " is uppercase");
            }

            else if (alp >= 'a' && alp <= 'z')
            {
                Console.WriteLine(alp + " is lowercase");

            }
            else
            {
                Console.WriteLine(alp + " is not alphabet");

            }
        }
    }
}

namespace DP4   
{
    internal class Transportation
    {
        static void Main(string[] args)
        {
            /* A student has to travel n kilometers. He can choose between three types of transportation:
            Taxi. Starting fee: 5 INR/KM. Day rate: 8 INR/km. Night rate: 9 INR/km.
            Bus. Day / Night rate: 9 EUR/km. Can be used for distances of minimum 20 km.
            Train. Day / Night rate: 6 EUR/km. Can be used for distances of minimum 100 km.
            Write a program that reads the number of kilometers n and period of the day (day or night) 
            and calculates the fare amount*/


            Console.WriteLine("1. Taxi");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Train");
            Console.WriteLine("Select any one number to perform the operation.");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter KM:");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Day/Night");
            char time = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 1:

                    if (time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge = (km * 8) + 5;
                        Console.WriteLine("Day Charges is :" + day_charge);
                    }
                    else if (time == 'n')
                    {
                        double night_charge = (km * 9) + 5;
                        Console.WriteLine("Night Charge is :" + night_charge);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                case 2:
                    if (km >= 20 && time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge1 = km * 9;
                        Console.WriteLine("Day Charges is :" + day_charge1);
                    }
                    else if (km > 20 && time == 'n')
                    {
                        double night_charge1 = km * 9;
                        Console.WriteLine("Night Charge is :" + night_charge1);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                case 3:
                    if (km >= 100 && time == 'd')
                    {
                        Console.WriteLine("Available");
                        double day_charge2 = km * 9;
                        Console.WriteLine("Day Charges is :" + day_charge2);
                    }
                    else if (km > 20 && time == 'n')
                    {
                        double night_charge2 = km * 9;
                        Console.WriteLine("Night Charge is :" + night_charge2);
                    }
                    else
                    {
                        Console.WriteLine("Not Available.");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error!!!!");
                        break;
                    }

            }
        }
    }
}

namespace DP4
{
    internal class Prime_Not
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.WriteLine($"{num} is not prime number");
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is not prime number");
                    }
                }
                Console.WriteLine($"{num} is prime number");
                
            }
        }
    }
}

namespace DP4
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int num, tem, rem, sum = 0;

            Console.WriteLine("enter your no.");
            num = Convert.ToInt32(Console.ReadLine());

            tem = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (tem == sum)
            {
                Console.WriteLine(tem + " Is A Armstrong Number");
            }
            else
            {
                Console.WriteLine(tem + " Is Not A Armstrong Number");
            }
        }
    }
}

namespace DP4
{
    internal class Palindroma
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a Number To Check Palindrome");
            number = Convert.ToInt32(Console.ReadLine());
            int remineder, sum = 0;
            int res = number;
            while (number > 0)
            {
 
                remineder = number % 10;

                sum = (sum * 10) + remineder;

                number = number / 10;
            }
            if (res == sum)
            {
                Console.WriteLine($"Number {res} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {res} is not Palindrome");
            }
        }
    }
}

namespace DP4
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {

            int num1 = 0, num2 = 1, sum, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(num1 + " " + num2 + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    sum = num1 + num2;
                    Console.WriteLine(sum + " ");
                    num1 = num2;
                    num2 = sum;
                }
            }
        }
    }
}

namespace DP4
{
    internal class SumDigit
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter the Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, reminder;

            while (num > 0)
            {
                reminder = num % 10;
                sum = sum + reminder;
                num = num / 10;
            }

            Console.WriteLine($"The Sum of Digits is : {sum}");
        }
    }
}

namespace DP4
{
    internal class ReverseOrd
    {
        static void Main(string[] args)
        {
            int num, rev = 0;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rev = rev * 10;
                rev = rev + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + rev);
        }
    }
}

namespace DP4
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;

            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {num}  is: {fact}");
        }
    }
}