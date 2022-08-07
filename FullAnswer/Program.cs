using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_work {
    internal class Program {
        static void PrintStringArray(string[] array, bool newLine = false) {
            Console.Write("[");
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++) {
                Console.Write($"\"{array[i]}\", ");
            }
            if (arrayLength != 0) {
                if (newLine) Console.WriteLine($"\"{array[arrayLength - 1]}\"]");
                else Console.Write($"\"{array[arrayLength - 1]}\"]");
            }
            else {
                if (newLine) Console.WriteLine("]");
                else Console.Write("]");
            }
        }
        static string[] ArrayWithLessFourSymbol(string[] array) {
            int newArrayLength = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i].Length <= 3) newArrayLength++;
            }
            string[] arrayWithLessFourSymbol = new string[newArrayLength];
            int counter = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i].Length <= 3) {
                    arrayWithLessFourSymbol[counter] = array[i];
                    counter++;
                }
            }
            return arrayWithLessFourSymbol;
        }
        static void Main(string[] args) {
            Console.WriteLine("Enter an array of strings separated by a space:");
            string[] array = Console.ReadLine().Split(' ');
            PrintStringArray(array);
            Console.Write(" -> ");
            PrintStringArray(ArrayWithLessFourSymbol(array), true);
        }
    }
}
