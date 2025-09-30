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
