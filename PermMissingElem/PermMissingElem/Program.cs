using System;
using System.Collections.Generic;
using System.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesProvided = new int[] { 1, 2, 3, 9};
            int[] valuesMissing;
            Operate(valuesProvided, out valuesMissing);
            Present(valuesProvided, valuesMissing);
        }

        static void Present(int[] valuesProvided, int[] valueMissing)
        {
            Console.WriteLine("Values provided: " + string.Join(", ", valuesProvided));
            Console.WriteLine("Values missing in sequence: " + string.Join(", ", valueMissing));
            Console.ReadKey();
        }

        static void Operate(int[] valuesProvided, out int[] valueMissing)
        {
            List<int> listControl = new List<int>();
            int referenceVal = valuesProvided.Max();
            for (int i = 1; i < referenceVal; i++)
            {
                if (!Array.Exists(valuesProvided, m => m.Equals(i)))
                    listControl.Add(i);
            }
            valueMissing = listControl.ToArray();
        }
    }
}
