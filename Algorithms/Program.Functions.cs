using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Algorithms
{
    partial class Program
    {
    internal static void ArrayReverser (int[] x) 
        {
            Array.Reverse(x);
            foreach (int i in x) 
            {
                Console.WriteLine(i);
            }
        
        }
    }
}
