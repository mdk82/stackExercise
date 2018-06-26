using System;
using System.Collections;

namespace StackExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Count);

            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }

            stack.Pop();

        }
    }
}
