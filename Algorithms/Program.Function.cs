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
            for(int i = 0; i < 10; i++)
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
            for (int i = numbers.Length - 1 ; i >0; i--)
            {
                Console.WriteLine(":" +numbers[i]);
            }
        
        }


        #endregion
    }
}
