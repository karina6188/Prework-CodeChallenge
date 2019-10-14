using System;

namespace dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 number between 1-10 at a time, 5 numbers total.");

            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
            Console.WriteLine("Select 1 number from the array.");
            Console.ReadLine();
        }
    }
}
