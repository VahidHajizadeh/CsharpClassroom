using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    partial class Program
    {

        #region Algorithm Array Store & Print:
        /// <summary>
        /// Wrote a program to store elements in an array and print them.
        /// And it takes 10 numbers from the user.
        /// </summary>
        static void storeAndPrint()
        {

            int[] number = new int[10];
            Console.WriteLine("Input 10 elements in the array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"element - {i} : ");
                string input = Console.ReadLine()!;


                if (int.TryParse(input, out int numbers))
                {
                    number[i] = numbers;
                }
                else
                {
                    Console.WriteLine("Input is empty or not a valid number.");
                    i--;
                }
            }

            Console.WriteLine("Expected Output: ");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(number[j]);
            }
            return;
        }
        #endregion

        #region Algorithm Count Duplicate Elements:
        /// <summary>
        /// I wrote a program that counts the total number of duplicate elements in an array.
        /// And prints the duplicate elements.
        /// </summary>
        static void countDuplicateElements()
        {
            int[] myArray = new int[3];
            //{
            //    int.Parse(Console.ReadLine()!),
            //    int.Parse(Console.ReadLine()!),
            //    int.Parse(Console.ReadLine()!),
            //};

            // Input:
            for (int c = 0; c < myArray.Length; c++)
            {
                Console.Write($"element - {c}: ");
                myArray[c] = int.Parse(Console.ReadLine()!);
            }


            // Check for duplicate elements in the array
            // And print the first occurrence of each duplicate:
            int count = 1;
            bool check = true;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        count++;
                        //Console.WriteLine($"{myArray[i]} Duplicate: {count}");

                        //check = true;
                        if (check)
                        {
                            Console.WriteLine("Total number of duplicate elements found in the array is: {0}", myArray[i]);
                            check = false;
                        }
                        break;
                    }
                }
            }

        }
        #endregion

        #region Algorithm Find Maximum & Minimum:

        static void MaximumAndMinimum()
        {
            // Input:
            int[] numbers = new int[3];
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write($"element - {i}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
                i++;
            }

            /*
                // Test:
                int res = numbers[0];
                if (res < numbers[1])
                {
                    res = numbers[1];
                }
                if (res < numbers[2])
                {
                    res = numbers[2];
                }
                Console.WriteLine(res); 
            */


            int max = numbers[0];
            int min = numbers[0];
            int j = 1;
            while (j < numbers.Length)
            {
                max = (numbers[j] > max) ? numbers[j] : max;
                min = (numbers[j] < min) ? numbers[j] : min;
                j++;
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);


            /*
                // Fail code:
                int c = 0;
                int max = 0;
                while(c < numbers.Length)
                {
                    int j = 0;
                    while(j < c)
                    {
                        max = (numbers[c] > numbers[j]) ? numbers[c] : numbers[j];
                        //int min = (numbers[i] < numbers[j]) ? numbers[i] : numbers[j];
                        j++;
                        //Console.WriteLine("Min: " + min);
                    }
                    c++;
                }
                Console.WriteLine("Max: " + max);
             */

        }

        #endregion


        #region Algorithm Array for reversing :
        static void ArrayReverser(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                Console.WriteLine(":" + numbers[i]);
            }

        }


        #endregion

        #region Array Copy & Frequency of Array Elements:
        /// <summary>
        /// Reads a set of numbers from the user, stores them in the first array,
        /// copies all elements into a second array, and prints both arrays.
        /// </summary>
        static void Array_Copy()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int number = int.Parse(Console.ReadLine());

            int[] firtArray = new int[number];
            int[] secondArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                firtArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(firtArray, secondArray, number);

            Console.Write("The elements stored in the first array are: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(firtArray[i] + " ");
            }

            Console.Write("\nThe elements copied into the second array are: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
        }



        /// <summary>
        /// Reads numbers from the user, stores them in an array,
        /// and prints how many times each number occurs in the array.
        /// </summary>
        static void Frequency_of_Array_Elements()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int number = int.Parse(Console.ReadLine());

            int[] numberArr = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter number{i + 1} : ");
                numberArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe frequency of all elements of an array:");
            for (int i = 0; i < number; i++)
            {
                int count = 0;

                for (int j = 0; j < number; j++)
                {
                    if (numberArr[i] == numberArr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{numberArr[i]} occurs {count} times");
            }
        }
        #endregion
    }
}
