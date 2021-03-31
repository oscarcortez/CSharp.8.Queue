using System;
using System.Collections.Generic;

namespace ConsoleApp4Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            numbers.Enqueue("six");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"dequeue1 {numbers.Dequeue()}");
            Console.WriteLine($"dequeue2 {numbers.Dequeue()}");
            Console.WriteLine($"peek3: {numbers.Peek()}");
            Console.WriteLine("------------");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            
        }
    }
}
