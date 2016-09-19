using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //values been tested
            int[] enteredItems = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int[] randomValues = generateRandomValues();
            int[] checkedValues = new int[] { 3, 7, 5, 3, 4, 1, 1, 1, 9, 4 };

            operate(randomValues);
        }

        static void operate(int[] valueToOperate)
        {
            int[] unpaired = unpairedValue(valueToOperate);
            presentResults(valueToOperate, unpaired);
        }

        static void presentResults(int[] initialValues, int[] unpaired)
        {
            Console.WriteLine("Values provided: " + string.Join(", ", initialValues));
            Console.WriteLine("Unpaired values: " + string.Join(", ", unpaired));
            Console.ReadKey();
        }

        static int[] generateRandomValues()
        {
            Random rand = new Random();
            int[] values = new int[10];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(1, 10);
            }

            return values;
        }

        static int[] unpairedValue(int[] values)
        {
            List<int> unpaired = new List<int>();

            foreach (var val in values)
            {
                int quantityInArray = checkNumberInArray(val, values);
                if (quantityInArray % 2 != 0)
                {
                    unpaired.Add(val);
                }
            }
            return unpaired.Distinct().ToArray();
        }

        static int checkNumberInArray(int value, int[] values)
        {
            var resultados = values.Where(m => m.Equals(value));
            return resultados.Count();
        }
    }
}
