using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DP4
{
    public class ArrayLoop
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            Console.WriteLine("Array Elements: ");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}

namespace DP4
{
    public class Array3by3
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
                    Console.Write(arr[i, j] + arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}

public class JoggingArr
{
    static void Main(string[] args)
    {
        // 4 is the row size, [] --> col

        int[][] jaggedArray = new int[4][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 10, 20, 30, 40 };
        jaggedArray[2] = new int[] { 100, 200 };
        jaggedArray[3] = new int[] { 1000 };

        for (int i = 0; i < jaggedArray.Length; i++) // Length --> row size 4
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)// jaggedArray[i] --> col size in each row
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }


}



//Write a program to check whether a given string is palindrome or not.

public class PalindromeString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Character to Check Char is Palindrome or Not");
        string str1 = Console.ReadLine();
        
        string str2 = Console.ReadLine();
        for (int i = str1.Length - 1; i >= 0; i--)
        {
            str2 = str1 + str2[i];
        }
        if (str2 == str1)
        {
            Console.WriteLine("Given Char is Palindrome");
        }
        else
        {
            Console.WriteLine("Given Char is not Palindrome");
        }
    }
}


//WAP to find longest word in the given sentence

internal class LongestWord
{
    static void Main(string[] args)
    {
        string str1 = "India is My Country";
        string[] str2 = str1.Split(new [] {" "}, StringSplitOptions.None);
        int count = 0; string word = string.Empty;
        
        foreach (string s in str2)
        {
            if (s.Length > count)
            {
                count = s.Length;
                word = s;
            }
        }
        Console.WriteLine($"Longest word is {word} and lengh = {count}");

    }
}


//WAP to replace all negative value with its immediate left elements square. Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].

public class PracticeProj
{
    static void Main(string[] args)
    {
        int[] num = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i]< 0)
            {
                int j = i - 1;
                num[i] = num[j] * num[j];
            }
            Console.Write(" ");
            Console.Write(num[i]);
        }
        //foreach (int i in num)
        //{
        //    Console.WriteLine(i);
        //}
    }
}

/*Move zeros to beginning or end of array. 
e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1} then output array should be 
a. { 0,0,2,10,5,3,4,1} 
b. { 2,10,5,3,4,1,0,0}*/

public class PracticeProje2
{
    static void Main(string[] args)
    {
        int[] num = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };
        int n = num.Length;
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] != 0)
            {
                int temp = num[j];
                num[j] = num[i];
                num[i] = temp;
                j++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(num[i]);
            Console.Write(" ");
        }
    }
}

/*Find pair of elements in array whose number is given number.
e.g. Given array is { 4,5,7,1,2,3,0} If number given is 7. Then pairs whose sum is equal to given 
number are – (4,3) (5,2) (7,0)*/

public class PracticalProje3
{
    static void Main(string[] args)
    {
        int[] array = { 4, 5, 7, 1, 2, 3, 0 };
        Console.WriteLine("Enter Your Number");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <  array.Length; i++)
        {
           for (int j = 0; j < array.Length; j++)
            {
                int sum = array[i] + array[j];
                if (array[i] + array[j] < sum)
                {
                    array[i] = sum;
                }
                Console.WriteLine($"Addition of Pair {(array[i], array[j])}");
            }
        }
    }
}


//Write a program to count the total number of words in a string.

public class StringCount
{
    static void Main(string[] args)
    {
        string str;
        int i, wrd, l;

        Console.Write("\n\nCount the total number of words in a string :\n");
        Console.Write("------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        l = 0;
        wrd = 1;

        /* loop till end of string */
        while (l <= str.Length - 1)
        {
            /* check whether the current character is white space or new line or tab character*/
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
    }
}

//Write a program to trim leading white space characters in a string.

public class TrimLead
{
    static void Main(string[] args)
    {
        string character = @"  
                               Hello,   
                               World     
                                ";
        string Trimmed = String.Concat(character.Where(c => !Char.IsWhiteSpace(c)));

        Console.WriteLine($"Original string: {character}.");
        Console.WriteLine($"Trimmed string:  {Trimmed}.");
    }
}

//Write a program to find the first occurrence of a word in a given string.

public class Occurrence
{
    static void Main(string[] args)
    {
        Console.Write("Enter the string : ");
        string message = Console.ReadLine();
        Dictionary<char, int> dict = message.Replace(" ", string.Empty)
                                     .GroupBy(c => c)
                                     .ToDictionary(gr => gr.Key, gr => gr.Count());
        foreach (var item in dict.Keys)
        {
            Console.WriteLine(item + " : " + dict[item]);
        }
    }
}

public class Anagrams
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write 1st Char");
        string str1 = Console.ReadLine();
        Console.WriteLine("write 2nd Char");
        string str2 = Console.ReadLine();

        char[] ch1 = str1.ToLower().ToCharArray();
        char[] ch2 = str2.ToLower().ToCharArray();

        Array.Sort(ch1);
        Array.Sort(ch2);

        string value1 = new string (ch1);
        string value2 = new string (ch2);

        if (value1 == value2)
        {
            Console.WriteLine("Both String are Anagrams");
        }
        else
        {
            Console.WriteLine("Both String are Not Anagrams");
        }
    }
}