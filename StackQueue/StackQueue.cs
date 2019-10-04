using System;
using System.Collections.Generic;

namespace StackQueue
{
    public class StackQueue<T> : IQueue<T>
    {
        private Stack<T> stack1;
        private Stack<T> stack2;

        public StackQueue()
        {
        }

        public bool IsEmpty => throw new NotImplementedException();

        public int Size => throw new NotImplementedException();

        public void AddBack(T item)
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T RemoveFront()
        {
            throw new NotImplementedException();
        }
    }
}
