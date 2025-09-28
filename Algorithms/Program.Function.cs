﻿using System;
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
    }
}
