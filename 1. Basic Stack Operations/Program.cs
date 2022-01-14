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
            var stack = new Stack<int>();
            int count = 0;
            for (int i = 0; i < commands[0]; i++)
            {
                stack.Push(numbers[count]);
                count++;
            }
            for (int i = 0; i < commands[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {

                if (stack.Count > 0)
                {
                    int element = stack.Peek();
                    while (stack.Count > 0)
                    {
                        if (stack.Peek() < element)
                        {
                            element = stack.Peek();
                            stack.Pop();
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }

                    Console.WriteLine(element);
                }
                else
                {
                    Console.WriteLine("0");
                }

            }
        }
    }
}
