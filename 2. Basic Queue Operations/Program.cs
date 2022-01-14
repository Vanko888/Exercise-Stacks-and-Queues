using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < commands[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int j = 0; j < commands[1]; j++)
            {
                queue.Dequeue();
            }
            if (queue.Count > 0)
            {
                if (queue.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            

            
        }
    }
}
