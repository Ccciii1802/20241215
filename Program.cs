using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241215
{
        internal class Program
         {
        
            static void MyHomeWork01()
            {
                // Task 1: Uninitialized arrays
                int[] intArray = new int[10];
                float[] floatArray = new float[8];
                double[] doubleArray = new double[4];
                string[] stringArray = new string[5];

                Console.WriteLine("\nTask 1: Input and Print Arrays");

                // Integer array input and output
                int intSum = 0;
                Console.WriteLine("Enter 10 integer values:");
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = int.Parse(Console.ReadLine());
                    intSum += intArray[i];
                }
                Console.WriteLine("Integer array: " + string.Join(" ", intArray));
                Console.WriteLine("Average: " + (intSum / 10.0));

                // Float array input and output
                float floatSum = 0;
                Console.WriteLine("Enter 8 float values:");
                for (int i = 0; i < floatArray.Length; i++)
                {
                    floatArray[i] = float.Parse(Console.ReadLine());
                    floatSum += floatArray[i];
                }
                Console.WriteLine("Float array: " + string.Join(" ", floatArray));
                Console.WriteLine("Average: " + (floatSum / 8.0));

                // Double array input and output
                double doubleSum = 0;
                Console.WriteLine("Enter 4 double values:");
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = double.Parse(Console.ReadLine());
                    doubleSum += doubleArray[i];
                }
                Console.WriteLine("Double array: " + string.Join(" ", doubleArray));
                Console.WriteLine("Average: " + (doubleSum / 4.0));

                // String array input and output
                Console.WriteLine("Enter 5 string values:");
                for (int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = Console.ReadLine();
                }
                Console.WriteLine("String array: " + string.Join(" ", stringArray));
            }

            static void MyHomeWork02()
            {
                // Task 2: Initialized arrays
                int[] intArray = { 1, 2, 3, 4, 5 };
                float[] floatArray = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
                double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 };
                string[] stringArray = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

                Console.WriteLine("\nTask 2: Pre-initialized Arrays");

                // Integer array output and average
                int intSum = 0;
                foreach (var num in intArray) intSum += num;
                Console.WriteLine("Integer array: " + string.Join(" ", intArray));
                Console.WriteLine("Average: " + (intSum / 5.0));

                // Float array output and average
                float floatSum = 0;
                foreach (var num in floatArray) floatSum += num;
                Console.WriteLine("Float array: " + string.Join(" ", floatArray));
                Console.WriteLine("Average: " + (floatSum / 5.0));

                // Double array output and average
                double doubleSum = 0;
                foreach (var num in doubleArray) doubleSum += num;
                Console.WriteLine("Double array: " + string.Join(" ", doubleArray));
                Console.WriteLine("Average: " + (doubleSum / 5.0));

                // String array output
                Console.WriteLine("String array: " + string.Join(" ", stringArray));
            }

            static void Main()
            {
                MyHomeWork01(); // Execute Task 1 and 2
                MyHomeWork02(); // Execute Task 3 and 4
            }
        }
}
    

