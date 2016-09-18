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
                Console.WriteLine("Longest gap in the binary sequence: {0}", LongestGap(binaryValue));
            }
            Console.ReadKey();
        }

        /// <summary>
        /// RQ - Main operation, it returns the longest gap of zeros in a number's binary value
        /// </summary>
        /// <param name="binaryVal"></param>
        /// <returns></returns>
        static int LongestGap(string binaryVal)
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

        /// <summary>
        /// Method called to check the actual char, verifying if it's an zero in the actual char of the chain
        /// </summary>
        /// <param name="binaryChar"></param>
        /// <returns></returns>
        static bool checkActual(int binaryChar)
        {
            if (binaryChar == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method called in order to pass a string value to an array of integer values
        /// </summary>
        /// <param name="binVal"></param>
        /// <returns></returns>
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
