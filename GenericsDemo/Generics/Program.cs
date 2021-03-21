using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class PrintArray<T>
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            PrintArray<int>.toPrint(intArray);
            PrintArray<double>.toPrint(doubleArray);
            PrintArray<char>.toPrint(charArray);
            Console.ReadKey();
        }
    }
}
