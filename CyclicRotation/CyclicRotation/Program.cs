using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // values to test
            int[] values = new int[] { 3, 8, 9, 7, 6 };
            int[] randomValues = ProvideRandomValues();


            Console.WriteLine("Choose the number to be used as key: ");
            int key;
            bool valorFornecido = int.TryParse(Console.ReadLine(), out key);
            if (valorFornecido)
                Operate(key, values);
        }

        static void Operate(int key, int[] values)
        {
            key = Simplify(key, values.Length);
            int[] invertedValue = Inversion(key, values);
            Present(key, values, invertedValue);
        }

        static int Simplify(int valueProvided, int lenght)
        {
            if (valueProvided > lenght)
                return valueProvided / lenght;
            else
                return valueProvided;
        }

        static int[] Inversion(int key, int[] values)
        {
            int[] toReturn = new int[values.Length];
            int referenceValue = 0;
            int referenceKey = key;
            for (int i = 0; i < values.Length; i++)
            {
                if (referenceKey >= values.Length)
                {
                    referenceKey = 0;
                }
                toReturn[referenceValue] = values[referenceKey];
                referenceValue++;
                referenceKey++;
            }
            return toReturn;
        }

        static void Present(int key, int[] providedValues, int[] invertedValues)
        {
            Console.WriteLine("Values used for inversion: " + string.Join(", ", providedValues));
            Console.WriteLine("Choosen key: {0}", key);
            Console.WriteLine("Inverted array: " + string.Join(", ", invertedValues));
            Console.ReadKey();
        }

        static int[] ProvideRandomValues()
        {
            Random rand = new Random();
            int[] toDeliver = new int[10];
            
            for (int i = 0; i < toDeliver.Length; i++)
            {
                toDeliver[i] = rand.Next(0, 10);
            }
            return toDeliver;
        }

    }
}
