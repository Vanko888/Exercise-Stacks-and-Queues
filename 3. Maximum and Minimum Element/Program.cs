using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (commands[0] == 1)
                {
                    numbers.Push(commands[1]);
                }
                if (numbers.Count > 0)
                {
                    if (commands[0] == 2)
                    {
                        numbers.Pop();
                    }
                    else if (commands[0] == 3)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                    else if (commands[0] == 4)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            while (numbers.Count > 0)
            {
                Console.Write(numbers.Pop());
                if (numbers.Count > 0)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
