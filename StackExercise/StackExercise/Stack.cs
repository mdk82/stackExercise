using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack<T>
    {
        private T[] numbers;
        private int currentStackIndex;

        public Stack(int Num)
        {
            if (Num < 0)
                throw new ArgumentOutOfRangeException();

            numbers = new T[Num];
            currentStackIndex = 0;
        }

        public void Push(T Num)
        {
            if(currentStackIndex + 1 >= numbers.Length)
            {
                Array.Resize(ref numbers, (numbers.Length + 1) * 2);
            }

            numbers[currentStackIndex] = Num;
        }

        public T Pop()
        {
            if (currentStackIndex == 0)
                throw new InvalidOperationException("Stack is empty");

            T value = numbers[--currentStackIndex];
            numbers[currentStackIndex] = default(T);
            return value;
        }
    }
}
