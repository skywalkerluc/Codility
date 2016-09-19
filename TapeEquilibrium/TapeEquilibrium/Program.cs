using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesProvided = new int[] { 3, 1, 2, 4, 3 };
            int keyProvided = 3;

            int diff = Calculate(keyProvided, valuesProvided);
            Present(keyProvided, diff, valuesProvided);
        }

        static void Present(int key, int diff, int[] valuesProvided)
        {
            Console.WriteLine("Values provided: " + string.Join(", ", valuesProvided));
            Console.WriteLine("Selected key: {0}", key);
            Console.WriteLine("Difference: {0}", diff);
            Console.ReadKey();
        }

        static int Calculate(int key, int[] valuesProvided)
        {
            int firstHalfVal = Math.Abs(CalculateFirstHalf(key, valuesProvided));
            int secHalfVal = Math.Abs(CalculateSecHalf(key, valuesProvided));
            return Math.Abs(firstHalfVal - secHalfVal);
        }

        static int CalculateFirstHalf(int key, int[] valuesProvided)
        {
            return valuesProvided[0] + valuesProvided[1] + valuesProvided[key - 1];
        }

        static int CalculateSecHalf(int key, int[] valuesProvided)
        {
            return valuesProvided[key] + valuesProvided[key + 1] + valuesProvided[valuesProvided.Length - 1];
        }

    }
}
