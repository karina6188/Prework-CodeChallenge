﻿using System;

namespace dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool displayProblems = true;
                while (displayProblems)
                {
                    displayProblems = Display();
                }
            }

            static bool Display()
            {
                Console.WriteLine("Select a problem number to test it.");
                Console.WriteLine("1) Problem 1: Array Max Result");
                Console.WriteLine("2) Problem 2: Leap Year Calculator");
                Console.WriteLine("3) Problem 3: Perfect Sequence");
                Console.WriteLine("4) Problem 4: Sum of Rows");
                Console.WriteLine("5) Exit");
                string test = Console.ReadLine();

                if (test == "1")
                {
                    Problem01();
                    return true;
                }
                else if (test == "2")
                {
                    Problem02();
                    return true;
                }
                else if (test == "3")
                {
                    //Problem03();
                    return true;
                }
                else if (test == "4")
                {
                    //Problem04();
                    return true;
                }
                else if (test == "5")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            static void Problem01()
            {
                Console.WriteLine("Problem 1: Enter 1 number between 1-10 at a time, 5 numbers total.");

                int[] array = new int[5];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("[{0}]", string.Join(", ", array));
                Console.WriteLine("Select 1 number from the array.");
                int picked = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                for (int x = 0; x < array.Length; x++)
                {
                    if (array[x] == picked)
                        count++;
                }

                int score = picked * count;
                Console.WriteLine("Your score is {0}", score);
                Console.ReadLine();
            }

            static void Problem02()
            {
                Console.WriteLine("Problem 2: Enter a year in 4 digit to see if it is a leap year.");
                int year = Convert.ToInt32(Console.ReadLine());
                bool result = false;
                if (year % 4 == 0)
                {
                    if (year % 100 != 0 || year % 400 == 0)
                    {
                        result = true;
                    }
                }
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
