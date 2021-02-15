using System;
namespace Demo
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] list = { 19, 39, 40, 32 };
            int[] temp = list;
            Console.Write("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}