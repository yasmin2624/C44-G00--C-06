using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Ass06
{
    internal class Program
    {
        //Q03
        static void Calculate(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }

        //Q04
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

        //Q05
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        //Q06
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
        }
        
        //Q08
        static string ChangeChar(string input, int position, char newChar)
        {   
            char[] chars = input.ToCharArray(); 
            chars[position] = newChar;          
            return new string(chars);           
        }


        static void Main(string[] args)
        {
            #region Q01-Explain the difference between passing (Value typeparameters) by value and by reference 
            /*
             * When you send a value type by value (such as int or bool), the function takes a copy of the number
             * and any modification to it doesn't affect the original.However, if you send it by reference (ref) 
             * the function modifies the same original variable.
             * 
             */


            #endregion

            #region Q02-Explain the difference between passing (Reference typeparameters) by value and by reference
            /*
             * When you send a reference type (such as array or class) by value, 
             * the function can be modified internally (because it holds the same address), 
             * but it cannot change the address itself.
             * 
             * If you send it by reference (ref), 
             * the function can be modified internally and can even change the entire address.
             * 
             */
            #endregion

            #region Q03-c# Function that accept 4 parameters from user and return result of summation and subtracting 
            //Console.Write("Enter first number: ");
            //int.TryParse(Console.ReadLine(),out int num1 );

            //Console.Write("Enter second number: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //int Sum, Diff;

            //Calculate(num1, num2, out Sum, out Diff);

            //Console.WriteLine($"\nSum = {Sum}");
            //Console.WriteLine($"Difference = {Diff}");
            #endregion

            #region Q04-Write a program in C# Sharp to create a function to calculate the sum of the individual digits
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int input);
            //int result = SumOfDigits(input);

            //Console.WriteLine($"\nThe sum of the digits is: {result}");
            #endregion

            #region Q05-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not.
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int input);

            //bool result = IsPrime(input);

            //if (result)
            //    Console.WriteLine($"{input} is a prime ");
            //else
            //    Console.WriteLine($"{input} is not a prime");
            #endregion

            #region Q06-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array
            //int[] numbers = { 5, 12, 3, 19, 7, 1, 25 };

            //int min = 0, max = 0;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine($"Minimum value = {min}");
            //Console.WriteLine($"Maximum value = {max}");
            #endregion

            #region Q07-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            #endregion

            #region Q08-Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //Console.Write("Enter a string: ");
            //string? original = Console.ReadLine();

            //Console.Write("\nEnter position to modify (0-based): ");
            //int.TryParse(Console.ReadLine(), out int pos);

            //Console.Write("\nEnter new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //if (pos >= 0 && pos < original.Length)
            //{
            //    string modified = ChangeChar(original, pos, newChar);
            //    Console.WriteLine("\nModified string: " + modified);
            //}
            //else
            //{
            //    Console.WriteLine("\nInvalid position. Please enter a valid index.");
            //    return;
            //}

            #endregion

        }
    }
}
