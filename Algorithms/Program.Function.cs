using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        #region Algorithm Insert in Sorted Array

        static void Ascending()
        {
            // Method 1: Failed
            /*
            int[] numbers = new int[5];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"element - {i}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            int first = 0;
            while (first < 4)
            {
                Console.WriteLine(
                    "The existing array list is: " +
                    numbers[first]);
                first++;
            }

            for (int i = 4; i < 5; i++)
            {
                Console.Write($"Input the value to be inserted: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            int second = 0;
            while (second < numbers.Length)
            {
                int third = 0;
                while (third < second)
                {
                    if (numbers[second] < numbers[third])
                    {
                        Console.Write("After Insert the list is: "); 
                        int p = 0;
                        while (p < 3)
                        {
                            Console.Write(
                                numbers[p]
                                );
                            p++;
                        }
                        Console.Write(numbers[second]);
                        Console.Write(numbers[third]);
                    }
                    third++;
                }
                //Console.WriteLine(
                //    "After Insert the list is: " +
                //    numbers[second]);
                second++;
            }
            */

            // Method 2:

            int[] numbers = new int[100 + 1];


            int input = int.Parse(Console.ReadLine()!);
            if (input > 100)
            {
                Console.WriteLine("0 - 100: Error");
                return;
            }

            for (int i = 0; i < input; i++)
            {
                Console.Write($"element - {i}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("Input the value to be inserted : ");
            int input2 = int.Parse(Console.ReadLine()!);

            Console.Write("The existing array list is: ");
            for (int i = 0; i < input; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
            int p = 0;
            for (int i = 0; i < input; i++)
            {
                if (input2 < numbers[i])
                {
                    p = i;
                    break;
                }
                else
                {
                    p = i + 1;
                }
            }

            for (int i = input; i >= p; i--)
            {
                numbers[i + 1] = numbers[i];
            }

            numbers[p] = input2;


            Console.Write("After Insert the list is : ");
            for (int i = 0; i <= input; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();

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

        #region Insert In Unsorted Array:
        /// <summary>
        /// Inserts a new element at a given position in an unsorted array.
        /// </summary>
        static void Insert_In_Unsorted_Array()
        {
            Console.Write("input the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size + 1];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"input element {i + 1} in the array:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("array list is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("Input the value to be inserted: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Input the position, where the value to be inserted: ");
            int position = int.Parse(Console.ReadLine());

            for (int i = size; i > position; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[position] = value;

            Console.WriteLine("After Insert the element the new list is:");
            for (int i = 0; i <= size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

        #region AmiraliHeidary

            #region PROJECT 13
            void p13()
            {
                //Write a program in C to insert the values in the array (sorted list).
                System.Console.WriteLine("enter number");
                int[] numbers =
                {
                                5,
                                7,
                                int.Parse(Console.ReadLine()),
                                int.Parse(Console.ReadLine()),
                                8,
                                3,
                                int.Parse(Console.ReadLine())
                            };
                Array.Sort(numbers);
                System.Console.WriteLine("----------------");
                foreach (int i in numbers)
                {
                    System.Console.WriteLine(i);
                }
            }
            #endregion
            #region PROJECT 33
            void p33()
            {
                //Write a program in C to find the majority element of an array.
                int count = 0;
                int flag = 0;
                System.Console.WriteLine("enter numbers");
                int[] numbers =
                {
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine())
                        };

                foreach (int i in numbers)
                {
                    count = 0;
                    foreach (int j in numbers)
                    {
                        if (i == j)
                        {
                            count++;
                            if (count > (numbers.Length / 2))
                            {
                                System.Console.WriteLine($"{i} is major");
                                return;
                            }
                            else
                            {
                                flag++;
                                if (flag > (numbers.Length / 2))
                                {
                                    System.Console.WriteLine("this array does not have any major");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region PROJECT 43
            void p43()
            {
                //Write a program in C to print the next greatest elements in a given unsorted array.
                //Elements for which no superior element exists, consider the next greatest element as -1. 
                System.Console.WriteLine("enter numbers");
                int[] numbers =
                {
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine())
                        };
                int j = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    bool check = false;
                    for (j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] < numbers[j])
                        {
                            System.Console.WriteLine($"next great number is {numbers[j]}");
                            check = true;
                            break;
                        }


                    }


                    if (!check)
                    {
                        System.Console.WriteLine("next great number is -1");
                    }
                }
            }
            #endregion
            #region PROJECT 53
            void p53()
            {
                //Write a program in C to find the number of times a given number appears in an array. 
                System.Console.WriteLine("enter array numbers");
                int[] numbers =
                {
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine())
                    };

                System.Console.WriteLine("enter your number");

                int input = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == input)
                    {
                        count++;
                    }
                }

                System.Console.WriteLine($"number {input} has reapeted {count} times");
            }
            #endregion
            #region PROJECT 73
            void p73()
            {
                //Write a program in C to print all unique elements of an unsorted array.
                System.Console.WriteLine("enter numbers");
                int[] numbers =
                {
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine())
                    };
                int[] snum = new int[numbers.Length];
                Array.Copy(numbers, 0, snum, 0, numbers.Length);
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    count = 0;
                    for (int q = 0; q < numbers.Length; q++)
                    {
                        if (numbers[i] == snum[q])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        System.Console.WriteLine($"{numbers[i]} is uniqe");
                    }
                }
            }
            #endregion

        #endregion
    }
    
    
}
