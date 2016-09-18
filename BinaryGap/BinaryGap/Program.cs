using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class BinaryGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a number to check the gap: ");
            string writtenValue = Console.ReadLine();
            int val;
            if (int.TryParse(writtenValue, out val))
            {
                string binaryValue = Convert.ToString(val, 2);
                Console.WriteLine("Binary value: {0}", binaryValue);
                Console.WriteLine("Longest gap in the binary sequence: {0}", LongestGapToArray(binaryValue));
            }
            Console.ReadKey();
        }

        static int LongestGapToArray(string binaryVal)
        {
            int[] countArray = new int[binaryVal.Length];
            int count = 0;
            int[] array = passToArray(binaryVal);

            for (int i = 0; i < array.Length; i++)
            {
                if (checkActual(array[i]))
                {
                    count++;
                }
                else
                {
                    countArray[i] = count;
                    count = 0;
                }
            }
            return countArray.Max();
        }

        static bool checkActual(int binaryChar)
        {
            if (binaryChar == 0)
                return true;
            else
                return false;
        }

        static int[] passToArray(string binVal)
        {
            int[] array = new int[binVal.Length];

            int i = 0;
            foreach (var ch in binVal)
            {
                array[i++] = Convert.ToInt32(ch.ToString());
            }
            return array;
        }
    }
}
